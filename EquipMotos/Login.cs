using System;
using System.Windows.Forms;
using EquipMotos.DAO;
using EquipMotos.MODEL;

namespace EquipMotos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            #region Login com Senha Master
            //string user, senha;

            //user = txtUsuario.Text;
            //senha = txtSenha.Text;

            //if (user.Equals("admin") && senha.Equals("admin"))
            //{
            //    MenuPrincipal menu = new MenuPrincipal();

            //    menu.Show();


            //}

            //else
            //{
            //    MessageBox.Show("Usuário ou Senha Incorretos!");
            //}
            #endregion

            //Efetuando Login
            try
            {
                Usuarios user = new Usuarios();

                user.usuario = txtUsuario.Text;
                user.senha = txtSenha.Text;

                UsuariosDAO dao = new UsuariosDAO();

                if (dao.EfetuarLogin(user))
                {
                    MessageBox.Show("Bem vindo " +user.usuario, "Sistema Equip Moto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    UsuarioLogado.Usuario = user.usuario;
                    MenuPrincipal Menu = new MenuPrincipal(user.usuario);
                    Menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalido!", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao iniciar o sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
