﻿using EquipMotos.Codigo.View;
using EquipMotos.CONTROLLER;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using EquipMotos.VIEW;
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
using MaterialForm = MaterialSkin.Controls.MaterialForm;

namespace EquipMotos.View
{
    public partial class frmCadastroVenda : MaterialForm
    {
        public static object Produto;
        public static object Cliente;
        public static object CondPagamento;
        Vendas Venda;
        CtrlVendas CtrlVenda = new CtrlVendas();
        CtrlProdutos CtrlProduto = new CtrlProdutos();
        CtrlCondicaoPagamento CtrlCondPagamento = new CtrlCondicaoPagamento();
        CtrlClientes CtrlCliente = new CtrlClientes();
        CondicaoPagamentos CondicaoPagamento;

        ToolTip toolTip = new ToolTip();

        public frmCadastroVenda()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnAddProduto, "Adicionar Produto");
            toolTip.SetToolTip(btnRemProduto, "Remover Produto");
            chkSituacao.Checked = true;
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
                        //if (ValidaEstoque())
                        {
                            Venda.modelo = txtModelo.Text;
                            Venda.serie = txtSerie.Text;
                            Venda.nrNota = txtNumeroVenda.Text;
                            Venda.dtEmissao = txtData.Value;
                            Venda.desconto = Double.Parse("0"+txtDescontos.Text);
                            Venda.totalReceber = Double.Parse("0"+txtValorTotal.Text);
                            Venda.cliente = CtrlCliente.BuscarPorID(txtCodCliente.Text.Trim()) as Clientes;
                            Venda.condPagamento = CtrlCondPagamento.BuscarPorID(Convert.ToInt32(txtCodCondPagamento.Text.Trim())) as CondicaoPagamentos;
                            Venda.observacoes = txtObservacoes.Text;
                            Venda.dtCadastro = DateTime.Now;
                            Venda.dtAlteracao = DateTime.Now;
                            var dtEmissao = txtData.Value;
                            Venda.usuario = UsuarioLogado.Usuario;
                            // ProdutosServicos produto = new ProdutosServicos();
                            for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
                            {
                                var idItem = Convert.ToInt32(lvProdutosVenda.Items[i].SubItems[0].Text);
                                var qtdItem = Convert.ToInt32(lvProdutosVenda.Items[i].SubItems[2].Text);
                                var custoItem = Decimal.Parse(lvProdutosVenda.Items[i].SubItems[4].Text, NumberStyles.Any);

                                listItemVenda.Add(new ItensVenda()
                                {
                                    modelo = Venda.modelo,
                                    serie = Venda.serie,
                                    nrNota = Venda.nrNota,
                                    cliente = Venda.cliente,
                                    codigo = idItem,
                                    qtd = qtdItem,
                                    precoVenda = custoItem,
                                    dtCadastro = Venda.dtCadastro,
                                    dtAlteracao = Venda.dtAlteracao,
                                    usuario = Venda.usuario,
                                });
                            }
                            Venda.listaItem = listItemVenda;

                            for (int i = 0; i < lvContaReceber.Items.Count; i++)
                            {
                                var forma = Venda.condPagamento.listaParcela.ElementAt(i).formaPagamento;
                                                     
                                listContaReceber.Add(new ContasReceber()
                                {
                                    modelo = Venda.modelo,
                                    serie = Venda.serie,
                                    nrNota = Venda.nrNota,
                                    cliente = Venda.cliente,
                                    formaPagamento = forma,
                                    nrParcela = i + 1,
                                    dtVencimento = Convert.ToDateTime(lvContaReceber.Items[i].SubItems[1].Text),
                                    vlrParcela = Double.Parse(lvContaReceber.Items[i].SubItems[2].Text, NumberStyles.Any),
                                    dtAlteracao = DateTime.Now,
                                    dtCadastro = DateTime.Now,
                                    dtEmissao = dtEmissao,
                                    usuario = UsuarioLogado.Usuario
                                });
                            }
                            Venda.listaContasReceber= listContaReceber;
                            Venda.situacao = chkSituacao.Checked;

                            CtrlVenda.Inserir(Venda);
                            this.DialogResult = DialogResult.OK;
                        }
                        btnRemProduto.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
                MessageBox.Show("Não foi possivel gerar a Venda", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Venda.listaContasReceber = null;
                Venda.listaItem = null;
            }
            finally
            {
                //this.LimparCampos();
            }
        }

        internal void DisableView()
        {
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtNumeroVenda.Enabled = false;
            txtData.Enabled = false;
            
            txtCodCliente.Enabled = false;
            txtCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            btnBuscarProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtValorProd.Enabled = false;
            btnAddProduto.Enabled = false;
            btnRemProduto.Enabled = false;
            lvProdutosVenda.Enabled = false;
            txtDescontos.Enabled = false;
            txtValorItens.Enabled = false;
            txtValorTotal.Enabled = false;
            txtCodCondPagamento.Enabled = false;
            txtCondPagamento.Enabled = false;
            btnBuscarCondPagamento.Enabled = false;
            chkSituacao.Enabled = false;

            txtObservacoes.Enabled = false;
            btnSalvar.Hide();
            btnLimpar.Hide();
        }

        internal void Carregar( object nrNota)
        {
            try
            {
                Venda = CtrlVenda.BuscarPorID(nrNota) as Vendas;
                txtModelo.Text = Venda.modelo;
                txtSerie.Text = Venda.serie;
                txtNumeroVenda.Text = Venda.nrNota;
                txtData.Text = Convert.ToString(Venda.dtEmissao);
                txtCodCliente.Text = Convert.ToString(Venda.cliente.codigo);
                txtCliente.Text = Convert.ToString(Venda.cliente.cliente);
                txtDescontos.Text = (Venda.desconto).ToString("C", CultureInfo.CurrentCulture);
                //txtValorItens.Text = (Venda.ValorItens).ToString("C", CultureInfo.CurrentCulture);
                //txtValorTotal.Text = (Venda.totalReceber).ToString("C", CultureInfo.CurrentCulture);

                foreach (var item in Venda.listaItem)
                {
                    var prod = CtrlProduto.BuscarPorID(Convert.ToString(item.codigo)) as Produtos;
                    var total = item.qtd * prod.precoVenda;
                    string[] itens = { Convert.ToString(item.codigo), prod.produto, prod.unidade, Convert.ToString(item.qtd), Convert.ToString(prod.custoUltCompra), Convert.ToString(total) };
                    var listItens = new ListViewItem(itens);
                    lvProdutosVenda.Items.Add(listItens);

                    var vlTotalincial = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                    if (vlTotalincial <= 0)
                    {
                        txtValorTotal.Text = Double.Parse(lvProdutosVenda.Items[0].SubItems[5].Text).ToString("C", CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
                        {
                            txtValorTotal.Text = Double.Parse(lvProdutosVenda.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        var vlTotalGrid = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
                        var ValorTotal = (vltotal + vlTotalGrid).ToString("C", CultureInfo.CurrentCulture);
                        txtValorTotal.Text = ValorTotal;
                    }
                }

                var totalproduto = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
               
                var totalPagar = totalproduto;
                txtValorTotal.Text = totalPagar.ToString("C", CultureInfo.CurrentCulture);

                txtCodCondPagamento.Text = Convert.ToString(Venda.condPagamento.codigo);
                txtCondPagamento.Text = Convert.ToString(Venda.condPagamento.condicao);
                foreach (var conta in Venda.listaContasReceber)
                {
                    string[] row = {  Convert.ToString(conta.nrParcela), conta.dtVencimento.ToString("dd/MM/yyyy"), conta.vlrParcela.ToString("C", CultureInfo.CurrentCulture) };
                    var lvi = new ListViewItem(row);
                    lvContaReceber.Items.Add(lvi);
                }
                chkSituacao.Checked = Venda.situacao;

            }
            catch
            {
                MessageBox.Show("Não foi possivel vizualizar a compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
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
        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {

        }

        private void CarregaCliente()
        {
            if (Cliente != null)
            {
                Clientes cli = Cliente as Clientes;
                txtCodCliente.Text = Convert.ToString(cli.codigo);
                txtCliente.Text = cli.cliente;
                if(cli.CondPagamento != null)
                {
                    txtCodCondPagamento.Text = Convert.ToString(cli.CondPagamento.codigo);
                    txtCondPagamento.Text = cli.CondPagamento.condicao;
                }
            }
        }

        private void BtnBuscarProduto_Click_1(object sender, EventArgs e)
        {
            frmConsultaProduto frmConProduto = new frmConsultaProduto();
            frmConProduto.btnVoltar.Text = "SELECIONAR";

            if (frmConProduto.ShowDialog() == DialogResult.OK)
            {
                CarregaProduto();
            }
        }

        private void CarregaProduto()
        {
            if (Produto != null)
            {
                Produtos pro = Produto as Produtos;
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
                lvContaReceber.Items.Clear();
                if (Double.Parse(txtValorTotal.Text, NumberStyles.Any) <= 0)
                {
                    var vlrDesconto = Double.Parse("0" + txtDescontos.Text);
                    var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                    double valorDesconto = 0;
                    if (vlrDesconto > 0)
                    {
                        var desconto = Double.Parse(txtDescontos.Text) / 100;
                        valorDesconto = desconto * totalItens;
                    }
                    txtValorTotal.Text = (totalItens - valorDesconto).ToString("C", CultureInfo.CurrentCulture);
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
                                var desconto = Double.Parse("0"+txtDescontos.Text) / 100;
                                double valorDesconto = 0;
                                if (desconto > 0)
                                {
                                    var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                    valorDesconto = desconto * totalItens;
                                }

                                var parcela = CondicaoPagamento.listaParcela.ElementAt(i);
                                var dtVencimento = Convert.ToDateTime(txtData.Text);
                                dtVencimento = dtVencimento.AddDays(parcela.nrDia);
                                var valorTot =  Double.Parse(txtValorItens.Text, NumberStyles.Any) - valorDesconto;
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
                                var desconto = Double.Parse("0" + txtDescontos.Text) / 100;
                                double valorDesconto = 0;
                                if (desconto > 0)
                                {
                                    var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                    valorDesconto = desconto * totalItens;
                                }
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

        private void LimparCampos()
        {
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtNumeroVenda.Text = "";
            txtData.Value = DateTime.Now;
            chkSituacao.Checked = true;
            txtCodCliente.Text = "";
            txtCliente.Text = "";
            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtQtd.Text = "";
            txtValorProd.Text = "R$ 0,00";
            txtDescontos.Text = "";
            lvProdutosVenda.Items.Clear();
            txtValorItens.Text = "R$ 0,00";
            txtValorTotal.Text = "R$ 0,00";
            txtCodCondPagamento.Text = "";
            txtCondPagamento.Text = "";
            lvContaReceber.Items.Clear();
            txtObservacoes.Text = "";
        }

        private bool ValidaCampos()
        {
            if (txtModelo.Text.Length < 2)
            {
                MessageBox.Show("Modelo inválido!", "Verefique o Modelo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }
            //if (txtNumeroVenda.Text == String.Empty)
            //{
            //    MessageBox.Show("Faltou informar o Número da Nota", "Informe o Número da Nota!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNrNota.Focus();
            //    return false;
            //}


            if (txtSerie.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar Serie", "Informe a Serie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }


            if (txtCodCliente.Text == String.Empty || (txtCliente.Text == String.Empty))
            {
                MessageBox.Show("Faltou informar o Cliente", "Informe o Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCliente.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaEstoque(int codigo, int qtd)
        {
            var qtdItem = qtd;
            var Produto = CtrlProduto.BuscarPorID(codigo) as Produtos;
            if (Produto.qtd < qtdItem)
            {
                MessageBox.Show("Não há estoque para a venda de " + Produto.produto + ", o estoque atual é de " + Produto.qtd, "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //private bool ValidaEstoque()
        //{
        //    for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
        //    {
        //        var idItem = Convert.ToInt32(lvProdutosVenda.Items[i].SubItems[0].Text);
        //        var qtdItem = Convert.ToInt32(lvProdutosVenda.Items[i].SubItems[2].Text);
        //        var Produto = CtrlProduto.BuscarPorID(idItem) as ProdutosServicos;
        //        if (Produto.qtd < qtdItem)
        //        {
        //            MessageBox.Show( "Não há estoque para a venda de " + Produto.produto + ", o estoque atual é de "+ Produto.qtd , "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos prod = Produto as Produtos;
                if (ValidaProduto())
                {
                    var preco = Double.Parse(txtValorProd.Text, NumberStyles.Any);
                    var qtd = Convert.ToInt32(txtQtd.Text);
                    var totalRow = (qtd * preco).ToString("C", CultureInfo.CurrentCulture);
                    var codigo = prod.codigo;
                    if (ValidaEstoque(codigo, qtd))
                    {

                            string[] row = { Convert.ToString(prod.codigo), prod.produto, txtQtd.Text, (prod.precoVenda).ToString("C", CultureInfo.CurrentCulture), Convert.ToString(totalRow) };
                            var lvi = new ListViewItem(row);
                            lvProdutosVenda.Items.Add(lvi);

                            var vlTotalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                            if (vlTotalItens <= 0)
                            {
                                txtValorItens.Text = lvProdutosVenda.Items[0].SubItems[4].Text;
                            }
                            else
                            {
                                var vltotal = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
                                {
                                    txtValorItens.Text = Double.Parse(lvProdutosVenda.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
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
                            txtValorProd.Text = "R$ 0.00";
                            Produto = null;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvProdutosVenda.SelectedIndices[0] != null)
                {
                    if ((MessageBox.Show("Remover item ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & (lvProdutosVenda.SelectedIndices[0] != null))
                    {
                        lvProdutosVenda.Items.RemoveAt(lvProdutosVenda.SelectedIndices[0]);
                        for (int i = 0; i < lvProdutosVenda.Items.Count; i++)
                        {
                            txtValorTotal.Text = Double.Parse(lvProdutosVenda.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        var vlTotalGrid = Double.Parse(txtValorTotal.Text, NumberStyles.Any);

                        txtValorTotal.Text = vlTotalGrid.ToString("C", CultureInfo.CurrentCulture);

                        if (lvProdutosVenda.Items.Count == 0)
                        {
                            txtValorTotal.Text = "R$ 0.00";
                            txtValorItens.Text = "R$ 0.00";
                            lvContaReceber.Items.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um item! ");
                }
            }
            catch
            {
                MessageBox.Show("Selecione um item! ");
            }
        }

        private bool ValidaProduto()
        {
            if (String.IsNullOrEmpty(txtCodProduto.Text))
            {
                MessageBox.Show("Faltou informar o Código Produto", "Informe o Código Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            else if (Convert.ToInt32("0"+txtCodProduto.Text) < 1)
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
            else if (Convert.ToInt32(txtQtd.Text) < 1)
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
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtNrItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodCondPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
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
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
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

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtNumeroVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            if(txtData.Value > DateTime.Now)
            {
                MessageBox.Show("Não é possivel inserir esta data", "Informe uma data igual ou menor que a atual", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtData.Value = DateTime.Now;
                txtData.Focus();
            }
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCliente.Text))
                return;
            if (Convert.ToInt32("0" + txtCodCliente.Text) < 1)
                return;
           
            Clientes cli = CtrlCliente.BuscarPorID(Convert.ToInt32(txtCodCliente.Text)) as Clientes;
            if (cli == null)
            {
                MessageBox.Show("Nenhum resultado", "Tente pesquisar clicando na lupa ao lado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodCliente.Text = "";
                txtCliente.Text = "";

                txtCodCliente.Enabled = true;
                txtCliente.Enabled = true;
                txtCodCliente.Focus();
            }
            else
            {
                txtCliente.Text = cli.cliente;

                cli = null;
                txtCliente.Enabled = false;
                txtCodCliente.Focus();
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
                txtCodProduto.Text = "";
                txtProduto.Text = "";

                txtCodProduto.Enabled = true;
                txtProduto.Enabled = true;
                txtCodProduto.Focus();
            }
            else
            {
                txtProduto.Text = prod.produto;

                txtProduto.Enabled = false;
                txtCodProduto.Focus();
            }
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
                txtCodCondPagamento.Text = "";
                txtCondPagamento.Text = "";

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

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean ValidarContasReceber(object modelo, object serie, object nrNota, object codCliente)
        {
            var listaContaReceber = CtrlVenda.BuscarContaReceber(modelo, serie, nrNota, codCliente);
            bool valida = true;
            foreach (var conta in listaContaReceber)
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
            if ((MessageBox.Show("Será necessario informar o usuario Administrador do sistema.", "Deseja cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & txtModelo.Text != null)
            {
                frmConfirmaAdmin frmConfirma = new frmConfirmaAdmin();
                if (frmConfirma.ShowDialog() == DialogResult.OK)
                {
                    if (ValidarContasReceber(txtModelo.Text, txtSerie.Text, txtNumeroVenda.Text, txtCodCliente.Text))
                    {
                        CtrlVenda.Desativar(txtModelo.Text, txtSerie.Text, txtNumeroVenda.Text, txtCodCliente.Text);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cancelar a venda, pois teve contas a receber vinculadas pagas.", "Parcelas vinculadas recebidas!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}
