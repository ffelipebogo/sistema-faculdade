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
        private String pusuario;
        public static object prod;
        public static object cliente;
        public static object condPagamento;

        CondicaoPagamentos condPag;

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
            frmConsultaCliente frmConCliente = new frmConsultaCliente(pusuario);
            frmConCliente.btnVoltar.Text = "SELECIONAR";
            if (frmConCliente.ShowDialog() == DialogResult.OK)
            {
                CarregaCliente();
            }
        }

        private void CarregaCliente()
        {
            if (cliente != null)
            {
                Clientes cli = cliente as Clientes;
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
            if (prod != null)
            {
                ProdutosServicos pro = prod as ProdutosServicos;
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
                        var aux = condPag.listaParcela;
                        if (aux.Count == condPag.listaParcela.Count)
                        {
                            lvContaReceber.Items.Clear();
                            for (int i = 0; i < condPag.listaParcela.Count; i++)
                            {
                                var desconto = Double.Parse(txtDescontos.Text) / 100;
                                var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                var valorDesconto = desconto * totalItens;

                                var parcela = condPag.listaParcela.ElementAt(i);
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
                            condPag.listaParcela = aux;
                            lvContaReceber.Items.Clear();
                            for (int i = 0; i < condPag.listaParcela.Count; i++)
                            {
                                var desconto = Double.Parse(txtDescontos.Text) / 100;
                                var totalItens = Double.Parse(txtValorItens.Text, NumberStyles.Any);
                                var valorDesconto = desconto * totalItens;

                                var parcela = condPag.listaParcela.ElementAt(i);
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
            if (condPagamento != null)
            {
                condPag = new CondicaoPagamentos();
                condPag = condPagamento as CondicaoPagamentos;
                txtCodCondPagamento.Text = Convert.ToString(condPag.codigo);
                txtCondPagamento.Text = condPag.condicao;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

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
