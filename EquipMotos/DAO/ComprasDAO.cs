using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using EquipMotos.MODEL;

namespace EquipMotos.DAO
{
    public class ComprasDAO : DAO, IDisposable
    {
        Compras Compra = new Compras();
        List<ContasPagar> ListaConta =  new List<ContasPagar>();
        List<ItensCompra> ListaItem =  new List<ItensCompra>();
        FornecedoresDAO DaoFornecedor = new FornecedoresDAO();
        CondicaoPagamentoDAO DaoCondPagamento = new CondicaoPagamentoDAO();
        ProdutosServicosDAO DaoProdutoServico = new ProdutosServicosDAO();

        public ComprasDAO()
        {
        }

        public override void Inserir(object obj)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                Compras comp = obj as Compras;
                var compValida = BuscarCompra_porID(comp.modelo, comp.serie, comp.nrNota, comp.fornecedor.codigo);
                if(compValida.modelo == null)
                {

                    this.InserirCompraSql(comp, transaction);

                    foreach (ContasPagar conta in comp.listaContasPagar)
                    {
                        this.InserirContasPagar(conta, transaction);
                    }

                    foreach (ItensCompra item in comp.listaItem)
                    {
                        this.InserirItemCompra(item, transaction);
                    }

                    transaction.Commit();
                    MessageBox.Show("Compra salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    transaction.Rollback();
                    MessageBox.Show("Este modelo, serie, nrNota e fornecedor já existe em outra compra!", "Erro ao salvar a Compra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException ex) 
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Este modelo, serie, nrNota e fornecedor já existe em outra compra!", "Erro ao salvar a Compra!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void InserirCompraSql(Compras compra, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO compras (modelo, serie, nrNota, codFornecedor, codCondPagamento, totalProduto, totalPagar, seguro, despesa, cfi, frete, dtChegada, dtEmissao, situacao, dtCadastro, dtAlteracao, usuario)
                                 VALUES (@modelo, @serie, @nrNota, @codFornecedor, @codCondPagamento, @totalProduto, @totalPagar, @seguro, @despesa, @cfi, @frete, @dtEmissao, @dtChegada, @situacao, @dtCadastro, @dtAlteracao, @usuario);";

            comando.Parameters.AddWithValue("@modelo", compra.modelo);
            comando.Parameters.AddWithValue("@serie", compra.serie);
            comando.Parameters.AddWithValue("@nrNota", compra.nrNota);
            comando.Parameters.AddWithValue("@codFornecedor", compra.fornecedor.codigo);
            comando.Parameters.AddWithValue("@codCondPagamento", compra.condPagamento.codigo);
            comando.Parameters.AddWithValue("@totalProduto", compra.totalProduto);
            comando.Parameters.AddWithValue("@totalPagar", compra.totalPagar);
            comando.Parameters.AddWithValue("@seguro", compra.seguro);
            comando.Parameters.AddWithValue("@despesa", compra.despesa);
            comando.Parameters.AddWithValue("@cfi", compra.cfi);
            comando.Parameters.AddWithValue("@frete", compra.frete);
            comando.Parameters.AddWithValue("@dtChegada", compra.dtChegada);
            comando.Parameters.AddWithValue("@dtEmissao", compra.dtEmissao);
            comando.Parameters.AddWithValue("@situacao", compra.situacao);
            comando.Parameters.AddWithValue("@observacoes", compra.observacoes);
            comando.Parameters.AddWithValue("@dtCadastro", compra.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", compra.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", compra.usuario);

            comando.ExecuteNonQuery();
        }

        public override object Pesquisar(string compra)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(compra, out int n);
                if (string.IsNullOrEmpty(compra))
                {
                    sql = "SELECT * FROM compras ";
                }
                else
                {
                    sql = @"select * from compras where modelo = @compra or serie = @compra or nrNota = @compra";
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@compra", compra);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCompra = new DataTable();
                da.Fill(dtCompra);

                return dtCompra;
            }
        }

        public void Desativar(object modelo, object serie, object nrNota, object idFornecedor)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                SqlCommand comando = this.CreateCommandTransaction(transaction);

                comando.CommandText = @"UPDATE compras
                                         SET situacao = 1  
                                        WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota  and codFornecedor = @codFornecedor ;";

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codFornecedor", idFornecedor);

                comando.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                conexao.Close();
                MessageBox.Show("Nao foi possivel desativar!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void InserirContasPagar(ContasPagar conta, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO contaPagar ( modelo, serie, nrNota, nrParcela, codFornecedor, codFormaPagamento, valorParcela, dtVencimento, dtEmissao, dtCadastro, dtAlteracao, usuario) 
                                                    values ( @modelo, @serie, @nrNota,  @nrParcela, @codFornecedor, @codFormaPagamento, @valorParcela, @dtVencimento, @dtEmissao, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", conta.modelo);
            comando.Parameters.AddWithValue("@serie", conta.serie);
            comando.Parameters.AddWithValue("@nrNota", conta.nrNota);
            comando.Parameters.AddWithValue("@nrParcela", conta.nrParcela);
            comando.Parameters.AddWithValue("@codFornecedor", conta.fornecedor.codigo);
            comando.Parameters.AddWithValue("@codFormaPagamento", conta.formaPagamento.codigo);
            comando.Parameters.AddWithValue("@valorParcela", conta.vlrParcela);
            comando.Parameters.AddWithValue("@dtVencimento", conta.dtVencimento);
            comando.Parameters.AddWithValue("@dtEmissao", conta.dtEmissao);
            comando.Parameters.AddWithValue("@dtCadastro", conta.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", conta.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", conta.usuario);
            

            comando.ExecuteNonQuery();
        }

        public void InserirItemCompra(ItensCompra item, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            var Produto = DaoProdutoServico.BuscarPorID(item.codigo) as ProdutosServicos;
            comando.CommandText = @"INSERT INTO itemCompra (  modelo, serie, nrNota, codFornecedor, codProduto, qtd, custoUnitario, valorUnitario, dtCadastro, dtAlteracao) 
                                                    values ( @modelo, @serie, @nrNota, @codFornecedor,  @codProduto, @qtd ,  @custoUnitario, @valorUnitario,  @dtCadastro, @dtAlteracao);
                                    UPDATE  produtos set qtd = @qtdEstoque, custoUltCompra = @valorUnitario, precoCusto = @custoUnitario, codFornecedor = @codFornecedor, dtUltCompra = @dtCadastro WHERE codigo = @codProduto ";

            comando.Parameters.AddWithValue("@modelo", item.modelo);
            comando.Parameters.AddWithValue("@serie", item.serie);
            comando.Parameters.AddWithValue("@nrNota", item.nrNota);
            comando.Parameters.AddWithValue("@codFornecedor", item.Fornecedor.codigo);
            comando.Parameters.AddWithValue("@codProduto", item.codigo);
            comando.Parameters.AddWithValue("@qtdEstoque", item.qtd + Produto.qtd);
            comando.Parameters.AddWithValue("@qtd", item.qtd);
            comando.Parameters.AddWithValue("@custoUnitario", item.custoUnitario);
            comando.Parameters.AddWithValue("@valorUnitario", item.valorUnitario);
            comando.Parameters.AddWithValue("@dtCadastro", item.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", item.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM compras WHERE situacao = 1";

                SqlCommand comando = new SqlCommand(sql, conexao);
                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCompra = new DataTable();
                da.Fill(dtCompra);

                return dtCompra;
            }
        }
        public Compras BuscarCompra_porID(object modelo, object serie, object nrNota, object idFornecedor)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Compra = new Compras();
                SqlDataAdapter da;
                string sql = @"SELECT * FROM compras WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota and codFornecedor = @codFornecedor";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codFornecedor", idFornecedor);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCompra = new DataTable();
                da.Fill(dtCompra);

                foreach (DataRow row in dtCompra.Rows)
                {
                    Compras comp = new Compras();

                    comp.modelo = Convert.ToString(row["modelo"]);
                    comp.serie = Convert.ToString(row["serie"]);
                    comp.nrNota = Convert.ToString(row["nrNota"]);
                    comp.fornecedor = DaoFornecedor.BuscarPorID(Convert.ToInt64(row["codFornecedor"])) as Fornecedores;
                    comp.condPagamento = DaoCondPagamento.BuscarPorID(Convert.ToInt64(row["codCondPagamento"]))as CondicaoPagamentos;
                    comp.dtEmissao = Convert.ToDateTime(row["dtEmissao"]);
                    comp.dtChegada = Convert.ToDateTime(row["dtChegada"]);
                    comp.cfi = Convert.ToBoolean(row["cfi"]);
                    comp.frete = Convert.ToDouble(Convert.ToDouble(row["frete"]).ToString("N2"));
                    comp.seguro = Convert.ToDouble(Convert.ToDouble(row["seguro"]).ToString("N2"));
                    comp.despesa = Convert.ToDouble(Convert.ToDouble(row["despesa"]).ToString("N2"));
                    comp.situacao = Convert.ToBoolean(row["situacao"]);
                    comp.observacoes = Convert.ToString(row["observacoes"]);
                    comp.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    comp.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    comp.usuario = Convert.ToString(row["usuario"]);
                    comp.listaItem = BuscarItem(modelo, serie, nrNota, idFornecedor);
                    comp.listaContasPagar = BuscarContasPagar(modelo, serie, nrNota, idFornecedor);
                    
                    Compra = comp;
                }
                return Compra;
            }
        }

        private List<ItensCompra> BuscarItem(object modelo, object serie, object nrNota, object idFornecedor)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM itemCompra WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota and codFornecedor = @codFornecedor";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codFornecedor", idFornecedor);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtItemCompra = new DataTable();
                da.Fill(dtItemCompra);
                foreach (DataRow row in dtItemCompra.Rows)
                {
                    ListaItem.Add(new ItensCompra()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        Fornecedor = DaoFornecedor.BuscarPorID(Convert.ToInt64(row["codFornecedor"])) as Fornecedores,
                        codigo = Convert.ToInt32(row["codProduto"]),
                        qtd = Convert.ToInt32(row["qtd"]),
                        custoUnitario = Convert.ToDecimal(row["custoUnitario"]),
                        valorUnitario = Convert.ToDecimal(row["valorUnitario"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                    });
                }
                return ListaItem;
            }
        }

        private List<ContasPagar> BuscarContasPagar(object modelo, object serie, object nrNota, object idFornecedor)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaPagar WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota and codFornecedor = @codFornecedor";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codFornecedor", idFornecedor);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtContaPagar = new DataTable();
                da.Fill(dtContaPagar);
                foreach (DataRow row in dtContaPagar.Rows)
                {
                    ListaConta.Add(new ContasPagar()
                    {
                        modelo = Convert.ToString(row["modelo"]),
                        serie = Convert.ToString(row["serie"]),
                        nrNota = Convert.ToString(row["nrNota"]),
                        fornecedor = DaoFornecedor.BuscarPorID(Convert.ToInt64(row["codFornecedor"])) as Fornecedores,
                        nrParcela = Convert.ToInt32(row["nrParcela"]),
                        dtVencimento = Convert.ToDateTime(row["dtVencimento"]),
                        vlrParcela = Convert.ToDouble(row["valorParcela"]),
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                        dtEmissao = Convert.ToDateTime(row["dtEmissao"]),
                        
                    });
                }
                return ListaConta;
            }
        }
        public void Dispose()
        {
            if (this.conexao != null)
            {
                this.conexao.Dispose();
            }
        }
    }
}
