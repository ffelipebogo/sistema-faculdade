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
    public partial class frmCadastroModelo : Form
    {
        public static object marca;
        Modelos mod = new Modelos();
        ModelosDAO dao = new ModelosDAO();
        public frmCadastroModelo()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnBuscarMarca_Click(object sender, EventArgs e)
        {
            frmConsultaMarca frmConMarca = new frmConsultaMarca();
            frmConMarca.btnVoltar.Text = "SELECIONAR";
            if (frmConMarca.ShowDialog() == DialogResult.OK)
            {
                CarregaMarca();
            }
        }

        private void CarregaMarca()
        {
            if (marca != null)
            {
                Marcas mar = marca as Marcas;
                txtCodMarca.Text = Convert.ToString(mar.codigo);
                txtMarca.Text = mar.marca;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCompos())
                {
                    Marcas mar = new Marcas();
                    mod.modelo = txtModelo.Text;
                    mar.codigo = Convert.ToInt32(txtCodMarca.Text);
                    mod.Marca = mar;
                    mod.usuario = txtUsuario.Text;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        mod.codigo = Convert.ToInt32(txtCodModelo.Text);
                        mod.dtAlteracao = DateTime.Now;
                        dao.Editar(mod);
                        MessageBox.Show("Modelo alterado com Sucesso!");
                    }
                    else
                    {
                        mod.dtAlteracao = DateTime.Now;
                        mod.dtCadastro = DateTime.Now;
                        dao.Inserir(mod);
                        MessageBox.Show("Modelo cadastrado com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        private bool ValidaCompos()
        {
            if (txtModelo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar o Modelo", "Informe o Modelo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            if (txtMarca.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar a Marca", "Informe a Marca!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            return true;
        }

        internal void Carregar(object id)
        {
            mod = dao.BuscarPorID(id) as Modelos;
            txtCodModelo.Text = Convert.ToString(mod.codigo);
            txtModelo.Text = mod.modelo;
            txtCodMarca.Text = Convert.ToString(mod.Marca.codigo);
            txtMarca.Text = mod.Marca.marca;
            txtDtCadastro.Text = Convert.ToString(mod.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(mod.dtAlteracao);
            txtUsuario.Text = mod.usuario;

            btnSalvar.Text = "ALTERAR";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodModelo.Text = "";
            txtCodMarca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDtAlteracao.Text = "";
            txtDtCadastro.Text = "";
            txtUsuario.Text = "";
        }

        private void txtCodMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }
    }
}
