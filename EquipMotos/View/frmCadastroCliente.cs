using System;
using System.Activities.Expressions;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View;
using EquipMotos.View.helper;

namespace EquipMotos.Codigo.View
{
    public partial class frmCadastroCliente : MaterialSkin.Controls.MaterialForm
    {
        Clientes Cliente = new Clientes();
        CtrlClientes CtrlCliente = new CtrlClientes();
        CtrlCidades CtrlCidade = new CtrlCidades();
        CtrlCondicaoPagamento CtrlCondicao = new CtrlCondicaoPagamento();
        CondicaoPagamentos CondicaoPag = new CondicaoPagamentos();

        public static object cidade = null;
        public static object condPagamento = null;

        public frmCadastroCliente(string pusuario)
        {
            InitializeComponent();
            //txtObservacao.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            rbFisica.Checked = true;            
        }

        private void FrmCadastroCliente_Load(object sender, System.EventArgs e)
        {

        }

        #region Salvar
        private void BtnSalvar_Click(object sender, System.EventArgs e)
        {
                if(ValidaCampos())
                {
                    Cidades cid = new Cidades();
                    Cliente.cliente = txtCliente.Text;
                    Cliente.apelido = txtApelido.Text;
                    Cliente.dtNascimento = Convert.ToDateTime(txtDtNascimento.Text);
                    Cliente.endereco = txtEndereco.Text;
                    Cliente.numero = Convert.ToString(txtNumero.Text);
                    Cliente.complemento = txtComplemento.Text;
                    Cliente.bairro = txtBairro.Text;
                    Cliente.cep = txtCep.Text;
                    cid.codigo = Convert.ToInt16(txtIdCidade.Text);
                    Cliente.Cidade = cid;
                    Cliente.telefone = txtTelefone.Text;
                    Cliente.celular = txtCelular.Text;
                    Cliente.contato = txtContato.Text;

                    if (Convert.ToInt32("0" + txtCodCondicao.Text) != 0)
                    {
                        CondicaoPag.codigo = Convert.ToInt32("0" + txtCodCondicao.Text);
                        Cliente.CondPagamento = CondicaoPag;
                    }
                    Cliente.CondPagamento = CondicaoPag;
                    Cliente.limiteCredito = Double.Parse(txtLimiteCredito.Text, NumberStyles.Any);
                    Cliente.observacoes = txtObservacao.Text;
                    Cliente.dtCadastro = DateTime.Now;
                    Cliente.dtAlteracao = DateTime.Now;
                    Cliente.usuario = UsuarioLogado.Usuario;
                    Cliente.email = txtEmail.Text;
                    Cliente.estrangeiro = chkEstrangeiro.Checked;
                    Cliente.juridico = rbJuridica.Checked;

                    if (rbJuridica.Checked)
                    {
                        Cliente.email = txtEmail.Text;
                        Cliente.site = txtSite.Text;
                        Cliente.cnpj = txtCpf.Text;
                        Cliente.ie = txtRg.Text;
                        Cliente.cpf = "";
                        Cliente.rg = "";
                        Cliente.sexo = '\0';
                    }else
                    {
                        Cliente.cpf = txtCpf.Text;
                        Cliente.rg = txtRg.Text;
                        Cliente.site = txtSite.Text;
                        Cliente.sexo = Convert.ToChar(txtSexo.Text);
                        Cliente.cnpj = "";
                        Cliente.ie = "";
                    }
                    if (btnSalvar.Text == "ALTERAR")
                    {
                        Cliente.codigo = Convert.ToInt32(txtCodigo.Text);
                        CtrlCliente.Editar(Cliente);
                        MessageBox.Show("Cliente alterado com Sucesso!");
                    } else
                    {
                        CtrlCliente.Inserir(Cliente);

                        MessageBox.Show("Cliente cadastrado com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    limparCampos();
                    this.Close();
                }
        }
        #endregion
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void RbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = false;
            txtSexo.Visible = false;
            chkEstrangeiro.Visible = false;
            chkEstrangeiro.Checked = false;
            lblApelido.Text = "Nome Fantasia";
            lblDtNascimento.Text = "Fundação";
            lblCpf.Text = "CNPJ *";
            txtCpf.Mask = "00.000.000/0000-00";
            lblRg.Text = "I.E";
            lblSite.Visible = true;
            txtSite.Visible = true;
        }

        private void RbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = true;
            txtSexo.Visible = true;
            chkEstrangeiro.Visible = true;
            lblApelido.Text = "Apelido";
            lblDtNascimento.Text = "Data Nascimento";
            lblCpf.Text = "CPF *";
            txtCpf.Mask = "000.000.000-00";
            lblRg.Text = "RG";
            lblSite.Visible = false;
            txtSite.Visible = false;
        }

