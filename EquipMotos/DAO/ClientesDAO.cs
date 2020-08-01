using EquipMotos.MODEL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;

namespace EquipMotos.DAO
{
    public class ClientesDAO : DAO
    {
        Clientes cliente = new Clientes();
        CidadesDAO daoCid = new CidadesDAO();
        Cidades cidade = new Cidades();
        CondicaoPagamentoDAO daoCondPag = new CondicaoPagamentoDAO();

        public ClientesDAO() : base()
        {
        }

        public ClientesDAO(SqlConnection conexao) : base(conexao)
        {
        }

        #region InserirCliente
        public override void Inserir(object obj)
        {            
            SqlConnection conexao = Conecta.CreateConnection();
            try
            {
                Clientes cli = obj as Clientes;

                string sql = @"INSERT into clientes (
                                    cliente, apelido, dtNascimento, sexo, cnpj, ie,
                                    cpf, rg, email, telefone, celular, contato, site, endereco, complemento, numero, bairro, cep, codCidade,
                                    codCondPagamento, limiteCredito, observacoes, dtCadastro, dtAlteracao, usuario, juridico, estrangeiro
                            ) values (@cliente, @apelido, @dtNascimento, @sexo, @cnpj, @ie, @cpf, @rg, @email, @telefone, @celular, @contato, @site, @endereco, @complemento,
                                        @numero, @bairro, @cep, @codCidade, @codCondPagamento, @limiteCredito, @observacoes, @dtCadastro, @dtAlteracao, @usuario, @juridico, @estrangeiro )";
                        SqlCommand comando = new SqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@cliente", cli.cliente);
                        comando.Parameters.AddWithValue("@apelido", cli.apelido);
                        comando.Parameters.AddWithValue("@dtNascimento", cli.dtNascimento);
                        comando.Parameters.AddWithValue("@sexo", cli.sexo);
                        comando.Parameters.AddWithValue("@cnpj", cli.cnpj);
                        comando.Parameters.AddWithValue("@cpf", cli.cpf);
                        comando.Parameters.AddWithValue("@rg", cli.rg);
                        comando.Parameters.AddWithValue("@ie", cli.ie);
                        comando.Parameters.AddWithValue("@email", cli.email);
                        comando.Parameters.AddWithValue("@telefone", cli.telefone);
                        comando.Parameters.AddWithValue("@celular", cli.celular);
                        comando.Parameters.AddWithValue("@contato", cli.contato);
                        comando.Parameters.AddWithValue("@site", cli.site);
                        comando.Parameters.AddWithValue("@endereco", cli.endereco);
                        comando.Parameters.AddWithValue("@complemento", cli.complemento);
                        
                        comando.Parameters.AddWithValue("@numero", cli.numero);
                
                        comando.Parameters.AddWithValue("@bairro", cli.bairro);
                        comando.Parameters.AddWithValue("@cep", cli.cep);
                        
                        comando.Parameters.AddWithValue("@codCidade", cli.Cidade.codigo);
                        if (cli.CondPagamento.codigo != 0)
                        {
                            comando.Parameters.AddWithValue("@codCondPagamento", cli.CondPagamento.codigo);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@codCondPagamento", DBNull.Value);
                        }
                        comando.Parameters.AddWithValue("@limiteCredito", cli.limiteCredito);
                        comando.Parameters.AddWithValue("@observacoes", cli.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", cli.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", cli.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", cli.usuario);
                        comando.Parameters.AddWithValue("@juridico", cli.juridico);
                        comando.Parameters.AddWithValue("@estrangeiro", cli.estrangeiro);

                        conexao.Open();
                        comando.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Erro ao cadastrar o Cliente!");
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion

        public override object Pesquisar(string cli)
        {
            SqlConnection conexao = Conecta.CreateConnection();
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(cli, out int n);
                if (cli.Length <= 4 && isNumeric)
                {
                        int id = Convert.ToInt32(cli);
                        sql = @"SELECT * FROM clientes WHERE codigo = @cli";
                }
                else
                {
                    if (isNumeric)
                    {
                        string cpf = cli;
                        sql = @"SELECT * FROM clientes WHERE cpf like '%'+ @cli +'%'";
                    }
                    else
                    {
                        string cliente = cli;
                        sql = @"SELECT * FROM clientes WHERE cliente like '%'+ @cli + '%' ";

                    }
                }
                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cli", cli);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);
                return dtCliente;
            }
        }

        public object PesquisaLogin(string cpf, string senha)
        {
            SqlConnection conexao = Conecta.CreateConnection();
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(cpf, out int n);
             
                if (!isNumeric)
                {
                    sql = @"SELECT * FROM clientes WHERE cpf = @cli and cpf = @senha";
                }
                else
                {
                    return null;
                }

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cli", cpf);
                comando.Parameters.AddWithValue("@senha", senha);
                conexao.Open();
                da = new SqlDataAdapter(comando);
                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);

                if(dtCliente.Rows.Count > 0)
                {
                    foreach (DataRow row in dtCliente.Rows)
                    {
                        Clientes Cliente = new Clientes();


                        Cliente.codigo = Convert.ToInt32(row["codigo"]);
                        Cliente.cliente = Convert.ToString(row["cliente"]);
                        Cliente.apelido = Convert.ToString(row["apelido"]);
                        Cliente.dtNascimento = Convert.ToDateTime(row["dtNascimento"]);
                        Cliente.sexo = Convert.ToChar(row["sexo"]);
                        Cliente.endereco = Convert.ToString(row["endereco"]);
                        Cliente.numero = Convert.ToString(row["numero"]);
                        Cliente.complemento = Convert.ToString(row["complemento"]);
                        Cliente.bairro = Convert.ToString(row["bairro"]);
                        Cliente.cep = Convert.ToString(row["cep"]);

                        Cliente.Cidade = daoCid.BuscarPorID(Convert.ToInt32(row["codCidade"])) as Cidades;
                        Cliente.telefone = Convert.ToString(row["telefone"]);
                        Cliente.celular = Convert.ToString(row["celular"]);
                        Cliente.contato = Convert.ToString(row["contato"]);
                        Cliente.email = Convert.ToString(row["email"]);
                        Cliente.site = Convert.ToString(row["site"]);
                        Cliente.cpf = Convert.ToString(row["cpf"]);
                        Cliente.rg = Convert.ToString(row["rg"]);

                        if (Convert.ToInt32("0" + row["codCondPagamento"]) != 0)
                        {
                            Cliente.CondPagamento = daoCondPag.BuscarPorID(Convert.ToInt32(row["codCondPagamento"])) as CondicaoPagamentos;
                        }
                        Cliente.limiteCredito = Convert.ToDouble(row["limiteCredito"]);
                        Cliente.observacoes = Convert.ToString(row["observacoes"]);
                        Cliente.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                        Cliente.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                        Cliente.usuario = Convert.ToString(row["usuario"]);
                        Cliente.cnpj = Convert.ToString(row["cnpj"]);
                        Cliente.ie = Convert.ToString(row["ie"]);
                        Cliente.juridico = Convert.ToBoolean(row["juridico"]);
                        Cliente.estrangeiro = Convert.ToBoolean(row["estrangeiro"]);

                        this.cliente = Cliente;
                    }
                    return cliente;
                }
                else
                {
                    return null;
                }
            }
        }

