using System.Data;
using System.Windows.Forms;
using EquipMotos.MODEL;
using System.Data.SqlClient;

using System;

namespace EquipMotos.DAO
{
    public class FornecedoresDAO: DAO
    {
        CidadesDAO daoCidade = new CidadesDAO();
        CondicaoPagamentoDAO daoCondPagamento = new CondicaoPagamentoDAO();
        private Fornecedores fornecedor;
        SqlCommand comando = null;

        #region InserirFornecedor
        public override void Inserir(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    Fornecedores forn = obj as Fornecedores;
                    string sql = @"INSERT INTO fornecedores (
                                            fornecedor, nomeFantasia, dtFundacao, sexo, cpf, rg, cnpj, ie, email, telefone, celular, contato, site, endereco, complemento, numero,
                                            bairro, cep, codCidade, codCondPagamento, limiteCredito, observacoes, dtCadastro, dtAlteracao, usuario, fisico )
                                    VALUES (
                                            @fornecedor, @nomeFantasia, @dtFundacao, @sexo, @cpf, @rg, @cnpj, @ie, @email, @telefone, @celular, @contato, 
                                            @site, @endereco, @complemento, @numero, @bairro, @cep, @codCidade, @codCondPagamento, @limiteCredito, @observacoes, 
                                            @dtCadastro, @dtAlteracao, @usuario, @fisico )";
                    comando = null;
                    comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@fornecedor", forn.fornecedor);
                    comando.Parameters.AddWithValue("@nomeFantasia", forn.nomeFantasia);
                    comando.Parameters.AddWithValue("@dtFundacao", forn.dtFundacao);
                    comando.Parameters.AddWithValue("@sexo", forn.sexo);
                    comando.Parameters.AddWithValue("@cpf", forn.cpf);
                    comando.Parameters.AddWithValue("@rg", forn.rg);
                    comando.Parameters.AddWithValue("@cnpj", forn.cnpj);
                    comando.Parameters.AddWithValue("@ie", forn.ie);
                    comando.Parameters.AddWithValue("@email", forn.email);
                    comando.Parameters.AddWithValue("@telefone", forn.telefone);
                    comando.Parameters.AddWithValue("@celular", forn.celular);
                    comando.Parameters.AddWithValue("@contato", forn.contato);
                    comando.Parameters.AddWithValue("@site", forn.site);
                    comando.Parameters.AddWithValue("@endereco", forn.endereco);
                    comando.Parameters.AddWithValue("@complemento", forn.complemento);
                    comando.Parameters.AddWithValue("@numero", forn.numero);
                    comando.Parameters.AddWithValue("@bairro", forn.bairro);
                    comando.Parameters.AddWithValue("@cep", forn.cep);
                    comando.Parameters.AddWithValue("@codCidade", forn.Cidade.codigo);
                    if(forn.CondPagamento != null)
                    {
                        comando.Parameters.AddWithValue("@codCondPagamento", forn.CondPagamento.codigo);
                    }
                    else
                    { 
                        comando.Parameters.AddWithValue("@codCondPagamento", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@limiteCredito", forn.limiteCredito);
                    comando.Parameters.AddWithValue("@observacoes", forn.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", forn.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", forn.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", forn.usuario);
                    comando.Parameters.AddWithValue("@fisico", forn.fisico);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    comando.Transaction.Rollback();
                    conexao.Close();
                }

                finally
                {
                    conexao.Close();
                }
            }
        }
        #endregion

