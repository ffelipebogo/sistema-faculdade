using EquipMotos.CONTROLLER;
using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace EquipMotos.DAO
{
    class ProdutosServicosDAO : DAO
    {

        ProdutosServicos produtoServico = new ProdutosServicos();
        CtrlCategorias CtrlCategoria = new CtrlCategorias();
        FornecedoresDAO daoForn = new FornecedoresDAO();
        FuncionariosDAO daoFunc = new FuncionariosDAO();

        #region Inserir ProdutosServicos 
        public override void Inserir(object obj)
        {
            {
                SqlConnection conexao = Conecta.CreateConnection();
                try
                {
                    ProdutosServicos proServ = obj as ProdutosServicos;
                    string sql = @"INSERT into produtos (
                                        produto,
                                        unidade,
                                        codCategoria,
                                        codBarra,
                                        qtd,
                                        precoCusto,
                                        precoVenda,
                                        codFornecedor,
                                        codFuncionario,
                                        custoUltCompra,
                                        dtUltCompra,
                                        comissao,
                                        observacoes,
                                        dtCadastro,
                                        dtAlteracao,
                                        usuario,
                                        servico
                                
                                        ) values (@produto, @unidade, @codCategoria, @codBarra, @qtd, @precoCusto, @precoVenda, @codFornecedor, @codFuncionario, @custoUltCompra, @dtUltCompra, @comissao,
                                          @observacoes, @dtCadastro, @dtAlteracao, @usuario, @servico )";


                    SqlCommand comando = new SqlCommand(sql, conexao);

                    if (!proServ.servico)
                    {
                        comando.Parameters.AddWithValue("@produto", proServ.produto);
                        comando.Parameters.AddWithValue("@unidade", proServ.unidade);
                        comando.Parameters.AddWithValue("@codBarra", proServ.codBarra);
                        comando.Parameters.AddWithValue("@codCategoria", proServ.Categoria.codigo);
                        comando.Parameters.AddWithValue("@qtd", proServ.qtd);
                        comando.Parameters.AddWithValue("@precoCusto", proServ.custo);
                        comando.Parameters.AddWithValue("@precoVenda", proServ.precoVenda);

                        comando.Parameters.AddWithValue("@codFornecedor", proServ.Fornecedor.codigo);
                        comando.Parameters.AddWithValue("@codFuncionario", proServ.Funcionario.codigo);

                        comando.Parameters.AddWithValue("@custoUltCompra", proServ.custoUltCompra);
                        comando.Parameters.AddWithValue("@dtUltCompra", proServ.dtUltCompra);
                        comando.Parameters.AddWithValue("@comissao", proServ.comissao);

                        comando.Parameters.AddWithValue("@observacoes", proServ.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", proServ.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", proServ.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", proServ.usuario);
                        comando.Parameters.AddWithValue("@servico", proServ.servico);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@produto", proServ.produto);
                        comando.Parameters.AddWithValue("@unidade", DBNull.Value);
                        comando.Parameters.AddWithValue("@codBarra", DBNull.Value);
                        comando.Parameters.AddWithValue("@codCategoria", proServ.Categoria.codigo);
                        comando.Parameters.AddWithValue("@qtd", DBNull.Value);
                        comando.Parameters.AddWithValue("@precoCusto", proServ.custo);
                        comando.Parameters.AddWithValue("@precoVenda", proServ.precoVenda);

                        comando.Parameters.AddWithValue("@codFuncionario", proServ.Funcionario.codigo);
                        comando.Parameters.AddWithValue("@codFornecedor", DBNull.Value);
                        comando.Parameters.AddWithValue("@custoUltCompra", DBNull.Value);
                        comando.Parameters.AddWithValue("@dtUltCompra", "01/01/1900");
                        comando.Parameters.AddWithValue("@comissao", proServ.comissao);

                        comando.Parameters.AddWithValue("@observacoes", proServ.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", proServ.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", proServ.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", proServ.usuario);
                        comando.Parameters.AddWithValue("@servico", proServ.servico);

                    }
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

        #region PesquisarProdutoServicos
        public override object Pesquisar(string proServ)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(proServ, out int n);
                if (proServ.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM produtos WHERE codigo = @proServ";
                }
                else
                {
                    if (isNumeric)
                    {
                        sql = @"SELECT * FROM produtos WHERE produto like '%'+ @proServ +'%'";
                    }
                    else
                    {
                        sql = @"SELECT * FROM produtos WHERE produto like '%'+ @proServ + '%' ";
                    }
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@proServ", proServ);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                return dtProdutoServico;
            }
        }

        public object Pesquisar(string proServ, List<string> filterID, int isProduto)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(proServ, out int n);

                var filterIDaux = "";
                for (int i = 0; i < filterID.Count; i++)
                {
                    filterIDaux += filterID[i] + (filterID.Count - 1 > i ? ", " : "");
                }

                if (string.IsNullOrEmpty(proServ))
                {
                    proServ = "";
                    sql = $@"SELECT * FROM produtos WHERE 1=1  ";
                }
                else if (proServ.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT * FROM produtos WHERE codigo = @proServ ";
                }
                else
                {
                    if (isNumeric)
                    {
                        sql = @"SELECT * FROM produtos WHERE produto like '%'+ @proServ +'%' ";
                    }
                    else
                    {
                        sql = @"SELECT * FROM produtos WHERE produto like '%'+ @proServ + '%' ";
                    }
                }
                sql += $@" {(isProduto == 3 ? "" : $" AND servico = { isProduto - 1 } ")} 
                        { (filterID == null || filterID.Count == 0 ? "" : $" AND not codigo in ({ filterIDaux}) ") } ";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@proServ", proServ);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                return dtProdutoServico;
            }
        }


        #endregion

        #region Alterar Produto Servico
        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    ProdutosServicos proServ = obj as ProdutosServicos;
                    string sql = @"UPDATE produtos set 
                                produto = @produto,
                                unidade = @unidade,
                                codBarra = @codBarra,
                                codCategoria = @codCategoria, 

                                qtd = @qtd,
                                precoCusto = @precoCusto,
                                precoVenda = @precoVenda,
                               
                                codFornecedor = @codFornecedor,
                                codFuncionario = @codFuncionario,
                                custoUltCompra = @custoUltCompra,
                                dtUltCompra = @dtUltCompra,
                                comissao = @comissao,

                                observacoes = @observacoes,
                                dtCadastro = @dtCadastro,
                                dtAlteracao = @dtAlteracao,
                                usuario = @usuario,
                                servico = @servico

                                WHERE codigo = @codigo";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    if (!proServ.servico)
                    {
                        comando.Parameters.AddWithValue("@produto", proServ.produto);
                        comando.Parameters.AddWithValue("@unidade", proServ.unidade);
                        comando.Parameters.AddWithValue("@codBarra", proServ.codBarra);
                        comando.Parameters.AddWithValue("@codCategoria", proServ.Categoria.codigo);
                        comando.Parameters.AddWithValue("@qtd", proServ.qtd);
                        comando.Parameters.AddWithValue("@precoCusto", proServ.custo);
                        comando.Parameters.AddWithValue("@precoVenda", proServ.precoVenda);

                        comando.Parameters.AddWithValue("@codFornecedor", proServ.Fornecedor.codigo);
                        comando.Parameters.AddWithValue("@codFuncionario", 0);

                        comando.Parameters.AddWithValue("@custoUltCompra", proServ.custoUltCompra);
                        comando.Parameters.AddWithValue("@dtUltCompra", proServ.dtUltCompra);
                        comando.Parameters.AddWithValue("@comissao", proServ.comissao);

                        comando.Parameters.AddWithValue("@observacoes", proServ.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", proServ.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", proServ.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", proServ.usuario);
                        comando.Parameters.AddWithValue("@servico", proServ.servico);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@produto", proServ.produto);
                        comando.Parameters.AddWithValue("@unidade", "");
                        comando.Parameters.AddWithValue("@codBarra", "");
                        comando.Parameters.AddWithValue("@codCategoria", proServ.Categoria.codigo);
                        comando.Parameters.AddWithValue("@qtd", 0);
                        comando.Parameters.AddWithValue("@precoCusto", proServ.custo);
                        comando.Parameters.AddWithValue("@precoVenda", proServ.precoVenda);

                        comando.Parameters.AddWithValue("@codFuncionario", proServ.Funcionario.codigo);
                        comando.Parameters.AddWithValue("@codFornecedor", 0);
                        comando.Parameters.AddWithValue("@custoUltCompra", 0);
                        comando.Parameters.AddWithValue("@dtUltCompra", "01/01/1900");
                        comando.Parameters.AddWithValue("@comissao", proServ.comissao);

                        comando.Parameters.AddWithValue("@observacoes", proServ.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", proServ.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", proServ.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", proServ.usuario);
                        comando.Parameters.AddWithValue("@servico", proServ.servico);

                    }
                    comando.Parameters.AddWithValue("@codigo", proServ.codigo);

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
        public override void Excluir(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"DELETE FROM produtos WHERE codigo = @codigo ";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", id);

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

        #region BuscarProdutoServicoId
        public override object BuscarPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT  produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                                 produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, fornecedores.fornecedor, categorias.categoria, funcionarios.funcionario, 
                                 produtos.precoVenda, produtos.valorUnitario
                                    FROM  produtos INNER JOIN
                                 categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                                 funcionarios ON produtos.codFuncionario = funcionarios.codigo INNER JOIN
                                 fornecedores ON produtos.codFornecedor = fornecedores.codigo
                                WHERE produtos.codigo = @codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codigo", id);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);
                produtoServico = null;
                foreach (DataRow row in dtProdutoServico.Rows)
                {
                    ProdutosServicos proServ = new ProdutosServicos();
                    proServ.servico = Convert.ToBoolean(row["servico"]);
                    if (!proServ.servico)
                    {
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.unidade = Convert.ToString(row["unidade"]);
                        proServ.codBarra = Convert.ToString(row["codBarra"]);

                        proServ.Categoria = CtrlCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.qtd = Convert.ToInt32(row["qtd"]);
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                        proServ.Fornecedor = daoForn.BuscarPorID(Convert.ToInt32(row["codFornecedor"])) as Fornecedores;
                        proServ.custoUltCompra = Convert.ToDecimal(row["custoUltCompra"]);
                        proServ.dtUltCompra = Convert.ToDateTime(row["dtUltCompra"]);
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);
                        this.produtoServico = proServ;
                    }
                    else
                    {
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.Categoria = CtrlCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                        proServ.Funcionario = daoFunc.BuscarPorID(Convert.ToInt32(row["codFuncionario"])) as Funcionarios;
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);

                        this.produtoServico = proServ;
                    }
                }
                return produtoServico;
            }
        }
        #endregion

        #region BuscarServicoId
        public object BuscarServicoPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT  produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                         produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, categorias.categoria, funcionarios.funcionario, 
                         produtos.precoVenda, produtos.valorUnitario
                         FROM            produtos INNER JOIN
                         categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                         funcionarios ON produtos.codFuncionario = funcionarios.codigo
                         
                            WHERE produtos.codigo = @codigo AND produtos.servico = 1 ";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codigo", id);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);
                produtoServico = null;
                foreach (DataRow row in dtProdutoServico.Rows)
                {
                    ProdutosServicos proServ = new ProdutosServicos();
                    proServ.servico = Convert.ToBoolean(row["servico"]);
                    if (!proServ.servico)
                    {
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.unidade = Convert.ToString(row["unidade"]);
                        proServ.codBarra = Convert.ToString(row["codBarra"]);

                        proServ.Categoria = CtrlCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.qtd = Convert.ToInt32(row["qtd"]);
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                        proServ.Fornecedor = daoForn.BuscarPorID(Convert.ToInt32(row["codFornecedor"])) as Fornecedores;
                        proServ.custoUltCompra = Convert.ToDecimal(row["custoUltCompra"]);
                        proServ.dtUltCompra = Convert.ToDateTime(row["dtUltCompra"]);
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);
                        this.produtoServico = proServ;
                    }
                    else
                    {
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.Categoria = CtrlCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                        proServ.Funcionario = daoFunc.BuscarPorID(Convert.ToInt32(row["codFuncionario"])) as Funcionarios;
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);

                        this.produtoServico = proServ;
                    }
                }
                return produtoServico;
            }
        }
        #endregion

        #region BuscarProdutoId
        public object BuscarProdutoPorID(object id)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT        produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                         produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, fornecedores.fornecedor, categorias.categoria, funcionarios.funcionario, 
                         produtos.precoVenda, produtos.valorUnitario
                            FROM            produtos INNER JOIN
                         categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                         funcionarios ON produtos.codFuncionario = funcionarios.codigo INNER JOIN
                         fornecedores ON produtos.codFornecedor = fornecedores.codigo WHERE produtos.codigo = @codigo AND produtos.servico = 0";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codigo", id);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);
                produtoServico = null;
                foreach (DataRow row in dtProdutoServico.Rows)
                {
                    ProdutosServicos proServ = new ProdutosServicos();
                    proServ.servico = Convert.ToBoolean(row["servico"]);
                    if (!proServ.servico)
                    {
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.unidade = Convert.ToString(row["unidade"]);
                        proServ.codBarra = Convert.ToString(row["codBarra"]);

                        proServ.Categoria = CtrlCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.qtd = Convert.ToInt32(row["qtd"]);
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                        proServ.Fornecedor = daoForn.BuscarPorID(Convert.ToInt32(row["codFornecedor"])) as Fornecedores;
                        proServ.custoUltCompra = Convert.ToDecimal(row["custoUltCompra"]);
                        proServ.dtUltCompra = Convert.ToDateTime(row["dtUltCompra"]);
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);
                        this.produtoServico = proServ;
                    }
                    else
                    {
                        proServ.codigo = Convert.ToInt32(row["codigo"]);
                        proServ.produto = Convert.ToString(row["produto"]);
                        proServ.Categoria = CtrlCategoria.BuscarPorID(Convert.ToInt32(row["codCategoria"])) as Categorias;
                        proServ.custo = Convert.ToDecimal(row["precoCusto"]);
                        proServ.precoVenda = Convert.ToDecimal(row["precoVenda"]);

                        proServ.Funcionario = daoFunc.BuscarPorID(Convert.ToInt32(row["codFuncionario"])) as Funcionarios;
                        proServ.comissao = Convert.ToDouble(row["comissao"]);
                        proServ.observacoes = Convert.ToString(row["observacoes"]);
                        proServ.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        proServ.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        proServ.usuario = Convert.ToString(row["usuario"]);

                        this.produtoServico = proServ;
                    }
                }
                return produtoServico;
            }
        }
        #endregion


        #region ListarTodosProdutosServicos
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT        produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                         produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, categorias.categoria, funcionarios.funcionario, 
                         produtos.precoVenda, produtos.valorUnitario
                            FROM            produtos INNER JOIN
                         categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                         funcionarios ON produtos.codFuncionario = funcionarios.codigo;";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                return dtProdutoServico;
            }
        }
        #endregion

        public DataTable ListarTodosProdutos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT        produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                             produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, fornecedores.fornecedor, categorias.categoria, funcionarios.funcionario, 
                             produtos.precoVenda, produtos.valorUnitario
                                FROM            produtos INNER JOIN
                             categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                             funcionarios ON produtos.codFuncionario = funcionarios.codigo INNER JOIN
                             fornecedores ON produtos.codFornecedor = fornecedores.codigo
                                WHERE produtos.servico = 0";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtProdutoServico = new DataTable();

                da.Fill(dtProdutoServico);

                conexao.Close();

                return dtProdutoServico;
            }
        }

        public DataTable ListarTodosServicos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT        produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                             produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, fornecedores.fornecedor, categorias.categoria, funcionarios.funcionario, 
                             produtos.precoVenda, produtos.valorUnitario
                                FROM            produtos INNER JOIN
                             categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                             funcionarios ON produtos.codFuncionario = funcionarios.codigo INNER JOIN
                             fornecedores ON produtos.codFornecedor = fornecedores.codigo
                                WHERE produtos.servico = 1 ";
                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();

                da = new SqlDataAdapter(comando);

                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                conexao.Close();

                return dtProdutoServico;

            }
        }

        #region ListarTodosProdutoServicos por nome
        public DataTable ListarTodosProdutosServicos_porNome(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                ProdutosServicos proServ = obj as ProdutosServicos;
                SqlDataAdapter da;
                string sql = @"SELECT        produtos.codigo, produtos.produto, produtos.unidade, produtos.codBarra, produtos.codCategoria, produtos.qtd, produtos.precoCusto, produtos.codFornecedor, produtos.custoUltCompra, produtos.dtUltCompra, 
                             produtos.comissao, produtos.observacoes, produtos.dtCadastro, produtos.dtAlteracao, produtos.usuario, produtos.servico, produtos.codFuncionario, fornecedores.fornecedor, categorias.categoria, funcionarios.funcionario, 
                             produtos.precoVenda, produtos.valorUnitario
                                FROM            produtos INNER JOIN
                             categorias ON produtos.codCategoria = categorias.codigo INNER JOIN
                             funcionarios ON produtos.codFuncionario = funcionarios.codigo INNER JOIN
                             fornecedores ON produtos.codFornecedor = fornecedores.codigo
                               WHERE produtos.nome = @nome";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", proServ.produto);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtProdutoServico = new DataTable();
                da.Fill(dtProdutoServico);

                return dtProdutoServico;
            }
        }
        #endregion
    }
}
