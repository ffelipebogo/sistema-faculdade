﻿using EquipMotos.MODEL;
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
        ClientesDAO DaoCliente = new ClientesDAO();
        FuncionariosDAO DaoFuncionario = new FuncionariosDAO();
        ModelosDAO DaoModelo = new ModelosDAO();
        ServicosDAO DaoServico = new  ServicosDAO();
        ProdutosDAO DaoProduto = new  ProdutosDAO();
        CondicaoPagamentoDAO DaoCondPag = new CondicaoPagamentoDAO();

        public object SelecionaUltimoID()
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = "SELECT MAX(nrNota) ID FROM ordemServicos";

            int CondID = int.Parse( "0" + comando.ExecuteScalar().ToString());

            if (String.IsNullOrEmpty(CondID.ToString()) || CondID <= 0)
            {
                conexao.Close();
                return CondID = 1;
            }
            conexao.Close();
            return CondID + 1;
        }

        public override void Inserir(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                OrdemServicos ordemS = obj as OrdemServicos;
                this.InserirOrdemSQl(ordemS, transaction);

                foreach (ItensOrdemServico produto in ordemS.ListaProduto)
                {
                    this.InserirProdutosItemOS(ordemS.NrNota, produto, transaction);
                } 
                foreach (ItensOrdemServico servico in ordemS.ListaServico)
                {
                    this.InserirServicoItemOS(ordemS.NrNota, servico, transaction);
                }
                transaction.Commit();
                MessageBox.Show("Ordem de serviço salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            comando.CommandText = @"INSERT INTO ordemServicos (nrNota,  codVeiculo, codCliente,  data, codCondPagamento, ano, placa, km, cor, valorProduto, valorServico, desconto,  valorTotal,
                                                               observacoes, dtCadastro, dtAlteracao, usuario, finalizada ) 
                                                VALUES ( @nrNota,  @codVeiculo, @codCliente, @data, @codCondPagamento, @ano, @placa, @km, @cor, @valorProduto, @valorServico, @desconto, @valorTotal, 
                                                              @observacoes, @dtCadastro, @dtAlteracao, @usuario, @finalizada)";

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
            comando.Parameters.AddWithValue("@finalizada", 0);

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
                string sql = @"SELECT   ordemServicos.nrNota, ordemServicos.codCliente, ordemServicos.codVeiculo, ordemServicos.data, ordemServicos.ano, 
                                ordemServicos.placa, ordemServicos.km, ordemServicos.cor, ordemServicos.valorProduto, ordemServicos.desconto, ordemServicos.valorServico, ordemServicos.valorTotal, 
                                 ordemServicos.codCondPagamento, ordemServicos.observacoes, ordemServicos.dtCadastro, ordemServicos.dtAlteracao, ordemServicos.usuario, ordemServicos.finalizada, condicaoPagamento.condicao, 
                                 clientes.cliente, modelos.modelo AS veiculo
                                FROM         ordemServicos INNER JOIN
                                 clientes ON ordemServicos.codCliente = clientes.codigo INNER JOIN
                                 modelos ON ordemServicos.codVeiculo = modelos.codigo INNER JOIN
                                 condicaoPagamento ON ordemServicos.codCondPagamento = condicaoPagamento.codigo WHERE ordemServicos.nrNota = @nrNota";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);
                ordemServ = null;
                foreach (DataRow row in dtCliente.Rows)
                {
                    OrdemServicos os = new OrdemServicos();
                    os.NrNota = Convert.ToString(row["nrNota"]); 
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
                    os.CondPagamento = DaoCondPag.BuscarPorID(Convert.ToInt32(row["codCondPagamento"])) as CondicaoPagamentos;
                    os.observacoes = Convert.ToString(row["observacoes"]);
                    os.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    os.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    os.usuario = Convert.ToString(row["usuario"]);
                    os.finalizada = Convert.ToBoolean(row["finalizada"]);
                    os.ListaProduto = BuscarProdutos(nrNota);
                    os.ListaServico = BuscarServicos(nrNota);

                    ordemServ = os;
                }
                conexao.Close();
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
                    var Servico = DaoServico.BuscarPorID(cod) as Servicos;
                    ListaItensOrdemServicoS.Add(new ItensOrdemServico()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        produto = Servico.servico,
                        cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes,
                        Veiculo = DaoModelo.BuscarPorID(Convert.ToInt64(row["codVeiculo"])) as Modelos,
                        Mecanico = DaoFuncionario.BuscarPorID(Convert.ToInt64(row["codMecanico"])) as Funcionarios,
                        codigo = Convert.ToInt32(row["codServico"]),
                        precoVenda = Convert.ToDecimal(row["valorVenda"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                    });
                }
                conexao.Close();
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
                    var Produto = DaoProduto.BuscarPorID(cod) as Produtos;
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
                conexao.Close();
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
                                        codVeiculo = @codVeiculo, codCliente = @codCliente,  data = @data, codCondPagamento = @codCondPagamento,
                                        ano = @ano, placa = @placa, km = @km, cor = @cor,  valorProduto = @valorProduto, valorServico = @valorServico, desconto = @desconto,  valorTotal = @valorTotal,
                                        observacoes = @observacoes, dtCadastro = @dtCadastro, dtAlteracao = @dtAlteracao, usuario = @usuario
                                        WHERE nrNota = @nrNota ";
             
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
                    string sql = @"DELETE FROM ordemServicos WHERE (nrNota = @id)";

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
                string sql = @"SELECT   ordemServicos.nrNota, ordemServicos.codCliente, ordemServicos.codVeiculo, ordemServicos.data, ordemServicos.ano, 
                         ordemServicos.placa, ordemServicos.km, ordemServicos.cor, ordemServicos.valorProduto, ordemServicos.desconto, ordemServicos.valorServico, ordemServicos.valorTotal, 
                         ordemServicos.codCondPagamento, ordemServicos.observacoes, ordemServicos.dtCadastro, ordemServicos.dtAlteracao, ordemServicos.usuario, condicaoPagamento.condicao, 
                         clientes.cliente, modelos.modelo AS veiculo
                            FROM         ordemServicos INNER JOIN
                         clientes ON ordemServicos.codCliente = clientes.codigo INNER JOIN
                         modelos ON ordemServicos.codVeiculo = modelos.codigo INNER JOIN
                         condicaoPagamento ON ordemServicos.codCondPagamento = condicaoPagamento.codigo"; //where finalizada = 0
                SqlCommand comando = new SqlCommand(sql, conexao);
                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtOS = new DataTable();
                da.Fill(dtOS);

                conexao.Close();
                return dtOS;
            }
        }
    }
}