        #region AlterarFuncionario
        public override void Editar(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    Fornecedores forn = obj as Fornecedores;
                    string sql = @"UPDATE fornecedores set 
                                fornecedor = @fornecedor,
                                nomeFantasia = @nomeFantasia,
                                dtFundacao = @dtFundacao,
                                
                                email = @email,
                                telefone = @telefone,
                                celular = @celular,
                                contato = @contato,

                                endereco = @endereco,
                                complemento = @complemento,
                                numero = @numero,
                                bairro = @bairro,
                                cep = @cep,
                                codCidade = @codCidade,

                                codCondPagamento = @codCondPagamento,
                                limiteCredito = @limiteCredito,
                                observacoes = @observacoes,
                                dtCadastro = @dtCadastro,
                                dtAlteracao = @dtAlteracao,
                                usuario = @usuario,
                                fisico = @fisico, ";

                    string whereFisico = "sexo = @sexo, cpf = @cpf, rg = @rg where codigo = @codigo";
                    string whereJuridico = "cnpj = @cnpj, ie = @ie where codigo = @codigo";
                    comando = null;
                    if (forn.fisico == true)
                    {
                        comando = new SqlCommand(sql+whereFisico, conexao);
                    }
                    else
                    {
                        comando = new SqlCommand(sql+whereJuridico, conexao);
                    }
                    comando.Parameters.AddWithValue("@fornecedor", forn.fornecedor);
                    comando.Parameters.AddWithValue("@nomeFantasia", forn.nomeFantasia);
                    comando.Parameters.AddWithValue("@dtFundacao", forn.dtFundacao);
                    if(forn.fisico == true)
                    {
                        comando.Parameters.AddWithValue("@cpf", forn.cpf);
                        comando.Parameters.AddWithValue("@rg", forn.rg);
                        comando.Parameters.AddWithValue("@sexo", forn.sexo);
                    } else
                    {
                        comando.Parameters.AddWithValue("@cnpj", forn.cnpj);
                        comando.Parameters.AddWithValue("@ie", forn.ie);
                    }
                    comando.Parameters.AddWithValue("@email", forn.email);
                    comando.Parameters.AddWithValue("@telefone", forn.telefone);
                    comando.Parameters.AddWithValue("@celular", forn.celular);
                    comando.Parameters.AddWithValue("@contato", forn.contato);
                    comando.Parameters.AddWithValue("@endereco", forn.endereco);
                    comando.Parameters.AddWithValue("@complemento", forn.complemento);
                    comando.Parameters.AddWithValue("@numero", forn.numero);
                    comando.Parameters.AddWithValue("@bairro", forn.bairro);
                    comando.Parameters.AddWithValue("@cep", forn.cep);
                    comando.Parameters.AddWithValue("@codCidade", forn.Cidade.codigo);
                    if (forn.CondPagamento != null)
                    {
                        comando.Parameters.AddWithValue("@codCondPagamento", forn.CondPagamento.codigo);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@codCondPagamento", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@limiteCredito", forn.limiteCredito);
                    comando.Parameters.AddWithValue("@observacoes", forn.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", forn.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", forn.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", forn.usuario);
                    comando.Parameters.AddWithValue("@fisico", forn.fisico);
                    comando.Parameters.AddWithValue("@codigo", forn.codigo);
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

        #region ExcluirFornecedor
        public override void Excluir(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"DELETE FROM fornecedores WHERE (codigo = @codigo)";
                    comando = new SqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    comando.Transaction.Rollback();
                    conexao.Close();
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        #endregion

        #region BuscarFornecedor id
        public override object BuscarPorID(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT        fornecedores.codigo, fornecedores.fornecedor, fornecedores.nomeFantasia, fornecedores.dtFundacao, fornecedores.sexo, fornecedores.endereco, fornecedores.numero, fornecedores.complemento, fornecedores.bairro, 
                         fornecedores.cep, fornecedores.codCidade, fornecedores.telefone, fornecedores.celular, fornecedores.email, fornecedores.contato, fornecedores.site, fornecedores.cnpj, fornecedores.ie, fornecedores.limiteCredito, 
                         fornecedores.observacoes, fornecedores.dtCadastro, fornecedores.dtAlteracao, fornecedores.usuario, fornecedores.codCondPagamento, fornecedores.fisico, fornecedores.cpf, fornecedores.rg, condicaoPagamento.condicao, 
                         cidades.cidade
                            FROM            fornecedores INNER JOIN
                         condicaoPagamento ON fornecedores.codCondPagamento = condicaoPagamento.codigo INNER JOIN
                         cidades ON fornecedores.codCidade = cidades.codigo 
                            WHERE fornecedores.codigo = @codigo";
                comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@codigo", codigo);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtFornecedor = new DataTable();
                da.Fill(dtFornecedor);
                fornecedor = null;
                foreach (DataRow row in dtFornecedor.Rows)
                {
                    Fornecedores forn = new Fornecedores();
                    forn.codigo = Convert.ToInt32(row["codigo"]);
                    forn.fornecedor = Convert.ToString(row["fornecedor"]);
                    forn.nomeFantasia = Convert.ToString(row["nomeFantasia"]);
                    forn.dtFundacao = Convert.ToDateTime(row["dtFundacao"]);
                    forn.sexo = Convert.ToChar(row["sexo"]);
                    forn.endereco = Convert.ToString(row["endereco"]);
                    forn.numero = Convert.ToString(row["numero"]);
                    forn.complemento = Convert.ToString(row["complemento"]);
                    forn.bairro = Convert.ToString(row["bairro"]);
                    forn.cep = Convert.ToString(row["cep"]);
                    forn.Cidade = daoCidade.BuscarPorID(Convert.ToInt32(row["codCidade"])) as Cidades;
                    forn.telefone = Convert.ToString(row["telefone"]);
                    forn.celular = Convert.ToString(row["celular"]);
                    forn.contato = Convert.ToString(row["contato"]);
                    forn.email = Convert.ToString(row["email"]);
                    forn.site = Convert.ToString(row["site"]);
                    forn.cpf = Convert.ToString(row["cpf"]);
                    forn.rg = Convert.ToString(row["rg"]);
                    forn.cnpj = Convert.ToString(row["cnpj"]);
                    forn.ie = Convert.ToString(row["ie"]);
                    
                    if(Convert.ToInt32("0" + row["codCondPagamento"]) != 0)
                    {
                        forn.CondPagamento = daoCondPagamento.BuscarPorID(Convert.ToInt32(row["codCondPagamento"])) as CondicaoPagamentos;
                    }
                    forn.limiteCredito = Convert.ToDouble(row["limiteCredito"]);
                    forn.observacoes = Convert.ToString(row["observacoes"]);
                    forn.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    forn.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    forn.usuario = Convert.ToString(row["usuario"]);
                    forn.fisico = Convert.ToBoolean(row["fisico"]);
                    this.fornecedor = forn;
                }
                conexao.Close();
                return fornecedor;
            }
            
        }
        #endregion

        #region ListarTodosFornecedores
        public override DataTable ListarTodos()
        {
            // Instanciando a conexão
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT        fornecedores.codigo, fornecedores.fornecedor, fornecedores.nomeFantasia, fornecedores.dtFundacao, fornecedores.sexo, fornecedores.endereco, fornecedores.numero, fornecedores.complemento, fornecedores.bairro, 
                         fornecedores.cep, fornecedores.codCidade, fornecedores.telefone, fornecedores.celular, fornecedores.email, fornecedores.contato, fornecedores.site, fornecedores.cnpj, fornecedores.ie, fornecedores.limiteCredito, 
                         fornecedores.observacoes, fornecedores.dtCadastro, fornecedores.dtAlteracao, fornecedores.usuario, fornecedores.codCondPagamento, fornecedores.fisico, fornecedores.cpf, fornecedores.rg, condicaoPagamento.condicao, 
                         cidades.cidade
                            FROM            fornecedores INNER JOIN
                         condicaoPagamento ON fornecedores.codCondPagamento = condicaoPagamento.codigo INNER JOIN
                         cidades ON fornecedores.codCidade = cidades.codigo";
                SqlCommand comando = new SqlCommand(sql, conexao);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtFornecedor = new DataTable();
                da.Fill(dtFornecedor);
                conexao.Close();
                return dtFornecedor;
               
            }
        }
        #endregion

        #region ListarTodosFornecedores por nome
        public DataTable ListarTodosFornecedores_porNome(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Fornecedores forn = obj as Fornecedores;
                SqlDataAdapter da;
                    string sql = @"SELECT        fornecedores.codigo, fornecedores.fornecedor, fornecedores.nomeFantasia, fornecedores.dtFundacao, fornecedores.sexo, fornecedores.endereco, fornecedores.numero, fornecedores.complemento, fornecedores.bairro, 
                             fornecedores.cep, fornecedores.codCidade, fornecedores.telefone, fornecedores.celular, fornecedores.email, fornecedores.contato, fornecedores.site, fornecedores.cnpj, fornecedores.ie, fornecedores.limiteCredito, 
                             fornecedores.observacoes, fornecedores.dtCadastro, fornecedores.dtAlteracao, fornecedores.usuario, fornecedores.codCondPagamento, fornecedores.fisico, fornecedores.cpf, fornecedores.rg, condicaoPagamento.condicao, 
                             cidades.cidade
                                FROM            fornecedores INNER JOIN
                             condicaoPagamento ON fornecedores.codCondPagamento = condicaoPagamento.codigo INNER JOIN
                             cidades ON fornecedores.codCidade = cidades.codigo
                                WHERE fornecedores.fornecedor like '%' + @nome + '%'";
                
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", forn.fornecedor);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtFornecedor = new DataTable();
                da.Fill(dtFornecedor);

                return dtFornecedor;
            }
        }
        #endregion

