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
    public partial class frmCadastroFuncionario : Form
    {
        Funcionarios func = new Funcionarios();
        CtrlFuncionarios CtrlFuncionario = new CtrlFuncionarios();
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
                    func.numero = Convert.ToInt32(txtNumero.Text);
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
                    func.usuario = txtUsuario.Text;

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

            if (txtFuncionario.Text.Trim().Length < 3)
            {
                MessageBox.Show("Funcionario inválido!", "Verefique o Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }

            if (txtFuncionario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar o Funcionario", "Informe o Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }

            if (txtNumero.Text.Trim() == String.Empty)
            {
                txtNumero.Text = "0";
            }
            else if (Convert.ToInt32(txtNumero.Text.Trim()) < 0)
            {
                MessageBox.Show("Numero inválido", "Informe um Numero!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }

            if (txtNumero.Text.Trim() == String.Empty)
            {
                txtNumero.Text = "0";
            }
            else if (Convert.ToInt32(txtNumero.Text.Trim()) < 0)
            {
                MessageBox.Show("Numero inválido", "Informe o Numero!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
                return false;
            }

            if (txtEndereco.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar o Endereço", "Informe o Endereço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return false;
            }

            if (txtBairro.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar o Bairro", "Informe o Bairro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBairro.Focus();
                return false;
            }

            if (txtCep.Text.Trim() == String.Empty)
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

            if (txtIdCidade.Text.Trim() == String.Empty & txtIdCidade.Text.Length < 0)
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

            if (txtCelular.Text.Trim() == String.Empty & txtCelular.Text.Length < 11)
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
            if (txtRg.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar o RG", "Informe o RG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRg.Focus();
                return false;
            }

            if (txtSexo.Text.Trim() == String.Empty)
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

            if (txtSalario.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar oSalario", "Informe o Salario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return false;
            }
            else if (Double.Parse(txtSalario.Text, NumberStyles.Any) < 0)
            {
                MessageBox.Show("Salario inválido", "Informe o Salario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
                return false;
            }

            if (txtSerie.Text.Trim() == String.Empty)
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

            if (txtCarteiraTrabalho.Text.Trim() == String.Empty)
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

            if (txtCnh.Text.Trim() == String.Empty)
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

            if (txtPis.Text.Trim() == String.Empty)
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

            if (txtEmissor.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar o Orgão Emissor", "Informe o Orgão Emissor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmissor.Focus();
                return false;
            }
            if (txtCategoria.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Faltou informar a Categoria", "Informe a Categoria!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return false;
            }
            if (txtComissao.Text.Trim() == String.Empty)
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
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCarteiraTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtPis_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }
    }
}
