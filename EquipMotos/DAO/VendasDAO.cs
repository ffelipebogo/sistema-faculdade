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
    public class VendasDAO : DAO
    {
        Vendas Venda = new Vendas();
        List<ContasReceber> ListaContaReceber = new List<ContasReceber>();
        List<ItensVenda> ListaItem = new List<ItensVenda>();
        ClientesDAO DaoCliente = new ClientesDAO();
        CondicaoPagamentoDAO DaoCondPagamento = new CondicaoPagamentoDAO();
        ProdutosServicosDAO DaoProdutoServico = new ProdutosServicosDAO();


        private object SelecionaUltimoID(SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = "SELECT MAX(nrNota) ID FROM vendas";

            var CondID = comando.ExecuteScalar();

            if (String.IsNullOrEmpty(CondID.ToString()))
            {
                CondID = 1;
            }
            return CondID;
        }

        public override void Inserir(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                Vendas venda = obj as Vendas;

                this.InserirVendaSql(venda, transaction);
                var nrNota = this.SelecionaUltimoID(transaction);
                foreach (ContasReceber conta in venda.listaContasReceber)
                {

                    this.InserirContasReceber(nrNota, conta, transaction);
                }
                foreach (ItensVenda item in venda.listaItem)
                {

                    this.InserirItemVenda(nrNota, item, transaction);
                }
                transaction.Commit();
                MessageBox.Show("Venda salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Este modelo, serie, nrNota e fornecedor já existe em outra Venda!", "Erro ao salvar a Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void InserirVendaSql(Vendas venda, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO vendas (modelo, serie,  codCliente, codCondPagamento, dtEmissao, situacao, desconto, dtCadastro, dtAlteracao, usuario)
                                 VALUES (@modelo, @serie,  @codCliente, @codCondPagamento, @dtEmissao, @situacao, @desconto, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", venda.modelo);
            comando.Parameters.AddWithValue("@serie", venda.serie);
            //comando.Parameters.AddWithValue("@nrNota", venda.nrNota);
            comando.Parameters.AddWithValue("@codCliente", venda.cliente.codigo);
            comando.Parameters.AddWithValue("@codCondPagamento", venda.condPagamento.codigo);
            comando.Parameters.AddWithValue("@desconto", venda.desconto);
            comando.Parameters.AddWithValue("@dtEmissao", venda.dtEmissao);
            comando.Parameters.AddWithValue("@situacao", venda.situacao);
            comando.Parameters.AddWithValue("@observacoes", venda.observacoes);
            comando.Parameters.AddWithValue("@dtCadastro", venda.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", venda.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", venda.usuario);

            comando.ExecuteNonQuery();
        }

        private void InserirItemVenda(object nrNota, ItensVenda item, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            var Produto = DaoProdutoServico.BuscarPorID(item.codigo) as ProdutosServicos;
            comando.CommandText = @"INSERT INTO itemVenda (  modelo, serie, nrNota, codCliente, codProduto, qtd, valorVenda, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codCliente,  @codProduto, @qtd ,  @valorVenda,  @dtCadastro, @dtAlteracao);
                                    UPDATE  produtos set qtd = @qtdEstoque WHERE codigo = @codProduto ";

            comando.Parameters.AddWithValue("@modelo", item.modelo);
            comando.Parameters.AddWithValue("@serie", item.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@codCliente", item.cliente.codigo);
            comando.Parameters.AddWithValue("@codProduto", item.codigo);
            comando.Parameters.AddWithValue("@qtd", item.qtd);
            comando.Parameters.AddWithValue("@qtdEstoque", Produto.qtd - item.qtd);
            comando.Parameters.AddWithValue("@valorVenda", item.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", item.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", item.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        private void InserirContasReceber(object nrNota, ContasReceber conta, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO contaReceber ( modelo, serie, nrNota, nrParcela, codCliente, codFormaPagamento, valorParcela, dtVencimento, dtEmissao, dtCadastro, dtAlteracao, usuario) 
                                                    values ( @modelo, @serie, @nrNota,  @nrParcela, @codCliente, @codFormaPagamento, @valorParcela, @dtVencimento, @dtEmissao, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", conta.modelo);
            comando.Parameters.AddWithValue("@serie", conta.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@nrParcela", conta.nrParcela);
            comando.Parameters.AddWithValue("@codCliente", conta.cliente.codigo);
            comando.Parameters.AddWithValue("@codFormaPagamento", conta.formaPagamento.codigo);
            comando.Parameters.AddWithValue("@valorParcela", conta.vlrParcela);
            comando.Parameters.AddWithValue("@dtVencimento", conta.dtVencimento);
            comando.Parameters.AddWithValue("@dtEmissao", conta.dtEmissao);
            comando.Parameters.AddWithValue("@dtCadastro", conta.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", conta.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", conta.usuario);

            comando.ExecuteNonQuery();
        }

        public void InserirVendaOS(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                Vendas venda = obj as Vendas;
                var nrNota = this.SelecionaUltimoID(transaction);
                this.InserirVendaOSSql(venda, transaction);

                foreach (ContasReceber conta in venda.listaContasReceberProdutos)
                {
                    conta.nrNota = nrNota.ToString();
                    this.InserirContasReceberProduto(conta, transaction);
                }
                foreach (ContasReceber conta in venda.listaContasReceberServicos)
                {
                    conta.nrNota = nrNota.ToString();
                    this.InserirContasReceberServico(conta, transaction);
                }
                foreach (ItensOrdemServico item in venda.listaItemProdutos)
                {
                    item.nrNota = nrNota.ToString();
                    this.InserirItemVendaProduto(item, transaction);
                }
                foreach (ItensOrdemServico item in venda.listaItemServico)
                {
                    item.nrNota = nrNota.ToString();
                    this.InserirItemVendaServico(item, transaction);
                }
                MarcarFinalizada(venda, transaction);
                transaction.Commit();
                MessageBox.Show("Venda salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                // MessageBox.Show("Este modelo, serie, nrNota e fornecedor já existe em outra Venda!", "Erro ao salvar a Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void MarcarFinalizada(Vendas venda, SqlTransaction transaction)
        {

            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = "UPDATE ordemServico SET finalizada = @finalizada WHERE nrNota = @nrNota ";

            comando.Parameters.AddWithValue("@nrNota", venda.nrNota);
            comando.Parameters.AddWithValue("@finalizada", 1);

            comando.ExecuteNonQuery();

        }

        private void InserirVendaOSSql(Vendas venda, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);


            comando.CommandText = @"INSERT INTO vendas (modelo, serie,  codCliente, codCondPagamento, dtEmissao, situacao, desconto, dtCadastro, dtAlteracao, usuario)
                                 VALUES (@modelo, @serie,  @codCliente, @codCondPagamento, @dtEmissao, @situacao, @desconto, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", venda.modelo);
            comando.Parameters.AddWithValue("@serie", venda.serie);

            comando.Parameters.AddWithValue("@codCliente", venda.cliente.codigo);
            comando.Parameters.AddWithValue("@codCondPagamento", venda.condPagamento.codigo);
            comando.Parameters.AddWithValue("@desconto", venda.desconto);
            comando.Parameters.AddWithValue("@dtEmissao", venda.dtEmissao);
            comando.Parameters.AddWithValue("@situacao", venda.situacao);
            comando.Parameters.AddWithValue("@observacoes", venda.observacoes);
            comando.Parameters.AddWithValue("@dtCadastro", venda.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", venda.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", venda.usuario);

            comando.ExecuteNonQuery();
        }

        private void InserirContasReceberProduto(ContasReceber conta, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO contaReceberProduto ( modelo, serie, nrNota, nrParcela, codCliente, codFormaPagamento, valorParcela, dtVencimento, dtEmissao, dtCadastro, dtAlteracao, usuario) 
                                                    values ( @modelo, @serie, @nrNota,  @nrParcela, @codCliente, @codFormaPagamento, @valorParcela, @dtVencimento, @dtEmissao, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", conta.modelo);
            comando.Parameters.AddWithValue("@serie", conta.serie);
            comando.Parameters.AddWithValue("@nrNota", conta.nrNota);
            comando.Parameters.AddWithValue("@nrParcela", conta.nrParcela);
            comando.Parameters.AddWithValue("@codCliente", conta.cliente.codigo);
            comando.Parameters.AddWithValue("@codFormaPagamento", conta.formaPagamento.codigo);
            comando.Parameters.AddWithValue("@valorParcela", conta.vlrParcela);
            comando.Parameters.AddWithValue("@dtVencimento", conta.dtVencimento);
            comando.Parameters.AddWithValue("@dtEmissao", conta.dtEmissao);
            comando.Parameters.AddWithValue("@dtCadastro", conta.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", conta.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", conta.usuario);

            comando.ExecuteNonQuery();
        }

        private void InserirContasReceberServico(ContasReceber conta, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO contaReceberServico ( modelo, serie, nrNota, nrParcela, codCliente, codFormaPagamento, valorParcela, dtVencimento, dtEmissao, dtCadastro, dtAlteracao, usuario) 
                                                    values ( @modelo, @serie, @nrNota,  @nrParcela, @codCliente, @codFormaPagamento, @valorParcela, @dtVencimento, @dtEmissao, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", conta.modelo);
            comando.Parameters.AddWithValue("@serie", conta.serie);
            comando.Parameters.AddWithValue("@nrNota", conta.nrNota);
            comando.Parameters.AddWithValue("@nrParcela", conta.nrParcela);
            comando.Parameters.AddWithValue("@codCliente", conta.cliente.codigo);
            comando.Parameters.AddWithValue("@codFormaPagamento", conta.formaPagamento.codigo);
            comando.Parameters.AddWithValue("@valorParcela", conta.vlrParcela);
            comando.Parameters.AddWithValue("@dtVencimento", conta.dtVencimento);
            comando.Parameters.AddWithValue("@dtEmissao", conta.dtEmissao);
            comando.Parameters.AddWithValue("@dtCadastro", conta.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", conta.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", conta.usuario);

            comando.ExecuteNonQuery();

        }

        private void InserirItemVendaProduto(ItensOrdemServico item, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            var Produto = DaoProdutoServico.BuscarPorID(item.codigo) as ProdutosServicos;

            comando.CommandText = @"INSERT INTO produtoOrdemServico (  modelo, serie, nrNota, codCliente, codVeiculo, codProduto, qtd, valorVenda, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codCliente, @codVeiculo, @codProduto, @qtd ,  @valorVenda,  @dtCadastro, @dtAlteracao)
                                          UPDATE  produtos set qtd = @qtdEstoque WHERE codigo = @codProduto ";

            comando.Parameters.AddWithValue("@modelo", item.modelo);
            comando.Parameters.AddWithValue("@serie", item.serie);
            comando.Parameters.AddWithValue("@nrNota", item.nrNota);
            comando.Parameters.AddWithValue("@codCliente", item.cliente.codigo);
            comando.Parameters.AddWithValue("@codVeiculo", item.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codProduto", item.codigo);
            comando.Parameters.AddWithValue("@qtd", item.qtd);
            comando.Parameters.AddWithValue("@qtdEstoque", Produto.qtd - item.qtd);
            comando.Parameters.AddWithValue("@valorVenda", item.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", item.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", item.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        private void InserirItemVendaServico(ItensOrdemServico item, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            //var Produto = DaoProdutoServico.BuscarPorID(item.codigo) as ProdutosServicos;

            comando.CommandText = @"INSERT INTO servicoOrdemServico (  modelo, serie, nrNota, codCliente, codServico, codMecanico, codVeiculo, valorVenda, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codCliente,  @codServico, @codMecanico, @codVeiculo,  @valorVenda,  @dtCadastro, @dtAlteracao)";

            comando.Parameters.AddWithValue("@modelo", item.modelo);
            comando.Parameters.AddWithValue("@serie", item.serie);
            comando.Parameters.AddWithValue("@nrNota", item.nrNota);
            comando.Parameters.AddWithValue("@codCliente", item.cliente.codigo);
            comando.Parameters.AddWithValue("@codVeiculo", item.Veiculo.codigo);
            comando.Parameters.AddWithValue("@codServico", item.codigo);
            comando.Parameters.AddWithValue("@codMecanico", item.Mecanico.codigo);
            comando.Parameters.AddWithValue("@valorVenda", item.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", item.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", item.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM vendas";

                SqlCommand comando = new SqlCommand(sql, conexao);
                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtVenda = new DataTable();
                da.Fill(dtVenda);

                return dtVenda;
            }
        }

        public Vendas BuscarVenda_porID(object nrNota)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                //venda = new Vendas();
                SqlDataAdapter da;
                string sql = @"SELECT * FROM vendas WHERE  nrNota = @nrNota ";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCompra = new DataTable();
                da.Fill(dtCompra);
                Venda = null;
                foreach (DataRow row in dtCompra.Rows)
                {
                    Vendas venda = new Vendas();

                    venda.modelo = Convert.ToString(row["modelo"]);
                    venda.serie = Convert.ToString(row["serie"]);
                    venda.nrNota = Convert.ToString(row["nrNota"]);
                    venda.cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes;
                    venda.condPagamento = DaoCondPagamento.BuscarPorID(Convert.ToInt64(row["codCondPagamento"])) as CondicaoPagamentos;
                    venda.dtEmissao = Convert.ToDateTime(row["dtEmissao"]);
                   
                    venda.desconto = Convert.ToDouble(Convert.ToDouble(row["desconto"]).ToString("N2"));
                    venda.situacao = Convert.ToBoolean(row["situacao"]);
                    venda.observacoes = Convert.ToString(row["observacoes"]);
                    venda.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    venda.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    venda.usuario = Convert.ToString(row["usuario"]);
                    venda.listaItem = BuscarItem(nrNota);
                    venda.listaContasReceber = BuscarContasReceber( nrNota);

                    Venda = venda;
                }
                return Venda;
            }
        }

        private List<ContasReceber> BuscarContasReceber(object nrNota)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaReceber WHERE  nrNota = @nrNota ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                 
                comando.Parameters.AddWithValue("@nrNota", nrNota); 

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtContaPagar = new DataTable();
                da.Fill(dtContaPagar);
                foreach (DataRow row in dtContaPagar.Rows)
                {
                    ListaContaReceber.Add(new ContasReceber()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes,
                        nrParcela = Convert.ToInt32(row["nrParcela"]),
                        dtVencimento = Convert.ToDateTime(row["dtVencimento"]),
                        vlrParcela = Convert.ToDouble(row["valorParcela"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                        dtEmissao = Convert.ToDateTime(row["dtEmissao"]),

                    });
                }
                return ListaContaReceber;
            }
        }

        private List<ItensVenda> BuscarItem(object nrNota)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM itemVenda WHERE nrNota = @nrNota ";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtItemVenda = new DataTable();
                da.Fill(dtItemVenda);
                foreach (DataRow row in dtItemVenda.Rows)
                {
                    ListaItem.Add(new ItensVenda()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes,
                        codigo = Convert.ToInt32(row["codProduto"]),
                        qtd = Convert.ToInt32(row["qtd"]),
                        precoVenda = Convert.ToDecimal(row["valorVenda"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                    });
                }
                return ListaItem;
            }
        }
    }
}
