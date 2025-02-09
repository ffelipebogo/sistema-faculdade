﻿using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View;
using EquipMotos.View.helper;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EquipMotos.Codigo.View
{
    public partial class frmCadastroFornecedor : MaterialSkin.Controls.MaterialForm
    {
        CtrlFornecedores CtrlFornecedor = new CtrlFornecedores();
        Fornecedores Fornecedor = new Fornecedores();
        CtrlCidades CtrlCidade = new CtrlCidades();
        CtrlCondicaoPagamento CtrlCondicao = new CtrlCondicaoPagamento();
        public static object cidade = null;
        public static object condPagamento = null;
        public frmCadastroFornecedor()
        {
            InitializeComponent();
            rbJuridica.Checked = true;
            btnSalvar.Text = "SALVAR";
            
        }

        private void FrmCadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                { 
                    Cidades cid = new Cidades();
                    CondicaoPagamentos condPag = new CondicaoPagamentos();

                    Fornecedor.fornecedor = txtFornecedor.Text;
                    Fornecedor.nomeFantasia = txtNomeFantasia.Text;
                    Fornecedor.dtFundacao = Convert.ToDateTime(txtDtFundacao.Text);
                    Fornecedor.endereco = txtEndereco.Text;
                    Fornecedor.numero = Convert.ToString(txtNumero.Text);
                    Fornecedor.complemento = txtComplemento.Text;
                    Fornecedor.bairro = txtBairro.Text;
                    Fornecedor.cep = txtCep.Text;

                    cid.codigo = Convert.ToInt16("0"+txtIdCidade.Text);
                    Fornecedor.Cidade = cid;
                    
                    Fornecedor.telefone = txtTelefone.Text;
                    Fornecedor.celular = txtCelular.Text;
                    Fornecedor.email = txtEmail.Text;
                    Fornecedor.contato = txtContato.Text;
                    Fornecedor.site = txtSite.Text;
                    if (rbJuridica.Checked)
                    {
                        Fornecedor.cnpj = txtCnpj.Text;
                        Fornecedor.ie = txtIe.Text;
                        Fornecedor.cpf = "";
                        Fornecedor.rg = "";
                        Fornecedor.sexo = '\0';

                    }
                    else
                    {
                        Fornecedor.cpf = txtCnpj.Text;
                        Fornecedor.rg = txtIe.Text;
                        Fornecedor.cnpj = "";
                        Fornecedor.ie = "";
                        Fornecedor.sexo = Convert.ToChar(txtSexo.Text);

                    }
                    if ((Convert.ToInt32("0") + Convert.ToInt32(txtCodCondicao.Text)) != 0)
                    {
                        condPag.codigo = Convert.ToInt32("0" + txtCodCondicao.Text);
                        Fornecedor.CondPagamento = condPag;
                    }
                    Fornecedor.limiteCredito = Double.Parse(txtLimiteCredito.Text, NumberStyles.Any);
                    Fornecedor.observacoes = txtObservacao.Text;
                    
                    Fornecedor.usuario = UsuarioLogado.Usuario;
                    Fornecedor.fisico = rbFisica.Checked;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        Fornecedor.codigo = Convert.ToInt32("0"+txtCodigo.Text);
                        Fornecedor.dtAlteracao = DateTime.Now;
                        Fornecedor.dtCadastro = Convert.ToDateTime(txtDtCadastro.Text);
                        CtrlFornecedor.Editar(Fornecedor);

                        MessageBox.Show("Fornecedor alterado com Sucesso!");
                    }
                    else
                    {
                        Fornecedor.dtCadastro = DateTime.Now;
                        Fornecedor.dtAlteracao = DateTime.Now;
                        CtrlFornecedor.Inserir(Fornecedor);

                        MessageBox.Show("Fornecedor cadastrado com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RbFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = true;
            txtSexo.Visible = true;

            lblNomeFantasia.Text = "Apelido";
            lblDtFundacao.Text = "DT.Nascimento";
            lblCnpj.Text = "CPF *";
            txtCnpj.Mask = "000.000.000-00";
            txtCnpj.Clear();
            lblIe.Text = "RG";

            lblSite.Visible = false;
            txtSite.Visible = false;
        }

        private void RbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblSexo.Visible = false;
            txtSexo.Visible = false;
            txtSexo.Clear();
            lblNomeFantasia.Text = "Nome Fantasia";
            lblDtFundacao.Text = "Fundação";
            lblCnpj.Text = "CNPJ *";
            txtCnpj.Mask = "00.000.000/0000-00";
            txtCnpj.Clear();
            lblIe.Text = "I.E";

            lblSite.Visible = true;
            txtSite.Visible = true;
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtFornecedor.Text = "";
            //rbFisica.Select();
            txtNomeFantasia.Text = "";
            txtDtFundacao.Text = "";
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
            txtIe.Text = "";
            txtCnpj.Text = "";
            txtCodCondicao.Text = "";
            txtLimiteCredito.Text = "";
            txtObservacao.Text = "";
            txtDtCadastro.Text = "";
            txtDtAlteracao.Text = "";
            txtUsuario.Text = "";
            txtIdCidade.Enabled = true;
            txtCidade.Enabled = true;
        }

        public void Carregar(object id)
        {
            Fornecedores forn = CtrlFornecedor.BuscarPorID(id) as Fornecedores;
            
            txtCodigo.Text = Convert.ToString(forn.codigo);
            txtFornecedor.Text = forn.fornecedor;
            //rbFisica.Select();
            txtNomeFantasia.Text = forn.nomeFantasia;
            txtDtFundacao.Text = Convert.ToString(forn.dtFundacao);
            txtSexo.Text = Convert.ToString(forn.sexo);
            txtEndereco.Text = forn.endereco;
            txtNumero.Text = Convert.ToString(forn.numero);
            txtComplemento.Text = forn.complemento;
            txtCep.Text = forn.cep;
            txtBairro.Text = forn.bairro;
            txtIdCidade.Text = Convert.ToString(forn.Cidade.codigo);
            txtCidade.Text = forn.Cidade.cidade;
            txtUF.Text = forn.Cidade.Estado.uf;
            txtTelefone.Text = forn.telefone;
            txtCelular.Text = forn.celular;
            txtEmail.Text = forn.email;
            txtContato.Text = forn.contato;
            txtSite.Text = forn.site;
            if(forn.CondPagamento == null)
            {
                txtCodCondicao.Text = Convert.ToString("");
                txtCondicao.Text = "";
            }
            else
            {
                txtCodCondicao.Text = Convert.ToString(forn.CondPagamento.codigo);
                txtCondicao.Text = forn.CondPagamento.condicao;
            }
            
            txtLimiteCredito.Text = Convert.ToString(forn.limiteCredito);
            txtObservacao.Text = forn.observacoes;
            txtDtCadastro.Text = Convert.ToString(forn.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(forn.dtAlteracao);
            txtUsuario.Text = forn.usuario;
            btnSalvar.Text = "ALTERAR";
            if (forn.fisico == false)
            {
                rbJuridica.Checked = true;
                txtIe.Text = forn.ie;
                txtCnpj.Text = forn.cnpj;
            }
            else
            {
                rbFisica.Checked = true;
                txtCnpj.Text = forn.cpf;
                txtIe.Text = forn.rg;
                txtSexo.Text = Convert.ToString(forn.sexo);
            }
        }

        private void BtnBuscarCondPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaCondicaoPagamento frmConCondPag = new frmConsultaCondicaoPagamento();
            frmConCondPag.btnVoltar.Text = "SELECIONAR";
            // frmConCidade.Show();
            if (frmConCondPag.ShowDialog() == DialogResult.OK)
            {
                CarregaCondPagamento();
            }
        }

        private void CarregaCondPagamento()
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

        private void BtnBuscarCidade_Click(object sender, EventArgs e)
        {
            frmConsultaCidade frmConCidade = new frmConsultaCidade();
            frmConCidade.btnVoltar.Text = "SELECIONAR";
            if (frmConCidade.ShowDialog() == DialogResult.OK)
            {
                CarregaCidade();
            }
        }

        private void CarregaCidade()
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

        public bool ValidaCampos()
        {
            if (txtFornecedor.Text.Length < 3)
            {
                MessageBox.Show("Fornecedor inválido!", "Verefique o Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFornecedor.Focus();
                return false;
            }
            if (txtFornecedor.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este fornecedor", "Informe o fornecedor com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFornecedor.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtFornecedor.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Fornecedor", "Informe o Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFornecedor.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtFornecedor.Text))
            {
                MessageBox.Show("Fornecedor inválido!", "Fornecedor não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFornecedor.Focus();
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
            if (txtCep.Text.Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido, é necessário  8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtIdCidade.Text.Trim()) & txtIdCidade.Text.Length < 0)
            {
                MessageBox.Show("Faltou informar o Cidade", "Informe o Cidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCidade.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtCelular.Text.Trim()) & txtCelular.Text.Length < 11)
            {
                MessageBox.Show("Faltou informar o Celular", "Informe o Celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
                return false;
            }
            if (Double.Parse(txtLimiteCredito.Text, NumberStyles.Any) < 0)
            {
                MessageBox.Show("Limite de crédito inválido", "Informe o Limite de crédito!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimiteCredito.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodCondicao.Text.Trim()))
            {
                MessageBox.Show("Código Condição de Pagamento Inválido!", "Informe o Código da Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCondicao.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtCodCondicao.Text) < 0)
            {
                MessageBox.Show("Código Condição de Pagamento Inválido!", "Verefique o Código Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodCondicao.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCondicao.Text.Trim()))
            {
                MessageBox.Show("Condição de Pagamento Inválida!", "Informe a Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCondicao.Focus();
                return false;
            }
            else if (txtCondicao.Text.Length < 3)
            {
                MessageBox.Show("Condição de Pagamento Inválida!", "Informe a Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCondicao.Focus();
                return false;
            }
            if (rbFisica.Checked)
            {
                if (!IsCpf(txtCnpj.Text) || txtCnpj.Text.Length < 11)
                {
                    MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCnpj.Focus();
                    return false;
                }
                if (txtDtFundacao.Text == DateTime.Now.ToString())
                {
                    MessageBox.Show("Data Nascimento inválida", "Informe a Data de Nascimento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtFundacao.Focus();
                    return false;
                }
                else if (Convert.ToDateTime(txtDtFundacao.Text) > DateTime.Now)
                {
                    MessageBox.Show("Data Nascimento inválida", "Informe a Data de Nascimento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtFundacao.Focus();
                    return false;
                }
                if (txtSexo.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Faltou informar o Sexo", "Informe o Sexo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSexo.Focus();
                    return false;
                }else if (txtSexo.Text != "M" & txtSexo.Text != "F")
                {
                    MessageBox.Show("Sexo inválido, sexo deve ser ( 'M' ou 'F')", "Verefique o Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSexo.Focus();
                    return false;
                }
            }
            else if (rbJuridica.Checked)
            {
                if (!IsCnpj(txtCnpj.Text) || txtCnpj.Text.Length < 14)
                {
                    MessageBox.Show("CNPJ Inválido!", "Verefique o CNPJ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCnpj.Focus();
                    return false;
                }
                if (txtDtFundacao.Text == DateTime.Now.ToString())
                {
                    MessageBox.Show("Data Fundação inválida", "Informe a Data de Fundação!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtFundacao.Focus();
                    return false;
                }
                else if (Convert.ToDateTime(txtDtFundacao.Text) > DateTime.Now)
                {
                    MessageBox.Show("Data Fundação inválida", "Informe a Data de Fundação!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtFundacao.Focus();
                    return false;
                }
                return true;
            }
            return true;
        }

        //public Boolean ValidaEmail(string email)
        //{
        //    Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

        //    if (rg.IsMatch(email))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

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

        private void txtCodCondicao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodCondicao.Text))
            {
                if (Convert.ToInt32(txtCodCondicao.Text) != 0)
                {
                    var condicao = CtrlCondicao.BuscarPorID(txtCodCondicao.Text);
                    if (condicao == null)
                    {
                        MessageBox.Show("Nenhum resultado");
                    }
                    else
                    {
                        condPagamento = condicao;
                        CarregaCondPagamento();
                    }
                }
            }
        }

        String vlr;
        private void TxtLimiteCredito_Leave(object sender, EventArgs e)
        {
            try
            {
                vlr = txtLimiteCredito.Text.Replace("R$", "");
                txtLimiteCredito.Text = string.Format("{0:C}", Convert.ToDouble("0" + vlr));
            }
            catch (Exception)
            {

            }
        }

        private void TxtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtLimiteCredito.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void TxtLimiteCredito_KeyUp(object sender, KeyEventArgs e)
        {
            vlr = txtLimiteCredito.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (vlr.Length == 0)
            {
                txtLimiteCredito.Text = "0,00" + vlr;
            }
            if (vlr.Length == 1)
            {
                txtLimiteCredito.Text = "0,0" + vlr;
            }
            if (vlr.Length == 2)
            {
                txtLimiteCredito.Text = "0," + vlr;
            }
            else if (vlr.Length >= 3)
            {
                if (txtLimiteCredito.Text.StartsWith("0,"))
                {
                    txtLimiteCredito.Text = vlr.Insert(vlr.Length - 2, ",").Replace("0,", "");
                }
                else if (txtLimiteCredito.Text.Contains("00,"))
                {
                    txtLimiteCredito.Text = vlr.Insert(vlr.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtLimiteCredito.Text = vlr.Insert(vlr.Length - 2, ",");
                }
            }
            vlr = txtLimiteCredito.Text;
            txtLimiteCredito.Text = string.Format("{0:C}", Convert.ToDouble("0" + vlr));
            txtLimiteCredito.Select(txtLimiteCredito.Text.Length, 0);
        }

        private void TxtCodCondicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
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
            }
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFornecedor.Text))
            {
                if (txtFornecedor.Text.Length < 3)
                {
                    MessageBox.Show("Fornecedor inválido!", "Informe o fornecedor com mais de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFornecedor.Focus();
                }
                else
                if (txtFornecedor.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Fornecedor inválido!", "Informe o fornecedor com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFornecedor.Focus();
                }
                else
                if (String.IsNullOrEmpty(txtFornecedor.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Fornecedor", "Informe o Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFornecedor.Focus();
                }
                else
                if (!MaskForm.ValidaTexto(txtFornecedor.Text))
                {
                    MessageBox.Show("Fornecedor inválido!", "Fornecedor não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFornecedor.Focus();
                }
            }
        }

        private void txtNomeFantasia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeFantasia.Text))
            {
                if (rbFisica.Checked)
                {
                    if (!MaskForm.ValidaTexto(txtNomeFantasia.Text))
                    {
                        MessageBox.Show("Apelido inválido!", "Apelido não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNomeFantasia.Focus();
                    }
                }
                else
                {
                    if (!MaskForm.ValidaTexto(txtNomeFantasia.Text))
                    {
                        MessageBox.Show("Nome Fantasia inválido!", "Nome Fantasia não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNomeFantasia.Focus();
                    }
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
            else if (txtCep.Text.Trim().Length != 8)
            {
                MessageBox.Show("CEP inválido, é necessário  8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
            }
            //else if (txtCep.Text.Trim().Length > 8)
            //{
            //    MessageBox.Show("CEP inválido, é necessário no máximo 8 números.", "Informe o CEP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCep.Focus();
            //}
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

        private void txtSite_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSite.Text))
            {
                if (!MaskForm.ValidaSite(txtSite.Text))
                {
                    MessageBox.Show("Site inválido!", "Formato de site inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSite.Focus();
                }
            }
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCnpj.Text))
            {
                if (rbFisica.Checked)
                {
                    if (!IsCpf(txtCnpj.Text) || txtCnpj.Text.Length < 11)
                    {
                        MessageBox.Show("CPF Inválido!", "Verefique o CPF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCnpj.Focus();
                    }
                }
                else if (rbJuridica.Checked)
                {
                    if (!IsCnpj(txtCnpj.Text) || txtCnpj.Text.Length < 14)
                    {
                        MessageBox.Show("CNPJ Inválido!", "Verefique o CNPJ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCnpj.Focus();
                    }
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Sexo_KeyPress(sender, e);
        }

        private void txtDtFundacao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtFundacao.Text))
            {
                if (txtDtFundacao.Value >= DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "informe uma data menor que hoje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtFundacao.Focus();
                }
            }
        }

        private void txtIdCidade_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtIdCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCep_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtSexo_MouseDown(object sender, MouseEventArgs e)
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

        private void txtCodCondicao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa de texto desabilitada.");
            }
        }
    }
}