        #region Pesquisar Fornecedor por Nome
        public override object Pesquisar(string forn)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(forn, out int n);
                if (forn.Length <= 4 && isNumeric)
                {
                    sql = @"SELECT        fornecedores.codigo, fornecedores.fornecedor, fornecedores.nomeFantasia, fornecedores.dtFundacao, fornecedores.sexo, fornecedores.endereco, fornecedores.numero, fornecedores.complemento, fornecedores.bairro, 
                             fornecedores.cep, fornecedores.codCidade, fornecedores.telefone, fornecedores.celular, fornecedores.email, fornecedores.contato, fornecedores.site, fornecedores.cnpj, fornecedores.ie, fornecedores.limiteCredito, 
                             fornecedores.observacoes, fornecedores.dtCadastro, fornecedores.dtAlteracao, fornecedores.usuario, fornecedores.codCondPagamento, fornecedores.fisico, fornecedores.cpf, fornecedores.rg, condicaoPagamento.condicao, 
                             cidades.cidade
                                FROM            fornecedores INNER JOIN
                             condicaoPagamento ON fornecedores.codCondPagamento = condicaoPagamento.codigo INNER JOIN
                             cidades ON fornecedores.codCidade = cidades.codigo
                                WHERE fornecedores.codigo = @forn";
                }
                else
                {
                    sql = @"SELECT        fornecedores.codigo, fornecedores.fornecedor, fornecedores.nomeFantasia, fornecedores.dtFundacao, fornecedores.sexo, fornecedores.endereco, fornecedores.numero, fornecedores.complemento, fornecedores.bairro, 
                             fornecedores.cep, fornecedores.codCidade, fornecedores.telefone, fornecedores.celular, fornecedores.email, fornecedores.contato, fornecedores.site, fornecedores.cnpj, fornecedores.ie, fornecedores.limiteCredito, 
                             fornecedores.observacoes, fornecedores.dtCadastro, fornecedores.dtAlteracao, fornecedores.usuario, fornecedores.codCondPagamento, fornecedores.fisico, fornecedores.cpf, fornecedores.rg, condicaoPagamento.condicao, 
                             cidades.cidade
                                FROM            fornecedores INNER JOIN
                             condicaoPagamento ON fornecedores.codCondPagamento = condicaoPagamento.codigo INNER JOIN
                             cidades ON fornecedores.codCidade = cidades.codigo
                                WHERE fornecedores.fornecedor like '%'+ @forn + '%' ";
                }
                comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@forn", forn);
                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtFornecedor = new DataTable();
                da.Fill(dtFornecedor);

                conexao.Close();
                return dtFornecedor;
            }
        }
        #endregion
    }
}
