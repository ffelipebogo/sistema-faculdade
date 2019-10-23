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
    public partial class frmCadastroPais : Form
    {
        Paises pais = new Paises();
        PaisesDAO dao = new PaisesDAO();
        public frmCadastroPais()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPais.Text = "";
            txtCodigoPais.Text = "";
            txtDtAlteracao.Text = "  /  /";
            txtDtCadastro.Text = "  /  /";
            txtUsuario.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampo())
                {
                    pais.pais = txtPais.Text;
                   // pais.dtCadastro = DateTime.Now;
                    //pais.dtAlteracao = DateTime.Now;
                    pais.usuario = txtUsuario.Text;



                    //dao.InserirPais(pais);

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        pais.codigo = Convert.ToInt32(txtCodigoPais.Text);
                        pais.dtAlteracao = DateTime.Now;
                        dao.Editar(pais);

                        MessageBox.Show("Pais alterado com Sucesso!");
                    }
                    else
                    {
                        pais.dtAlteracao = DateTime.Now;
                        pais.dtCadastro = DateTime.Now;
                        dao.Inserir(pais);
                        MessageBox.Show("Pais cadastrado com Sucesso!");
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

        internal void Carregar(object id)
        {
            pais = dao.BuscarPorID(id) as Paises;
            txtCodigoPais.Text = Convert.ToString(pais.codigo);
            txtPais.Text = pais.pais;
            txtDtCadastro.Text = Convert.ToString(pais.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(pais.dtAlteracao);
            txtUsuario.Text = pais.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        public bool ValidaCampo()
        {
            if (txtPais.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar o Pais", "Informe Pais!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPais.Focus();
                return false;
            }
            return true;
        }

    }
}
