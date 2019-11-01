using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.DAO
{
    public class VendasDAO: DAO
    {
        Vendas Venda = new Vendas();
        List<ContasReceber> ListaContaReceber = new List<ContasReceber>();
        List<ItensVenda> ListaItem = new List<ItensVenda>();
        ClientesDAO DaoCliente = new ClientesDAO();
        CondicaoPagamentoDAO DaoCondPagamento = new CondicaoPagamentoDAO();

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
                    this.InserirContasReceber(conta, transaction);
                }
                foreach (ItensCompra item in venda.listaItem)
                {
                    this.InserirItemVenda(item, transaction);
                }
                transaction.Commit();
                MessageBox.Show("Venda salvar com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Este modelo, serie, nrNota e fornecedor já existe em outra Venda!", "Erro ao salvar a Venda!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void InserirVendaSql(Vendas venda, SqlTransaction transaction)
        {
            SqlCommand comando = this.CreateCommandTransaction(transaction);

            comando.CommandText = @"INSERT INTO vendas (modelo, serie, nrNota, codCliente, codCondPagamento, dtEmissao, situacao, dtCadastro, dtAlteracao, usuario)
                                 VALUES (@modelo, @serie, @nrNota, @codCliente, @codCondPagamento, @dtEmissao, @situacao, @dtCadastro, @dtAlteracao, @usuario)";

            comando.Parameters.AddWithValue("@modelo", venda.modelo);
            comando.Parameters.AddWithValue("@serie", venda.serie);
            comando.Parameters.AddWithValue("@nrNota", venda.nrNota);
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

        private void InserirItemVenda(ItensCompra item, SqlTransaction transaction)
        {
            throw new NotImplementedException();
        }

        private void InserirContasReceber(ContasReceber conta, SqlTransaction transaction)
        {
            throw new NotImplementedException();
        }

    }
}
