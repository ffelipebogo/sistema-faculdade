using EquipMotos.MODEL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EquipMotos.DAO
{
    public class UsuariosDAO
    {
        #region InserirUsuario
        public void InserirUsuario(Usuarios user)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"INSERT INTO usuarios(usuario, senha) values (@nome, @senha)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", user.usuario);
                comando.Parameters.AddWithValue("@senha", user.senha);
                
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        #endregion

        #region editar usuario
        public void EditarUsuario(Usuarios user)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"UPDATE usuario SET nome_user = @nome, senha_user = @senha, cargo = @cargo where id = @id";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", user.usuario);
                comando.Parameters.AddWithValue("@senha", user.senha);
               
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        #endregion

        #region excluir usuario
        public void ExcluirUsuario(Usuarios user)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"delete from usuarios where usuarui = @login";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@login", user.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        #endregion

        #region ListarTodosUsuarios
        public DataTable ListarTodosUsuarios()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM usuarios";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtUsuario = new DataTable();
                da.Fill(dtUsuario);

                return dtUsuario;
            }
        }

        #endregion

        public bool EfetuarLogin(Usuarios user)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"select usuario ,senha, cargo from usuarios where usuario = @login and senha = @senha";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@login", user.usuario);
                    comando.Parameters.AddWithValue("@senha", user.senha);

                    conexao.Open();

                    SqlDataReader dados = comando.ExecuteReader();

                    if (dados.Read())
                    {
                        //recebe  dados do cargo do usuario
                        string usuario = dados.GetString(0);
                        string cargo = dados.GetString(2);
                        if (usuario != null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                        //string usuariologado = user.usuario;

                        //MessageBox.Show("Bem vindo ao Sistema");

                        ////Define as permissoes
                        //if (cargo.Equals("gerente"))
                        //{
                        //    MenuPrincipal telamenu = new MenuPrincipal(usuariologado.ToString());

                        //    telamenu.Show();
                        //}
                        //else if (cargo.Equals("vendedor"))
                        //{
                        //    MenuPrincipal telamenu = new MenuPrincipal(usuariologado.ToString());
                        //    //telamenu.menuvenda.Enabled = false;
                        //    //  telamenu.menurelatorios.Enabled = false;
                        //    telamenu.Show();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Inválidos. Contate o suporte", "Atenção", MessageBoxButtons.OK);
                        return false;
                    }
                }
                catch (SqlException e)
                {

                    MessageBox.Show(e.Message);
                    return false;
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
