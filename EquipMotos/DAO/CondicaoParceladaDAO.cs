using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.DAO
{
    class CondicaoParceladaDAO
    {

        public void InserirCondicaoParcela(CondicaoParcelada condPar)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                string sql = @"INSERT INTO parcelas ( nrParcela, nrDia, porcentagem, codFormaPagamento , codCondPagamento, dtCadastro, dtAlteracao, usuario) 
                                VALUES ( @nrParcela, @nrDia, @porcentagem,  @codFormaPagamento, @codCondPagamento, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nrParcela", condPar.nrParcela);
                comando.Parameters.AddWithValue("@nrDia", condPar.nrDia);
                comando.Parameters.AddWithValue("@porcentagem", condPar.porcentagem);
                comando.Parameters.AddWithValue("@codFormaPagamento", condPar.formaPagamento.codigo);
                comando.Parameters.AddWithValue("@codCondPagamento", condPar.condPagamento.codigo);
                comando.Parameters.AddWithValue("@dtCadastro", condPar.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", condPar.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", condPar.usuario);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }



    }
}
