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
    public class FormaPagamentoDAO: DAO
    {

        FormaPagamentos formaPagamento;
        public override void Inserir(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                FormaPagamentos formaPag = obj as FormaPagamentos;
                string sql = @"INSERT INTO formaPagamento (forma, dtCadastro, dtAlteracao, usuario) values (@forma, @dtCadastro, @dtAlteracao, @usuario)";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@forma", formaPag.forma);
                comando.Parameters.AddWithValue("@dtCadastro", formaPag.dtCadastro);
                comando.Parameters.AddWithValue("@dtAlteracao", formaPag.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", formaPag.usuario);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }

        }

        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                FormaPagamentos formaPag = obj as FormaPagamentos;
                string sql = @"UPDATE formaPagamento SET forma = @forma,  dtAlteracao = @dtAlteracao, usuario = @usuario WHERE codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@forma", formaPag.forma);
                comando.Parameters.AddWithValue("@dtAlteracao", formaPag.dtAlteracao);
                comando.Parameters.AddWithValue("@usuario", formaPag.usuario);
                comando.Parameters.AddWithValue("@codigo", formaPag.codigo);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void ExcluirFormaPagamento(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"DELETE FROM formaPagamento WHERE codigo = @codigo";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Forma de Pagamento foi excluida!");
                }
                catch
                {
                    MessageBox.Show("Não foi possivel excluir a forma de pagamento!", "Forma está sendo utilizada em outro cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                }
            }
        }

        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM formaPagamento";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtFormaPagamentos = new DataTable();
                da.Fill(dtFormaPagamentos);

                return dtFormaPagamentos;
            }

        }

        public override object BuscarPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM formaPagamento WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtFormaPag = new DataTable();
                da.Fill(dtFormaPag);
                formaPagamento = null;
                foreach (DataRow row in dtFormaPag.Rows)
                {
                    FormaPagamentos condPag = new FormaPagamentos();

                    condPag.codigo = Convert.ToInt32(row["codigo"]);
                    condPag.forma = Convert.ToString(row["forma"]);
                    condPag.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    condPag.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    condPag.usuario = Convert.ToString(row["usuario"]);

                    this.formaPagamento = condPag;
                }
                return formaPagamento;
            }
        }

        public override object Pesquisar(string form)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(form, out int n);
                if (form.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM formaPagamento WHERE codigo = @form";
                }
                else
                {
                    sql = @"SELECT * FROM formaPagamento WHERE forma like '%'+ @form + '%' ";
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@form", form);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtForma = new DataTable();
                da.Fill(dtForma);

                return dtForma;
            }
        }
    }
}
