using System.Configuration;
using System.Data.SqlClient;


namespace EquipMotos.MODEL
{
    class Conecta
    {

        //metodo para conectar o banco de dados
        public static SqlConnection CreateConnection()
        {
            SqlConnection conexao = new SqlConnection();
            //acessando a string de conexão
            conexao.ConnectionString = "Server=localhost;Database=SistemaMoto2;Trusted_Connection=True;";
                
           // ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString;
            

            return conexao;
        }
    }
}
