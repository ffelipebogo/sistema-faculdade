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
    class CondicaoPagamentoDAO : DAO, IDisposable
    {
        CondicaoPagamentos condicaoPagamento;
        FormaPagamentoDAO daoFormPagamento = new FormaPagamentoDAO();

        public void InserirCondicaoPagamento(CondicaoPagamentos condPagamento)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                this.InsertCondicaoPagamento(condPagamento, transaction);

                foreach (CondicaoParcelada parcela in condPagamento.listaParcela)
                {
                    this.InsertParcela(parcela, transaction);
                }
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao salvar a Condição de Pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
        }

        private void InsertParcela(CondicaoParcelada parcela, SqlTransaction transaction)
        {
            var IDcondPagamento = this.SelecionaUltimoID(transaction);

            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = @"INSERT INTO parcelas( codCondPagamento, codFormaPagamento, nrParcela, nrDia , porcentagem, dtCadastro, dtAlteracao) 
                                            VALUES (@codCondPagamento, @codFormaPagamento, @nrParcela,  @nrDia, @porcentagem, @dtCadastrop, @dtAlteracaop)";

            comando.Parameters.AddWithValue("@codCondPagamento", Convert.ToInt32(IDcondPagamento) ); //  para pegar o id condição deste insert
            comando.Parameters.AddWithValue("@codFormaPagamento", parcela.formaPagamento.codigo);
            comando.Parameters.AddWithValue("@nrParcela", parcela.nrParcela);
            comando.Parameters.AddWithValue("@nrDia", parcela.nrDia);
            comando.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
            comando.Parameters.AddWithValue("@dtCadastrop", parcela.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracaop", parcela.dtAlteracao);

            comando.ExecuteNonQuery();
        }

        private object SelecionaUltimoID(SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);
            comando.CommandText = "SELECT MAX(codigo) ID FROM condicaoPagamento";
            
            var CondID = comando.ExecuteScalar();

            if (String.IsNullOrEmpty(CondID.ToString()))
            {
                CondID = 1;
            }
            return CondID;
        }

        private void InsertCondicaoPagamento(CondicaoPagamentos condPag, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO condicaoPagamento (condicao,  juros, multa, desconto, dtCadastro, dtAlteracao, usuario)
                                           VALUES (@condicao,  @juros, @multa, @desconto, @dtCadastro, @dtAlteracao, @usuario)";
            
            comando.Parameters.AddWithValue("@condicao", condPag.condicao);
            comando.Parameters.AddWithValue("@juros", condPag.juros);
            comando.Parameters.AddWithValue("@multa", condPag.multa);
            comando.Parameters.AddWithValue("@desconto", condPag.desconto);
            comando.Parameters.AddWithValue("@dtCadastro", condPag.dtCadastro);
            comando.Parameters.AddWithValue("@dtAlteracao", condPag.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", condPag.usuario);

            comando.ExecuteNonQuery();
        }

        public void EditarCondicaoPagamento(CondicaoPagamentos condPagamento)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                this.UpdateCondicaoPagamento(condPagamento, transaction);

                //this.ExcluirParcela(condPagamento.codigo, transaction);

                foreach (CondicaoParcelada parcela in condPagamento.listaParcela)
                {
                    this.UpdateParcela(parcela, transaction);
                }
                transaction.Commit();
                MessageBox.Show("Condição de Pagamento alterada com Sucesso!"); ;
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao alterar a Condição de Pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexao.Close();
            }
        }

        private void UpdateCondicaoPagamento(CondicaoPagamentos condPag, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"UPDATE condicaoPagamento SET condicao = @condicao, juros = @juros, multa = @multa, desconto = @desconto,
                                                                 dtAlteracao = @dtAlteracao, usuario = @usuario WHERE codigo = @codigo ";
            comando.Parameters.AddWithValue("@condicao", condPag.condicao);
            comando.Parameters.AddWithValue("@juros", condPag.juros);
            comando.Parameters.AddWithValue("@multa", condPag.multa);
            comando.Parameters.AddWithValue("@desconto", condPag.desconto);
            comando.Parameters.AddWithValue("@dtAlteracao", condPag.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", condPag.usuario);
            comando.Parameters.AddWithValue("@codigo", condPag.codigo);

            comando.ExecuteNonQuery();
        }

        private void UpdateParcela(CondicaoParcelada parcela, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"UPDATE parcelas SET nrParcela = @nrParcela, nrDia = @nrDia, porcentagem = @porcentagem, codFormaPagamento = @codFormaPagamento,
                                                                 dtAlteracao = @dtAlteracao, usuario = @usuario WHERE codigo = @codigo ";

            comando.Parameters.AddWithValue("@nrParcela", parcela.nrParcela);
            comando.Parameters.AddWithValue("@nrDia", parcela.nrDia);
            comando.Parameters.AddWithValue("@porcentagem", parcela.porcentagem);
            comando.Parameters.AddWithValue("@codFormaPagamento", parcela.formaPagamento.codigo);
            comando.Parameters.AddWithValue("@dtAlteracao", parcela.dtAlteracao);
            comando.Parameters.AddWithValue("@usuario", parcela.usuario);
            comando.Parameters.AddWithValue("@codigo", parcela.codigo);

            comando.ExecuteNonQuery();
        }

        public void ExcluirCondicaoPagamento(object id)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                SqlCommand comando = this.CreateCommandTransaction(transaction);

                comando.CommandText = @"DELETE FROM condicaoPagamento WHERE codigo = @codigo;
                                    DELETE FROM parcelas WHERE codCondPagamento = @codigo;";
                comando.Parameters.AddWithValue("@codigo", id);

                comando.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("Não foi possivel excluir a condição de pagamento!", "Condição está sendo utilizada em outro cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                conexao.Close();
            }
        }

        public void ExcluirParcela(object id, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = "DELETE FROM parcelas WHERE codCondPagamento = @codigo;";
            comando.Parameters.AddWithValue("@codigo", id);

            comando.ExecuteNonQuery();
         
        }

        public DataTable ListarTodasCondicoes()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM condicaoPagamento";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCondicaoPagamento = new DataTable();
                da.Fill(dtCondicaoPagamento);
                conexao.Close();
                return dtCondicaoPagamento;
            }

        }

        internal CondicaoPagamentos BuscarCondicao_porID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM condicaoPagamento cp INNER JOIN parcelas p on p.codCondPagamento = cp.codigo WHERE cp.codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);
                List<CondicaoParcelada> listaParcelas = new List<CondicaoParcelada>();
                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCondicao = new DataTable();
                da.Fill(dtCondicao);
                foreach (DataRow row in dtCondicao.Rows)
                {
                    CondicaoPagamentos condPagamento = new CondicaoPagamentos();

                    condPagamento.codigo = Convert.ToInt32(row["codigo"]);
                    condPagamento.condicao = Convert.ToString(row["condicao"]);
                    condPagamento.multa = Convert.ToDouble(row["multa"]);
                    condPagamento.juros = Convert.ToDouble(row["juros"]);
                    condPagamento.desconto = Convert.ToDouble(row["desconto"]);
                    
                    listaParcelas.Add(new CondicaoParcelada
                    {
                        nrParcela = Convert.ToInt32(row["nrParcela"]),
                        nrDia = Convert.ToInt32(row["nrDia"]),
                        porcentagem = Convert.ToDouble(row["porcentagem"]),
                        formaPagamento = daoFormPagamento.BuscarPorID(Convert.ToInt32(row["codFormaPagamento"])) as FormaPagamentos,
                        dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]),
                        dtCadastro = Convert.ToDateTime(row["dtCadastro"]),
                        usuario = Convert.ToString(row["usuario"])
                    }) ;
                    condPagamento.listaParcela = listaParcelas;
                    condPagamento.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    condPagamento.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    condPagamento.usuario = Convert.ToString(row["usuario"]);
                    condicaoPagamento = condPagamento;
                }
                conexao.Close();
                return condicaoPagamento;
            }
        }

        internal object pesquisaCondicao(string cond)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(cond, out int n);
                if (cond.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM condicaoPagamento WHERE codigo = @cond";
                }
                else
                {
                    sql = @"SELECT * FROM condicaoPagamento WHERE condicao LIKE '%'+ @cond + '%' ";
                }

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cond", cond);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCategoria = new DataTable();
                da.Fill(dtCategoria);

                return dtCategoria;

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