        public bool ValidaCampos()
        {
            try
            {
                if (txtCliente.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este cliente", "Informe o cliente com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return false;
                }
                if (txtCliente.Text.Length < 3)
                {
                    MessageBox.Show("Cliente inválido!", "Verefique o Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return false;
                }
                if (!MaskForm.ValidaTexto(txtCliente.Text))
                {
                    MessageBox.Show("Cliente inválido!", "Cliente não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtCliente.Text.Trim() ))
                {
                    MessageBox.Show("Faltou informar o Cliente", "Informe o Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return false;
                }

                if (!string.IsNullOrEmpty(txtNumero.Text))
                {
                    if (!MaskForm.ValidaNumero(txtNumero.Text))
                    {
                        MessageBox.Show("Numero inválido", "Informe um Numero!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNumero.Focus();
                        return false;
                    }
                }

                if ( Double.Parse(txtLimiteCredito.Text,  NumberStyles.Any) < 0)
                {
                    MessageBox.Show("Limite de crédito inválido", "Informe o Limite de crédito!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLimiteCredito.Focus();
                    return false;
                }
               
                if (txtEndereco.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este endereço", "Informe o endereço com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEndereco.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtEndereco.Text.Trim()))
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
                if (String.IsNullOrEmpty(txtBairro.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Bairro", "Informe o Bairro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBairro.Focus();
                    return false;
                }
                if (!MaskForm.ValidaTexto(txtBairro.Text))
                {
                    MessageBox.Show("Bairro inválido!", "Bairro não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBairro.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtCep.Text.Trim()))
                {
                    txtCep.Text = "0";
                }
                else if(txtCep.Text.Length < 8 & txtCep.Text.Length > 2 )
                {
                    MessageBox.Show("CEP inválido, é necessário no minímo 8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCep.Focus();
                    return false;
                }
                 if (Convert.ToDateTime(txtDtNascimento.Value) > DateTime.Now)
                {
                    MessageBox.Show("Data Nascimento inválida, data não pode ser maior que hoje.", "Informe a Data de Nascimento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtNascimento.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtIdCidade.Text ))
                {
                    MessageBox.Show("Faltou informar o Cidade.", "Informe o Cidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCidade.Focus();
                    return false;
                }
                else if (Convert.ToInt32(txtIdCidade.Text) < 0)
                {
                    MessageBox.Show("Código cidade inválido, deve ser maior que zero.", "Informe o código da cidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCidade.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtCelular.Text))
                {
                    MessageBox.Show("Faltou informar o celular", "Informe o celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                    return false;
                }
                else if (txtCelular.Text.Length < 10)
                {
                    MessageBox.Show("Celular inválido, deve ter no mínimo 10 números", "Informe o celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtCodCondicao.Text))
                {
                    txtCodCondicao.Text = "";
                }
                else if (Convert.ToInt32(txtCodCondicao.Text) < 0)
                {
                    MessageBox.Show("Código da condição inválida, deve ser maior que zero.", "Informe o código da condição!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodCondicao.Focus();
                    return false;
                }
                if (!String.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    if(!ValidaEmail(txtEmail.Text))
                    {
                        MessageBox.Show("Email inválido ", "Informe um email valido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return false;
                    }
                }
                if (txtEmail.Text.Trim().Length > 30)
                {
                    MessageBox.Show("Não é possivel inserir este email", "Informe o email com menos de 30 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
                if (rbFisica.Checked && chkEstrangeiro.Checked)
                {
                    if (!string.IsNullOrEmpty(txtCpf.Text)){
                        if (!IsCpf(txtCpf.Text) || txtCpf.Text.Length < 11)
                        {
                            MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCpf.Focus();
                            return false;
                        }
                    }
                    if (String.IsNullOrEmpty(txtSexo.Text.Trim()))
                    {
                        MessageBox.Show("Faltou informar o Sexo", "Informe o Sexo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSexo.Focus();
                        return false;
                    }
                    if (txtSexo.Text != "M" & txtSexo.Text != "F")
                    {
                        MessageBox.Show("Sexo inválido, deve ser 'M' ou 'F' ", "Verefique o Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSexo.Focus();
                        return false;
                    }
                    return true;
                }
                else if (rbFisica.Checked && !chkEstrangeiro.Checked)
                {
                    if (!IsCpf(txtCpf.Text) || txtCpf.Text.Length < 11)
                    {
                        MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCpf.Focus();
                        return false;
                    }
                    if (String.IsNullOrEmpty(txtSexo.Text.Trim()))
                    {
                        MessageBox.Show("Faltou informar o Sexo", "Informe o Sexo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSexo.Focus();
                        return false;
                    }
                    if (txtSexo.Text != "M" & txtSexo.Text != "F")
                    {
                        MessageBox.Show("Sexo inválido, deve ser 'M' ou 'F' ", "Verefique o Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSexo.Focus();
                        return false;
                    }
                    return true;
                }
                else if (rbJuridica.Checked)
                {
                    if (!IsCnpj(txtCpf.Text) || txtCpf.Text.Length < 14)
                    {
                        MessageBox.Show("CNPJ Inválido!", "Verefique o CNPJ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCpf.Focus();
                        return false;
                    }
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            return rg.IsMatch(email);
            
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
                txtIdCidade.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
            }
        }

        public void Carregar(object id)
        {
            Cliente = CtrlCliente.BuscarPorID(id) as Clientes;
            if (Cliente.juridico)
            {
                rbJuridica.Checked = true;
                txtCpf.Text = Cliente.cnpj;
                txtRg.Text = Cliente.ie;
                txtSite.Text = Cliente.site;
                rbFisica.Visible = false;
            }
            else
            {
                rbFisica.Checked = true;
                txtRg.Text = Cliente.rg;
                txtCpf.Text = Cliente.cpf;
                rbJuridica.Visible = false;
                chkEstrangeiro.Visible = Cliente.estrangeiro;
                chkEstrangeiro.Checked = Cliente.estrangeiro;
            }
            chkEstrangeiro.Checked = Cliente.estrangeiro;
            txtCodigo.Text = Convert.ToString(Cliente.codigo);
            txtCliente.Text = Cliente.cliente;
            txtApelido.Text = Cliente.apelido;
            txtDtNascimento.Text = Convert.ToString(Cliente.dtNascimento);
            txtSexo.Text = Convert.ToString(Cliente.sexo);
            txtEndereco.Text = Cliente.endereco;
            if(Cliente.numero == "0")
            {
                txtNumero.Text = "";
            }
            else
            {
                txtNumero.Text = Convert.ToString(Cliente.numero);
            }
            txtComplemento.Text = Cliente.complemento;
            if (Cliente.cep == "0")
            {
                txtCep.Text = "";
            }
            else
            {
                txtCep.Text = Cliente.cep;
            }
            txtBairro.Text = Cliente.bairro;
            txtIdCidade.Text = Convert.ToString(Cliente.Cidade.codigo);
            txtCidade.Text = Cliente.Cidade.cidade;
            txtUF.Text = Convert.ToString(Cliente.Cidade.Estado.uf);
            txtTelefone.Text = Cliente.telefone;
            txtCelular.Text = Cliente.celular;
            txtEmail.Text = Cliente.email;
            txtContato.Text = Cliente.contato;
            
            if(Cliente.CondPagamento == null)
            {
                txtCodCondicao.Text = "";
                txtCondicao.Text = "";
            }
            else
            {
                txtCodCondicao.Text = Convert.ToString(Cliente.CondPagamento.codigo);
                txtCondicao.Text = Cliente.CondPagamento.condicao;
            }
            txtLimiteCredito.Text = Cliente.limiteCredito.ToString("C", CultureInfo.CurrentCulture);
            txtObservacao.Text = Cliente.observacoes;
            txtDtCadastro.Text = Convert.ToString(Cliente.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(Cliente.dtAlteracao);
            txtUsuario.Text = Cliente.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtCliente.Text = "";
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
            txtContato.Text = "";
            txtSite.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtCodCondicao.Text = "";
            txtLimiteCredito.Text = "";
            txtObservacao.Text = "";
            txtDtCadastro.Text = "";
            txtDtAlteracao.Text = "";
            txtUsuario.Text = "";
            chkEstrangeiro.Checked = false;
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

        public Boolean IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        private void BtnBuscarConPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaCondicaoPagamento frmConCondPag = new frmConsultaCondicaoPagamento();
            frmConCondPag.btnVoltar.Text = "SELECIONAR";
            if (frmConCondPag.ShowDialog() == DialogResult.OK)
            {
                CarregaCondPagamento();
            }
        }

        public void CarregaCondPagamento()
        {

            if (condPagamento != null)
            {
                CondicaoPagamentos condPag = condPagamento as CondicaoPagamentos;
                txtCodCondicao.Text = Convert.ToString(condPag.codigo);
                txtCondicao.Text = condPag.condicao;
                txtCodCondicao.Enabled = false;
                txtCondicao.Enabled = false;
            }
        }

        private void TxtLimiteCredito_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void TxtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void TxtLimiteCredito_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void TxtIdCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void TxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void TxtCodCondicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void chkEstrangeiro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstrangeiro.Checked)
            {
                lblCpf.Text = "CPF";
            }
            else if (rbFisica.Checked)
            {
                 lblCpf.Text = "CPF *";
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCliente.Text))
            {
                if (txtCliente.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este cliente", "Informe o cliente com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                }
                else if (txtCliente.Text.Length < 3)
                {
                    MessageBox.Show("Cliente inválido!", "Verefique o Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    //return false;
                }
                else if (!MaskForm.ValidaTexto(txtCliente.Text))
                {
                    MessageBox.Show("Cliente inválido!", "Cliente não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                }

                else if (String.IsNullOrEmpty(txtCliente.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Cliente", "Informe o Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
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
                else if (txtApelido.Text.Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este apelido", "Informe o apelido com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApelido.Focus();
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
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCep.Text.Trim()))
            {
                txtCep.Text = "";
            }
            else if (txtCep.Text.Trim().Length < 8   )
            {
                MessageBox.Show("CEP inválido, é necessário no minímo 8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
            } else if (txtCep.Text.Trim().Length > 8)
            {
                MessageBox.Show("CEP inválido, é necessário no máximo 8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
            }
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

        private void txtContato_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContato.Text.Trim()))
            {
                if (!MaskForm.ValidaTexto(txtContato.Text))
                {
                    MessageBox.Show("Contato inválido!", "Contato não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContato.Focus();
                }
                else if (txtContato.Text.Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este contato", "Informe o contato com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContato.Focus();
                }
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCpf.Text))
            {
                if ((rbFisica.Checked && chkEstrangeiro.Checked) | (rbFisica.Checked && !chkEstrangeiro.Checked))
                {
                    if (!IsCpf(txtCpf.Text) || txtCpf.Text.Length < 11)
                    {
                        MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCpf.Focus();
                    }
                }
                else if (rbJuridica.Checked)
                {
                    if (!IsCnpj(txtCpf.Text) || txtCpf.Text.Length < 14)
                    {
                        MessageBox.Show("CNPJ Inválido!", "Verefique o CNPJ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCpf.Focus();
                    }
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!ValidaEmail(txtEmail.Text))
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

        private void txtSite_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSite.Text))
            {
                if (!MaskForm.ValidaSite(txtSite.Text))
                {
                    MessageBox.Show("Site inválido!", "Contato não pode conter numeros !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSite.Focus();
                }
            }
        }

        private void txtCodCondicao_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCondicao.Text))
                return;
            //if (Convert.ToInt32("0" + txtCodCondicao.Text) < 1 )
            //    return;
            CondicaoPagamentos Cond = CtrlCondicao.BuscarPorID(Convert.ToInt32(txtCodCondicao.Text)) as CondicaoPagamentos;
            if (Cond == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCondicao.Clear();
                txtCodCondicao.Clear();
                txtCondicao.Enabled = true;
                txtCodCondicao.Enabled = true;
            }
            else
            {
                txtCondicao.Text = Cond.condicao;
                txtCondicao.Enabled = false;
                txtCodCondicao.Enabled = false;
            }
        }

        private void txtIdCidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCidade.Text))
            {
                if (!MaskForm.ValidaNumero(txtIdCidade.Text.Trim()))
                {
                    MessageBox.Show("Codigo cidade inválido!", "Codigo da cidade dever ser númerico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCidade.Text = "";
                    txtIdCidade.Focus();
                }
                else if (string.IsNullOrEmpty(txtIdCidade.Text))
                {
                    MessageBox.Show("Faltou informar o codigo da cidade", "Informer o codigo da cidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdCidade.Focus();
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtRg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtNumero_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtApelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Sexo_KeyPress(sender, e);
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtCodCondicao_MouseDown(object sender, MouseEventArgs e)
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

        private void txtCep_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtLimiteCredito_MouseDown(object sender, MouseEventArgs e)
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
            //if (Convert.ToInt32("0" + txtIdCidade.Text) < 1)
            //    return;
            Cidades cid = CtrlCidade.BuscarPorID(Convert.ToInt32(txtIdCidade.Text)) as Cidades;
            if (cid == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCidade.Clear();
                txtIdCidade.Clear();
                txtUF.Clear();
                txtCidade.Enabled = true;
                txtUF.Enabled = true;
                txtIdCidade.Enabled = true;
                txtIdCidade.Focus();
            }
            else
            {
                txtCidade.Text = cid.cidade;
                txtUF.Text = cid.Estado.uf;
                txtUF.Enabled = false;
                txtCidade.Enabled = false;
                txtIdCidade.Focus();
            }
        }

        private void txtSexo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtDtNascimento_Leave(object sender, EventArgs e)
        {
            if (txtDtNascimento.Value >= DateTime.Now)
            {
                MessageBox.Show("Não é possivel inserir esta data", "informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDtNascimento.Focus();
            }
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
