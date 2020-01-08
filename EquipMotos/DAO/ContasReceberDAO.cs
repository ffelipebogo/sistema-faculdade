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
    public class ContasReceberDAO : DAO
    {
        ContasReceber conta = new ContasReceber();
        ClientesDAO DaoCliente = new ClientesDAO();
        FormaPagamentoDAO DaoFormaPagamento = new FormaPagamentoDAO();
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaReceber";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtContaReceber = new DataTable();
                da.Fill(dtContaReceber);
                conexao.Close();
                return dtContaReceber;
            }
        }

        public DataTable ListaPorCliente(int codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaReceber where codCliente = @codCliente";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codCliente", codigo);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtContaReceber = new DataTable();
                da.Fill(dtContaReceber);
                conexao.Close();
                return dtContaReceber;
            }
        }

        public override object Pesquisar(string conta)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(conta, out int n);
                if (conta.Length > 1 )
                {
                    sql = @"SELECT * FROM contaReceber WHERE modelo = @conta or serie = @conta or nrNota = @conta";
                }
                else
                {
                    sql = "SELECT * FROM contaReceber";
                }

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@conta", conta);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtContaPAgar = new DataTable();
                da.Fill(dtContaPAgar);

                return dtContaPAgar;
            }
        }

        public object BuscarContasReceber_porID(object modelo, object serie, object nrNota, object codCliente, object nrParcela)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM contaReceber WHERE modelo = @modelo 
                                                        AND serie = @serie 
                                                        AND nrNota = @nrNota 
                                                        AND codCliente = @codCliente   
                                                        AND nrParcela = @nrParcela";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@codCliente", codCliente);
                comando.Parameters.AddWithValue("@nrParcela", nrParcela);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCompra = new DataTable();
                da.Fill(dtCompra);

                foreach (DataRow row in dtCompra.Rows)
                {
                    ContasReceber contaReceber = new ContasReceber();

                    contaReceber.modelo = Convert.ToString(row["modelo"]);
                    contaReceber.serie = Convert.ToString(row["serie"]);
                    contaReceber.nrNota = Convert.ToString(row["nrNota"]);
                    contaReceber.cliente = DaoCliente.BuscarPorID(Convert.ToInt64(row["codCliente"])) as Clientes;
                    contaReceber.formaPagamento = DaoFormaPagamento.BuscarPorID(Convert.ToInt64(row["codFormaPagamento"])) as FormaPagamentos;
                    contaReceber.nrParcela = Convert.ToInt32(row["nrParcela"]);
                    contaReceber.dtVencimento = Convert.ToDateTime(row["dtVencimento"]);
                    contaReceber.vlrParcela = Convert.ToDouble(row["valorParcela"]);
                    contaReceber.dtEmissao = Convert.ToDateTime(row["dtEmissao"]);
                    contaReceber.observacoes = Convert.ToString(row["observacoes"]);
                    contaReceber.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    contaReceber.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    contaReceber.pago = Convert.ToBoolean(row["recebido"]);
                    contaReceber.usuario = Convert.ToString(row["usuario"]);
                    conta = contaReceber;
                }
                return conta;
            }
        }

        public void MarcarPago(object modelo, object serie, object nrNota, object codCliente, object nrParcela)
        {
            conexao.Open();
            SqlTransaction transaction = conexao.BeginTransaction("SampleTransacion");
            try
            {
                SqlCommand comando = this.CreateCommandTransaction(transaction);

                comando.CommandText = @"UPDATE contaReceber
                                         SET recebido = 1  
                                        WHERE modelo = @modelo and serie = @serie and nrNota = @nrNota and nrParcela = @nrParcela and codCliente = @codCliente ;";

                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@serie", serie);
                comando.Parameters.AddWithValue("@nrNota", nrNota);
                comando.Parameters.AddWithValue("@nrParcela", nrParcela);
                comando.Parameters.AddWithValue("@codCliente", codCliente);
                comando.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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