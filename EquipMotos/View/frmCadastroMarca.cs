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
    public partial class frmCadastroMarca : Form
    {
        Marcas mar = new Marcas();
        MarcasDAO dao = new MarcasDAO();
        public frmCadastroMarca()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampo())
                {
                    mar.marca = txtMarca.Text;
                    mar.usuario = txtUsuario.Text;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        mar.codigo = Convert.ToInt32(txtCodMarca.Text);
                        mar.dtAlteracao = DateTime.Now;
                        dao.Editar(mar);

                        MessageBox.Show("Marca alterada com Sucesso!");
                    }
                    else
                    {
                        mar.dtAlteracao = DateTime.Now;
                        mar.dtCadastro = DateTime.Now;
                        dao.Inserir(mar);
                        MessageBox.Show("Marca cadastrada com Sucesso!");
                    }
                    this.Close();
                    this.DialogResult = DialogResult.OK;
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
            mar = dao.BuscarPorID(id) as Marcas;
            txtCodMarca.Text = Convert.ToString(mar.codigo);
            txtMarca.Text = mar.marca;

            txtDtCadastro.Text = Convert.ToString(mar.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(mar.dtAlteracao);
            txtUsuario.Text = mar.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodMarca.Text = "";
            txtMarca.Text = "";
            txtDtAlteracao.Text = "";
            txtDtCadastro.Text = "";
            txtUsuario.Text = "";
        }
        public bool ValidaCampo()
        {
            if (txtMarca.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar a Marca", "Informe a Marca!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            return true;
        }

        private void FrmCadastroMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
