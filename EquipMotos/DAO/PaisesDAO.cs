using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.DAO
{
    class PaisesDAO: DAO
    {
        Paises paises = new Paises();
        public override void Inserir(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Paises pais = obj as Paises;
                string sql = @"INSERT INTO paises(pais, dtCadastro, dtAlteracao, usuario) values (@pais, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@pais", pais.pais);
                comando.Parameters.AddWithValue("@dtCadastro", pais.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", pais.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", pais.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Paises pais = obj as Paises;
                string sql = @"UPDATE paises SET pais = @pais WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@pais", pais.pais);
                comando.Parameters.AddWithValue("@dtCadastro", pais.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", pais.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", pais.usuario);

                comando.Parameters.AddWithValue("@codigo", pais.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"DELETE FROM paises WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM paises";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtPaises = new DataTable();
                da.Fill(dtPaises);
                conexao.Close();
                return dtPaises;
            }
        }

        public override object BuscarPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM paises WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtPais = new DataTable();
                da.Fill(dtPais);
                paises = null;
                foreach (DataRow row in dtPais.Rows)
                {
                    Paises pais = new Paises();
                    pais.codigo = Convert.ToInt32(row["codigo"]);
                    pais.pais = Convert.ToString(row["pais"]);
                    pais.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    pais.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    pais.usuario = Convert.ToString(row["usuario"]);
                    this.paises = pais;
                }
                conexao.Close();
                return paises; //as object
            }
        }

        public override object Pesquisar(string pais)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(pais, out int n);
                if (pais.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM paises WHERE codigo = @pais";
                }
                else
                {
                    sql = @"SELECT * FROM paises WHERE pais like '%'+ @pais + '%' ";
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@pais", pais);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtPais = new DataTable();
                da.Fill(dtPais);
                conexao.Close();
                return dtPais;
            }
        }
    }
}
