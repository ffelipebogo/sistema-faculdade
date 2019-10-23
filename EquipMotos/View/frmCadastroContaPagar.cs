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
    public partial class frmCadastroContaPagar : Form
    {
        ContasPagar conta = new ContasPagar();
        ContasPagarDAO dao = new ContasPagarDAO();
        public static object fornecedor = null;
        public static object condPagamento = null;
        CondicaoPagamentos condPag = new CondicaoPagamentos();
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
                conta.formaPagamento = daoFormaPagamento.BuscarPorID(Convert.ToInt32(txtCodFormaPagamento.Text)) as FormaPagamentos;
                conta.fornecedor = daoFornecedor.BuscarPorID(Convert.ToInt32(txtCodFornecedor.Text)) as Fornecedores;
                conta.modelo = txtModelo.Text;
                conta.serie = txtSerie.Text;
                conta.nrNota = txtNrNota.Text;
                conta.nrParcela = Convert.ToInt32("0" + txtNrParcela.Text);
                conta.dtVecimento = txtDtVencimento.Value;
                conta.dtEmissao = txtDtEmissao.Value;
                conta.vlrParcela = 1;
                conta.observacoes = txtObeservacoes.Text;
                conta.dtCadastro = DateTime.Now;
                conta.dtAlteracao = DateTime.Now;
                conta.usuario = txtUsuario.Text;
                conta.pago = chkPaga.Checked;

                dao.InserirContasPagar(conta);
            }
        }

        internal void Disable()
        {
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtNrNota.Enabled = false;
            txtValor.Enabled = false;
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
            conta = dao.BuscarContasPagar_porID(modelo, serie, nrNota, idFornecedor, nrParcela);
            txtModelo.Text = conta.modelo;
            txtSerie.Text = conta.serie;
            txtNrNota.Text = conta.nrNota;
            txtValor.Text = conta.vlrParcela.ToString("C", CultureInfo.CurrentCulture); 
            txtFornecedor.Text = Convert.ToString(conta.fornecedor.codigo);
            txtCodFornecedor.Text = conta.fornecedor.fornecedor;
            txtDtEmissao.Text = Convert.ToString(conta.dtEmissao);
            txtDtVencimento.Text = Convert.ToString(conta.dtVecimento);
            txtCodFormaPagamento.Text = Convert.ToString(conta.formaPagamento.codigo);
            txtFormaPagamento.Text = conta.formaPagamento.forma;
            txtObeservacoes.Text = conta.observacoes;
            txtDtCadastro.Text = Convert.ToString( conta.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(conta.dtAlteracao);
            txtUsuario.Text = conta.usuario;
            chkPaga.Checked = conta.pago;
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

        private void CarregaCondicao()
        {
            if (condPagamento != null)
            {
                condPag = condPagamento as CondicaoPagamentos;
                txtCodFormaPagamento.Text = Convert.ToString(condPag.codigo);
                txtFormaPagamento.Text = condPag.condicao;
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
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtNrNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void txtCodCondPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }
    }
}
