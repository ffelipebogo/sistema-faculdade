using EquipMotos.CONTROLLER;
using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.DAO
{
    class ServicosDAO : DAO
    {
        Servicos Servico = new Servicos();
        CategoriasDAO DaoCategoria = new CategoriasDAO();
        FuncionariosDAO DaoFunc = new FuncionariosDAO();


        #region Inserir ProdutosServicos 
        public override void Inserir(object obj)
        {
            
            SqlConnection conexao = Conecta.CreateConnection();
            try
            {
                Servicos servico = obj as Servicos;
                string sql = @"INSERT into servicos (
                                        servico, precoCusto, precoVenda, codFuncionario, comissao, observacoes, dtCadastro, dtAlteracao, usuario
                                    ) values (@servico,  @precoCusto, @precoVenda,  @codFuncionario, @comissao,  @observacoes, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@servico", servico.servico);
                    comando.Parameters.AddWithValue("@precoCusto", servico.custo);
                    comando.Parameters.AddWithValue("@precoVenda", servico.precoVenda);

                    comando.Parameters.AddWithValue("@codFuncionario", servico.Funcionario.codigo);
                    comando.Parameters.AddWithValue("@comissao", servico.comissao);

                    comando.Parameters.AddWithValue("@observacoes", servico.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", servico.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", servico.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", servico.usuario);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }
            
        }
        #endregion

        #region PesquisarServicos
        public override object Pesquisar(string servico)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(servico, out int n);
                if (servico.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT   servicos.*, funcionarios.funcionario
                                FROM    servicos INNER JOIN
                             funcionarios ON servicos.codFuncionario = funcionarios.codigo WHERE servicos.codigo = @servico";
                }
                else
                {
                    if (isNumeric)
                    {
                        sql = @"SELECT   servicos.*, funcionarios.funcionario
                                FROM    servicos INNER JOIN
                             funcionarios ON servicos.codFuncionario = funcionarios.codigo WHERE servicos.servico like '%'+ @servico +'%'";
                    }
                    else
                    {
                        sql = @"SELECT   servicos.*, funcionarios.funcionario
                                FROM    servicos INNER JOIN
                             funcionarios ON servicos.codFuncionario = funcionarios.codigo WHERE servicos.servico like '%'+ @servico + '%' ";
                    }
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@servico", servico);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtServico = new DataTable();
                da.Fill(dtServico);
                conexao.Close();
                return dtServico;
            }
        }

        #endregion

        #region Alterar Servico
        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    Servicos proServ = obj as Servicos;
                    string sql = @"UPDATE servicos set 
                                servico = @servico,

                                precoCusto = @precoCusto,
                                precoVenda = @precoVenda,
                               
                                codFuncionario = @codFuncionario,
                                comissao = @comissao,

                                observacoes = @observacoes,
                                dtCadastro = @dtCadastro,
                                dtAlteracao = @dtAlteracao,
                                usuario = @usuario

                                WHERE codigo = @codigo";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                   
                    comando.Parameters.AddWithValue("@servico", proServ.servico);
                    comando.Parameters.AddWithValue("@precoCusto", proServ.custo);
                    comando.Parameters.AddWithValue("@precoVenda", proServ.precoVenda);

                    comando.Parameters.AddWithValue("@codFuncionario", proServ.Funcionario.codigo);
                    comando.Parameters.AddWithValue("@comissao", proServ.comissao);

                    comando.Parameters.AddWithValue("@observacoes", proServ.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", proServ.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", proServ.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", proServ.usuario);

                    comando.Parameters.AddWithValue("@codigo", proServ.codigo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        #endregion

        #region Excluir Servico
        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"DELETE FROM servicos WHERE codigo = @codigo ";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        #endregion

        #region BuscarServicoId
        public override object BuscarPorID(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT   servicos.*, funcionarios.funcionario
                                FROM    servicos INNER JOIN
                             funcionarios ON servicos.codFuncionario= funcionarios.codigo
                             WHERE servicos.codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codigo", codigo);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtServico = new DataTable();
                da.Fill(dtServico);
                Servico = null;
                foreach (DataRow row in dtServico.Rows)
                {
                    Servicos serv = new Servicos();
                   
                    serv.codigo = Convert.ToInt32(row["codigo"]);
                    serv.servico = Convert.ToString(row["servico"]);
                    serv.custo = Convert.ToDecimal(row["precoCusto"]);
                    serv.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                    serv.Funcionario = DaoFunc.BuscarPorID(Convert.ToInt32(row["codFuncionario"])) as Funcionarios;
                    serv.comissao = Convert.ToDouble(row["comissao"]);
                    serv.observacoes = Convert.ToString(row["observacoes"]);
                    serv.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    serv.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    serv.usuario = Convert.ToString(row["usuario"]);

                    this.Servico = serv;
                    
                }
                conexao.Close();
                return Servico;
            }
        }
        #endregion

        #region ListarTodos
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT   servicos.*, funcionarios.funcionario
                                FROM    servicos INNER JOIN
                             funcionarios ON servicos.codFuncionario= funcionarios.codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();

                da = new SqlDataAdapter(comando);

                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                conexao.Close();

                return dtProdutoServico;

            }
        }
        #endregion

        #region ListarServicos por nome
        public DataTable ListarServicos_porNome(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Servicos serv = obj as Servicos;
                SqlDataAdapter da;
                string sql = @"SELECT   servicos.*, funcionarios.funcionario
                                FROM    servicos INNER JOIN
                             funcionarios ON servicos.codFuncionario= funcionarios.codigo
                               WHERE servicos.servico = @nome";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", serv.servico);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtServico = new DataTable();
                da.Fill(dtServico);
                conexao.Close();
                return dtServico;
            }
        }
        #endregion
    }
}
