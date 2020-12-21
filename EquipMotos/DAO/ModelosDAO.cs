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
    class ModelosDAO: DAO
    {
        Modelos modelos = new Modelos();
        MarcasDAO daoMarca = new MarcasDAO();
        public override void Inserir(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Modelos mod = obj as Modelos;
                string sql = @"INSERT INTO modelos (modelo, codMarca,dtCadastro, dtAlteracao, usuario) VALUES (@modelo , @codMarca, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", mod.modelo);
                comando.Parameters.AddWithValue("@codMarca", mod.Marca.codigo);
                comando.Parameters.AddWithValue("@dtCadastro", mod.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", mod.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", mod.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Modelos mod = obj as Modelos;
                string sql = @"UPDATE modelos SET modelo = @modelo, codMarca = @codMarca, dtAlteracao = @dtAlteracao, usuario = @usuario  WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", mod.modelo);
                comando.Parameters.AddWithValue("@codMarca", mod.Marca.codigo);
                comando.Parameters.AddWithValue("@dtAlteracao", mod.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", mod.usuario);
                comando.Parameters.AddWithValue("@codigo", mod.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"delete FROM modelos WHERE codigo = @codigo";
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
                string sql = @"SELECT    modelos.*, marcas.marca
                    FROM        modelos INNER JOIN
                  marcas ON modelos.codMarca = marcas.codigo 
                    WHERE modelos.codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtModelos = new DataTable();
                da.Fill(dtModelos);
                modelos = null;
                foreach (DataRow row in dtModelos.Rows)
                {
                    Modelos mod = new Modelos();
                    mod.codigo = Convert.ToInt32(row["codigo"]);
                    mod.modelo = Convert.ToString(row["modelo"]);
                    mod.Marca = daoMarca.BuscarPorID(Convert.ToInt32(row["codMarca"])) as Marcas;
                    mod.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    mod.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    mod.usuario = Convert.ToString(row["usuario"]);

                    this.modelos = mod;
                }
                conexao.Close();
                return modelos;
            }
        }

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT    modelos.*, marcas.marca
                             FROM        modelos INNER JOIN
                         marcas ON modelos.codMarca = marcas.codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtModelos = new DataTable();
                da.Fill(dtModelos);
                conexao.Close();
                return dtModelos;
            }

        }

        public override object Pesquisar(string mod)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(mod, out int n);
                if (mod.Length <= 4 && isNumeric)
                {

                    sql = @"SELECT     modelos.*, marcas.marca
                            FROM  modelos INNER JOIN
                                marcas ON modelos.codMarca = marcas.codigo    
                            WHERE modelos.codigo = @mod";
                }
                else
                {

                    sql = @"SELECT     modelos.*, marcas.marca
                            FROM  modelos INNER JOIN
                                marcas ON modelos.codMarca = marcas.codigo
                            WHERE modelos.modelo like '%'+ @mod + '%' ";

                }

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@mod", mod);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtModelo = new DataTable();
                da.Fill(dtModelo);
                conexao.Close();
                return dtModelo;

            }
        }
    }
}
