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
    class MarcasDAO:DAO
    {
        Marcas marcas = new Marcas();
        public override void Inserir(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Marcas mar = obj as Marcas;
                string sql = @"INSERT INTO marcas (marca, dtCadastro, dtAlteracao, usuario) VALUES (@marca, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@marca", mar.marca);
                comando.Parameters.AddWithValue("@dtCadastro", mar.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", mar.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", mar.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Marcas mar = obj as Marcas;
                string sql = @"UPDATE marcas SET marca = @marca, dtAlteracao = @dtAlteracao, usuario = @usuario WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@marca", mar.marca);

                comando.Parameters.AddWithValue("@dtAlteracao", mar.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", mar.usuario);
                comando.Parameters.AddWithValue("@codigo", mar.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"DELETE FROM marcas WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override object BuscarPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM marcas WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtPais = new DataTable();
                da.Fill(dtPais);
                marcas = null;
                foreach (DataRow row in dtPais.Rows)
                {
                    Marcas marca = new Marcas();

                    marca.codigo = Convert.ToInt32(row["codigo"]);
                    marca.marca = Convert.ToString(row["marca"]);
                    marca.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    marca.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    marca.usuario = Convert.ToString(row["usuario"]);

                    this.marcas = marca;
                }
                return marcas;

            }
        }

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM marcas";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtMarcas = new DataTable();
                da.Fill(dtMarcas);

                return dtMarcas;
            }

        }

        public override object Pesquisar(string mar)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(mar, out int n);
                if (mar.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM marcas WHERE codigo = @mar";
                }
                else
                {
                    sql = @"SELECT * FROM marcas WHERE marca like '%'+ @mar + '%' ";
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@mar", mar);

                conexao.Open();
                
                da = new SqlDataAdapter(comando);
                DataTable dtMarca = new DataTable();
                da.Fill(dtMarca);

                return dtMarca;

            }
        }
    }
}
