using EquipMotos.Codigo.View;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroVenda : Form
    {
        public static object Produto;
        public static object Cliente;
        public static object CondPagamento;
        Vendas Venda;

        CondicaoPagamentos CondicaoPagamento;

        public frmCadastroVenda()
        {
            InitializeComponent();
        }

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConCliente = new frmConsultaCliente();
            frmConCliente.btnVoltar.Text = "SELECIONAR";
            if (frmConCliente.ShowDialog() == DialogResult.OK)
            {
                CarregaCliente();
            }
        }

        internal void Carregar(object codigo)
        {
            
        }

        private void CarregaCliente()
        {
            if (Cliente != null)
            {
                Clientes cli = Cliente as Clientes;
                txtCodCliente.Text = Convert.ToString(cli.codigo);
                txtCliente.Text = cli.cliente;
            }
        }

        private void BtnBuscarProduto_Click_1(object sender, EventArgs e)
        {
            frmConsultaProdutosServicos frmConProdServ = new frmConsultaProdutosServicos();
            frmConProdServ.btnVoltar.Text = "SELECIONAR";

            if (frmConProdServ.ShowDialog() == DialogResult.OK)
            {
                CarregaProduto();
            }
        }

        private void CarregaProduto()
        {
            if (Produto != null)
            {
                ProdutosServicos pro = Produto as ProdutosServicos;
                txtCodProduto.Text = Convert.ToString("0" + pro.codigo);
                txtProduto.Text = pro.produto;
                txtValorProd.Text = pro.precoVenda.ToString();
            }
        }

        private void BtnBuscarCondPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaCondicaoPagamento frmConCondPag = new frmConsultaCondicaoPagamento();
            frmConCondPag.btnVoltar.Text = "SELECIONAR";
            try
            {
                if (Double.Parse(txtValorTotal.Text, NumberStyles.Any) <= 0)
                {
                    var desconto = Double.Parse(txtDescontos.Text) / 100;
                    var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                    var valorDesconto = desconto * totalItens;
                    txtValorTotal.Text = (valorDesconto - totalItens).ToString("C", CultureInfo.CurrentCulture);
                }


                if (frmConCondPag.ShowDialog() == DialogResult.OK)
                {
                    if (Double.Parse(txtValorTotal.Text, NumberStyles.Any) <= 0)
                    {
                        MessageBox.Show("É necessario informar o valor total para gerar contas à pagar", "Valor total inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtValorTotal.Focus();
                    }
                    else
                    {
                        CarregaCondicao();
                        var aux = CondicaoPagamento.listaParcela;
                        if (aux.Count == CondicaoPagamento.listaParcela.Count)
                        {
                            lvContaReceber.Items.Clear();
                            for (int i = 0; i < CondicaoPagamento.listaParcela.Count; i++)
                            {
                                var desconto = Double.Parse(txtDescontos.Text) / 100;
                                var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                var valorDesconto = desconto * totalItens;

                                var parcela = CondicaoPagamento.listaParcela.ElementAt(i);
                                var dtVencimento = Convert.ToDateTime(txtData.Text);
                                dtVencimento = dtVencimento.AddDays(parcela.nrDia);
                                var valorTot = valorDesconto - Double.Parse(txtValorItens.Text, NumberStyles.Any) ;
                                var valorParcela = valorTot * (parcela.porcentagem / 100);

                                string[] row = {txtNumeroVenda.Text + "/" + Convert.ToString(parcela.nrParcela), dtVencimento.ToString("dd/MM/yyyy"), valorParcela.ToString("C", CultureInfo.CurrentCulture) };
                                var lvi = new ListViewItem(row);
                                lvContaReceber.Items.Add(lvi);
                            }
                        }
                        else
                        {
                            CondicaoPagamento.listaParcela = aux;
                            lvContaReceber.Items.Clear();
                            for (int i = 0; i < CondicaoPagamento.listaParcela.Count; i++)
                            {
                                var desconto = Double.Parse(txtDescontos.Text) / 100;
                                var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                var valorDesconto = desconto * totalItens;

                                var parcela = CondicaoPagamento.listaParcela.ElementAt(i);
                                var dtVencimento = Convert.ToDateTime(txtData.Text);
                                dtVencimento = dtVencimento.AddDays(parcela.nrDia);
                                var valorTot = valorDesconto - Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                                var valorParcela = valorTot * (parcela.porcentagem / 100);

                                string[] row = { txtNumeroVenda.Text + "/" + Convert.ToString(parcela.nrParcela), dtVencimento.ToString("dd/MM/yyyy"), valorParcela.ToString("C", CultureInfo.CurrentCulture) };
                                var lvi = new ListViewItem(row);
                                lvContaReceber.Items.Add(lvi);
                            }
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel gerar lista de Contas à pagar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodCondPagamento.Text = "";
                txtCondPagamento.Text = "";
            }

        }

        private void CarregaCondicao()
        { 
            if (CondPagamento != null)
            {
                CondicaoPagamento = new CondicaoPagamentos();
                CondicaoPagamento = CondPagamento as CondicaoPagamentos;
                txtCodCondPagamento.Text = Convert.ToString(CondicaoPagamento.codigo);
                txtCondPagamento.Text = CondicaoPagamento.condicao;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Venda = new Vendas();
                var listContaReceber = new List<ContasReceber>();
                var listItemVenda = new List<ItensVenda>();
                {
                    if (ValidaCampos())
                    {
                        Venda.modelo = txtModelo.Text;
                        Venda.serie = txtSerie.Text;
                        Venda.dtEmissao = txtData.Value;

                        var condPag = new CondicaoPagamentos();
                        condPag.codigo = Convert.ToInt32(txtCodCondPagamento.Text);
                        Venda.condPagamento = condPag;

                        Venda.observacoes = txtObservacoes.Text;
                        Venda.dtCadastro = DateTime.Now;
                        Venda.dtAlteracao = DateTime.Now;
                        var dtEmissao = txtData.Value;
                        Venda.usuario = txtUsuario.Text;
                        // ProdutosServicos produto = new ProdutosServicos();
                        for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvProdutosVenda.Items[i].SubItems[0].Text);
                            var qtdItem = Convert.ToInt32(lvProdutosVenda.Items[i].SubItems[3].Text);
                            var custoItem = Convert.ToDecimal(Double.Parse(lvProdutosVenda.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("N2"));
                            //var totalItens = getTotal();
                            //var totalDespesas = Convert.ToDecimal(Venda.frete + Venda.seguro + Venda.despesa);
                            //var porcentagemItem = ((custoItem * qtdItem) / totalItens);
                            //var vlrFinal = totalDespesas * porcentagemItem;
                            //vlrFinal /= qtdItem;

                            listItemVenda.Add(new ItensVenda()
                            {
                                modelo = Venda.modelo,
                                serie = Venda.serie,
                                nrNota = Venda.nrNota,
                                cliente = Venda.cliente,
                                codigo = idItem,
                                qtd = qtdItem,
                                //custo = custoItem,
                                precoVenda = custoItem,//+ vlrFinal,
                                dtCadastro = Venda.dtCadastro,
                                dtAlteracao = Venda.dtAlteracao,
                            });
                        }
                        Venda.listaItem = listItemVenda;

                        for (int i = 0; i < lvContaReceber.Items.Count; i++)
                        {
                            listContaReceber.Add(new ContasReceber()
                            {
                                modelo = Venda.modelo,
                                serie = Venda.serie,
                                nrNota = Venda.nrNota,
                                cliente = Venda.cliente,
                                nrParcela = i + 1,
                                dtVecimento = Convert.ToDateTime(lvContaReceber.Items[i].SubItems[1].Text),
                                vlrParcela = Double.Parse(lvContaReceber.Items[i].SubItems[2].Text, NumberStyles.Any),
                                dtAlteracao = DateTime.Now,
                                dtCadastro = DateTime.Now,
                                dtEmissao = dtEmissao,
                                usuario = txtUsuario.Text
                            });
                        }
                        //Venda.lista = listContaReceber;
                        //Venda.situacao = chkSituacao.Checked;

                        //CtrlVenda.Inserir(Venda);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel gerar a Venda.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Venda.ListaServico = null;
                        //Venda.ListaProduto = null;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.LimparCampos();
            }
        }

        private void LimparCampos()
        {
            throw new NotImplementedException();
        }

        private bool ValidaCampos()
        {
            throw new NotImplementedException();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutosServicos prod = Produto as ProdutosServicos;
                if (ValidaProduto())
                {
                    var qtd = Convert.ToInt32(txtQtd.Text);
                    var totalRow = Convert.ToString(qtd * prod.custo);

                    string[] row = { Convert.ToString(prod.codigo), prod.produto, prod.unidade, txtQtd.Text, Convert.ToString(prod.custo), Convert.ToString(totalRow) };
                    var lvi = new ListViewItem(row);
                    lvProdutosVenda.Items.Add(lvi);

                    var vlTotalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                    if (vlTotalItens <= 0)
                    {
                        txtValorItens.Text = lvProdutosVenda.Items[0].SubItems[5].Text;
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                        for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
                        {
                            txtValorItens.Text = Double.Parse(lvProdutosVenda.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        //vltotal + txtvalortoal
                        var vlTotalGrid = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                        var ValorTotal = vltotal + vlTotalGrid;
                        txtValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                    }
                   // SomaTotal();
                    txtCodProduto.Text = "";
                    txtProduto.Text = "";
                    txtQtd.Text = "";
                    Produto = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidaProduto()
        {
            if (txtCodProduto.Text == String.Empty & txtCodProduto.Text.Length < 0)
            {
                MessageBox.Show("Faltou informar o Código Produto", "Informe o Código Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtCodProduto.Text) < 0)
            {
                MessageBox.Show("Código Produto inválido", "Informe o Código do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            if (txtProduto.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar o Produto", "Informe o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
                return false;
            }
            if (txtQtd.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar a Quantidade", "Informe uma Quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtQtd.Text) < 0)
            {
                MessageBox.Show("Quantidade inválida", "Informe a Quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            return true;
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {

        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtNrItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtCodCondPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtValorItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtValorItens_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtValorItens_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtValorProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtValorProd_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtValorProd_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void txtDescontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }
    }
}
