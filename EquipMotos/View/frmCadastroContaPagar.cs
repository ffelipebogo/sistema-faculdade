using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
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
    public partial class frmCadastroContaPagar : MaterialSkin.Controls.MaterialForm
    {
        ContasPagar ContaPagar = new ContasPagar();
        CtrlContasPagar CtrlContaPagar = new CtrlContasPagar();
        CtrlFornecedores CtrlFornecedor = new CtrlFornecedores();
        CtrlFormaPagamentos CtrlFormaPagamento = new CtrlFormaPagamentos();

        public static object fornecedor = null;
        public static object condPagamento = null;
        public static object formaPag;
        public frmCadastroContaPagar()
        {
            InitializeComponent();
        }

      
        private void FrmCadastroContaPagar_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            FormaPagamentoDAO daoFormaPagamento = new FormaPagamentoDAO();
            FornecedoresDAO daoFornecedor = new FornecedoresDAO();
            if (ValidaConta())
            {
                ContaPagar.formaPagamento = daoFormaPagamento.BuscarPorID(Convert.ToInt32(txtCodFormaPagamento.Text)) as FormaPagamentos;
                ContaPagar.fornecedor = daoFornecedor.BuscarPorID(Convert.ToInt32(txtCodFornecedor.Text)) as Fornecedores;
                ContaPagar.modelo = txtModelo.Text;
                ContaPagar.serie = txtSerie.Text;
                ContaPagar.nrNota = txtNrNota.Text;
                ContaPagar.nrParcela = Convert.ToInt32("0" + txtNrParcela.Text);
                ContaPagar.dtVencimento = txtDtVencimento.Value;
                ContaPagar.dtEmissao = txtDtEmissao.Value;
                ContaPagar.vlrParcela = 1;
                ContaPagar.observacoes = txtObeservacoes.Text;
                ContaPagar.dtCadastro = DateTime.Now;
                ContaPagar.dtAlteracao = DateTime.Now;
                ContaPagar.usuario = UsuarioLogado.Usuario;
                ContaPagar.pago = chkPaga.Checked;

                CtrlContaPagar.Inserir(ContaPagar);
            }
        }

        internal void Disable()
        {
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtNrNota.Enabled = false;
            txtValor.Enabled = false;
            txtNrParcela.Enabled = false;
            txtFornecedor.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtDtEmissao.Enabled = false;
            txtDtVencimento.Enabled = false;
            txtCodFormaPagamento.Enabled = false;
            txtFormaPagamento.Enabled = false;
            txtObeservacoes.Enabled = false;
            txtDtCadastro.Enabled = false;
            txtDtAlteracao.Enabled = false;
            txtUsuario.Enabled = false;
            chkPaga.Enabled = false;
        }

        internal void Carregar(object modelo, object serie, object nrNota, object idFornecedor, object nrParcela)
        {
            ContaPagar = CtrlContaPagar.BuscarContasPagar_porID(modelo, serie, nrNota, idFornecedor, nrParcela) as ContasPagar;
            txtModelo.Text = ContaPagar.modelo;
            txtSerie.Text = ContaPagar.serie;
            txtNrNota.Text = ContaPagar.nrNota;
            txtNrParcela.Text = Convert.ToString(ContaPagar.nrParcela);
            txtValor.Text = ContaPagar.vlrParcela.ToString("C", CultureInfo.CurrentCulture); 
            txtFornecedor.Text = Convert.ToString(ContaPagar.fornecedor.codigo);
            txtCodFornecedor.Text = ContaPagar.fornecedor.fornecedor;
            txtDtEmissao.Text = Convert.ToString(ContaPagar.dtEmissao);
            txtDtVencimento.Text = Convert.ToString(ContaPagar.dtVencimento);
            txtCodFormaPagamento.Text = Convert.ToString(ContaPagar.formaPagamento.codigo);
            txtFormaPagamento.Text = ContaPagar.formaPagamento.forma;
            txtObeservacoes.Text = ContaPagar.observacoes;
            txtDtCadastro.Text = Convert.ToString( ContaPagar.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(ContaPagar.dtAlteracao);
            txtUsuario.Text = ContaPagar.usuario;
            chkPaga.Checked = ContaPagar.pago;
            //lvContaPagar.Visible = false;
            btnSalvar.Visible = false;
            btnLimpar.Visible = false;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtModelo.Text = "";
            txtSerie.Text = "";
            txtNrNota.Text = "";
            txtCodFormaPagamento.Text = "";
            txtFormaPagamento.Text = "";
            txtDtVencimento.Value = DateTime.Now;
            txtDtEmissao.Value = DateTime.Now;
            txtValor.Text = "R$0,00";
            txtObeservacoes.Text = "";
            txtDtAlteracao.Text = "  /  /   ";
            txtDtCadastro.Text = "  /  /   ";
            txtUsuario.Text = "";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidaConta()
        {
            if (txtModelo.Text.Trim().Length > 3)
            {
                MessageBox.Show("Não é possivel inserir este modelo", "Informe o modelo com menos de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }
            if (txtModelo.Text.Length < 2 || String.IsNullOrEmpty(txtModelo.Text.Trim()))
            {
                MessageBox.Show("Modelo não pode ter menos de 2 caracteres!", "Verefique o Modelo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }
            if (txtNrNota.Text == String.Empty)
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

            return true;
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void TxtValor_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void BtnBuscarCondPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento frmConFormaPagamento = new frmConsultaFormaPagamento();
            frmConFormaPagamento.btnVoltar.Text = "SELECIONAR";
            try
            {
                if (frmConFormaPagamento.ShowDialog() == DialogResult.OK)
                {
                    CarregaForma();
                }
            }
            catch
            {
                txtCodFormaPagamento.Text = "";
                txtFormaPagamento.Text = "";
            }
        }

        private void CarregaForma()
        {
            
            if (formaPag != null)
            {
                FormaPagamentos forma = formaPag as FormaPagamentos;
                txtCodFormaPagamento.Text = Convert.ToString(forma.codigo);
                txtFormaPagamento.Text = forma.forma;
            }
            
        }

        //private void CarregaCondicao()
        //{
        //    if (condPagamento != null)
        //    {
        //        condPag = condPagamento as CondicaoPagamentos;
        //        txtCodFormaPagamento.Text = Convert.ToString(condPag.codigo);
        //        txtFormaPagamento.Text = condPag.condicao;
        //    }
        //}

        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmConFornecedor = new frmConsultaFornecedor();
            frmConFornecedor.btnVoltar.Text = "SELECIONAR";
            if (frmConFornecedor.ShowDialog() == DialogResult.OK)
            {
                CarregaFornecedor();
            }
        }

        private void CarregaFornecedor()
        {
            if (fornecedor != null)
            {
                Fornecedores forn = fornecedor as Fornecedores;
                txtCodFornecedor.Text = Convert.ToString(forn.codigo);
                txtFornecedor.Text = forn.fornecedor;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtNrNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodCondPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodFornecedor.Text))
                return;
            if (Convert.ToInt32("0" + txtCodFornecedor.Text) < 1)
                return;
            Fornecedores forn = CtrlFornecedor.BuscarPorID(Convert.ToInt32(txtCodFornecedor.Text)) as Fornecedores;
            if (forn == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtFornecedor.Text = "";
                txtCodFornecedor.Text = "";
                txtFornecedor.Enabled = true;
                txtCodFornecedor.Focus();
            }
            else
            {
                txtFornecedor.Text = forn.fornecedor;
                txtFornecedor.Enabled = false;
                txtCodFornecedor.Focus();
            }
        }

        private void txtCodFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodFormaPagamento.Text))
                return;
            if (Convert.ToInt32("0" + txtCodFormaPagamento.Text) < 1)
                return;
            FormaPagamentos formaPag = CtrlFormaPagamento.BuscarPorID(Convert.ToInt32(txtCodFormaPagamento.Text)) as FormaPagamentos;
            if (formaPag == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCodFormaPagamento.Text = "";
                txtFormaPagamento.Text = "";
                txtCodFormaPagamento.Enabled = true;
                txtFormaPagamento.Enabled = true;
            }
            else
            {
                txtFormaPagamento.Text = formaPag.forma;
                txtCodFormaPagamento.Enabled = false;
                txtFormaPagamento.Enabled = false;
            }
        }
    }
}
