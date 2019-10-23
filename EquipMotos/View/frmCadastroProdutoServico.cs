﻿using EquipMotos.DAO;
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
        ProdutosServicos proServ = new ProdutosServicos();
        ProdutosServicosDAO dao = new ProdutosServicosDAO();
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
                        proServ.produto = txtProdutoServico.Text;
                        proServ.unidade = txtUnidade.Text;
                        proServ.codBarra = txtCodBarra.Text;
                        proServ.qtd = Convert.ToInt32("0");
                        cat.codigo = Convert.ToInt32("0" + txtCodCategoria.Text);
                        proServ.Categoria = cat;
                        forn.codigo = Convert.ToInt32("0" + txtCodFornecedor.Text);
                        proServ.Fornecedor = forn;
                        proServ.custoUltCompra = Convert.ToDecimal(Decimal.Parse("0").ToString("N2"));
                        proServ.dtUltCompra = DateTime.Now;
                        proServ.observacoes = txtObservacao.Text;
                        proServ.usuario = txtUsuario.Text;
                        proServ.servico = Convert.ToBoolean(rbServico.Checked);
                    }
                    else
                    {
                        proServ.produto = txtProdutoServico.Text;
                        cat.codigo = Convert.ToInt32(txtCodCategoria.Text);
                        proServ.Categoria = cat;
                        func.codigo = Convert.ToInt32(txtCodFornecedor.Text);
                        proServ.Funcionario = func;
                        proServ.servico = Convert.ToBoolean(rbServico.Checked);
                    }
                    proServ.comissao = Double.Parse(txtComissao.Text, NumberStyles.Any);
                    proServ.observacoes = txtObservacao.Text;
                    proServ.usuario = txtUsuario.Text;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        proServ.codigo = Convert.ToInt32(txtCodigo.Text);
                        proServ.dtAlteracao = DateTime.Now;
                        dao.Editar(proServ);
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
                        proServ.dtCadastro = DateTime.Now;
                        proServ.dtAlteracao = DateTime.Now;
                        dao.Inserir(proServ);
                        if (rbProduto.Checked)
                        {
                            MessageBox.Show("Produto salvo com Sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Serviço salvo com Sucesso!");
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
            proServ = dao.BuscarPorID(id) as ProdutosServicos;
            if(proServ.servico == false)
            {
                rbProduto.Checked = true;
                txtUnidade.Text = proServ.unidade;
                txtCodBarra.Text = Convert.ToString(proServ.codBarra);
                txtCodFornecedor.Text = Convert.ToString(proServ.Fornecedor.codigo);
                txtFornecedor.Text = Convert.ToString(proServ.Fornecedor.fornecedor);
                txtCustoUltCompra.Text = Convert.ToString(proServ.custoUltCompra);
                txtDtUltCompra.Text = Convert.ToString(proServ.dtUltCompra);
            }
            else
            {
                rbServico.Checked = true;
                txtCodFornecedor.Text = Convert.ToString(proServ.Funcionario.codigo);
                txtFornecedor.Text = Convert.ToString(proServ.Funcionario.funcionario);

            }
            txtCodigo.Text = Convert.ToString(proServ.codigo);
            txtProdutoServico.Text = proServ.produto;
            txtCodCategoria.Text = Convert.ToString(proServ.Categoria.codigo);
            txtCategoriaGrupo.Text = Convert.ToString(proServ.Categoria.categoria);
            txtComissao.Text = Convert.ToString(proServ.comissao);
            txtObservacao.Text = proServ.observacoes;
            txtDtCadastro.Text = Convert.ToString(proServ.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(proServ.dtAlteracao);
            txtUsuario.Text = proServ.usuario;
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
                frmConsultaFuncionario frmConFuncionario = new frmConsultaFuncionario(pusuario);
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
                if (txtProdutoServico.Text.Length < 3)
                {
                    MessageBox.Show("Produto inválido!", "Verefique o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }
                if (txtProdutoServico.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Faltou informar o Produto", "Informe o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }

                if (txtUnidade.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Faltou informar o Unidade", "Informe a Unidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnidade.Focus();
                    return false;
                }
                if (txtCategoriaGrupo.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Faltou informar a Categoria", "Informe a Categoria!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategoriaGrupo.Focus();
                    return false;
                }
                if (txtCodFornecedor.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Faltou informar o Código do Fornecedor", "Informe o Código do Fornecedor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodFornecedor.Focus();
                    return false;
                }
                if (txtFornecedor.Text.Trim() == String.Empty )
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
                if (txtProdutoServico.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Faltou informar o Serviço", "Informe o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdutoServico.Focus();
                    return false;
                }

                if (txtCategoriaGrupo.Text.Trim() == String.Empty)
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
                if (txtFornecedor.Text.Trim() == String.Empty & txtFornecedor.Text.Length < 2)
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
            lblPrecoVenda.Visible = true;
            txtPrecoVenda.Visible = true;
        }

        private void RbServico_CheckedChanged(object sender, EventArgs e)
        {
            lblProdutoServico.Text = "Serviço *";
            lblUnidade.Visible = false;
            txtUnidade.Visible = false;
            lblCodigoBarra.Visible = false;
            txtCodBarra.Visible = false;
            lblFornecedor.Text = "Mecanico *";
            lblPrecoVenda.Visible = false;
            txtPrecoVenda.Visible = false;
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
