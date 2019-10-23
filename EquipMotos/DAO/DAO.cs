using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.DAO
{
   public  class DAO
    {
        public SqlConnection conexao { get; }

        public DAO()
        {
            this.conexao = Conecta.CreateConnection();
        }

        public DAO(SqlConnection conexao)
        {
            this.conexao = conexao;

        }


        public virtual void Inserir(Object obj)
        {

        }

        public virtual void Editar(Object obj)
        {

        }

        public virtual void Excluir(Object obj)
        {

        }

        public virtual object BuscarPorID(Object obj)
        {
            return null;
        }

        public virtual DataTable ListarTodos()
        {
            return null;
        }

        public virtual object Pesquisar(string obj)
        {
            return null;
        }

        protected SqlCommand CreateCommandTransaction(SqlTransaction transaction)
        {
            SqlCommand comando = this.conexao.CreateCommand();

            comando.Transaction = transaction;

            return comando;
        }
    }
}
