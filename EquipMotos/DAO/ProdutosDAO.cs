using EquipMotos.CONTROLLER;
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
    class ProdutosDAO: DAO
    {
        Produtos Produto = new Produtos();
        CategoriasDAO DaoCategoria = new CategoriasDAO();
        FornecedoresDAO DaoForn = new FornecedoresDAO();

        #region Inserir Produtos
        public override void Inserir(object obj)
        {
            {
                SqlConnection conexao = Conecta.CreateConnection();
                try
                {
                    Produtos produto = obj as Produtos;
                    string sql = @"INSERT into produtos ( produto, unidade, codCategoria,codBarra, qtd, precoCusto, precoVenda, codFornecedor,  custoUltCompra, dtUltCompra, comissao, observacoes, dtCadastro, dtAlteracao, usuario,
                                        ) values (@produto, @unidade, @codCategoria, @codBarra, @qtd, @precoCusto, @precoVenda, @codFornecedor,  @custoUltCompra, @dtUltCompra, @comissao,
                                          @observacoes, @dtCadastro, @dtAlteracao, @usuario )";


                    SqlCommand comando = new SqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@produto", produto.produto);
                        comando.Parameters.AddWithValue("@unidade", produto.unidade);
                        comando.Parameters.AddWithValue("@codBarra", produto.codBarra);
                        comando.Parameters.AddWithValue("@codCategoria", produto.Categoria.codigo);
                        comando.Parameters.AddWithValue("@qtd", produto.qtd);
                        comando.Parameters.AddWithValue("@precoCusto", produto.custo);
                        comando.Parameters.AddWithValue("@precoVenda", produto.precoVenda);
                        comando.Parameters.AddWithValue("@codFornecedor", produto.Fornecedor.codigo);

                        comando.Parameters.AddWithValue("@custoUltCompra", produto.custoUltCompra);
                        comando.Parameters.AddWithValue("@dtUltCompra", produto.dtUltCompra);
                        comando.Parameters.AddWithValue("@comissao", produto.comissao);

                        comando.Parameters.AddWithValue("@observacoes", produto.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", produto.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", produto.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", produto.usuario);
                   
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
        #endregion

        #region PesquisarProduto
        public override object Pesquisar(string produto)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(produto, out int n);
                if (produto.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT  produtos.*,  fornecedores.fornecedor, categorias.categoria 
                            FROM	produtos INNER JOIN
		                            categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
		                            fornecedores ON produtos.codFornecedor = fornecedores.codigo
                            WHERE codigo = @produto";
                }
                else
                {
                    if (isNumeric)
                    {
                        sql = @"SELECT  produtos.*,  fornecedores.fornecedor, categorias.categoria 
                                FROM	produtos INNER JOIN
		                                categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
		                                fornecedores ON produtos.codFornecedor = fornecedores.codigo WHERE produto like '%'+ @produto +'%'";
                    }
                    else
                    {
                        sql = @"SELECT  produtos.*,  fornecedores.fornecedor, categorias.categoria 
                                FROM	produtos INNER JOIN
		                                categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
		                                fornecedores ON produtos.codFornecedor = fornecedores.codigo  WHERE produto like '%'+ @produto + '%' ";
                    }
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@produto", produto);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);

                return dtProduto;
            }
        }

        #endregion

        #region Alterar Produto 
        public override void Editar(object produto)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    Produtos prod = produto as Produtos;
                    string sql = @"UPDATE produtos set 
                                produto = @produto,
                                unidade = @unidade,
                                codBarra = @codBarra,
                                codCategoria = @codCategoria, 

                                qtd = @qtd,
                                precoCusto = @precoCusto,
                                precoVenda = @precoVenda,
                               
                                codFornecedor = @codFornecedor,
                                custoUltCompra = @custoUltCompra,
                                dtUltCompra = @dtUltCompra,
                                comissao = @comissao,

                                observacoes = @observacoes,
                                dtCadastro = @dtCadastro,
                                dtAlteracao = @dtAlteracao,
                                usuario = @usuario,

                                WHERE codigo = @codigo";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@produto", prod.produto);
                        comando.Parameters.AddWithValue("@unidade", prod.unidade);
                        comando.Parameters.AddWithValue("@codBarra", prod.codBarra);
                        comando.Parameters.AddWithValue("@codCategoria", prod.Categoria.codigo);
                        comando.Parameters.AddWithValue("@qtd", prod.qtd);
                        comando.Parameters.AddWithValue("@precoCusto", prod.custo);
                        comando.Parameters.AddWithValue("@precoVenda", prod.precoVenda);

                        comando.Parameters.AddWithValue("@codFornecedor", prod.Fornecedor.codigo);

                        comando.Parameters.AddWithValue("@custoUltCompra", prod.custoUltCompra);
                        comando.Parameters.AddWithValue("@dtUltCompra", prod.dtUltCompra);
                        comando.Parameters.AddWithValue("@comissao", prod.comissao);

                        comando.Parameters.AddWithValue("@observacoes", prod.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", prod.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", prod.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", prod.usuario);
                  
                        comando.Parameters.AddWithValue("@codigo", prod.codigo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        #endregion

        #region Excluir Produto Servico
        public override void Excluir(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"DELETE FROM produtos WHERE codigo = @codigo ";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        #endregion

        #region BuscarProdutoId
        public override object BuscarPorID(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT  produtos.*,  fornecedores.fornecedor, categorias.categoria 
                                FROM	produtos INNER JOIN
		                                categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
		                                fornecedores ON produtos.codFornecedor = fornecedores.codigo
                                WHERE produtos.codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codigo", codigo);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                foreach (DataRow row in dtProdutoServico.Rows)
                {
                        var proServ = new Produtos();
                    
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.unidade = Convert.ToString(row["unidade"]);
                        proServ.codBarra = Convert.ToString(row["codBarra"]);
                        proServ.Categoria = DaoCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.qtd = Convert.ToInt32(row["qtd"]);
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);
                        proServ.Fornecedor = DaoForn.BuscarPorID(Convert.ToInt32(row["codFornecedor"])) as Fornecedores;
                        proServ.custoUltCompra = Convert.ToDecimal(row["custoUltCompra"]);
                        proServ.dtUltCompra = Convert.ToDateTime(row["dtUltCompra"]);
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);
                        this.Produto = proServ;
                   
                }
                return Produto;
            }
        }
        #endregion

        #region ListarTodos
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT  produtos.*,  fornecedores.fornecedor, categorias.categoria 
                                FROM	produtos INNER JOIN
		                                categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
		                                fornecedores ON produtos.codFornecedor = fornecedores.codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtProduto = new DataTable();

                da.Fill(dtProduto);

                conexao.Close();

                return dtProduto;
            }
        }
        #endregion

        #region ListarTodosProdutoServicos por nome
        public DataTable ListarProdutos_porNome(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Produtos produto = obj as Produtos;
                SqlDataAdapter da;
                string sql = @"SELECT  produtos.*,  fornecedores.fornecedor, categorias.categoria 
                                FROM	produtos INNER JOIN
		                                categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
		                                fornecedores ON produtos.codFornecedor = fornecedores.codigo
                               WHERE produtos.nome = @nome";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", produto.produto);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);

                return dtProduto;
            }
        }
        #endregion
    }
}
