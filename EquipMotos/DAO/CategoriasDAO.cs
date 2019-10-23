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
    class CategoriasDAO : DAO
    {
        Categorias categorias = new Categorias();
        public override void Inserir(Object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Categorias cat = obj as Categorias;
                string sql = @"INSERT INTO categorias(categoria,  dtCadastro, dtAlteracao, usuario) values (@categoria, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", cat.categoria);
                comando.Parameters.AddWithValue("@dtCadastro", cat.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", cat.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", cat.usuario);
                
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }
        public override void Editar(Object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Categorias cat = obj as Categorias;
                string sql = @"UPDATE categorias SET categoria = @categoria, dtAlteracao = @dtAlteracao, usuario = @usuario WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", cat.categoria);
                comando.Parameters.AddWithValue("@dtAlteracao", cat.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", cat.usuario);
                comando.Parameters.AddWithValue("@codigo", cat.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override void Excluir(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"DELETE FROM categorias WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", codigo);

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
                string sql = @"SELECT * FROM categorias";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCategorias = new DataTable();
                da.Fill(dtCategorias);

                return dtCategorias;
            }

        }

        public override object BuscarPorID(object codigo)
        {
            // Instanciando a conexão
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM categorias WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", codigo);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtPais = new DataTable();
                da.Fill(dtPais);

                foreach (DataRow row in dtPais.Rows)
                {
                    Categorias cat = new Categorias();

                    cat.codigo = Convert.ToInt32(row["codigo"]);
                    cat.categoria = Convert.ToString(row["categoria"]);
                    cat.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    cat.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    cat.usuario = Convert.ToString(row["usuario"]);

                    this.categorias = cat;
                }
                return categorias;
            }
        }

        public override object Pesquisar(string cat)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(cat, out int n);
                if (cat.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM categorias WHERE codigo = @cat";
                }
                else
                {
                    sql = @"SELECT * FROM categorias WHERE categoria like '%'+ @cat + '%' ";
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cat", cat);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCategoria = new DataTable();
                da.Fill(dtCategoria);

                return dtCategoria;
            }
        }
    }
}
