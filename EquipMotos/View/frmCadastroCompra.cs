
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroCompra : Form
    {
        //private string pusuario;
        public static object fornecedor;
        public static object condPagamento;
        public static object prod;
        Compras compra;
        //ComprasDAO dao;
        CtrlProdutosServicos CtrlProduto = new CtrlProdutosServicos();
        List<ContasPagar> listContaPagar;
        List<ItensCompra> listItemCompra;
        CondicaoPagamentos condPag = new CondicaoPagamentos();
        CtrlCompras CtrlCompra = new CtrlCompras();
        public frmCadastroCompra()
        {
            InitializeComponent();
            chkSituacao.Checked = true;
            Disable();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                compra = new Compras();
                listContaPagar = new List<ContasPagar>();
                listItemCompra = new List<ItensCompra>();
                
                {
                    if (ValidaCompra())
                    {
                        compra.modelo = txtModelo.Text;
                        compra.serie = txtSerie.Text;
                        compra.nrNota = txtNrNota.Text;
                        var forn = fornecedor as Fornecedores;
                        forn.codigo = Convert.ToInt32(txtCodFornecedor.Text);
                        compra.fornecedor = forn;
                        var condPag = condPagamento as CondicaoPagamentos;
                        condPag.codigo = Convert.ToInt32(txtCodCondPagamento.Text);
                        compra.condPagamento = condPag;
                        compra.dtEmissao = Convert.ToDateTime(txtDataEmissao.Text);
                        compra.dtChegada = Convert.ToDateTime(txtDtChegada.Text);
                        compra.cfi = rbTipoFrete1.Checked;

                        compra.frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
                        compra.seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
                        compra.despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);

                        compra.totalPagar = Double.Parse(txtTotalPagar.Text, NumberStyles.Any);
                        compra.totalProduto = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                        compra.situacao = chkSituacao.Checked;
                        compra.observacoes = txtObservacoes.Text;
                        compra.dtCadastro = DateTime.Now;
                        compra.dtAlteracao = DateTime.Now;
                        var dtEmissao = txtDataEmissao.Value;
                        compra.usuario = UsuarioLogado.Usuario;
                        ProdutosServicos produto = new ProdutosServicos();
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvItem.Items[i].SubItems[0].Text);
                            var qtdItem = Convert.ToInt32(lvItem.Items[i].SubItems[3].Text);
                            var custoItem = Convert.ToDecimal(Double.Parse(lvItem.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("N2"));
                            var totalItens = getTotal();
                            var totalDespesas = Convert.ToDecimal(compra.frete + compra.seguro + compra.despesa);
                            var porcentagemItem = ((custoItem * qtdItem) / totalItens);
                            var vlrFinal = totalDespesas * porcentagemItem;
                            vlrFinal /= qtdItem;
                                                       
                            listItemCompra.Add(new ItensCompra()
                            {
                                modelo = compra.modelo,
                                serie = compra.serie,
                                nrNota = compra.nrNota,
                                Fornecedor = compra.fornecedor,
                                codigo = idItem,
                                qtd = qtdItem,
                                valorUnitario = custoItem,
                                custoUnitario = custoItem + vlrFinal,
                                dtCadastro = compra.dtCadastro,
                                dtAlteracao = compra.dtAlteracao,
                            });
                        }
                        compra.listaItem = listItemCompra;

                        for (int i = 0; i < lvContaPagar.Items.Count; i++)
                        {
                            var parcela = compra.condPagamento.listaParcela.ElementAt(i);
                            listContaPagar.Add(new ContasPagar()
                            {
                                modelo = compra.modelo,
                                serie = compra.serie,
                                nrNota = compra.nrNota,
                                fornecedor = compra.fornecedor,
                                formaPagamento = parcela.formaPagamento,
                                nrParcela = i + 1,
                                dtVencimento = Convert.ToDateTime(lvContaPagar.Items[i].SubItems[1].Text),
                                vlrParcela = Double.Parse(lvContaPagar.Items[i].SubItems[2].Text, NumberStyles.Any),
                                dtAlteracao = DateTime.Now,
                                dtCadastro = DateTime.Now,
                                dtEmissao = dtEmissao,
                                usuario = UsuarioLogado.Usuario
                            }); 
                        }
                        compra.listaContasPagar = listContaPagar;
                        compra.situacao = chkSituacao.Checked;
                        CtrlCompra.Inserir(compra);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel gerar a compra.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        compra.listaContasPagar = null;
                        compra.listaItem = null;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //this.LimpaCampos();
            }

        }
        public void DisableView()
        {
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtNrNota.Enabled = false;
            txtDataEmissao.Enabled = false;
            txtDtChegada.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtFornecedor.Enabled = false;
            btnBuscarCondPagamento.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            btnBuscarProduto.Enabled = false;
            txtUnidade.Enabled = false;
            txtQtd.Enabled = false;
            txtCusto.Enabled = false;
            btnAddProduto.Enabled = false;
            btnRemProduto.Enabled = false;
            lvItem.Enabled = false;
            rbTipoFrete1.Enabled = false;
            rbTipoFrete2.Enabled = false;
            txtFrete.Enabled = false;
            txtSeguro.Enabled = false;
            txtOutrasDesp.Enabled = false;
            txtValorTotal.Enabled = false;
            txtValorTotal.Enabled = false;
            txtCodCondPagamento.Enabled = false;
            txtCondPagamento.Enabled = false;
            btnBuscarCondPagamento.Enabled = false;
            
            txtObservacoes.Enabled = false;
            btnSalvar.Hide();
            btnLimpar.Hide();
        }
        public void Disable()
        {
            txtDataEmissao.Enabled = false;
            txtDtChegada.Enabled = false;
            btnBuscarCondPagamento.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            btnBuscarProduto.Enabled = false;
            txtUnidade.Enabled = false;
            txtQtd.Enabled = false;
            txtCusto.Enabled = false;
            btnAddProduto.Enabled = false;
            btnRemProduto.Enabled = false;
            lvItem.Enabled = false;
            rbTipoFrete1.Enabled = false;
            rbTipoFrete2.Enabled = false;
            txtFrete.Enabled = false;
            txtSeguro.Enabled = false;
            txtOutrasDesp.Enabled = false;
            txtValorTotal.Enabled = false;
            txtValorTotal.Enabled = false;
            txtCodCondPagamento.Enabled = false;
            txtCondPagamento.Enabled = false;
            btnBuscarCondPagamento.Enabled = false;

            txtObservacoes.Enabled = false;
           
        }
        public void Enable()
        {
            txtDataEmissao.Enabled = true;
            txtDtChegada.Enabled = true;
            btnBuscarCondPagamento.Enabled = true;
            txtCodProduto.Enabled = true;
            txtProduto.Enabled = true;
            btnBuscarProduto.Enabled = true;
            txtUnidade.Enabled = true;
            txtQtd.Enabled = true;
            txtCusto.Enabled = true;
            btnAddProduto.Enabled = true;
            btnRemProduto.Enabled = true;
            lvItem.Enabled = true;
            rbTipoFrete1.Enabled = true;
            rbTipoFrete2.Enabled = true;
            txtFrete.Enabled = true;
            txtSeguro.Enabled = true;
            txtOutrasDesp.Enabled = true;
            txtValorTotal.Enabled = true;
            txtValorTotal.Enabled = true;
            txtCodCondPagamento.Enabled = true;
            txtCondPagamento.Enabled = true;
            btnBuscarCondPagamento.Enabled = true;

            txtObservacoes.Enabled = true;
            
        }
        public void Carregar(object modelo, object serie, object nrNota, object idFornecedor)
        {
            try
            {
                //dao = new ComprasDAO();
               // compra = new Compras();
                compra = CtrlCompra.BuscarPorID(modelo, serie, nrNota, idFornecedor) as Compras;
                txtModelo.Text = compra.modelo;
                txtSerie.Text = compra.serie;
                txtNrNota.Text = compra.nrNota;
                txtDataEmissao.Text = Convert.ToString(compra.dtEmissao);
                txtDtChegada.Text = Convert.ToString(compra.dtChegada);
                txtCodFornecedor.Text = Convert.ToString(compra.fornecedor.codigo);
                txtFornecedor.Text = Convert.ToString(compra.fornecedor.fornecedor);
                txtFrete.Text = (compra.frete).ToString("C", CultureInfo.CurrentCulture);
                txtSeguro.Text = (compra.seguro).ToString("C", CultureInfo.CurrentCulture);
                txtOutrasDesp.Text = (compra.despesa).ToString("C", CultureInfo.CurrentCulture);

                foreach (var item in compra.listaItem)
                {
                    var prod = CtrlProduto.BuscarPorID(Convert.ToString(item.codigo)) as ProdutosServicos;
                    var total = item.qtd * prod.custoUltCompra;
                    string[] itens = { Convert.ToString(item.codigo), prod.produto, prod.unidade, Convert.ToString(item.qtd), Convert.ToString(prod.custoUltCompra), Convert.ToString(total) };
                    var listItens = new ListViewItem(itens);
                    lvItem.Items.Add(listItens);

                    var vlTotalincial = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                    if (vlTotalincial <= 0)
                    {
                        txtValorTotal.Text = Double.Parse(lvItem.Items[0].SubItems[5].Text).ToString("C", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            txtValorTotal.Text = Double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        var vlTotalGrid = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        var ValorTotal = (vltotal + vlTotalGrid).ToString("C", CultureInfo.CurrentCulture);
                        txtValorTotal.Text = ValorTotal;
                    }
                }

                var totalproduto = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                var frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
                var seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
                var despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
                var totalPagar = totalproduto + frete + seguro + despesa;
                txtTotalPagar.Text = totalPagar.ToString("C", CultureInfo.CurrentCulture);

                txtCodCondPagamento.Text = Convert.ToString(compra.condPagamento.codigo);
                txtCondPagamento.Text = Convert.ToString(compra.condPagamento.condicao);
                foreach (var conta in compra.listaContasPagar)
                {
                    string[] row = { txtNrNota.Text + "/" + Convert.ToString(conta.nrParcela), conta.dtVencimento.ToString("dd/MM/yyyy"), conta.vlrParcela.ToString("C", CultureInfo.CurrentCulture) };
                    var lvi = new ListViewItem(row);
                    lvContaPagar.Items.Add(lvi);
                }
                chkSituacao.Checked = compra.situacao;
               
                if (compra.cfi == true)
                {
                    rbTipoFrete1.Checked = true;
                }
                else
                {
                    rbTipoFrete2.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel vizualizar a compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal getTotal()
        {
            return Convert.ToDecimal(Double.Parse(txtValorTotal.Text, NumberStyles.Any));
        }
        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {

            frmConsultaProdutosServicos frmConProdServ = new frmConsultaProdutosServicos();
            frmConProdServ.btnVoltar.Text = "SELECIONAR";

            if (frmConProdServ.ShowDialog() == DialogResult.OK)
            {
                CarregaProduto();
            }
        }
        private void BtnBuscarCondPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaCondicaoPagamento frmConCondPag = new frmConsultaCondicaoPagamento();
            frmConCondPag.btnVoltar.Text = "SELECIONAR";
            try
            {
                if(Double.Parse(txtTotalPagar.Text, NumberStyles.Any ) <= 0)
                {
                    var frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
                    var seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
                    var despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
                    var valorTotal = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                    txtTotalPagar.Text = (frete + seguro + despesa + valorTotal).ToString("C", CultureInfo.CurrentCulture);
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
                        var aux = condPag.listaParcela;
                        if(aux.Count == condPag.listaParcela.Count)
                        {
                            lvContaPagar.Items.Clear();
                            for (int i = 0; i < condPag.listaParcela.Count; i++)
                            {
                                var parcela = condPag.listaParcela.ElementAt(i);
                                var dtVencimento = Convert.ToDateTime(txtDataEmissao.Text);
                                dtVencimento = dtVencimento.AddDays(parcela.nrDia);
                                var valorTot = Double.Parse(txtValorTotal.Text, NumberStyles.Any) + Double.Parse(txtFrete.Text, NumberStyles.Any) + Double.Parse(txtSeguro.Text, NumberStyles.Any) + Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
                                var valorParcela = valorTot * (parcela.porcentagem / 100);

                                string[] row = { txtNrNota.Text + "/" + Convert.ToString(parcela.nrParcela), dtVencimento.ToString("dd/MM/yyyy"), valorParcela.ToString("C", CultureInfo.CurrentCulture) };
                                var lvi = new ListViewItem(row);
                                lvContaPagar.Items.Add(lvi);
                            }
                        }
                        else
                        {
                            condPag.listaParcela = aux;
                            lvContaPagar.Items.Clear();
                            for (int i = 0; i < condPag.listaParcela.Count; i++)
                            {
                                var parcela = condPag.listaParcela.ElementAt(i);
                                var dtVencimento = Convert.ToDateTime(txtDataEmissao.Text);
                                dtVencimento = dtVencimento.AddDays(parcela.nrDia);
                                var valorTot = Double.Parse(txtValorTotal.Text, NumberStyles.Any) + Double.Parse(txtFrete.Text, NumberStyles.Any) + Double.Parse(txtSeguro.Text, NumberStyles.Any) + Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
                                var valorParcela = valorTot * (parcela.porcentagem / 100);

                                string[] row = { txtNrNota.Text + "/" + Convert.ToString(parcela.nrParcela), dtVencimento.ToString("dd/MM/yyyy"), valorParcela.ToString("C", CultureInfo.CurrentCulture) };
                                var lvi = new ListViewItem(row);
                                lvContaPagar.Items.Add(lvi);
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
        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmConFornecedor = new frmConsultaFornecedor();
            frmConFornecedor.btnVoltar.Text = "SELECIONAR";
            if (frmConFornecedor.ShowDialog() == DialogResult.OK)
            {
                CarregaFornecedor();
            }
            var compraValida = CtrlCompra.BuscarPorID(txtModelo.Text, txtSerie.Text, txtNrNota.Text, txtCodFornecedor.Text) as Compras;
            if (compraValida.modelo != null)
            {
                MessageBox.Show("Já existe uma compra com este modelo, serie, Nr. nota e fornecedor", "Compra já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable();
                txtCodFornecedor.Text = "";
                txtFornecedor.Text = "";
            }
        }
        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaProduto())
                {
                    PopulaGridProduto();
                    var qtd = Convert.ToInt32(txtQtd.Text);
                    var valorProd = Double.Parse(txtCusto.Text, NumberStyles.Any);
                    var vlTotalincial = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                    if (vlTotalincial <= 0)
                    {
                        txtValorTotal.Text = lvItem.Items[0].SubItems[5].Text;
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            txtValorTotal.Text = Double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        //vltotal + txtvalortoal
                        var vlTotalGrid = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        var ValorTotal = vltotal + vlTotalGrid;
                        txtValorTotal.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                    }
                    txtCodProduto.Text = "";
                    txtProduto.Text = "";
                    txtUnidade.Text = "";
                    txtCusto.Text = "R$0.00";
                    txtQtd.Text = "";
                }
            }
            catch
            {
                txtValorTotal.Text = "R$0.00";
            }
        }
        private bool ValidaCompra()
        {
            if (txtModelo.Text.Trim().Length > 3)
            {
                MessageBox.Show("Não é possivel inserir este modelo", "Informe o modelo com menos de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }
            if (txtModelo.Text.Length < 2)
            {
                MessageBox.Show("Modelo inválido!", "Verefique o Modelo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }
            
            if (String.IsNullOrEmpty(txtNrNota.Text))
            {
                MessageBox.Show("Faltou informar o Número da Nota", "Informe o Número da Nota!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNrNota.Focus();
                return false;
            }


            if (txtSerie.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar Serie", "Informe a Serie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }


            if (txtCodFornecedor.Text == String.Empty || (txtFornecedor.Text == String.Empty))
            {
                MessageBox.Show("Faltou informar o Fornecedor", "Informe o Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodFornecedor.Focus();
                return false;
            }
            return true;
        }
        private void LimpaCampos()
        {
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtNrNota.Text = "";
            txtDataEmissao.Value = DateTime.Now;
            txtDtChegada.Value = DateTime.Now;
            chkSituacao.Checked = true;
            txtCodFornecedor.Text = "";
            txtFornecedor.Text = "";
            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtUnidade.Text = "";
            txtQtd.Text = "";
            txtCusto.Text = "R$0,00";
            lvItem.Items.Clear();
            rbTipoFrete2.Checked = true;
            txtFrete.Text = "R$0,00";
            txtSeguro.Text = "R$0,00";
            txtOutrasDesp.Text = "R$0,00";
            txtValorTotal.Text = "R$0,00";
            txtCodCondPagamento.Text = "";
            txtCondPagamento.Text = "";
            lvContaPagar.Items.Clear();
            txtObservacoes.Text = "";

        }
        private void CarregaProduto()
        {
            if (prod != null)
            {
                ProdutosServicos pro = prod as ProdutosServicos;
                txtCodProduto.Text = Convert.ToString("0" + pro.codigo);
                txtProduto.Text = pro.produto;
                txtUnidade.Text = pro.unidade;
            }
        }
        private void CarregaCondicao()
        {
            if (condPagamento != null)
            {
                condPag = condPagamento as CondicaoPagamentos;
                txtCodCondPagamento.Text = Convert.ToString(condPag.codigo);
                txtCondPagamento.Text = condPag.condicao;
            }
        }
        private void CarregaFornecedor()
        {
            if (fornecedor != null)
            {
                Fornecedores forn = fornecedor as Fornecedores;
                txtCodFornecedor.Text = Convert.ToString(forn.codigo);
                txtFornecedor.Text = forn.fornecedor;
                if (!String.IsNullOrEmpty(txtFornecedor.Text))
                {
                    Enable();
                }
            }
        }
        private void PopulaGridProduto()
        {
            var custo = Double.Parse(txtCusto.Text, NumberStyles.Any);
            var qtdd = Convert.ToInt32(txtQtd.Text);

            var valorTot = qtdd * custo;

            String[] row = { txtCodProduto.Text, txtProduto.Text, txtUnidade.Text, txtQtd.Text, txtCusto.Text, valorTot.ToString("C", CultureInfo.CurrentCulture) };
            var listItem = new ListViewItem(row);
            lvItem.Items.Add(listItem);
        }
        private bool VerificaProduto()
        {
            if (txtCodProduto.Text == string.Empty || (txtProduto.Text == string.Empty))
            {
                MessageBox.Show("Faltou informar o Produto", "Informe o  Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtUnidade.Text.Trim()))
            {
                MessageBox.Show("Faltou informar a Unidade", "Informe a Unidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnidade.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtQtd.Text.Trim()))
            {
                MessageBox.Show("Faltou informar a quantidade", "Informe a quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            else if (Convert.ToInt32("0" + txtQtd.Text) < 1)
            {
                MessageBox.Show("Informe uma quantidade maior que 0!", "Quantidade invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            if (Double.Parse(txtCusto.Text, NumberStyles.Any) <= 0)
            {
                MessageBox.Show("Faltou informar o custo", "Informe o custo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCusto.Focus();
                return false;
            }
            return true;
        }
        private void TxtDtChegada_ValueChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (txtDtChegada.Value < txtDataEmissao.Value && i == 0)
            {
                MessageBox.Show("Data deve ser maior que a emissão!", "Data de chegada ínvalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDtChegada.Value = txtDataEmissao.Value;
                i++;
            }
        }
        private void RbTipoFrete1_CheckedChanged(object sender, EventArgs e)
        {
            txtFrete.Enabled = false;
            txtSeguro.Enabled = false;
        }
        private void RbTipoFrete2_CheckedChanged(object sender, EventArgs e)
        {
            txtFrete.Enabled = true;
            txtSeguro.Enabled = true;
        }
        private void BtnRemProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if(lvItem.SelectedIndices[0] != null)
                {
                    if ((MessageBox.Show("Remover item ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & (lvItem.SelectedIndices[0] != null))
                    {
                        lvItem.Items.RemoveAt(lvItem.SelectedIndices[0]);
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            txtValorTotal.Text = Double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        var vlTotalGrid = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                        txtValorTotal.Text = vlTotalGrid.ToString("C", CultureInfo.CurrentCulture);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um item!");
                }
            }
            catch
            {
                MessageBox.Show("Selecione um item! ");
            }
        }

        #region Formatacão dos Campos de valores
        private void TxtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }
        private void TxtCusto_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);

        }
        private void TxtCusto_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }
        private void TxtFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }
        private void TxtFrete_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);

        }
        private void TxtFrete_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }
        private void TxtSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }
        private void TxtSeguro_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }
        private void TxtSeguro_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }
        private void TxtOutrasDesp_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }
        private void TxtOutrasDesp_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }
        private void TxtOutrasDesp_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }
        private void TxtValorTotal_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }
        private void TxtValorTotal_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }
        private void TxtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }
        #endregion
        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void TxtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChkSituacao_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Show();
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);

        }

        private void txtCodCondPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtNrNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }
    }
}
