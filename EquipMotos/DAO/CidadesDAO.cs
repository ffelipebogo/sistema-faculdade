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
    class CidadesDAO : DAO
    {
        Cidades cidade;
        EstadosDAO daoEstado= new EstadosDAO();
        public override void Inserir(object obj)
        {
            
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"INSERT INTO cidades(cidade, codEstado, dtCadastro, dtAlteracao, usuario) values (@cidade, @codEstado, @dtCadastro, @dtAlteracao, @usuario)";

                Cidades cid = obj as Cidades;

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cidade", cid.cidade);
                comando.Parameters.AddWithValue("@codEstado", cid.Estado.codigo);
                comando.Parameters.AddWithValue("@dtCadastro", cid.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", cid.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", cid.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"UPDATE cidades SET cidade = @cidade, codEstado = @codEstado where codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                Cidades cid = obj as Cidades;
                comando.Parameters.AddWithValue("@cidade", cid.cidade);
                comando.Parameters.AddWithValue("@codEstado", cid.Estado.codigo);
                comando.Parameters.AddWithValue("@codigo", cid.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"delete from cidades where codigo = @codigo";
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
                string sql = @"SELECT * FROM cidades";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCidades = new DataTable();
                da.Fill(dtCidades);

                return dtCidades;
            }

        }

        public override object BuscarPorID(object id)
        {
            // Instanciando a conexão
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"select * from cidades where codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCidade = new DataTable();
                da.Fill(dtCidade);
                EstadosDAO daoEstado = new EstadosDAO();
                foreach (DataRow row in dtCidade.Rows)
                {
                    Cidades cid = new Cidades();
                    cid.codigo = Convert.ToInt32(row["codigo"]);
                    cid.cidade = Convert.ToString(row["cidade"]);
                    cid.Estado= daoEstado.BuscarPorID(Convert.ToInt32(row["codEstado"])) as Estados;
                    cid.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    cid.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    cid.usuario = Convert.ToString(row["usuario"]);

                    this.cidade = cid;
                }
                return cidade;
            }
        }

        public override object Pesquisar(string cid)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(cid, out int n);
                if (cid.Length <= 4 && isNumeric)
                {

                    sql = @"select * from cidades where codigo = @cid";
                }
                else
                {

                    sql = @"select * from cidades where cidade like '%'+ @cid + '%' ";

                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cid", cid);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCidade = new DataTable();
                da.Fill(dtCidade);

                return dtCidade;
            }
        }
    }
}
