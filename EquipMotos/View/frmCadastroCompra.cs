
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using EquipMotos.VIEW;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroCompra : MaterialSkin.Controls.MaterialForm
    {
        //private string pusuario;
        public static object Fornecedor;
        public static object CondPagamento;
        public static object Produto;
        Compras Compra;
        //ComprasDAO dao;
        CtrlProdutos CtrlProduto = new CtrlProdutos();
        CtrlFornecedores CtrlFornecedor = new CtrlFornecedores();
        CtrlCondicaoPagamento CtrlCondPagamento = new CtrlCondicaoPagamento();
        List<ContasPagar> listContaPagar;
        List<ItensCompra> listItemCompra;
        CondicaoPagamentos condPag = new CondicaoPagamentos();
        CtrlCompras CtrlCompra = new CtrlCompras();
        public frmCadastroCompra()
        {
            InitializeComponent();
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
                Compra = new Compras();
                listContaPagar = new List<ContasPagar>();
                listItemCompra = new List<ItensCompra>();
                Compra.condPagamento = CondPagamento as CondicaoPagamentos;
                {
                    if (ValidaCompra())
                    {
                        Compra.modelo = txtModelo.Text;
                        Compra.serie = txtSerie.Text;
                        Compra.nrNota = txtNrNota.Text;
                        Fornecedores forn = new Fornecedores();
                        forn.codigo = Convert.ToInt32(txtCodFornecedor.Text);
                        Compra.fornecedor = forn;
                        Compra.dtEmissao = Convert.ToDateTime(txtDataEmissao.Text);
                        Compra.dtChegada = Convert.ToDateTime(txtDtChegada.Text);
                        Compra.cfi = rbTipoFrete1.Checked;

                        Compra.frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
                        Compra.seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
                        Compra.despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);

                        Compra.totalPagar = Double.Parse(txtTotalPagar.Text, NumberStyles.Any);
                        Compra.totalProduto = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                        Compra.situacao = chkSituacao.Checked;
                        Compra.observacoes = txtObservacoes.Text;
                        Compra.dtCadastro = DateTime.Now;
                        Compra.dtAlteracao = DateTime.Now;
                        var dtEmissao = txtDataEmissao.Value;
                        Compra.usuario = UsuarioLogado.Usuario;
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvItem.Items[i].SubItems[0].Text);
                            var qtdItem = Convert.ToInt32(lvItem.Items[i].SubItems[3].Text);
                            var custoItem = Convert.ToDecimal(Double.Parse(lvItem.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("N2"));
                                               
                            listItemCompra.Add(new ItensCompra()
                            {
                                modelo = Compra.modelo,
                                serie = Compra.serie,
                                nrNota = Compra.nrNota,
                                Fornecedor = Compra.fornecedor,
                                codigo = idItem,
                                qtd = qtdItem,
                                valorUnitario = custoItem,
                                custoUnitario = custoItem,
                                dtCadastro = Compra.dtCadastro,
                                dtAlteracao = Compra.dtAlteracao,
                            });
                        }
                        Compra.listaItem = listItemCompra;

                        for (int i = 0; i < lvContaPagar.Items.Count; i++)
                        {
                            var parcela = Compra.condPagamento.listaParcela.ElementAt(i);
                            listContaPagar.Add(new ContasPagar()
                            {
                                modelo = Compra.modelo,
                                serie = Compra.serie,
                                nrNota = Compra.nrNota,
                                fornecedor = Compra.fornecedor,
                                formaPagamento = parcela.formaPagamento,
                                nrParcela = i + 1,
                                dtVencimento = Convert.ToDateTime(lvContaPagar.Items[i].SubItems[1].Text),
                                vlrParcela = Double.Parse(lvContaPagar.Items[i].SubItems[2].Text, NumberStyles.Any),
                                dtAlteracao = DateTime.Now,
                                dtCadastro = DateTime.Now,
                                dtEmissao = dtEmissao,
                                observacoes = parcela.observacoes,
                                usuario = UsuarioLogado.Usuario
                            }); ; 
                        }

                        Compra.listaContasPagar = listContaPagar;
                        Compra.situacao = chkSituacao.Checked;
                        if (btnSalvar.Text == "DESATIVAR")
                        {
                            if ((MessageBox.Show("Depois desta operação, não será possivel vizualizar estas informações novamente.", "DESATIVAR COMPRA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                            {
                                CtrlCompra.Desativar(Compra.modelo, Compra.serie, Compra.nrNota, Compra.fornecedor.codigo);
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            CtrlCompra.Inserir(Compra);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel gerar a compra.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Compra.listaContasPagar = null;
                        Compra.listaItem = null;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel gerar a compra.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnBuscarFornecedor.Enabled = false;
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
            lvContaPagar.Enabled = false;
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
                Compra = CtrlCompra.BuscarPorID(modelo, serie, nrNota, idFornecedor) as Compras;
                txtModelo.Text = Compra.modelo;
                txtSerie.Text = Compra.serie;
                txtNrNota.Text = Compra.nrNota;
                txtDataEmissao.Value = Compra.dtEmissao;
                txtDtChegada.Value = Compra.dtChegada;
                txtCodFornecedor.Text = Convert.ToString(Compra.fornecedor.codigo);
                txtFornecedor.Text = Convert.ToString(Compra.fornecedor.fornecedor);
                Fornecedor = Compra.fornecedor;
                txtFrete.Text = (Compra.frete).ToString("C", CultureInfo.CurrentCulture);
                txtSeguro.Text = (Compra.seguro).ToString("C", CultureInfo.CurrentCulture);
                txtOutrasDesp.Text = (Compra.despesa).ToString("C", CultureInfo.CurrentCulture);
                txtDtAlteracao.Text = Compra.dtAlteracao.ToString();
                txtDtCadastro.Text = Compra.dtCadastro.ToString();
                txtUsuario.Text = Compra.usuario;

                foreach (var item in Compra.listaItem)
                {
                    var prod = CtrlProduto.BuscarPorID(Convert.ToString(item.codigo)) as Produtos;
                    var total = item.qtd * prod.custo;

                    string[] itens = { Convert.ToString(item.codigo), prod.produto, prod.unidade, Convert.ToString(item.qtd), Convert.ToString(prod.custo), Convert.ToString(total) };
                    var listItens = new ListViewItem(itens);
                    lvItem.Items.Add(listItens);

                    var vlTotalincial = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                    if (vlTotalincial <= 0)
                    {
                        txtValorTotal.Text = Double.Parse(lvItem.Items[0].SubItems[5].Text).ToString("C", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        double vltotal = 0; Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            vltotal += Double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any);
                        }
                        //var vlTotalGrid = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        
                        txtValorTotal.Text = vltotal.ToString("C", CultureInfo.CurrentCulture);
                    }
                }

                var totalproduto = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                var frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
                var seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
                var despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
                double totalPagar = totalproduto + frete + seguro + despesa;
                
                CondPagamento = Compra.condPagamento;
                txtTotalPagar.Text = totalPagar.ToString("C", CultureInfo.CurrentCulture);

                txtCodCondPagamento.Text = Convert.ToString(Compra.condPagamento.codigo);
                txtCondPagamento.Text = Convert.ToString(Compra.condPagamento.condicao);
                chkSituacao.Checked = Compra.situacao;
               
                if (Compra.cfi == true)
                {
                    rbTipoFrete1.Checked = true;
                }
                else
                {
                    rbTipoFrete2.Checked = true;
                }
            }
            catch(Exception ex)
            {
                var test = ex.Message;
                MessageBox.Show("Não foi possivel vizualizar a compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {

            frmConsultaProduto frmConProduto = new frmConsultaProduto();
            frmConProduto.btnVoltar.Text = "SELECIONAR";

            if (frmConProduto.ShowDialog() == DialogResult.OK)
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
                txtCodCondPagamento.Clear();
                txtCondPagamento.Clear();
            }
        }

        public void GerarContaPagar()
        {
            lvContaPagar.Items.Clear();
            CarregaCondicao();
            if(condPag != null)
            { 
                var aux = condPag.listaParcela;
                if (aux.Count == condPag.listaParcela.Count)
                {
                    lvContaPagar.Items.Clear();
                    for (int i = 0; i < condPag.listaParcela.Count; i++)
                    {
                        var parcela = condPag.listaParcela.ElementAt(i);
                        var dtVencimento = txtDataEmissao.Value;
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

        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmConFornecedor = new frmConsultaFornecedor();
            frmConFornecedor.btnVoltar.Text = "SELECIONAR";
            if (frmConFornecedor.ShowDialog() == DialogResult.OK)
            {
                CarregaFornecedor();
            }
            var compraValida = CtrlCompra.BuscarPorID(txtModelo.Text, txtSerie.Text, txtNrNota.Text, txtCodFornecedor.Text) as Compras;
            if (compraValida.modelo != null || compraValida.serie != null || compraValida.nrNota != null)
            {
                MessageBox.Show("Já existe uma compra com este modelo, serie, Nr. nota e fornecedor", "Compra já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disable();
                txtCodFornecedor.Clear();
                txtFornecedor.Clear();
            }
        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaProduto())
                {
                    var codProduto = int.Parse(txtCodProduto.Text);
                    if (VerificaProdutoNaLista(codProduto))
                    {
                        PopulaGridProduto();
                        var qtd = Convert.ToInt32(txtQtd.Text);
                        var valorProd = Double.Parse(txtCusto.Text, NumberStyles.Any);
                        var vlTotalincial = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        if (vlTotalincial <= 0)
                        {
                            var vlr = (Double.Parse(lvItem.Items[0].SubItems[4].Text, NumberStyles.Any) * Double.Parse(lvItem.Items[0].SubItems[3].Text, NumberStyles.Any));
                            txtTotalPagar.Text = vlr.ToString("C", CultureInfo.CurrentCulture);
                            txtValorTotal.Text = lvItem.Items[0].SubItems[5].Text;
                        }
                        else
                        {
                            double vltotal = 0;
                            for (int i = 0; i < lvItem.Items.Count; i++)
                            {
                                vltotal += Double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any);
                            }
                            double vltotalPagar = 0;
                            for (int i = 0; i < lvItem.Items.Count; i++)
                            {
                                vltotalPagar += Double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any);
                            }

                            txtTotalPagar.Text = vltotalPagar.ToString("C", CultureInfo.CurrentCulture);
                            txtValorTotal.Text = vltotal.ToString("C", CultureInfo.CurrentCulture);
                        }
                        txtCodProduto.Clear();
                        txtProduto.Clear();
                        txtUnidade.Clear();
                        txtCusto.Text = "R$ 0.00";
                        txtQtd.Clear();
                        GerarContaPagar();
                    }
                }
            }
            catch
            {
                txtValorTotal.Text = "R$ 0.00";
            }
        }

        private bool VerificaProdutoNaLista(int codigo)
        {
            if (lvItem.Items.Count > 0)
            {
                for( var i = 0; i < lvItem.Items.Count; i++)
                {
                    if (codigo == int.Parse(lvItem.Items[i].SubItems[0].Text))
                    {
                        MessageBox.Show("Não foi possivel adicionar o mesmo item", "Erro, remova o item da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodProduto.Text = "";
                        txtProduto.Text = "";
                        txtUnidade.Text = "";
                        txtQtd.Text = "";
                        txtCusto.Text = "";
                        return false;
                    }
                }
            }
            return true;
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


            if (String.IsNullOrEmpty(txtSerie.Text))
            {
                MessageBox.Show("Faltou informar Serie", "Informe a Serie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }


            if (String.IsNullOrEmpty(txtCodFornecedor.Text) || String.IsNullOrEmpty(txtFornecedor.Text))
            {
                MessageBox.Show("Faltou informar o Fornecedor", "Informe o Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodFornecedor.Focus();
                return false;
            }
            return true;
        }

        private void LimpaCampos()
        {
            txtModelo.Clear();
            txtSerie.Clear();
            txtNrNota.Clear();
            txtDataEmissao.Value = DateTime.Now;
            txtDtChegada.Value = DateTime.Now;
            chkSituacao.Checked = false;
            txtCodFornecedor.Clear();
            txtFornecedor.Clear();
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUnidade.Clear();
            txtQtd.Clear();
            txtCusto.Text = "R$ 0.00";
            lvItem.Items.Clear();
            rbTipoFrete2.Checked = true;
            txtFrete.Text = "R$ 0.00";
            txtSeguro.Text = "R$ 0.00";
            txtOutrasDesp.Text = "R$ 0.00";
            txtValorTotal.Text = "R$ 0.00";
            txtCodCondPagamento.Clear();
            txtCondPagamento.Clear();
            lvContaPagar.Items.Clear();
            txtObservacoes.Clear();

        }

        private void CarregaProduto()
        {
            if (Produto != null)
            {
                Produtos pro = Produto as Produtos;
                txtCodProduto.Text = Convert.ToString("0" + pro.codigo);
                txtProduto.Text = pro.produto;
                txtUnidade.Text = pro.unidade;
                txtCusto.Text = pro.custo.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void CarregaCondicao()
        {
            if (CondPagamento != null)
            {
                condPag = CondPagamento as CondicaoPagamentos;
                txtCodCondPagamento.Text = Convert.ToString(condPag.codigo);
                txtCondPagamento.Text = condPag.condicao;
            }
        }

        private void CarregaFornecedor()
        {
            if (Fornecedor != null)
            {
                Fornecedores forn = Fornecedor as Fornecedores;
                txtCodFornecedor.Text = Convert.ToString(forn.codigo);
                txtFornecedor.Text = forn.fornecedor;
                txtCodCondPagamento.Text = forn.CondPagamento.codigo.ToString();
                txtCondPagamento.Text = forn.CondPagamento.condicao;
                CondPagamento = forn.CondPagamento;
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

        private bool ValidaProduto()
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
            
            if (txtDtChegada.Value < txtDataEmissao.Value)
            {
                MessageBox.Show("Data deve ser maior que a emissão!", "Data de chegada ínvalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDtChegada.Value = txtDataEmissao.Value;
                txtDtChegada.Focus();
            }
        }

        private void RbTipoFrete1_CheckedChanged(object sender, EventArgs e)
        {
            txtFrete.Enabled = false;
            txtSeguro.Enabled = false;
            txtFrete.Text = "R$ 0,00";
            txtSeguro.Text = "R$ 0,00";

            double despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
            double frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
            double seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
            double total = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
           
            total += frete + seguro + despesa;
            txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture);
            
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
                        double valorTotal = 0;
                        for (int i = 0; i < lvItem.Items.Count; i++)
                        {
                            valorTotal += double.Parse(lvItem.Items[i].SubItems[5].Text, NumberStyles.Any);
                        } 
                        txtValorTotal.Text = valorTotal.ToString("C", CultureInfo.CurrentCulture);
                        if(lvItem.Items.Count == 0)
                        {
                            double i = 0;
                            txtValorTotal.Text = i.ToString("C", CultureInfo.CurrentCulture);
                        }
                        else
                        {
                            var seguro = double.Parse(txtSeguro.Text, NumberStyles.Any);
                            var frete = double.Parse(txtFrete.Text, NumberStyles.Any);
                            var despesa = double.Parse(txtOutrasDesp.Text, NumberStyles.Any);

                            valorTotal += seguro + frete + despesa;
                            txtValorTotal.Text = valorTotal.ToString("C", CultureInfo.CurrentCulture);

                        }
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
            double frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
            double seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any); 
            double despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any); 
            double total = Double.Parse(txtValorTotal.Text, NumberStyles.Any); 
            if(frete > 0)
            {
                total += frete + seguro + despesa;
                txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture); 
            }
            else
            {
                total += despesa + seguro;
                txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture);
            }
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
            double seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
            double frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
            double despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
            double total = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
            if(seguro > 0)
            { 
                total += seguro + frete + despesa;
                txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture);
            }
            else
            {
                total += frete + despesa;
                txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture);
            }
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
            double despesa = Double.Parse(txtOutrasDesp.Text, NumberStyles.Any);
            double frete = Double.Parse(txtFrete.Text, NumberStyles.Any);
            double seguro = Double.Parse(txtSeguro.Text, NumberStyles.Any);
            double total = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
            if(despesa > 0)
            {
                total += despesa + seguro + frete;
                txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture); 
            }
            else
            {
                total += frete + seguro;
                txtTotalPagar.Text = total.ToString("C", CultureInfo.CurrentCulture);
            }

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
            if (string.IsNullOrEmpty(txtCodFornecedor.Text))
                return;
            if (Convert.ToInt32("0" + txtCodFornecedor.Text) < 1)
                return;
            Fornecedores forn = CtrlFornecedor.BuscarPorID(Convert.ToInt32(txtCodFornecedor.Text)) as Fornecedores;
            if (forn == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtFornecedor.Clear();
                txtCodFornecedor.Clear();

                txtCodFornecedor.Enabled = true;
                txtFornecedor.Enabled = true;
            }
            else
            {
                txtFornecedor.Text = forn.fornecedor;
                condPag = forn.CondPagamento;
                txtCodCondPagamento.Text = forn.CondPagamento.codigo.ToString();
                txtCondPagamento.Text = forn.CondPagamento.condicao;
                Enable();
                txtCodFornecedor.Enabled = false;
                txtFornecedor.Enabled = false;
            }
        }

        private void ChkSituacao_CheckedChanged(object sender, EventArgs e)
        {
           
            btnSalvar.Text = "DESATIVAR";
            btnSalvar.Show();
            
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);

        }

        private void txtCodCondPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtNrNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtUnidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtCodCondPagamento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCondPagamento.Text))
                return;
            if (Convert.ToInt32("0" + txtCodCondPagamento.Text) < 1)
                return;
            CondicaoPagamentos cond = CtrlCondPagamento.BuscarPorID(Convert.ToInt32(txtCodCondPagamento.Text)) as CondicaoPagamentos;
            if (cond == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCondPagamento.Clear();
                txtCodCondPagamento.Clear();

                txtCodCondPagamento.Enabled = true;
                txtCondPagamento.Enabled = true;
            }
            else
            {
                txtCondPagamento.Text = cond.condicao;

                txtCodCondPagamento.Enabled = false;
                txtCondPagamento.Enabled = false;
            }
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodProduto.Text))
                return;
            if (Convert.ToInt32("0" + txtCodProduto.Text) < 1)
                return;
            Produtos prod = CtrlProduto.BuscarPorID(Convert.ToInt32(txtCodProduto.Text)) as Produtos;
            if (prod == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtProduto.Clear();
                txtCodProduto.Clear();
                txtCusto.Clear();
                txtCodProduto.Enabled = true;
                txtProduto.Enabled = true;
                txtUnidade.Enabled = true;
            }
            else
            {
                txtProduto.Text = prod.produto;
                txtUnidade.Text = prod.unidade;
                txtCusto.Text = prod.custoUltCompra.ToString("C", CultureInfo.CurrentCulture); 
                txtCodProduto.Enabled = false;
                txtProduto.Enabled = false;
                txtUnidade.Enabled = false;
            }
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            DateTime emissao = DateTime.Parse(txtDataEmissao.Text);
            DateTime chegada = DateTime.Parse(txtDtChegada.Text);

            if(emissao > chegada)
            {
                MessageBox.Show("Data de emissão não pode ser maior que a data de chagada", "Data de emissão invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDataEmissao.Value = DateTime.Now;
                txtDataEmissao.Focus();
            }
        }

        private void txtDtChegada_Leave(object sender, EventArgs e)
        {
            DateTime emissao = DateTime.Parse(txtDataEmissao.Text);
            DateTime chegada = DateTime.Parse(txtDtChegada.Text);

            if (chegada < emissao)
            {
                MessageBox.Show("Data de chegada não pode ser menor que a data de emissão", "Data de chegada invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtChegada.Value = DateTime.Now;
                txtDtChegada.Focus();
            }
        }

        private void frmCadastroCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private Boolean ValidarContasPagar(object modelo, object serie, object nrNota, object codFornecedor)
        {
            var listaContaPagar = CtrlCompra.BuscarContaPagar(modelo, serie, nrNota, codFornecedor);
            bool valida = true;
            foreach (var conta in listaContaPagar)
            {
                if (conta.pago)
                {
                    valida = false;
                }

            }
            return valida;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Será necessario informar o usuario Administrador do sistema.", "Deseja cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & txtModelo.Text != null)
                {
                    frmConfirmaAdmin frmConfirma = new frmConfirmaAdmin();
                    if (frmConfirma.ShowDialog() == DialogResult.OK)
                    {
                        if (ValidarContasPagar(txtModelo.Text, txtSerie.Text, txtNrNota.Text, txtCodFornecedor.Text))
                        {
                            CtrlCompra.Desativar(txtModelo.Text, txtSerie.Text, txtNrNota.Text, txtCodFornecedor.Text);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel cancelar a compra, pois teve contas a pagar vinculadas pagas.", "Parcelas vinculadas pagas!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } 
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel cancelar a compra");
            }
        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {
            var total = int.Parse(txtTotalPagar.Text, NumberStyles.Any);
            if(total > 0)
            {
                btnBuscarCondPagamento.Enabled = true;
                GerarContaPagar();
            }
            else
            {
                btnBuscarCondPagamento.Enabled = false;
            }
        }

        private void txtSeguro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutrasDesp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrete_Click(object sender, EventArgs e)
        {

        }

        private void txtSeguro_Click(object sender, EventArgs e)
        {

        }

        private void txtOutrasDesp_Click(object sender, EventArgs e)
        {

        }

        private void txtFrete_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtSeguro_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtOutrasDesp_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtDataEmissao_ValueChanged(object sender, EventArgs e)
        {
            if (txtDataEmissao.Value > txtDtChegada.Value)
            {
                MessageBox.Show("Data emissão deve ser menor que a data de chegada!", "Data de emissão ínvalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataEmissao.Value = txtDtChegada.Value;
                txtDataEmissao.Focus();
            }
        }

        private void txtFrete_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if(txtModelo.Text.Trim().Length > 3)
            {
                MessageBox.Show("Modelo não pode ter mais de 3 numeros", "Modelo da compra é ivalido!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                txtModelo.Focus();
            }
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            if (txtSerie.Text.Trim().Length > 3)
            {
                MessageBox.Show("Serie não pode ter mais de 3 numeros", "Serie da compra é ivalido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSerie.Focus();
            }
        }

        private void txtNrNota_Leave(object sender, EventArgs e)
        {
            if (txtNrNota.Text.Trim().Length > 8)
            {
                MessageBox.Show("Numero da nota não pode ter mais de 8 numeros", "Numero da Nota da compra é ivalido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNrNota.Focus();
            }
        }
    }
}
