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

namespace EquipMotos.VIEW
{
    public partial class frmConfirmaAdmin : MaterialSkin.Controls.MaterialForm
    {

        CtrlCompras CtrlCompra = new CtrlCompras();

        public frmConfirmaAdmin()
        {
            InitializeComponent();
        }

        private void frmConfirmaAdmin_Load(object sender, EventArgs e)
        {

        }

        public Boolean ValidaUsuarioSenha()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text.Trim() ))
            {
                MessageBox.Show("Usuario inválido!", "Informe um usuario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtUsuario.Text))
            {
                MessageBox.Show("Usuario inválido!", "Usuario não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Senha inválida!", "Informe uma senha!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios(); 
            UsuariosDAO dao = new UsuariosDAO();


            if (ValidaUsuarioSenha())
            {
                user.usuario = txtUsuario.Text;
                user.senha = txtSenha.Text;

                if (dao.ConfirmaAdmin(user))
                {
                    MessageBox.Show("Sucesso!", "Usuario e senha validos !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Atenção", "Usuário ou Senha Inválidos.", MessageBoxButtons.OK);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Atenção", "Usuário ou Senha Inválidos.", MessageBoxButtons.OK);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
