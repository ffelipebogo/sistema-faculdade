using EquipMotos.MODEL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EquipMotos.DAO
{
    class ContasPagarDAO : DAO
    {
        ContasPagar conta = new ContasPagar();
        FornecedoresDAO daoFornecedor = new FornecedoresDAO();
        FormaPagamentoDAO daoFormaPag = new FormaPagamentoDAO();
        public void InserirContasPagar(ContasPagar conta)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                SqlCommand comando = this.CreateCommandTransaction(transaction);

                comando.CommandText = @"INSERT INTO contaPagar (  modelo, serie, nrNota, nrParcela, codFornecedor, codFormaPagamento, valorParcela, dtVencimento, dtEmissao, dtCadastro, dtAlteracao, usuario, pago) 
                                                    values ( @modelo, @serie, @nrNota,  @nrParcela, @codFornecedor, @codFormaPagamento, @valorParcela, @dtVencimento, @dtEmissao, @dtCadastro, @dtAlteracao, @usuario, @pago)";

                comando.Parameters.AddWithValue("@modelo", conta.modelo);
                comando.Parameters.AddWithValue("@serie", conta.serie);
                comando.Parameters.AddWithValue("@nrNota", conta.nrNota);
                comando.Parameters.AddWithValue("@nrParcela", conta.nrParcela);
                comando.Parameters.AddWithValue("@codFormaPagamento", conta.formaPagamento.codigo);
                comando.Parameters.AddWithValue("@codFornecedor", conta.fornecedor.codigo);
                comando.Parameters.AddWithValue("@valorParcela", conta.vlrParcela);
                comando.Parameters.AddWithValue("@dtVencimento", conta.dtVecimento);
                comando.Parameters.AddWithValue("@dtEmissao", conta.dtEmissao);
                comando.Parameters.AddWithValue("@dtCadastro", conta.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", conta.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", conta.usuario);
                if (conta.pago)
                {
                    comando.Parameters.AddWithValue("@pago", true);
                }
                else
                {
                    comando.Parameters.AddWithValue("@pago", false);
                }

                comando.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                conexao.Close();
                MessageBox.Show("Não foi possivel salvar a conta a pagar numero "+ conta.nrNota +"/"+ conta.nrParcela +" !");
            }
            finally
            {
                conexao.Close();
            }

        }
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaPagar WHERE pago = 0";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtContaPagar = new DataTable();
                da.Fill(dtContaPagar);
                conexao.Close();
                return dtContaPagar;
            }
        }

        public object BuscarContasPagar_porID(object modelo, object serie, object nrNota, object codFornecedor, object nrParcela)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaPagar WHERE modelo = @modelo 
                                                        AND serie = @serie 
                                                        AND nrNota = @nrNota 
                                                        AND codFornecedor = @codFornecedor   
                                                        AND nrParcela = @nrParcela";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                comando.Parameters.AddWithValue("@nrParcela", nrParcela);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCompra = new DataTable();
                da.Fill(dtCompra);

                foreach (DataRow row in dtCompra.Rows)
                {
                    ContasPagar contas = new ContasPagar();

                    contas.modelo = Convert.ToString(row["modelo"]);
                    contas.serie = Convert.ToString(row["serie"]);
                    contas.nrNota = Convert.ToString(row["nrNota"]);
                    contas.fornecedor = daoFornecedor.BuscarPorID(Convert.ToInt64(row["codFornecedor"])) as Fornecedores;
                    contas.formaPagamento = daoFormaPag.BuscarPorID(Convert.ToInt64(row["codFormaPagamento"])) as FormaPagamentos;
                    contas.nrParcela = Convert.ToInt32(row["nrParcela"]);
                    contas.dtVecimento = Convert.ToDateTime(row["dtVencimento"]);
                    contas.vlrParcela = Convert.ToDouble(row["valorParcela"]);
                    contas.dtEmissao = Convert.ToDateTime(row["dtEmissao"]);
                    contas.observacoes = Convert.ToString(row["observacoes"]);
                    contas.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    contas.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    contas.usuario = Convert.ToString(row["usuario"]);
                    conta = contas;
                }
                return conta;
            }
        }

        public void MarcarPago(object modelo, object serie, object nrNota, object codFornecedor, object nrParcela)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                SqlCommand comando = this.CreateCommandTransaction(transaction);

                comando.CommandText = @"UPDATE contaPagar
                                         SET pago = 1  
                                        WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota and nrParcela = @nrParcela and codFornecedor = @codFornecedor ;";

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@nrParcela", nrParcela);
                comando.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                comando.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
                conexao.Close();
                MessageBox.Show("Nao foi possivel marcar como pago!");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
