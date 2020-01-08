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
        List<ItensOrdemServico> ListaItensOrdemServicoP = new List<ItensOrdemServico>();
        List<ItensOrdemServico> ListaItensOrdemServicoS = new List<ItensOrdemServico>();
        OrdemServicos ordemServ = new OrdemServicos();
        Clientes cliente = new Clientes();
        ClientesDAO DaoCliente = new ClientesDAO();
        Funcionarios funcionario = new Funcionarios();
        FuncionariosDAO DaoFuncionario = new FuncionariosDAO();
        Modelos mod = new Modelos();
        ModelosDAO DaoModelo = new ModelosDAO();
        ProdutosServicos prodServ = new ProdutosServicos();
        ProdutosServicosDAO daoProdServ = new ProdutosServicosDAO();
        CondicaoPagamentos condPag = new CondicaoPagamentos();
        CondicaoPagamentoDAO daoCondPag = new CondicaoPagamentoDAO();

        private object SelecionaUltimoID(SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = "SELECT MAX(nrNota) ID FROM ordemServicos";

            var CondID = comando.ExecuteScalar();

            if (String.IsNullOrEmpty(CondID.ToString()))
            {
                CondID = 1;
            }
            return Convert.ToInt64(CondID) + 1;
        }

        public override void Inserir(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                OrdemServicos ordemS = obj as OrdemServicos;
                var NrNota = this.SelecionaUltimoID(transaction);
                this.InserirOrdemSQl(ordemS, transaction);

                foreach (ItensOrdemServico produto in ordemS.ListaProduto)
                {
                    this.InserirProdutosItemOS(NrNota, produto, transaction);
                } 
                foreach (ItensOrdemServico servico in ordemS.ListaServico)
                {
                    this.InserirServicoItemOS(NrNota, servico, transaction);
                }
                transaction.Commit();
                MessageBox.Show("Ordem de servico salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void InserirOrdemSQl(OrdemServicos ordemS, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"INSERT INTO ordemServicos (
                                        modelo, serie,  codVeiculo, codCliente,  data, codCondPagamento,
                                        ano, placa, km, cor,  valorProduto, valorServico, desconto,  valorTotal,
                                          observacoes, dtCadastro, dtAlteracao, usuario )
                                VALUES ( 
                                        @modelo, @serie,  @codVeiculo, @codCliente, @data, @codCondPagamento, 
                                        @ano, @placa, @km, @cor, @valorProduto, @valorServico, @desconto, @valorTotal, 
                                         @observacoes, @dtCadastro, @dtAlteracao, @usuario )";

            comando.Parameters.AddWithValue("@modelo", ordemS.modelo);
            comando.Parameters.AddWithValue("@serie", ordemS.serie);
           // comando.Parameters.AddWithValue("@nrNota", ordemS.NrNota);
            comando.Parameters.AddWithValue("@codVeiculo", ordemS.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codCliente", ordemS.Cliente.codigo);

            comando.Parameters.AddWithValue("@data", ordemS.data);
            comando.Parameters.AddWithValue("@codCondPagamento", ordemS.CondPagamento.codigo);
            comando.Parameters.AddWithValue("@ano", ordemS.ano);
            comando.Parameters.AddWithValue("@placa", ordemS.placa);
            comando.Parameters.AddWithValue("@km", ordemS.km);
            comando.Parameters.AddWithValue("@cor", ordemS.cor);
            comando.Parameters.AddWithValue("@valorProduto", ordemS.valorProduto);
            comando.Parameters.AddWithValue("@valorServico", ordemS.valorServico);
            comando.Parameters.AddWithValue("@desconto", ordemS.desconto);
            comando.Parameters.AddWithValue("@valorTotal", ordemS.valorTotal);
            comando.Parameters.AddWithValue("@observacoes", ordemS.observacoes);
            comando.Parameters.AddWithValue("@dtCadastro", ordemS.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", ordemS.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", ordemS.usuario);
            
            comando.ExecuteNonQuery();
        }

        private void InserirProdutosItemOS(object nrNota, ItensOrdemServico produto, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"INSERT INTO produtoOrdemServico (  modelo, serie, nrNota, codCliente, codVeiculo, codProduto, qtd, valorVenda, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codCliente, @codVeiculo, @codProduto, @qtd ,  @valorVenda,  @dtCadastro, @dtAlteracao)";

            comando.Parameters.AddWithValue("@modelo", produto.modelo);
            comando.Parameters.AddWithValue("@serie", produto.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@codCliente", produto.cliente.codigo);
            comando.Parameters.AddWithValue("@codVeiculo", produto.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codProduto", produto.codigo);
            comando.Parameters.AddWithValue("@qtd", produto.qtd);
            comando.Parameters.AddWithValue("@valorVenda", produto.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", produto.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", produto.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        private void InserirServicoItemOS(object nrNota, ItensOrdemServico servico, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"INSERT INTO servicoOrdemServico (  modelo, serie, nrNota, codCliente, codServico, codMecanico, codVeiculo, valorVenda, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codCliente,  @codServico, @codMecanico, @codVeiculo,  @valorVenda,  @dtCadastro, @dtAlteracao)";

            comando.Parameters.AddWithValue("@modelo", servico.modelo);
            comando.Parameters.AddWithValue("@serie", servico.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@codCliente", servico.cliente.codigo);
            comando.Parameters.AddWithValue("@codVeiculo", servico.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codServico", servico.codigo);
            comando.Parameters.AddWithValue("@codMecanico", servico.Mecanico.codigo);
            comando.Parameters.AddWithValue("@valorVenda", servico.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", servico.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", servico.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        public override object BuscarPorID(object nrNota)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM ordemServicos WHERE nrNota = @nrNota";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);
                foreach (DataRow row in dtCliente.Rows)
                {
                    OrdemServicos os = new OrdemServicos();
                    os.NrNota = Convert.ToString(row["nrNota"]);
                    os.modelo = Convert.ToString(row["modelo"]);
                    os.serie = Convert.ToString(row["serie"]);
                    os.data = Convert.ToDateTime(row["data"]);
                    os.Veiculo = DaoModelo.BuscarPorID(Convert.ToInt32(row["codVeiculo"])) as Modelos;
                    os.Cliente = DaoCliente.BuscarPorID(Convert.ToString(row["codCliente"])) as Clientes;
                    os.ano = Convert.ToString(row["ano"]);
                    os.placa = Convert.ToString(row["placa"]);
                    os.km = Convert.ToString(row["km"]);
                    os.cor = Convert.ToString(row["cor"]);
                    os.valorProduto = Convert.ToDecimal(row["valorProduto"]);
                    os.desconto = Convert.ToDecimal(row["desconto"]);
                    os.valorServico = Convert.ToDecimal(row["valorServico"]);
                    os.valorTotal = Convert.ToDecimal(row["valorTotal"]);
                    os.CondPagamento = daoCondPag.BuscarPorID(Convert.ToInt32(row["codCondPagamento"])) as CondicaoPagamentos;
                    os.observacoes = Convert.ToString(row["observacoes"]);
                    os.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    os.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    os.usuario = Convert.ToString(row["usuario"]);
                    os.ListaProduto = BuscarProdutos(nrNota);
                    os.ListaServico = BuscarServicos(nrNota);

                    ordemServ = os;
                }
                return ordemServ;
            }
        }

        private List<ItensOrdemServico> BuscarServicos(object nrNota)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM servicoOrdemServico WHERE nrNota = @nrNota";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtItemOS = new DataTable();
                da.Fill(dtItemOS);
                ListaItensOrdemServicoS = new List<ItensOrdemServico>();
                foreach (DataRow row in dtItemOS.Rows)
                {
                    var cod = Convert.ToInt32(row["codServico"]);
                    var Servico = daoProdServ.BuscarPorID(cod) as ProdutosServicos;
                    ListaItensOrdemServicoS.Add(new ItensOrdemServico()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        produto = Servico.produto,
                        cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes,
                        Veiculo = DaoModelo.BuscarPorID(Convert.ToInt64(row["codVeiculo"])) as Modelos,
                        Mecanico = DaoFuncionario.BuscarPorID(Convert.ToInt64(row["codMecanico"])) as Funcionarios,
                        codigo = Convert.ToInt32(row["codServico"]),
                        precoVenda = Convert.ToDecimal(row["valorVenda"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                    });
                }
                return ListaItensOrdemServicoS;
            }
        }

        private List<ItensOrdemServico> BuscarProdutos(object nrNota)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM produtoOrdemServico WHERE nrNota = @nrNota";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtItemOS = new DataTable();
                da.Fill(dtItemOS);
                ListaItensOrdemServicoP = new List<ItensOrdemServico>();
                foreach (DataRow row in dtItemOS.Rows)
                {
                    var cod = Convert.ToInt32(row["codProduto"]);
                    var Produto = daoProdServ.BuscarPorID(cod) as ProdutosServicos;
                    ListaItensOrdemServicoP.Add(new ItensOrdemServico()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes,
                        Veiculo = DaoModelo.BuscarPorID(Convert.ToInt64(row["codVeiculo"])) as Modelos,
                        codigo = Convert.ToInt32(row["codProduto"]),
                        produto = Produto.produto,
                        qtd = Convert.ToInt32(row["qtd"]),
                        precoVenda = Convert.ToDecimal(row["valorVenda"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                    });
                }
                return ListaItensOrdemServicoP;
            }
        }

        public override void Editar(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                OrdemServicos ordemS = obj as OrdemServicos;
                
                this.AlterarOrdemSQl(ordemS, transaction);
                this.ExcluirProdutosOS(ordemS.NrNota, transaction);
                this.ExcluirServicosOS(ordemS.NrNota, transaction);
                foreach (ItensOrdemServico produto in ordemS.ListaProduto)
                {
                    this.InserirProdutosItemOS(ordemS.NrNota, produto, transaction);
                }
                foreach (ItensOrdemServico servico in ordemS.ListaServico)
                {
                    this.InserirServicoItemOS(ordemS.NrNota, servico, transaction);
                }
                transaction.Commit();
                MessageBox.Show("Ordem de servico alterado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void ExcluirServicosOS(string nrNota, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @" DELETE FROM servicoOrdemServico WHERE nrNota = @nrNota ";
            comando.Parameters.AddWithValue("@nrNota", nrNota);

            comando.ExecuteNonQuery();
        }

        private void ExcluirProdutosOS(string nrNota, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @" DELETE FROM produtoOrdemServico WHERE nrNota = @nrNota";
            comando.Parameters.AddWithValue("@nrNota", nrNota);

            comando.ExecuteNonQuery();
        }

        private void AlterarOrdemSQl(OrdemServicos ordemS, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"UPDATE ordemServicos SET 
                                        modelo = @modelo, serie = @serie,  codVeiculo = @codVeiculo, codCliente = @codCliente,  data = @data, codCondPagamento = @codCondPagamento,
                                        ano = @ano, placa = @placa, km = @km, cor = @cor,  valorProduto = @valorProduto, valorServico = @valorServico, desconto = @desconto,  valorTotal = @valorTotal,
                                        observacoes = @observacoes, dtCadastro = @dtCadastro, dtAlteracao = @dtAlteracao, usuario = @usuario
                                        WHERE nrNota = @nrNota ";

            comando.Parameters.AddWithValue("@modelo", ordemS.modelo);
            comando.Parameters.AddWithValue("@serie", ordemS.serie);
             comando.Parameters.AddWithValue("@nrNota", ordemS.NrNota);
            comando.Parameters.AddWithValue("@codVeiculo", ordemS.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codCliente", ordemS.Cliente.codigo);

            comando.Parameters.AddWithValue("@data", ordemS.data);
            comando.Parameters.AddWithValue("@codCondPagamento", ordemS.CondPagamento.codigo);
            comando.Parameters.AddWithValue("@ano", ordemS.ano);
            comando.Parameters.AddWithValue("@placa", ordemS.placa);
            comando.Parameters.AddWithValue("@km", ordemS.km);
            comando.Parameters.AddWithValue("@cor", ordemS.cor);
            comando.Parameters.AddWithValue("@valorProduto", ordemS.valorProduto);
            comando.Parameters.AddWithValue("@valorServico", ordemS.valorServico);
            comando.Parameters.AddWithValue("@desconto", ordemS.desconto);
            comando.Parameters.AddWithValue("@valorTotal", ordemS.valorTotal);
            comando.Parameters.AddWithValue("@observacoes", ordemS.observacoes);
            comando.Parameters.AddWithValue("@dtCadastro", ordemS.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", ordemS.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", ordemS.usuario);

            comando.ExecuteNonQuery();
        }

        private void AlterarProdutosItemOS(object nrNota, ItensOrdemServico produto, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"UPDATE produtoOrdemServico  SET modelo = @modelo, serie = @serie, codCliente = @codCliente, codVeiculo = @codVeiculo, codProduto = @codProduto,
                                    qtd = @qtd, valorVenda = @valorVenda, dtCadastro = @dtCadastro,  dtAlteracao = @dtAlteracao
                                    WHERE nrNota = @nrNota";

            comando.Parameters.AddWithValue("@modelo", produto.modelo);
            comando.Parameters.AddWithValue("@serie", produto.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@codCliente", produto.cliente.codigo);
            comando.Parameters.AddWithValue("@codVeiculo", produto.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codProduto", produto.codigo);
            comando.Parameters.AddWithValue("@qtd", produto.qtd);
            comando.Parameters.AddWithValue("@valorVenda", produto.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", produto.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", produto.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        private void AlterarServicoItemOS(object nrNota, ItensOrdemServico servico, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"UPDATE servicoOrdemServico  SET modelo = @modelo, serie = @serie, codCliente = @codCliente, codServico = @codServico,
                                    codMecanico = @codMecanico, codVeiculo = @codVeiculo, valorVenda = @valorVenda, dtCadastro = @dtCadastro,  dtAlteracao = @dtAlteracao
                                    WHERE nrNota = @nrNota";

            comando.Parameters.AddWithValue("@modelo", servico.modelo);
            comando.Parameters.AddWithValue("@serie", servico.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@codCliente", servico.cliente.codigo);
            comando.Parameters.AddWithValue("@codVeiculo", servico.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codServico", servico.codigo);
            comando.Parameters.AddWithValue("@codMecanico", servico.Mecanico.codigo);
            comando.Parameters.AddWithValue("@valorVenda", servico.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", servico.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", servico.dtAlteracao);

            comando.ExecuteNonQuery();
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
                string sql = @"SELECT * FROM ordemServicos "; //where finalizada = 0
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
