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
    class FuncionariosDAO:DAO
    {

        Funcionarios funcionario = new Funcionarios();
        CidadesDAO daoCid = new CidadesDAO();
        #region InserirFuncionario
        public override void Inserir(object obj)
        {
            {
                SqlConnection conexao = Conecta.CreateConnection();
                try
                {
                    Funcionarios funcionario = obj as Funcionarios;
                    string sql = @"INSERT INTO funcionarios (
                                        funcionario, apelido, dtNascimento, sexo, cpf, rg, email, telefone, celular, endereco, complemento, numero, bairro, cep, codCidade,
                                        cargo, salario, comissao,
                                        carteiraTrabalho, serie, ufCt, dtEmissaoCt, pis,
                                        cnh, emissor, ufCnh, dtExpedicao, dtValidade, dtPrimeiraCnh, categoria,
                                        observacoes, dtCadastro, dtAlteracao, usuario) 
                                  VALUES ( 
                                  @funcionario, @apelido, @dtNascimento, @sexo, @cpf, @rg, @email, @telefone, @celular, @endereco, @complemento, @numero, @bairro, @cep, @codCidade,
                                  @cargo, @salario, @comissao,
                                  @carteiraTrabalho, @serie, @ufCt, @dtEmissaoCt, @pis,
                                  @cnh, @emissor, @ufCnh, @dtExpedicao, @dtValidade, @dtPrimeiraCnh, @categoria,
                                  @observacoes, @dtCadastro, @dtAlteracao, @usuario )";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@funcionario", funcionario.funcionario);
                    comando.Parameters.AddWithValue("@apelido", funcionario.apelido);
                    comando.Parameters.AddWithValue("@dtNascimento", funcionario.dtNascimento);
                    comando.Parameters.AddWithValue("@sexo", funcionario.sexo);
                    comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                    comando.Parameters.AddWithValue("@rg", funcionario.rg);
                    comando.Parameters.AddWithValue("@email", funcionario.email);
                    comando.Parameters.AddWithValue("@telefone", funcionario.telefone);
                    comando.Parameters.AddWithValue("@celular", funcionario.celular);
                    comando.Parameters.AddWithValue("@endereco", funcionario.endereco);
                    comando.Parameters.AddWithValue("@complemento", funcionario.complemento);
                    comando.Parameters.AddWithValue("@numero", funcionario.numero);
                    comando.Parameters.AddWithValue("@bairro", funcionario.bairro);
                    comando.Parameters.AddWithValue("@cep", funcionario.cep);
                    comando.Parameters.AddWithValue("@codCidade", funcionario.Cidade.codigo);
                    
                    comando.Parameters.AddWithValue("@cargo", funcionario.cargo);
                    comando.Parameters.AddWithValue("@salario", funcionario.salario);
                    comando.Parameters.AddWithValue("@comissao", funcionario.comissao);

                    comando.Parameters.AddWithValue("@carteiraTrabalho", funcionario.carteiraTrabalho);
                    comando.Parameters.AddWithValue("@serie", funcionario.ctSerie);
                    comando.Parameters.AddWithValue("@ufCt", funcionario.ctUf);
                    comando.Parameters.AddWithValue("@dtEmissaoCt", funcionario.ctDtEmissao);
                    comando.Parameters.AddWithValue("@pis", funcionario.ctPis);

                    comando.Parameters.AddWithValue("@cnh", funcionario.cnh);
                    comando.Parameters.AddWithValue("@emissor", funcionario.cnhEmissor);
                    comando.Parameters.AddWithValue("@ufCnh", funcionario.cnhUf);
                    comando.Parameters.AddWithValue("@dtExpedicao", funcionario.cnhDtExpedicao);
                    comando.Parameters.AddWithValue("@dtValidade", funcionario.cnhDtValidade);
                    comando.Parameters.AddWithValue("@dtPrimeiraCnh", funcionario.cnhDtPrimeira);
                    comando.Parameters.AddWithValue("@categoria", funcionario.cnhCategoria);

                    comando.Parameters.AddWithValue("@observacoes", funcionario.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", funcionario.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", funcionario.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", funcionario.usuario);

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

        public override object Pesquisar(string fun)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = null;
                bool isNumeric = int.TryParse(fun, out int n);
                if (fun.Length <= 4 && isNumeric)
                {
                    int id = Convert.ToInt32(fun);
                    sql = @"SELECT * FROM funcionarios WHERE codigo = @fun";
                }
                else
                {
                    if (isNumeric)
                    {
                        string cpf = fun;
                        sql = @"SELECT * FROM funcionarios WHERE cpf like '%'+ @fun +'%'";
                    }
                    else
                    {
                        string funcionario = fun;
                        sql = @"SELECT * FROM funcionarios WHERE funcionario like '%'+ @fun + '%' ";

                    }
                }

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@fun", fun);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtFuncionario = new DataTable();
                da.Fill(dtFuncionario);

                return dtFuncionario;
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
                    Funcionarios funcionario = obj as Funcionarios;
                    string sql = @"UPDATE funcionarios set 
                                funcionario = @funcionario,
                                apelido = @apelido,
                                dtNascimento = @dtNascimento,
                                sexo = @sexo,

                                endereco = @endereco,
                                complemento = @complemento,
                                numero = @numero,
                                bairro = @bairro,
                                cep = @cep,
                                codCidade = @codCidade,

                                telefone = @telefone,
                                celular = @celular,
                              
                                email = @email,
                                cpf = @cpf,
                                rg = @rg,
                                
                                cargo = @cargo,
                                salario = @salario,
                                comissao = @comissao,

                                carteiraTrabalho = @carteiraTrabalho,
                                serie = @serie,
                                ufCt = @ufCt,
                                dtEmissaoCt = @dtEmissaoCt,
                                pis = @pis,

                                cnh = @cnh,
                                emissor = @emissor,
                                ufCnh = @ufCnh,
                                dtExpedicao = @dtExpedicao,
                                dtValidade = @dtValidade,
                                dtPrimeiraCnh = @dtPrimeiraCnh,
                                categoria = @categoria,
                                
                                observacoes = @observacoes,
                                dtCadastro = @dtCadastro,
                                dtAlteracao = @dtAlteracao,
                                usuario = @usuario 

                                WHERE codigo = @codigo";

                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@funcionario", funcionario.funcionario);
                    comando.Parameters.AddWithValue("@apelido", funcionario.apelido);
                    comando.Parameters.AddWithValue("@dtNascimento", funcionario.dtNascimento);
                    comando.Parameters.AddWithValue("@sexo", funcionario.sexo);
                    comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                    comando.Parameters.AddWithValue("@rg", funcionario.rg);
                    comando.Parameters.AddWithValue("@email", funcionario.email);
                    comando.Parameters.AddWithValue("@telefone", funcionario.telefone);
                    comando.Parameters.AddWithValue("@celular", funcionario.celular); 
                    comando.Parameters.AddWithValue("@endereco", funcionario.endereco);
                    comando.Parameters.AddWithValue("@complemento", funcionario.complemento);
                    comando.Parameters.AddWithValue("@numero", funcionario.numero);
                    comando.Parameters.AddWithValue("@bairro", funcionario.bairro);
                    comando.Parameters.AddWithValue("@cep", funcionario.cep);
                    comando.Parameters.AddWithValue("@codCidade", funcionario.Cidade.codigo);

                    comando.Parameters.AddWithValue("@cargo", funcionario.cargo);
                    comando.Parameters.AddWithValue("@salario", funcionario.salario);
                    comando.Parameters.AddWithValue("@comissao", funcionario.comissao);

                    comando.Parameters.AddWithValue("@carteiraTrabalho", funcionario.carteiraTrabalho);
                    comando.Parameters.AddWithValue("@serie", funcionario.ctSerie);
                    comando.Parameters.AddWithValue("@ufCt", funcionario.ctUf);
                    comando.Parameters.AddWithValue("@dtEmissaoCt", funcionario.ctDtEmissao);
                    comando.Parameters.AddWithValue("@pis", funcionario.ctPis);

                    comando.Parameters.AddWithValue("@cnh", funcionario.cnh);
                    comando.Parameters.AddWithValue("@emissor", funcionario.cnhEmissor);
                    comando.Parameters.AddWithValue("@ufCnh", funcionario.cnhUf);
                    comando.Parameters.AddWithValue("@dtExpedicao", funcionario.cnhDtExpedicao);
                    comando.Parameters.AddWithValue("@dtValidade", funcionario.cnhDtValidade);
                    comando.Parameters.AddWithValue("@dtPrimeiraCnh", funcionario.cnhDtPrimeira);
                    comando.Parameters.AddWithValue("@categoria", funcionario.cnhCategoria);

                    comando.Parameters.AddWithValue("@observacoes", funcionario.observacoes);
                    comando.Parameters.AddWithValue("@dtCadastro", funcionario.dtCadastro);
                    comando.Parameters.AddWithValue("@dtAlteracao", funcionario.dtAlteracao);
                    comando.Parameters.AddWithValue("@usuario", funcionario.usuario);

                    comando.Parameters.AddWithValue("@codigo", funcionario.codigo);

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

        #region ExcluirFuncionario
        public override void Excluir(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                try
                {
                    string sql = @"DELETE FROM funcionarios WHERE (codigo = @codigo)";

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

        #region BuscarFuncionario id
        public override object BuscarPorID(object codigo)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            { 
                SqlDataAdapter da;
                string sql = @"SELECT * FROM funcionarios WHERE codigo = @codigo";

                SqlCommand comando = new SqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@codigo", codigo);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtFuncionario = new DataTable();
                da.Fill(dtFuncionario);
                funcionario = null;
                foreach (DataRow row in dtFuncionario.Rows)
                {
                    Funcionarios fun = new Funcionarios();
                    fun.codigo = Convert.ToInt32(row["codigo"]);
                    fun.funcionario = Convert.ToString(row["funcionario"]);
                    fun.apelido = Convert.ToString(row["apelido"]);
                    fun.dtNascimento = Convert.ToDateTime(row["dtNascimento"]);
                    fun.sexo = Convert.ToChar(row["sexo"]);
                    fun.endereco = Convert.ToString(row["endereco"]);
                    fun.numero = Convert.ToString(row["numero"]);
                    fun.complemento = Convert.ToString(row["complemento"]);
                    fun.bairro = Convert.ToString(row["bairro"]);
                    fun.cep = Convert.ToString(row["cep"]);
                    fun.Cidade = daoCid.BuscarPorID(Convert.ToInt32(row["codCidade"])) as Cidades;
                    fun.telefone = Convert.ToString(row["telefone"]);
                    fun.celular = Convert.ToString(row["celular"]); 
                    fun.email = Convert.ToString(row["email"]); 
                    fun.cpf = Convert.ToString(row["cpf"]);
                    fun.rg = Convert.ToString(row["rg"]);
                    fun.cargo = Convert.ToString(row["cargo"]);
                    fun.salario = Convert.ToDecimal(row["salario"]);
                    fun.comissao = Convert.ToDecimal(row["comissao"]);
                    fun.carteiraTrabalho= Convert.ToString(row["carteiraTrabalho"]);
                    fun.ctSerie = Convert.ToString(row["serie"]);
                    fun.ctUf = Convert.ToString(row["ufCt"]);
                    fun.ctDtEmissao = Convert.ToDateTime(row["dtEmissaoCt"]);
                    fun.ctPis = Convert.ToString(row["pis"]);
                    fun.cnh = Convert.ToString(row["cnh"]);
                    fun.cnhEmissor = Convert.ToString(row["emissor"]);
                    fun.cnhUf = Convert.ToString(row["ufCnh"]);
                    fun.cnhDtExpedicao = Convert.ToDateTime(row["dtExpedicao"]);
                    fun.cnhDtValidade = Convert.ToDateTime(row["dtValidade"]);
                    fun.cnhDtPrimeira = Convert.ToDateTime(row["dtPrimeiraCnh"]);
                    fun.cnhCategoria = Convert.ToString(row["categoria"]);
                    fun.observacoes = Convert.ToString(row["observacoes"]);
                    fun.dtCadastro = Convert.ToDateTime(row["dtCadastro"]);
                    fun.dtAlteracao = Convert.ToDateTime(row["dtAlteracao"]);
                    fun.usuario = Convert.ToString(row["usuario"]);
                    this.funcionario = fun;
                }
                return funcionario;

            }
        }
        #endregion

        #region ListarTodosFuncionarios
        public override DataTable ListarTodos()
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT * FROM funcionarios";

                SqlCommand comando = new SqlCommand(sql, conexao);

                conexao.Open();

                da = new SqlDataAdapter(comando);
                DataTable dtFuncionario = new DataTable();
                da.Fill(dtFuncionario);

                return dtFuncionario;
            }
        }
        #endregion

        #region ListarTodosFuncionarios por nome
        public DataTable ListarTodosFuncionarios_porNome(Funcionarios funcionario)
        {
            using (SqlConnection conexao = Conecta.CreateConnection())
            {
                SqlDataAdapter da;
                string sql = @"SELECT C.codigo as Codigo, C.nome as Funcionario,
                                C.cnpj as CNPJ, C.cpf as CPF, C.email as Email, C.telefone as Telefone,
                                C.celular as Celular, C.site As Site,  C.endereco as Endereco, C.complemento as Complemento, 
                                C.numero as Numero, C.bairro as Bairro, Cidade.cidade as Cidade, C.cep as CEP, 

                           FROM funcionarios As C
                             INNER JOIN cidades AS Cid ON C.codigoCidade = Cid.codigo 

                           WHERE C.nome = @nome";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", funcionario.funcionario);

                conexao.Open();
                da = new SqlDataAdapter(comando);

                DataTable dtFuncionario = new DataTable();
                da.Fill(dtFuncionario);

                return dtFuncionario;
            }
        }
        #endregion

    }
}