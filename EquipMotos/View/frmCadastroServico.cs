using EquipMotos.CONTROLLER;
using EquipMotos.MODEL;
using EquipMotos.View;
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

namespace EquipMotos.VIEW
{
    public partial class frmCadastroServico : MaterialSkin.Controls.MaterialForm
    {

        Servicos Servico = new Servicos();
        CtrlServicos CtrlServico = new CtrlServicos();
        CtrlCategorias CtrlCategoria = new CtrlCategorias();
        CtrlFuncionarios CtrlFuncionario = new CtrlFuncionarios();
        public static object categoria;
        public static object funcionario;

        public frmCadastroServico()
        {
            InitializeComponent();
        }

        private void frmCadastroServico_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario frmConFuncionario = new frmConsultaFuncionario();
            frmConFuncionario.btnVoltar.Text = "SELECIONAR";
            if (frmConFuncionario.ShowDialog() == DialogResult.OK)
            {
                CarregaFuncionario();
            }
        }

        private void CarregaFuncionario()
        {
            if (funcionario != null)
            {
                Funcionarios func = funcionario as Funcionarios;
                txtCodFornecedor.Text = Convert.ToString(func.codigo);
                txtFuncionario.Text = func.funcionario;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    Funcionarios func = new Funcionarios();
                    Categorias cat = new Categorias();

                    Servico.servico = txtServico.Text;
                    func.codigo = Convert.ToInt32(txtCodFornecedor.Text);
                    Servico.precoVenda = Decimal.Parse(txtPrecoVenda.Text, NumberStyles.Any);
                    Servico.Funcionario = func;
                   
                    Servico.comissao = Double.Parse("0" + txtComissao.Text, NumberStyles.Any);
                    Servico.observacoes = txtObservacao.Text;
                    Servico.usuario = UsuarioLogado.Usuario;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        Servico.codigo = Convert.ToInt32(txtCodigo.Text);
                        Servico.dtAlteracao = DateTime.Now;
                        CtrlServico.Editar(Servico);
                        MessageBox.Show("Serviço alterado com Sucesso!");
                    }
                    else
                    {
                        Servico.dtCadastro = DateTime.Now;
                        Servico.dtAlteracao = DateTime.Now;
                        CtrlServico.Inserir(Servico);
                       
                        MessageBox.Show("Serviço salvo com sucesso!");
                    }
                    limparCampos();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        public bool ValidaCampos()
        {
           
            if (txtServico.Text.Length < 3)
            {
                MessageBox.Show("Serviço inválido!", "Verefique o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServico.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtServico.Text))
            {
                MessageBox.Show("Serviço inválido!", "Serviço não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServico.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtServico.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Serviço", "Informe o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServico.Focus();
                return false;
            }

            if (txtCodFornecedor.Text.Trim() == String.Empty & txtCodFornecedor.Text.Length < 2)
            {
                MessageBox.Show("Faltou informar o Código do Funcionario", "Informe o Código do Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodFornecedor.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtFuncionario.Text.Trim()) & txtFuncionario.Text.Length < 2)
            {
                MessageBox.Show("Faltou informar o Funcionario", "Informe o Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFuncionario.Focus();
                return false;
            }
            
            return true;
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtServico.Text = "";
            txtCodFornecedor.Text = "";
            txtFuncionario.Text = "";
            txtPrecoVenda.Text = "R$ 0.00";
            txtComissao.Text = "";
            txtObservacao.Text = "";
            txtDtCadastro.Text = "";
            txtDtAlteracao.Text = "";
            txtUsuario.Text = "";
        }

        public void Carregar(object codigo)
        {
            Servico = CtrlServico.BuscarPorID(codigo) as Servicos;
           
              
            txtCodFornecedor.Text = Convert.ToString(Servico.Funcionario.codigo);
            txtFuncionario.Text = Convert.ToString(Servico.Funcionario.funcionario);

            txtCodigo.Text = Convert.ToString(Servico.codigo);
            txtServico.Text = Servico.servico;
            txtComissao.Text = Convert.ToString(Servico.comissao);
            txtPrecoVenda.Text = Convert.ToString(Servico.precoVenda);
            txtObservacao.Text = Servico.observacoes;
            txtDtCadastro.Text = Convert.ToString(Servico.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(Servico.dtAlteracao);
            txtUsuario.Text = Servico.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProdutoServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtProdutoServico_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServico.Text))
            {
                
                if (txtServico.Text.Length < 3)
                {
                    MessageBox.Show("Servico inválido!", "Informe o servico com mais de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServico.Focus();
                }
                else
                if (txtFuncionario.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Servico inválido!", "Informe o servico com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServico.Focus();
                }
                else
                if (String.IsNullOrEmpty(txtServico.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Servico", "Informe o Servico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServico.Focus();
                }
                else
                if (!MaskForm.ValidaTexto(txtServico.Text))
                {
                    MessageBox.Show("Servico inválido!", "Servico não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServico.Focus();
                }
                
            }
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);

        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtServico.Text))
            {

            }
        }

        private void txtCodFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFornecedor.Text))
            {
               
                if (Convert.ToInt32("0" + txtCodFornecedor.Text) < 1)
                    return;
                Funcionarios func = CtrlFuncionario.BuscarPorID(Convert.ToInt32(txtCodFornecedor.Text)) as Funcionarios;
                if (func == null)
                {
                    MessageBox.Show("Nenhum resultado");
                    txtFuncionario.Text = "";
                    txtCodFornecedor.Text = "";
                    txtFuncionario.Enabled = true;
                    txtCodFornecedor.Enabled = true;
                }
                else
                {
                    txtFuncionario.Text = func.funcionario;
                    txtFuncionario.Enabled = false;
                    txtCodFornecedor.Enabled = false;
                }
                func = null;
            }
            
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtPrecoVenda_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }
        String vlr;
        private void txtComissao_KeyUp(object sender, KeyEventArgs e)
        {
            vlr = txtComissao.Text.Replace(" ", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (vlr.Length == 0)
            {
                txtComissao.Text = "0,00" + vlr;
            }
            if (vlr.Length == 1)
            {
                txtComissao.Text = "0,0" + vlr;
            }
            if (vlr.Length == 2)
            {
                txtComissao.Text = "0," + vlr;
            }
            else if (vlr.Length >= 3)
            {
                if (txtComissao.Text.StartsWith("0,"))
                {
                    txtComissao.Text = vlr.Insert(vlr.Length - 2, ",").Replace("0,", "");
                }
                else if (txtComissao.Text.Contains("00,"))
                {
                    txtComissao.Text = vlr.Insert(vlr.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtComissao.Text = vlr.Insert(vlr.Length - 2, ",");
                }
            }
            vlr = txtComissao.Text;
            txtComissao.Text = Convert.ToDouble("0" + vlr).ToString();
            txtComissao.Select(txtComissao.Text.Length, 0);
        }

        private void txtComissao_Leave(object sender, EventArgs e)
        {
            try
            {
                txtComissao.Select(txtComissao.Text.Length, 0);
            }
            catch (Exception)
            {

            }
        }
    }
}
