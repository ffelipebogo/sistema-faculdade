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
        ProdutosDAO DaoProduto = new ProdutosDAO(); 

        public object   SelecionaUltimoID()
        {
            try
            {
                conexao.Open();
                SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
                SqlCommand comando = this.CreateCommandTransaction(transaction);
                comando.CommandText = "SELECT MAX(nrNota) ID FROM vendas";

                int CondID = int.Parse("0" + comando.ExecuteScalar().ToString());

                if (String.IsNullOrEmpty(CondID.ToString()) || CondID <= 0)
                {
                    conexao.Close();
                    return CondID = 1;
                }
                conexao.Close();
                return CondID + 1;
            }
            catch
            {
                MessageBox.Show("Erro ao selecionar nrNota!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public override void Inserir(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                Vendas venda = obj as Vendas; 
                this.InserirVendaSql(venda, transaction);
                foreach (ContasReceber conta in venda.listaContasReceber)
                { 
                    this.InserirContasReceber(venda.nrNota, conta, transaction);
                }
                foreach (ItensVenda item in venda.listaItem)
                { 
                    this.InserirItemVenda(venda.nrNota, item, transaction);
                }

                foreach(ItensVenda item in venda.listaItem)
                {
                    this.BaixaEstoque(item, transaction);
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

        public void BaixaEstoque(ItensVenda item, SqlTransaction transaction)
        {

            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @" IF 1 <= (select qtd from produtos where codigo = @codProduto )
	                                    UPDATE produtos SET qtd = (qtd - @qtd) WHERE codigo = @codProduto ";

            comando.Parameters.AddWithValue("@qtd", item.qtd);
            comando.Parameters.AddWithValue("@codProduto", item.codigo);

            comando.ExecuteNonQuery();

        }

        private void InserirVendaSql(Vendas venda, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO vendas (nrNota, modelo, serie,  codCliente, codCondPagamento, dtEmissao, situacao, totalReceber, desconto, dtCadastro, dtAlteracao, usuario)
                                 VALUES (@nrNota, @modelo, @serie,  @codCliente, @codCondPagamento, @dtEmissao, @situacao, @totalReceber, @desconto, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@nrNota", venda.nrNota);
            comando.Parameters.AddWithValue("@modelo", venda.modelo);
            comando.Parameters.AddWithValue("@serie", venda.serie);
            comando.Parameters.AddWithValue("@codCliente", venda.cliente.codigo);
            comando.Parameters.AddWithValue("@codCondPagamento", venda.condPagamento.codigo);
            comando.Parameters.AddWithValue("@desconto", venda.desconto);
            comando.Parameters.AddWithValue("@dtEmissao", venda.dtEmissao);
            comando.Parameters.AddWithValue("@situacao", venda.situacao);
            comando.Parameters.AddWithValue("@totalReceber", venda.totalReceber);
            comando.Parameters.AddWithValue("@dtCadastro", venda.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", venda.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", venda.usuario);

            comando.ExecuteNonQuery();
        }

        private void InserirItemVenda(object nrNota, ItensVenda item, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            
            comando.CommandText = @"INSERT INTO itemVenda (  modelo, serie, nrNota, codCliente, codProduto, qtd, valorVenda, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codCliente,  @codProduto, @qtd ,  @valorVenda,  @dtCadastro, @dtAlteracao)";

            comando.Parameters.AddWithValue("@modelo", item.modelo);
            comando.Parameters.AddWithValue("@serie", item.serie);
            comando.Parameters.AddWithValue("@nrNota", nrNota);
            comando.Parameters.AddWithValue("@codCliente", item.cliente.codigo);
            comando.Parameters.AddWithValue("@codProduto", item.codigo);
            comando.Parameters.AddWithValue("@qtd", item.qtd);
            comando.Parameters.AddWithValue("@valorVenda", item.precoVenda);
            comando.Parameters.AddWithValue("@dtCadastro", item.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", item.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        private void InserirContasReceber(object nrNota, ContasReceber conta, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO contaReceber ( modelo, serie, nrNota, nrParcela, codCliente, codFormaPagamento, valorParcela, dtVencimento, dtEmissao, dtCadastro, dtAlteracao, usuario, recebido) 
                                                    values ( @modelo, @serie, @nrNota,  @nrParcela, @codCliente, @codFormaPagamento, @valorParcela, @dtVencimento, @dtEmissao, @dtCadastro, @dtAlteracao, @usuario, @recebido)";

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
            if (conta.formaPagamento.codigo == 1 )
            {
                comando.Parameters.AddWithValue("@recebido", true);
            }
            else
            {
                comando.Parameters.AddWithValue("@recebido", false);
            }

            comando.ExecuteNonQuery();
        }

        public void InserirVendaOS(object obj)
        {
            
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                Vendas venda = obj as Vendas;
                this.InserirVendaOSSql(venda, transaction);

                foreach (ContasReceber conta in venda.listaContasReceberProdutos)
                {
                    conta.nrNota = venda.nrNota;
                    this.InserirContasReceberProduto(conta, transaction);
                }
                foreach (ContasReceber conta in venda.listaContasReceberServicos)
                {
                    conta.nrNota = venda.nrNota;
                    this.InserirContasReceberServico(conta, transaction);
                }
                foreach (ItensOrdemServico item in venda.listaItemProdutos)
                {
                    item.nrNota = venda.nrNota;
                    this.InserirItemVendaProduto(item, transaction);
                }
                foreach (ItensOrdemServico item in venda.listaItemServico)
                {
                    item.nrNota = venda.nrNota;
                    this.InserirItemVendaServico(item, transaction);
                }
                foreach (ContasReceber conta in venda.listaContasReceber)
                {
                    this.InserirContasReceber(venda.nrNota, conta, transaction);
                }
                foreach (ItensVenda item in venda.listaItem)
                {
                    this.InserirItemVenda(venda.nrNota, item, transaction);
                }
                foreach (ItensVenda item in venda.listaItem)
                {
                    this.BaixaEstoque(item, transaction);
                }
                MarcarFinalizada(venda, transaction);
                transaction.Commit();
                //MessageBox.Show("Venda salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                 MessageBox.Show("Não foi possivel finalizar a ordem de serviço","Erro ao gerar a Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void MarcarFinalizada(Vendas venda, SqlTransaction transaction)
        { 
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = "UPDATE ordemServicos SET finalizada = @finalizada WHERE nrNota = @nrNota ";

            comando.Parameters.AddWithValue("@nrNota", venda.nrNota);
            comando.Parameters.AddWithValue("@finalizada", 1);

            comando.ExecuteNonQuery(); 
        } 

        private void InserirVendaOSSql(Vendas venda, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
             
            comando.CommandText = @"INSERT INTO vendas (modelo, serie, nrNota, codCliente, codCondPagamento, dtEmissao, situacao, totalReceber, desconto, dtCadastro, dtAlteracao, usuario)
                                 VALUES (@modelo, @serie, @nrNota,  @codCliente, @codCondPagamento, @dtEmissao, @situacao, @totalReceber, @desconto, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", venda.modelo);
            comando.Parameters.AddWithValue("@serie", venda.serie);
            comando.Parameters.AddWithValue("@nrNota", venda.nrNota); 
            comando.Parameters.AddWithValue("@codCliente", venda.cliente.codigo);
            comando.Parameters.AddWithValue("@codCondPagamento", venda.condPagamento.codigo);
            comando.Parameters.AddWithValue("@desconto", venda.desconto);
            comando.Parameters.AddWithValue("@totalReceber", venda.totalReceber);
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
            var Produto = DaoProduto.BuscarPorID(item.codigo) as Produtos;

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
                string sql = @"SELECT     vendas.modelo, vendas.serie, vendas.nrNota, vendas.codCliente, vendas.codCondPagamento, vendas.dtEmissao, vendas.desconto, vendas.totalReceber, vendas.observacoes, vendas.dtCadastro, vendas.dtAlteracao, vendas.usuario, vendas.situacao, clientes.cliente, condicaoPagamento.condicao
                                FROM vendas 
                                INNER JOIN clientes ON vendas.codCliente = clientes.codigo 
                                INNER JOIN condicaoPagamento ON vendas.codCondPagamento = condicaoPagamento.codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);
                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtVenda = new DataTable();
                da.Fill(dtVenda);
                conexao.Close();
                return dtVenda;
            }
        }

        public DataTable BuscarVenda_Filtro(object nrNota, object cliente, DateTime dateMin, DateTime dateMax)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string select = @"SELECT        vendas.modelo, vendas.serie, vendas.nrNota, vendas.codCliente, vendas.codCondPagamento, vendas.dtEmissao, vendas.desconto, vendas.totalReceber, vendas.observacoes, vendas.dtCadastro, vendas.dtAlteracao, vendas.usuario, vendas.situacao, clientes.cliente, condicaoPagamento.condicao
                                FROM vendas 
                                INNER JOIN clientes ON vendas.codCliente = clientes.codigo 
                                INNER JOIN condicaoPagamento ON vendas.codCondPagamento = condicaoPagamento.codigo";

                string where = " WHERE 1 = 1 ";
                string sql = "";
                if (nrNota != null)
                {
                    where += " AND vendas.nrNota = @nrNota ";
                }
                else if (cliente != null)
                {
                    where += " AND clientes.cliente = @cliente OR clientes.cliente like '%'+ @cliente +'%' ";
                }
                else if (dateMin != DateTime.MinValue & dateMax != DateTime.MinValue)
                {
                    where += " AND vendas.dtCadastro >= @dateMin AND vendas.dtCadastro <= @dateMax";
                }
                sql = select + where;

                SqlCommand comando = new SqlCommand(sql, conexao);

                if (nrNota != null)
                {
                    comando.Parameters.AddWithValue("@nrNota", nrNota);
                }
                else if (cliente != null)
                {
                    comando.Parameters.AddWithValue("@cliente", cliente);
                }
                else if (dateMin != DateTime.MinValue & dateMax != DateTime.MinValue)
                {
                    comando.Parameters.AddWithValue("@dateMin", dateMin);
                    comando.Parameters.AddWithValue("@dateMax", dateMax);
                }

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtVenda = new DataTable();
                da.Fill(dtVenda);
                conexao.Close();
                return dtVenda;
            }
        }

        public Vendas BuscarVenda_porID(object nrNota, object serie)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                //venda = new Vendas();
                SqlDataAdapter da;
                string sql = @"SELECT  vendas.modelo, vendas.serie, vendas.nrNota, vendas.codCliente, vendas.codCondPagamento, vendas.dtEmissao, vendas.desconto, vendas.observacoes, vendas.dtCadastro, vendas.dtAlteracao, vendas.usuario, vendas.situacao, vendas.totalReceber, clientes.cliente, condicaoPagamento.condicao
                                FROM vendas 
                                INNER JOIN clientes ON vendas.codCliente = clientes.codigo 
                                INNER JOIN condicaoPagamento ON vendas.codCondPagamento = condicaoPagamento.codigo
                                WHERE  vendas.nrNota = @nrNota AND vendas.serie = @serie";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@serie", serie);

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
                    venda.totalReceber = Convert.ToDouble(Convert.ToDouble(row["totalReceber"]).ToString("N2"));
                    venda.situacao = Convert.ToBoolean(row["situacao"]);
                    venda.observacoes = Convert.ToString(row["observacoes"]);
                    venda.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    venda.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    venda.usuario = Convert.ToString(row["usuario"]);
                    venda.listaItem = BuscarItem(venda.modelo, nrNota, serie, venda.cliente.codigo);
                    venda.listaContasReceber = BuscarContasReceber( venda.modelo, venda.serie, nrNota, venda.cliente.codigo);

                    Venda = venda;
                }
                conexao.Close();
                return Venda;
            }
        }

        public List<ContasReceber> BuscarContasReceber(object modelo, object serie, object nrNota, object codCliente)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaReceber WHERE  modelo = @modelo AND serie = @serie AND nrNota = @nrNota AND codCliente = @codCliente ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                 
                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codCliente", codCliente);

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
                conexao.Close();
                return ListaContaReceber;
            }
        }

        public List<ItensVenda> BuscarItem(object modelo, object nrNota, object serie,  object codCliente)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM itemVenda WHERE nrNota = @nrNota AND serie = @serie AND modelo = @modelo AND codCliente = @codCliente ";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@codCliente", codCliente);

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
                conexao.Close();
                return ListaItem;
            }
        }

        public void Desativar(object modelo, object serie, object nrNota, object codCliente)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                SqlCommand comando = this.CreateCommandTransaction(transaction);

                comando.CommandText = @"UPDATE vendas
                                         SET situacao = 1  
                                        WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota  and codCliente = @codCliente ;";

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codCliente", codCliente);

                comando.ExecuteNonQuery();
                transaction.Commit(); 
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                transaction.Rollback();
                conexao.Close();
                MessageBox.Show("Nao foi possivel desativar!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
