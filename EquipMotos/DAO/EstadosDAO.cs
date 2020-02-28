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
    class EstadosDAO:DAO
    {
        Estados estado;
        PaisesDAO daoPaises = new PaisesDAO();
        public override void Inserir(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Estados est = obj as Estados;
                string sql = @"INSERT INTO estados (estado, uf, codPais,  dtCadastro, dtAlteracao, usuario) values (@estado ,@uf,  @codPais,  @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@estado", est.estado);
                comando.Parameters.AddWithValue("@uf", est.uf);
                comando.Parameters.AddWithValue("@codPais", est.Pais.codigo);
                comando.Parameters.AddWithValue("@dtCadastro", est.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", est.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", est.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Estados est = obj as Estados;
                string sql = @"UPDATE estados SET estado = @estado, uf = @uf, codPais = @codPais, dtAlteracao = @dtAlteracao, usuario = @usuario WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);


                comando.Parameters.AddWithValue("@estado", est.estado);
                comando.Parameters.AddWithValue("@uf", est.uf);
                comando.Parameters.AddWithValue("@codPais", est.Pais.codigo);
                comando.Parameters.AddWithValue("@dtAlteracao", est.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", est.usuario);

                comando.Parameters.AddWithValue("@codigo", est.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"delete FROM estados WHERE codigo = @codigo";
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
                string sql = @"SELECT * FROM estados";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtEstados = new DataTable();
                da.Fill(dtEstados);

                return dtEstados;
            }

        }

        public override object BuscarPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM estados WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtEstado = new DataTable();
                da.Fill(dtEstado);
                EstadosDAO daoEstado = new EstadosDAO();
                estado = null;
                foreach (DataRow row in dtEstado.Rows)
                {
                    Estados est = new Estados();

                    est.codigo = Convert.ToInt32(row["codigo"]);
                    est.estado = Convert.ToString(row["estado"]);
                    est.uf = Convert.ToString(row["uf"]);
                    est.Pais = daoPaises.BuscarPorID(Convert.ToInt32(row["codPais"])) as Paises;
                    est.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    est.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    est.usuario = Convert.ToString(row["usuario"]);

                    this.estado = est;
                }
                return estado;
            }
        }

        public override object Pesquisar(string est)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(est, out int n);
                if (est.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM estados WHERE codigo = @est";
                }
                else
                {
                    sql = @"SELECT * FROM estados WHERE estado like '%'+ @est + '%' ";
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@est", est);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtEstado = new DataTable();
                da.Fill(dtEstado);

                return dtEstado;
            }
        }
    }
}