        #region Alterar Cliente
        public override void Editar(object obj)
        {
            SqlConnection conexao = Conecta.CreateConnection();
            {
                try
                {
                    Clientes cliente = obj as Clientes;
                    string sql = @"UPDATE clientes set 
                                    cliente = @cliente,
                                    apelido = @apelido,
                                    dtNascimento = @dtNascimento,
                                    sexo = @sexo, 

                                    cpf = @cpf,
                                    rg = @rg,
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
                                
                                    site = @site,
                                    codCondPagamento = @codCondPagamento,
                                    limiteCredito = @limiteCredito,
                                    observacoes = @observacoes,
                                    dtCadastro = @dtCadastro,
                                    dtAlteracao = @dtAlteracao,
                                    usuario = @usuario ,
                                    juridico = @juridico,
                                    estrangeiro = @estrangeiro

                                    WHERE codigo = @codigo";

                    SqlCommand comando = new SqlCommand(sql, conexao);


                        comando.Parameters.AddWithValue("@cliente", cliente.cliente);
                        comando.Parameters.AddWithValue("@apelido", cliente.apelido);
                        comando.Parameters.AddWithValue("@dtNascimento", cliente.dtNascimento);
                        comando.Parameters.AddWithValue("@sexo", cliente.sexo);
                    
                        comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                        comando.Parameters.AddWithValue("@rg", cliente.rg);
                        comando.Parameters.AddWithValue("@email", cliente.email);
                        comando.Parameters.AddWithValue("@telefone", cliente.telefone);
                        comando.Parameters.AddWithValue("@celular", cliente.celular);
                        comando.Parameters.AddWithValue("@contato", cliente.contato);
                     
                        comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                        comando.Parameters.AddWithValue("@complemento", cliente.complemento);
                        comando.Parameters.AddWithValue("@numero", cliente.numero);
                        comando.Parameters.AddWithValue("@bairro", cliente.bairro);
                        comando.Parameters.AddWithValue("@cep", cliente.cep);
                        comando.Parameters.AddWithValue("@codCidade", cliente.Cidade.codigo);

                        comando.Parameters.AddWithValue("@site", cliente.site);
                        if (cliente.CondPagamento != null && cliente.CondPagamento.codigo != 0)
                        {
                            comando.Parameters.AddWithValue("@codCondPagamento", cliente.CondPagamento.codigo);
                        }
                        else
                        {
                            comando.Parameters.AddWithValue("@codCondPagamento", DBNull.Value);
                        }
                        comando.Parameters.AddWithValue("@limiteCredito", cliente.limiteCredito);
                        comando.Parameters.AddWithValue("@observacoes", cliente.observacoes);
                        comando.Parameters.AddWithValue("@dtCadastro", cliente.dtCadastro);
                        comando.Parameters.AddWithValue("@dtAlteracao", cliente.dtAlteracao);
                        comando.Parameters.AddWithValue("@usuario", cliente.usuario);
                        comando.Parameters.AddWithValue("@juridico", cliente.juridico);
                        comando.Parameters.AddWithValue("@estrangeiro", cliente.estrangeiro);
                        comando.Parameters.AddWithValue("@codigo", cliente.codigo);

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

        #region ExcluirCliente
        public override void Excluir(object id)
        {
                SqlConnection conexao = Conecta.CreateConnection();
            {
                try
                {
                    string sql = @"DELETE FROM clientes WHERE (codido = @codido)";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codido", id);


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

        #region BuscarCliete codido
        public override object BuscarPorID(object id)
        {
            // Instanciando a conexão
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM clientes WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", id);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);
                cliente = null;
                foreach ( DataRow row in dtCliente.Rows)
                {
                    Clientes cli = new Clientes();
                    
                    cli.codigo = Convert.ToInt32(row["codigo"]);
                    cli.cliente = Convert.ToString(row["cliente"]);
                    cli.apelido = Convert.ToString(row["apelido"]);
                    cli.dtNascimento = Convert.ToDateTime(row["dtNascimento"]);
                    cli.sexo = Convert.ToChar(row["sexo"]);
                    cli.endereco = Convert.ToString(row["endereco"]);
                    cli.numero = Convert.ToString(row["numero"]);
                    cli.complemento = Convert.ToString(row["complemento"]);
                    cli.bairro = Convert.ToString(row["bairro"]);
                    cli.cep = Convert.ToString(row["cep"]);
                    
                    cli.Cidade = daoCid.BuscarPorID(Convert.ToInt32(row["codCidade"])) as Cidades;
                    cli.telefone = Convert.ToString(row["telefone"]);
                    cli.celular = Convert.ToString(row["celular"]);
                    cli.contato = Convert.ToString(row["contato"]);
                    cli.email = Convert.ToString(row["email"]);
                    cli.site = Convert.ToString(row["site"]);
                    cli.cpf = Convert.ToString(row["cpf"]);
                    cli.rg = Convert.ToString(row["rg"]);
                    if (Convert.ToInt32("0" + row["codCondPagamento"]) != 0)
                    {
                        cli.CondPagamento = daoCondPag.BuscarPorID(Convert.ToInt32(row["codCondPagamento"])) as CondicaoPagamentos;
                    }
                    cli.limiteCredito = Convert.ToDouble(row["limiteCredito"]);
                    cli.observacoes = Convert.ToString(row["observacoes"]);
                    cli.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    cli.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    cli.usuario = Convert.ToString(row["usuario"]);
                    cli.cnpj = Convert.ToString(row["cnpj"]);
                    cli.ie = Convert.ToString(row["ie"]);
                    cli.juridico = Convert.ToBoolean(row["juridico"]);
                    cli.estrangeiro = Convert.ToBoolean(row["estrangeiro"]);
                    cliente = cli;
                }
                return cliente;
            }
        }
        #endregion

        #region ListarTodosClientes
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {

                SqlDataAdapter da;
                string sql = @"SELECT * FROM clientes";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);

                return dtCliente;
            }
        }
         #endregion

        #region ListarTodosClientes por nome
        public DataTable ListarTodosClientes_porNome(object obj)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                Clientes cliente = obj as Clientes;
                SqlDataAdapter da;
                string sql = @"SELECT C.codido as Codigo, C.nome as Cliente,
                                    C.cnpj as CNPJ, C.cpf as CPF, C.email as Email, C.telefone as Telefone,
                                    C.celular as Celular, C.site As Site,  C.endereco as Endereco, C.complemento as Complemento, 
                                    C.numero as Numero, C.bairro as Bairro, Cidade.cidade as Cidade, E.uf as UF, C.cep as CEP, 

                               FROM clientes As C
                                 INNER JOIN estados AS E ON C.codigoUf = E.codido 
                                 INNER JOIN cidades AS Cid ON C.codCidade = Cid.codido 

                               WHERE C.nome = @nome";

                    SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", cliente.cliente);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtCliente = new DataTable();
                da.Fill(dtCliente);

                return dtCliente;
            }
        }
        #endregion
    }
}
