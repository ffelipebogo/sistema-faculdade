using EquipMotos.DAO;
using EquipMotos.MODEL;
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
    public partial class frmCadastroFormaPagamento : Form
    {

        FormaPagamentos formPag = new FormaPagamentos();
        FormaPagamentoDAO dao = new FormaPagamentoDAO();
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
                    formPag.usuario = txtUsuario.Text;
                    //FormaPagamentoDAO dao = new FormaPagamentoDAO();

                    
                    if (btnSalvar.Text == "ALTERAR")
                    {
                        formPag.codigo = Convert.ToInt32(txtCodigo.Text);
                        formPag.dtAlteracao = DateTime.Now;
                        dao.Editar(formPag);

                        MessageBox.Show("Forma de Pagamento alterada com Sucesso!");
                    }
                    else
                    {
                        formPag.dtAlteracao = DateTime.Now;
                        formPag.dtCadastro = DateTime.Now;
                        dao.Inserir(formPag);
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
            formPag = dao.BuscarPorID(id) as FormaPagamentos;
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
            if (txtForma.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar a Descrição", "Informe a Descrição!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtForma.Focus();
                return false;
            }
            return true;
        }
    }
}
