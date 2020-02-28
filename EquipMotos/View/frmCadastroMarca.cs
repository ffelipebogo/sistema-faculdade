using EquipMotos.CONTROLLER;
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
    public partial class frmCadastroMarca : MaterialSkin.Controls.MaterialForm
    {
        Marcas mar = new Marcas();
        CtrlMarcas CtrlMarca = new CtrlMarcas();
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
                    mar.usuario = UsuarioLogado.Usuario;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        mar.codigo = Convert.ToInt32(txtCodMarca.Text);
                        mar.dtAlteracao = DateTime.Now;
                        CtrlMarca.Editar(mar);

                        MessageBox.Show("Marca alterada com Sucesso!");
                    }
                    else
                    {
                        mar.dtAlteracao = DateTime.Now;
                        mar.dtCadastro = DateTime.Now;
                        CtrlMarca.Inserir(mar);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        internal void Carregar(object id)
        {
            mar = CtrlMarca.BuscarPorID(id) as Marcas;
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
            if (txtMarca.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir esta marca", "Informe a marca com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmCadastroMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
