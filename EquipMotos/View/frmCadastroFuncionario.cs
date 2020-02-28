using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroFuncionario : MaterialSkin.Controls.MaterialForm
    {
        Funcionarios func = new Funcionarios();
        CtrlFuncionarios CtrlFuncionario = new CtrlFuncionarios();
        CtrlCidades CtrlCidade = new CtrlCidades();
        public static object cidade = null;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            txtUsuario.Text = "ADM";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    Cidades cid = new Cidades();
                    func.funcionario = txtFuncionario.Text;
                    func.apelido = txtApelido.Text;
                    func.dtNascimento = Convert.ToDateTime(txtDtNascimento.Text);
                    func.sexo = Convert.ToChar(txtSexo.Text);
                    func.endereco = txtEndereco.Text;
                    func.numero = Convert.ToString(txtNumero.Text);
                    func.complemento = txtComplemento.Text;
                    func.bairro = txtBairro.Text;
                    func.cep = txtCep.Text;

                    cid.codigo = Convert.ToInt16(txtIdCidade.Text);
                    func.Cidade = cid;

                    func.telefone = txtTelefone.Text;
                    func.celular = txtCelular.Text;
                    func.email = txtEmail.Text;
                    func.rg = txtRg.Text;
                    func.cpf = txtCpf.Text;

                    func.cargo = txtCargo.Text;
                    func.salario = Convert.ToDecimal(Decimal.Parse(txtSalario.Text, NumberStyles.Any).ToString("N2"));
                    func.comissao = Convert.ToDecimal(Convert.ToDecimal(txtComissao.Text).ToString("N2"));

                    func.carteiraTrabalho = txtCarteiraTrabalho.Text;
                    func.ctSerie = txtSerie.Text;
                    func.ctUf = txtUfct.Text;
                    func.ctDtEmissao = Convert.ToDateTime(txtDtEmissaoCt.Text);
                    func.ctPis = txtPis.Text;

                    func.cnh = txtCnh.Text;
                    func.cnhEmissor = txtEmissor.Text;
                    func.cnhUf = txtUfCnh.Text;
                    func.cnhDtExpedicao = Convert.ToDateTime(txtDtExpedicao.Text);
                    func.cnhDtValidade = Convert.ToDateTime(txtDtValidade.Text);
                    func.cnhDtPrimeira = Convert.ToDateTime(txtDtPrimeiraCnh.Text);
                    func.cnhCategoria = txtCategoria.Text;

                    func.observacoes = txtObservacao.Text;
                    func.usuario = UsuarioLogado.Usuario;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        func.codigo = Convert.ToInt32(txtCodigo.Text);
                        func.dtAlteracao = DateTime.Now;
                        CtrlFuncionario.Editar(func);

                        MessageBox.Show("Funcionario alterado com Sucesso!");
                    }
                    else
                    {
                        func.dtCadastro = DateTime.Now;
                        func.dtAlteracao = DateTime.Now;
                        CtrlFuncionario.Inserir(func);

                        MessageBox.Show("Funcionario cadastrado com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    limparCampos();
                    this.Close();
                }else
                {
                    MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        public bool ValidaCampos()
        {
            if (txtFuncionario.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este funcionario", "Informe o funcionario com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }
            if (txtFuncionario.Text.Trim().Length < 3)
            {
                MessageBox.Show("Funcionario inválido!", "Verefique o Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtFuncionario.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Funcionario", "Informe o Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtFuncionario.Text))
            {
                MessageBox.Show("Funcionario inválido!", "Funcionario não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtNumero.Text.Trim()))
            {
                txtNumero.Text = "0";
            }
            else if (Convert.ToInt32(txtNumero.Text.Trim()) < 0)
            {
                MessageBox.Show("Numero inválido", "Informe um Numero!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtNumero.Text.Trim()))
            {
                txtNumero.Text = "0";
            }
            else if (Convert.ToInt32(txtNumero.Text.Trim()) < 0)
            {
                MessageBox.Show("Numero inválido", "Informe o Numero!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }
            if (txtEndereco.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este endereco", "Informe o endereco com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Faltou informar o Endereço", "Informe o Endereço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtEndereco.Text))
            {
                MessageBox.Show("Endereço inválido!", "Endereço não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }

            if (txtBairro.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este bairro", "Informe o bairro com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtBairro.Text))
            {
                MessageBox.Show("Bairro inválido!", "Bairro não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtBairro.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Bairro", "Informe o Bairro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtCep.Text.Trim()))
            {
                txtCep.Text = "0";
            }
            else if (Convert.ToInt32(txtCep.Text.Trim()) < 0)
            {
                MessageBox.Show("CEP inválido", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
                return false;
            }

            if (!ValidaData(txtDtNascimento.Text))
            {
                MessageBox.Show("Data Nascimento inválida", "Informe a Data de Nascimento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtNascimento.Focus();
                return false;
            }
            else if (Convert.ToDateTime(txtDtNascimento.Text) > DateTime.Now)
            {
                MessageBox.Show("Data Nascimento inválida", "Informe a Data de Nascimento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtNascimento.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtIdCidade.Text.Trim()) & txtIdCidade.Text.Length < 0)
            {
                MessageBox.Show("Faltou informar o Cidade", "Informe o Cidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCidade.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtIdCidade.Text.Trim()) < 0)
            {
                MessageBox.Show("Código Cidade inválido", "Informe o código da cidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCidade.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtCelular.Text.Trim()) & txtCelular.Text.Length < 11)
            {
                MessageBox.Show("Faltou informar o Celular", "Informe o Celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                return false;
            }
            if (!ValidaData(txtDtEmissaoCt.Text))
            {
                MessageBox.Show("Data de Emissão inválida", "Informe a Data de Emissão!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtEmissaoCt.Focus();
                return false;
            }
            else if (Convert.ToDateTime(txtDtEmissaoCt.Text) > DateTime.Now)
            {
                MessageBox.Show("Data de Emissão inválida", "Informe a Data de Emissão!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtEmissaoCt.Focus();
                return false;
            }
            if (!ValidaData(txtDtExpedicao.Text))
            {
                MessageBox.Show("Data de Expedição inválida", "Informe a Data de Expedição!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtExpedicao.Focus();
                return false;
            }
            else if (Convert.ToDateTime(txtDtExpedicao.Text) > DateTime.Now)
            {
                MessageBox.Show("Data de Expedição inválida", "Informe a Data de Expedição!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtExpedicao.Focus();
                return false;
            }
            if (!ValidaData(txtDtValidade.Text))
            {
                MessageBox.Show("Data de Validade inválida", "Informe a Data de Validade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtExpedicao.Focus();
                return false;
            }
            else if (Convert.ToDateTime(txtDtValidade.Text) > DateTime.Now)
            {
                MessageBox.Show("Data de Validade inválida", "Informe a Data de Validade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtValidade.Focus();
                return false;
            }

            if (!ValidaData(txtDtPrimeiraCnh.Text))
            {
                MessageBox.Show("Data da 1º CNH inválida", "Informe a Data da 1º CNH!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtPrimeiraCnh.Focus();
                return false;
            }
            else if (Convert.ToDateTime(txtDtPrimeiraCnh.Text) > DateTime.Now)
            {
                MessageBox.Show("Data da 1º CNH inválida", "Informe a Data da 1º CNH!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtPrimeiraCnh.Focus();
                return false;
            }

            if (!IsCpf(txtCpf.Text) || txtCpf.Text.Length < 11)
            {
                MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtRg.Text))
            {
                MessageBox.Show("Faltou informar o RG", "Informe o RG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRg.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSexo.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Sexo", "Informe o Sexo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSexo.Focus();
                return false;
            }else if (txtSexo.Text != "M" & txtSexo.Text != "F")
            {
                MessageBox.Show("Sexo inválido, o sexo deve ser ( M ou F)!", "Verefique o Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSexo.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Faltou informar o Salario", "Informe o Salario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return false;
            }
            else if (Double.Parse(txtSalario.Text, NumberStyles.Any) < 0)
            {
                MessageBox.Show("Salario inválido", "Informe o Salario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtSerie.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Nº de Serie", "Informe o Nº de Serie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }
            else if (Convert.ToInt64(txtSerie.Text) < 0)
            {
                MessageBox.Show("Nº de Serie inválido", "Informe o Nº de Serie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerie.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtCarteiraTrabalho.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Nº da Carteira de Trabalho", "Informe o Nº da Carteira de Trabalho!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarteiraTrabalho.Focus();
                return false;
            }
            else if (Convert.ToInt64(txtCarteiraTrabalho.Text.Trim()) < 0)
            {
                MessageBox.Show("Nº da Carteira de Trabalho inválido", "Informe o Nº da Carteira de Trabalho!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCarteiraTrabalho.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtCnh.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Nº da CNH", "Informe o Nº da CNH!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCnh.Focus();
                return false;
            }
            else if (Convert.ToInt64(txtCnh.Text.Trim()) < 0)
            {
                MessageBox.Show("Nº da CNH inválido", "Informe o Nº da CNH!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCnh.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtPis.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Nº do PIS", "Informe o Nº do PIS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPis.Focus();
                return false;
            }
            else if (Convert.ToInt64(txtPis.Text) < 0)
            {
                MessageBox.Show("Nº do PIS inválido", "Informe o Nº do PIS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPis.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtEmissor.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Orgão Emissor", "Informe o Orgão Emissor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmissor.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtCategoria.Text.Trim() ))
            {
                MessageBox.Show("Faltou informar a Categoria", "Informe a Categoria!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtComissao.Text.Trim()))
            {
                txtComissao.Text = "0";
            }
            return true;
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtFuncionario.Text = "";
            txtApelido.Text = "";
            txtDtNascimento.Text = "";
            txtSexo.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCep.Text = "";
            txtBairro.Text = "";
            txtIdCidade.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtCargo.Text = "";
            txtSalario.Text = "";
            txtComissao.Text = "";
            txtCarteiraTrabalho.Text = "";
            txtSerie.Text = "";
            txtUfct.Text = "";
            txtDtEmissaoCt.Text = "";
            txtPis.Text = "";
            txtCnh.Text = "";
            txtEmissor.Text = "";
            txtUfCnh.Text = "";
            txtDtExpedicao.Text = "";
            txtDtValidade.Text = "";
            txtDtPrimeiraCnh.Text = "";
            txtCategoria.Text = "";
            txtObservacao.Text = "";
            txtDtCadastro.Text = "";
            txtDtAlteracao.Text = "";
            txtUsuario.Text = "";
        }

        private void BtnBuscarCidade_Click(object sender, EventArgs e)
        {
            frmConsultaCidade frmConCidade = new frmConsultaCidade();
            frmConCidade.btnVoltar.Text = "SELECIONAR";
            if (frmConCidade.ShowDialog() == DialogResult.OK)
            {
                CarregaCidade();
            }
        }

        public void CarregaCidade()
        {
            if (cidade != null)
            {
                Cidades cid = cidade as Cidades;
                txtIdCidade.Text = Convert.ToString(cid.codigo);
                txtCidade.Text = cid.cidade;
                txtUF.Text = Convert.ToString(cid.Estado.uf);
            }
        }

        public void Carregar(object id)
        {
            func = CtrlFuncionario.BuscarPorID(id) as Funcionarios;
            txtCodigo.Text = Convert.ToString(func.codigo);
            txtFuncionario.Text = func.funcionario;
            
            txtApelido.Text = func.apelido;
            txtDtNascimento.Text = Convert.ToString(func.dtNascimento);
            txtSexo.Text = Convert.ToString(func.sexo);
            txtEndereco.Text = func.endereco;
            txtNumero.Text = Convert.ToString(func.numero);
            txtComplemento.Text = func.complemento;
            txtCep.Text = func.cep;
            txtBairro.Text = func.bairro;
            txtIdCidade.Text = Convert.ToString(func.Cidade.codigo);
            txtCidade.Text = func.Cidade.cidade ;
            txtUF.Text = func.Cidade.Estado.uf;
            txtTelefone.Text = func.telefone;
            txtCelular.Text = func.celular;
            txtEmail.Text = func.email;
            txtRg.Text = func.rg;
            txtCpf.Text = func.cpf;
            txtCargo.Text = func.cargo;
            txtSalario.Text =  func.salario.ToString("C", CultureInfo.CurrentCulture); 
            txtComissao.Text = Convert.ToString(func.comissao);
            txtCarteiraTrabalho.Text = func.carteiraTrabalho;
            txtSerie.Text = func.ctSerie;
            txtUfct.Text = func.ctUf;
            txtDtEmissaoCt.Text = Convert.ToString(func.ctDtEmissao);
            txtPis.Text = func.ctPis;
            txtCnh.Text = func.cnh;
            txtEmissor.Text = func.cnhEmissor;
            txtUfCnh.Text = func.cnhUf;
            txtDtExpedicao.Text = Convert.ToString(func.cnhDtExpedicao);
            txtDtValidade.Text = Convert.ToString(func.cnhDtValidade);
            txtDtPrimeiraCnh.Text = Convert.ToString(func.cnhDtPrimeira);
            txtCategoria.Text = func.cnhCategoria; 

            txtObservacao.Text = func.observacoes;
            txtDtCadastro.Text = Convert.ToString(func.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(func.dtAlteracao);
            txtUsuario.Text = func.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        public Boolean IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public bool ValidaData(String data)
        {
            DateTime dt = DateTime.MinValue;
            if(DateTime.TryParse(data, out dt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TxtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void TxtSalario_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void TxtSalario_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void TxtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyPress(sender, e);
        }

        private void TxtComissao_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtComissao_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void txtIdCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCarteiraTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtFuncionario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFuncionario.Text))
            {
                if (txtFuncionario.Text.Length < 3)
                {
                    MessageBox.Show("Funcionario inválido!", "Informe o funcionario com mais de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFuncionario.Focus();
                }
                else
                if (txtFuncionario.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Funcionario inválido!", "Informe o funcionario com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFuncionario.Focus();
                }
                else
                if (String.IsNullOrEmpty(txtFuncionario.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Funcionario", "Informe o funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFuncionario.Focus();
                }
                else
                if (!MaskForm.ValidaTexto(txtFuncionario.Text))
                {
                    MessageBox.Show("Funcionario inválido!", "Funcionario não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFuncionario.Focus();
                }
            }
        }

        private void txtApelido_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApelido.Text))
            {
                if (!MaskForm.ValidaTexto(txtApelido.Text))
                {
                    MessageBox.Show("Apelido inválido!", "Apelido não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApelido.Focus();
                }
            }
        }

        private void txtDtNascimento_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtNascimento.Text))
            {
                if (txtDtNascimento.Value >= DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtNascimento.Focus();
                }
            }
        }

        private void txtSexo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSexo.Text))
            {
                if (txtSexo.Text != "M" & txtSexo.Text != "F")
                {
                    MessageBox.Show("Sexo inválido, deve ser 'M' ou 'F' ", "Verefique o Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSexo.Focus();
                    txtSexo.Text = "";
                }
            }
        }

        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEndereco.Text))
            {
                if (txtEndereco.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este endereço", "Informe o endereço com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Focus();
                }
                else if (String.IsNullOrEmpty(txtEndereco.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Endereço", "Informe o Endereço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Focus();
                }
                else if (!MaskForm.ValidaTexto(txtEndereco.Text))
                {
                    MessageBox.Show("Endereço inválido!", "Endereço não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Focus();
                }
                else if (txtEndereco.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Não é possivel inserir este endereço", "Informe o endereço com mais de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Focus();
                }
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                if (txtNumero.Text.Trim().Length > 6)
                {
                    MessageBox.Show("Numero inválido!", "Numero não pode conter mais de 10 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();

                }
                else if (!MaskForm.ValidaNumero(txtNumero.Text.Trim()))
                {
                    MessageBox.Show("Numero inválido!", "Valor dever ser numerico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Focus();
                }
            }
        }

        private void txtComplemento_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtComplemento.Text))
            {
                if (!MaskForm.ValidaTexto(txtComplemento.Text))
                {
                    MessageBox.Show("Complemento inválido!", "Complemento não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtComplemento.Focus();
                }
                else if (txtComplemento.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Complemento inválido!", "Complemento não pode conter mais de 50 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtComplemento.Focus();
                }
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBairro.Text))
            {
                if (txtBairro.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este bairro", "Informe o bairro com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBairro.Focus();
                }
                else if (String.IsNullOrEmpty(txtBairro.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Bairro", "Informe o Bairro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBairro.Focus();
                }
                else if (!MaskForm.ValidaTexto(txtBairro.Text))
                {
                    MessageBox.Show("Bairro inválido!", "Bairro não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBairro.Focus();
                }
                else if (txtBairro.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Não é possivel inserir este bairro", "Informe o bairro com mais de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBairro.Focus();
                }
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text.Trim()))
            {
                txtCep.Text = "";
            }
            else if (txtCep.Text.Trim().Length < 8)
            {
                MessageBox.Show("CEP inválido, é necessário no minímo 8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
            }
            else if (txtCep.Text.Trim().Length > 8)
            {
                MessageBox.Show("CEP inválido, é necessário no máximo 8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
            }
        }

        private void txtIdCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCidade.Text))
            {
                if (string.IsNullOrEmpty(txtIdCidade.Text))
                {
                    MessageBox.Show("Faltou informar o codigo da cidade", "Informer o codigo da cidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCidade.Focus();
                }
                else if (!MaskForm.ValidaNumero(txtIdCidade.Text.Trim()))
                {
                    MessageBox.Show("Codigo cidade inválido!", "Codigo da cidade dever ser númerico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCidade.Text = "";
                    txtIdCidade.Focus();
                }

            };
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCelular.Text))
            {
                if (String.IsNullOrEmpty(txtCelular.Text))
                {
                    MessageBox.Show("Faltou informar o celular", "Informe o celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
                else if (txtCelular.Text.Length < 10)
                {
                    MessageBox.Show("Celular inválido, deve ter no mínimo 10 números", "Informe o celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelefone.Text))
            {
                if (txtTelefone.Text.Length < 10)
                {
                    MessageBox.Show("Telefone inválido, deve ter no mínimo 10 números", "Informe o Telefone!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefone.Focus();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!MaskForm.ValidaEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email inválido ", "Informe um email valido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
                else if (txtEmail.Text.Trim().Length > 30)
                {
                    MessageBox.Show("Não é possivel inserir este email", "Informe o email com menos de 30 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCpf.Text))
            {
                if (!IsCpf(txtCpf.Text) || txtCpf.Text.Length < 11)
                {
                    MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCpf.Focus();
                }
            }
        }

        private void txtRg_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRg.Text))
            {
                if (txtRg.Text.Trim().Length > 20 )
                {
                    MessageBox.Show("Não é possivel inserir esse RG", "Informe o RG com menos de 20 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRg.Focus();
                }
                else if(txtRg.Text.Trim().Length < 9)
                {
                    MessageBox.Show("Não é possivel inserir esse RG", "Informe o RG com mais de 9 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRg.Focus();
                }
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCargo.Text))
            {
                if(txtCargo.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Não é possivel inserir esse Cargo", "Informe o Cargo com menos de 50 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCargo.Focus();
                }
                else if(txtCargo.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Não é possivel inserir esse Cargo", "Informe o Cargo com mais de 3 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCargo.Focus();
                }
            }
        }

        private void txtCarteiraTrabalho_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCarteiraTrabalho.Text))
            {
                if (txtCarteiraTrabalho.Text.Trim().Length > 11)
                {
                    MessageBox.Show("Não é possivel inserir essa Carteira de Trabalho", "Informe a Carteira de Trabalho com menos de 11 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCarteiraTrabalho.Focus();
                }
                else if (txtCarteiraTrabalho.Text.Trim().Length < 11)
                {
                    MessageBox.Show("Não é possivel inserir essa Carteira de Trabalho", "Informe a Carteira de Trabalho com mais de 11 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCarteiraTrabalho.Focus();
                }
            }
        }

        private void txtSerie_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSerie.Text))
            {
                if (txtSerie.Text.Trim().Length > 7)
                {
                    MessageBox.Show("Não é possivel inserir essa Serie", "Informe a Serie com menos de 7 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSerie.Focus();
                }
                else if (txtSerie.Text.Trim().Length < 7)
                {
                    MessageBox.Show("Não é possivel inserir essa Serie", "Informe a Serie com mais de 7 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSerie.Focus();
                }
            }
        }

        private void txtUfct_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUfct.Text))
            {
                if (txtUfct.Text.Trim().Length > 2 || txtUfct.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Não possivel inserir esta UF ", "Informe uma UF com 2 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUfct.Focus();
                }
            }
        }

        private void txtDtEmissaoCt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtEmissaoCt.Text))
            {
                if (txtDtEmissaoCt.Value >= DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtEmissaoCt.Focus();
                    txtDtEmissaoCt.Value = DateTime.Now;
                }
            }
        }

        private void txtPis_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPis.Text))
            {
                MaskForm.IsPis(txtPis.Text);
            }
        }

        private void txtCnh_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCnh.Text))
            {
                if(txtCnh.Text.Trim().Length > 11 || txtCnh.Text.Trim().Length < 11)
                {
                    MessageBox.Show("Não é possivel inserir este número de CNH", "Informe o número que consta na CNH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCnh.Focus();
                }
            }
        }

        private void txtEmissor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmissor.Text))
            {
                if(txtEmissor.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Não é possivel inserir este Orgão Emissor", "Informe um orgão emissor com mais de 3 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmissor.Focus();
                }
                else if(txtEmissor.Text.Trim().Length > 20)
                {
                    MessageBox.Show("Não é possivel inserir este Orgão Emissor", "Informe um orgão emissor com menos de 20 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmissor.Focus();
                }
            }
        }

        private void txtUfCnh_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUfCnh.Text))
            {
                if (txtUfCnh.Text.Trim().Length > 2 || txtUfCnh.Text.Trim().Length < 2)
                {
                    MessageBox.Show("Não possivel inserir esta UF ", "Informe uma UF com 2 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUfCnh.Focus();
                }
            }
        }

        private void txtDtExpedicao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtExpedicao.Text))
            {
                if (txtDtExpedicao.Value >= DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "Informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtExpedicao.Focus();
                    txtDtExpedicao.Value = DateTime.Now;
                }
            }
        }

        private void txtDtValidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtValidade.Text))
            {
                if (txtDtValidade.Value >= DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "Informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtValidade.Focus();
                    txtDtValidade.Value = DateTime.Now;
                }
            }
        }

        private void txtDtPrimeiraCnh_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtPrimeiraCnh.Text))
            {
                if (txtDtPrimeiraCnh.Value >= DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "Informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtPrimeiraCnh.Focus();
                    txtDtPrimeiraCnh.Value = DateTime.Now;
                }
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                if (txtCategoria.Text.Trim().Length > 2)
                {
                    MessageBox.Show("Não é possivel inserir esta categoria", "Informe a categoria que consta na CNH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoria.Focus();
                }
            }
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Sexo_KeyPress(sender, e);
        }

        private void txtSexo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtCep_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtIdCidade_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtIdCidade_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCidade.Text))
                return;
            if (Convert.ToInt32("0" + txtIdCidade.Text) < 1)
                return;
            Cidades cid = CtrlCidade.BuscarPorID(Convert.ToInt32(txtIdCidade.Text)) as Cidades;
            if (cid == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCidade.Text = "";
                txtIdCidade.Text = "";
                txtUF.Text = "";
                txtCidade.Enabled = true;
                txtUF.Enabled = true;
                txtIdCidade.Enabled = true;
            }
            else
            {
                txtCidade.Text = cid.cidade;
                txtUF.Text = cid.Estado.uf;
                txtUF.Enabled = false;
                txtCidade.Enabled = false;
                txtIdCidade.Enabled = false;
            }

    }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtUfct_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtUfCnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtEmissor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);

        }

        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtApelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
