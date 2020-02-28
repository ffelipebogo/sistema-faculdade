using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroFormaPagamento : MaterialSkin.Controls.MaterialForm
    {
        FormaPagamentos formPag = new FormaPagamentos();
        CtrlFormaPagamentos CtrlFormaPagamento = new CtrlFormaPagamentos();
        public frmCadastroFormaPagamento()
        {
            InitializeComponent();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampo())
                {
                    formPag.forma = txtForma.Text;
                    formPag.dtCadastro = DateTime.Now;
                    formPag.dtAlteracao = DateTime.Now;
                    formPag.usuario = UsuarioLogado.Usuario;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        formPag.codigo = Convert.ToInt32(txtCodigo.Text);
                        formPag.dtAlteracao = DateTime.Now;
                        CtrlFormaPagamento.Editar(formPag);

                        MessageBox.Show("Forma de Pagamento alterada com Sucesso!");
                    }
                    else
                    {
                        formPag.dtAlteracao = DateTime.Now;
                        formPag.dtCadastro = DateTime.Now;
                        CtrlFormaPagamento.Inserir(formPag);
                        MessageBox.Show("Forma de Pagamento cadastrada com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        public void Carregar(object id)
        {
            formPag = CtrlFormaPagamento.BuscarPorID(id) as FormaPagamentos;
            txtCodigo.Text = Convert.ToString(formPag.codigo);
            txtForma.Text = Convert.ToString(formPag.forma);
            txtDtCadastro.Text = Convert.ToString(formPag.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(formPag.dtAlteracao);
            txtUsuario.Text = Convert.ToString(formPag.usuario);
            btnSalvar.Text = "ALTERAR";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtForma.Text = "";
            txtDtAlteracao = null;
            txtDtCadastro = null;
            txtUsuario = null;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ValidaCampo()
        {
            if (txtForma.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir esta forma", "Informe a forma com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtForma.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtForma.Text))
            {
                MessageBox.Show("Faltou informar a forma", "Informe a forma!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtForma.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtForma.Text))
            {
                MessageBox.Show("Forma invalida", "Forma não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtForma.Focus();
                return false;
            }
            return true;
        }

        private void txtForma_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtForma_Leave(object sender, EventArgs e)
        {
            if(txtForma.Text.Length < 4)
            {
                MessageBox.Show("Informe uma forma com mais de 4 caracteres", "Forma invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCadastroFormaPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
