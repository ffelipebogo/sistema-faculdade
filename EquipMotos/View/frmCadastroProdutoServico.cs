﻿using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroProdutoServico : Form
    {
        String pusuario;
        ProdutosServicos ProdutoServico = new ProdutosServicos();
        CtrlProdutosServicos CtrlProdutoServico = new CtrlProdutosServicos();
        public static object categoria;
        public static object fornecedor;
        public static object funcionario;

        public frmCadastroProdutoServico()
        {
            InitializeComponent();
            rbProduto.Checked = true;
            txtUsuario.Text = "ADM";
            txtDtAlteracao.Text = Convert.ToString(DateTime.Now);
            txtDtCadastro.Text = Convert.ToString(DateTime.Now);
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
                    Fornecedores forn = new Fornecedores();
                    Funcionarios func = new Funcionarios();
                    Categorias cat = new Categorias();

                    if (rbProduto.Checked)
                    {
                        ProdutoServico.produto = txtProdutoServico.Text;
                        ProdutoServico.unidade = txtUnidade.Text;
                        ProdutoServico.codBarra = txtCodBarra.Text;
                        ProdutoServico.qtd = Convert.ToInt32("0");
                        cat.codigo = Convert.ToInt32("0" + txtCodCategoria.Text);
                        ProdutoServico.Categoria = cat;
                        forn.codigo = Convert.ToInt32("0" + txtCodFornecedor.Text);
                        ProdutoServico.Fornecedor = forn;
                        ProdutoServico.precoVenda =Decimal.Parse(txtPrecoVenda.Text, NumberStyles.Any);
                        ProdutoServico.custoUltCompra = Decimal.Parse("0", NumberStyles.Any);
                        ProdutoServico.dtUltCompra = DateTime.Now;
                        ProdutoServico.observacoes = txtObservacao.Text;
                        ProdutoServico.usuario = txtUsuario.Text;
                        ProdutoServico.servico = Convert.ToBoolean(rbServico.Checked);
                    }
                    else
                    {
                        ProdutoServico.produto = txtProdutoServico.Text;
                        cat.codigo = Convert.ToInt32(txtCodCategoria.Text);
                        ProdutoServico.Categoria = cat;
                        func.codigo = Convert.ToInt32(txtCodFornecedor.Text);
                        ProdutoServico.precoVenda = Decimal.Parse(txtPrecoVenda.Text, NumberStyles.Any);
                        ProdutoServico.Funcionario = func;
                        ProdutoServico.servico = Convert.ToBoolean(rbServico.Checked);
                    }
                    ProdutoServico.comissao = Double.Parse("0" + txtComissao.Text, NumberStyles.Any);
                    ProdutoServico.observacoes = txtObservacao.Text;
                    ProdutoServico.usuario = txtUsuario.Text;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        ProdutoServico.codigo = Convert.ToInt32(txtCodigo.Text);
                        ProdutoServico.dtAlteracao = DateTime.Now;
                        CtrlProdutoServico.Editar(ProdutoServico);
                        if (rbProduto.Checked)
                        {
                            MessageBox.Show("Produto alterado com Sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Serviço alterado com Sucesso!");
                        }
                    }
                    else
                    {
                        ProdutoServico.dtCadastro = DateTime.Now;
                        ProdutoServico.dtAlteracao = DateTime.Now;
                        CtrlProdutoServico.Inserir(ProdutoServico);
                        if (rbProduto.Checked)
                        {
                            MessageBox.Show("Produto salvo com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Serviço salvo com sucesso!");
                        }
                    }
                    limparCampos();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }
        public void Carregar(object id)
        {
            ProdutoServico = CtrlProdutoServico.BuscarPorID(id) as ProdutosServicos;
            if(ProdutoServico.servico == false)
            {
                rbProduto.Checked = true;
                txtUnidade.Text = ProdutoServico.unidade;
                txtCodBarra.Text = Convert.ToString(ProdutoServico.codBarra);
                txtCodFornecedor.Text = Convert.ToString(ProdutoServico.Fornecedor.codigo);
                txtFornecedor.Text = Convert.ToString(ProdutoServico.Fornecedor.fornecedor);
                txtCustoUltCompra.Text = Convert.ToString(ProdutoServico.custoUltCompra);
                txtDtUltCompra.Text = Convert.ToString(ProdutoServico.dtUltCompra);
            }
            else
            {
                rbServico.Checked = true;
                txtCodFornecedor.Text = Convert.ToString(ProdutoServico.Funcionario.codigo);
                txtFornecedor.Text = Convert.ToString(ProdutoServico.Funcionario.funcionario);

            }
            txtCodigo.Text = Convert.ToString(ProdutoServico.codigo);
            txtProdutoServico.Text = ProdutoServico.produto;
            txtCodCategoria.Text = Convert.ToString(ProdutoServico.Categoria.codigo);
            txtCategoriaGrupo.Text = Convert.ToString(ProdutoServico.Categoria.categoria);
            txtComissao.Text = Convert.ToString(ProdutoServico.comissao);
            txtPrecoVenda.Text = Convert.ToString(ProdutoServico.precoVenda);
            txtObservacao.Text = ProdutoServico.observacoes;
            txtDtCadastro.Text = Convert.ToString(ProdutoServico.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(ProdutoServico.dtAlteracao);
            txtUsuario.Text = ProdutoServico.usuario;
            btnSalvar.Text = "ALTERAR";
        }
        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtProdutoServico.Text = "";
            txtUnidade.Text = "";
            txtCodBarra.Text = "";
            txtCodCategoria.Text = "";
            txtCategoriaGrupo.Text = "";
            txtCodFornecedor.Text = "";
            txtFornecedor.Text = "";
            txtPrecoVenda.Text = "R$ 0.00";
            txtCustoUltCompra.Text = "";
            txtDtUltCompra.Text = "";
            txtComissao.Text = "";
            txtObservacao.Text = "";
            txtDtCadastro.Text = "";
            txtDtAlteracao.Text = "";
            txtUsuario.Text = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            if(rbProduto.Checked == true)
            {
                frmConsultaFornecedor frmConFornecedor = new frmConsultaFornecedor();
                frmConFornecedor.btnVoltar.Text = "SELECIONAR";
                if (frmConFornecedor.ShowDialog() == DialogResult.OK)
                {
                    CarregaFornecedor();
                }
            }
            else
            {
                frmConsultaFuncionario frmConFuncionario = new frmConsultaFuncionario();
                frmConFuncionario.btnVoltar.Text = "SELECIONAR";
                if (frmConFuncionario.ShowDialog() == DialogResult.OK)
                {
                    CarregaFuncionario();
                }
            }
        }

        private void CarregaFornecedor()
        {
            if (fornecedor != null)
            {
                Fornecedores forn = fornecedor as Fornecedores;
                txtCodFornecedor.Text = Convert.ToString(forn.codigo);
                txtFornecedor.Text = forn.fornecedor;
            }
        }

        private void CarregaFuncionario()
        {
            if (funcionario != null)
            {
                Funcionarios func = funcionario as Funcionarios;
                txtCodFornecedor.Text = Convert.ToString(func.codigo);
                txtFornecedor.Text = func.funcionario;
            }
        }

        private void BtnBuscarCategoria_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frmConCategoria = new frmConsultaCategoria();
            frmConCategoria.btnVoltar.Text = "SELECIONAR";
            if (frmConCategoria.ShowDialog() == DialogResult.OK)
            {
                CarregaCategoria();
            }
        }

        private void CarregaCategoria()
        {
            if (categoria != null)
            {
                Categorias cat = categoria as Categorias;
                txtCodCategoria.Text = Convert.ToString(cat.codigo);
                txtCategoriaGrupo.Text = cat.categoria;
            }
        }

        public bool ValidaCampos()
        {
            if (rbProduto.Checked)
            {
                if (String.IsNullOrEmpty(txtPrecoVenda.Text) || Decimal.Parse(txtPrecoVenda.Text, NumberStyles.Any) < 0)
                {
                    MessageBox.Show("Preço inválido!", "Informe o Preço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecoVenda.Focus();
                    return false;
                }
                if (txtProdutoServico.Text.Length < 3)
                {
                    MessageBox.Show("Produto inválido!", "Verefique o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtProdutoServico.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Produto", "Informe o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }
                if (!MaskForm.ValidaTexto(txtProdutoServico.Text))
                {
                    MessageBox.Show("Produto inválido!", "Produto não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtUnidade.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Unidade", "Informe a Unidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnidade.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtCategoriaGrupo.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar a Categoria", "Informe a Categoria!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoriaGrupo.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtCodFornecedor.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Código do Fornecedor", "Informe o Código do Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodFornecedor.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtFornecedor.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Fornecedor", "Informe o Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFornecedor.Focus();
                    return false;
                }
            }
            else
            {
                if (txtProdutoServico.Text.Length < 3)
                {
                    MessageBox.Show("Serviço inválido!", "Verefique o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }
                if (!MaskForm.ValidaTexto(txtProdutoServico.Text))
                {
                    MessageBox.Show("Serviço inválido!", "Serviço não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtProdutoServico.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Serviço", "Informe o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(txtCategoriaGrupo.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar a Categoria", "Informe a Categoria!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoriaGrupo.Focus();
                    return false;
                }
                if (txtCodFornecedor.Text.Trim() == String.Empty & txtCodFornecedor.Text.Length < 2)
                {
                    MessageBox.Show("Faltou informar o Código do Funcionario", "Informe o Código do Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodFornecedor.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtFornecedor.Text.Trim()) & txtFornecedor.Text.Length < 2)
                {
                    MessageBox.Show("Faltou informar o Funcionario", "Informe o Funcionario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFornecedor.Focus();
                    return false;
                }
            }
            return true;
        }

        private void RbProduto_CheckedChanged(object sender, EventArgs e)
        {
            lblProdutoServico.Text = "Produto *";
            lblUnidade.Visible = true;
            txtUnidade.Visible = true;
            lblCodigoBarra.Visible = true;
            txtCodBarra.Visible = true;
            lblCodigoFornecedor.Visible = true;
            txtCodFornecedor.Visible = true;
            lblFornecedor.Text = "Fornecedor *";
            txtFornecedor.Visible = true;
            
            lblCustoUltCompra.Visible = true;
            txtCustoUltCompra.Visible = true;
            lblDtUltCompra.Visible = true;
            txtDtUltCompra.Visible = true;
           
        }

        private void RbServico_CheckedChanged(object sender, EventArgs e)
        {
            lblProdutoServico.Text = "Serviço *";
            lblUnidade.Visible = false;
            txtUnidade.Visible = false;
            lblCodigoBarra.Visible = false;
            txtCodBarra.Visible = false;
            lblFornecedor.Text = "Mecanico *";
           
            lblCustoUltCompra.Visible = false;
            txtCustoUltCompra.Visible = false;
            lblDtUltCompra.Visible = false;
            txtDtUltCompra.Visible = false;

        }
        String vlr;
        private void TxtComissao_Leave(object sender, EventArgs e)
        {
            try
            {
                txtComissao.Select(txtComissao.Text.Length, 0);
            }
            catch (Exception)
            {

            }
        }
        private void TxtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtComissao.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }
        private void TxtComissao_KeyUp(object sender, KeyEventArgs e)
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

        private void frmCadastroProdutoServico_Load(object sender, EventArgs e)
        {

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

        private void txtCodCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCustoUltCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCustoUltCompra_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtCustoUltCompra_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }
    }
}
