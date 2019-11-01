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
    public class OrdemServicosDAO : DAO
    {
        OrdemServicos ordemServ = new OrdemServicos();
        Clientes cliente = new Clientes();
        ClientesDAO daoCliente = new ClientesDAO();
        Funcionarios funcionario = new Funcionarios();
        FuncionariosDAO daoFuncionario = new FuncionariosDAO();
        Modelos mod = new Modelos();
        ModelosDAO daoMod = new ModelosDAO();
        ProdutosServicos prodServ = new ProdutosServicos();
        ProdutosServicosDAO daoProdServ = new ProdutosServicosDAO();
        CondicaoPagamentos condPag = new CondicaoPagamentos();
        CondicaoPagamentoDAO daoCondPag = new CondicaoPagamentoDAO();


        public override void Inserir(object obj)
        {
            {
                SqlConnection conexao = Conecta.CreateConnection();
                try
                {
                    OrdemServicos ordemS = obj as OrdemServicos;
                    mod = daoMod.BuscarPorID(ordemS.Modelo.codigo) as Modelos;

                    // Acho que falta passar o cliente*******

                    string sql = @"INSERT INTO ordemServicos (
                                            dataOS, codVeiculo, codProduto, codFuncionario, codCondPagamento,
                                            ano, placa, km, cor, qtd, valorProd, valorServ, desconto,  valorTotal,
                                            limiteCredito,  observacoes, dtCadastro, dtAlteracao, usuario )
                                   VALUES ( 
                                            @dataOS, @codVeiculo, @codProduto, @codFuncionario, @codCondPagamento, @ano, @placa, 
                                            @km, @cor, @qtd, @valorProd, @valorServ, @desconto, @valorTotal, @observacoes, 
                                            @dtCadastro, @dtAlteracao, @usuario )";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@dataOS", ordemS.dataOS);
                    comando.Parameters.AddWithValue("@ano", ordemS.ano);
                    comando.Parameters.AddWithValue("@km", ordemS.km);
                    comando.Parameters.AddWithValue("@cor", ordemS.cor);
                    comando.Parameters.AddWithValue("@qtd", ordemS.qtd);
                    comando.Parameters.AddWithValue("@valorProd", ordemS.valorProd);
                    comando.Parameters.AddWithValue("@valorServ", ordemS.valorServ);
                    comando.Parameters.AddWithValue("@desconto", ordemS.desconto);
                    comando.Parameters.AddWithValue("@valorTotal", ordemS.valorTotal);
                    comando.Parameters.AddWithValue("@codVeiculo", ordemS.Modelo.codigo);
                    comando.Parameters.AddWithValue("@codCondPagamento", ordemS.CondPagamento.codigo);
                    comando.Parameters.AddWithValue("@codProduto", ordemS.Produto.codigo);
                    comando.Parameters.AddWithValue("@codServico", ordemS.Servico.codigo);
                    comando.Parameters.AddWithValue("@codFuncionario", ordemS.Funcionario.codigo);
                    comando.Parameters.AddWithValue("@observacoes", ordemS.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", ordemS.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", ordemS.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", ordemS.usuario);

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

        public override object BuscarPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM ordemServicos WHERE id = @id";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@id", id);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);
                foreach (DataRow row in dtCliente.Rows)
                {
                    OrdemServicos os = new OrdemServicos();
                    os.numeroOS = Convert.ToInt32(row["numeroOS"]);
                    os.dataOS = Convert.ToDateTime(row["dataOS"]);
                    os.Modelo = daoMod.BuscarPorID(Convert.ToInt32(row["codVeiculo"])) as Modelos;
                    os.Produto = daoProdServ.BuscarPorID(Convert.ToString(row["codProduto"])) as ProdutosServicos;
                    os.Servico = daoProdServ.BuscarPorID(Convert.ToString(row["codServico"])) as ProdutosServicos;
                    os.Funcionario = daoFuncionario.BuscarPorID(Convert.ToString(row["codFuncionario"])) as Funcionarios;
                    os.ano = Convert.ToString(row["ano"]);
                    os.placa = Convert.ToString(row["placa"]);

                    os.km = Convert.ToString(row["km"]);
                    os.cor = Convert.ToString(row["cor"]);
                    os.CondPagamento = daoCondPag.BuscarPorID(Convert.ToInt32(row["codCondPagamento"])) as CondicaoPagamentos;
                    os.observacoes = Convert.ToString(row["observacoes"]);
                    os.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    os.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    os.usuario = Convert.ToString(row["usuario"]);

                    ordemServ = os;
                }
                return ordemServ;
            }
        }

        public override void Editar(object obj)
        {
            SqlConnection conexao = Conecta.CreateConnection();
            {
                try
                {
                    OrdemServicos ordemS = obj as OrdemServicos;
                    string sql = @"UPDATE ordemServicos SET 
                                                dataOS = @dataOS, codCliente= @codCliente, codVeiculo = @codVeiculo, codProduto = @codProduto,
                                                codServico = @codServico, ano = @ano, placa = @placa, km = @km, rg = @rg, cor = @cor, qtd = @qtd,
                                                valorProd = @valorProd, desconto = @desconto, valorServ = @valorServ, valorTotal = @valorTotal,
                                                observacoes = @observacoes, dtCadastro = @dtCadastro, dtAlteracao = @dtAlteracao, usuario = @usuario 
                                   WHERE numeroOS = @numeroOS,";
                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@dataOS", ordemS.dataOS);
                    comando.Parameters.AddWithValue("@ano", ordemS.ano);
                    comando.Parameters.AddWithValue("@km", ordemS.km);
                    comando.Parameters.AddWithValue("@cor", ordemS.cor);
                    comando.Parameters.AddWithValue("@qtd", ordemS.qtd);
                    comando.Parameters.AddWithValue("@valorProd", ordemS.valorProd);
                    comando.Parameters.AddWithValue("@valorServ", ordemS.valorServ);
                    comando.Parameters.AddWithValue("@desconto", ordemS.desconto);
                    comando.Parameters.AddWithValue("@valorTotal", ordemS.valorTotal);
                    comando.Parameters.AddWithValue("@codVeiculo", ordemS.Modelo.codigo);
                    comando.Parameters.AddWithValue("@codCondPagamento", ordemS.CondPagamento.codigo);
                    comando.Parameters.AddWithValue("@codProduto", ordemS.Produto.codigo);
                    comando.Parameters.AddWithValue("@codServico", ordemS.Servico.codigo);
                    comando.Parameters.AddWithValue("@codFuncionario", ordemS.Funcionario.codigo);
                    comando.Parameters.AddWithValue("@observacoes", ordemS.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", ordemS.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", ordemS.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", ordemS.usuario);
                    comando.Parameters.AddWithValue("@ordemS", ordemS.numeroOS);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Erro ao alterar OS!", "Falha no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        public override void Excluir(object id)
        {
            SqlConnection conexao = Conecta.CreateConnection();
            {
                try
                {
                    string sql = @"DELETE FROM ordemServicos WHERE (id = @id)";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@id", id);

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

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM ordemServicos";
                SqlCommand comando = new SqlCommand(sql, conexao);
                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtOS = new DataTable();
                da.Fill(dtOS);

                return dtOS;

            }
        }
    }
}
