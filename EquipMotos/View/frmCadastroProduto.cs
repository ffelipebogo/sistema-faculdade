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
    public partial class frmCadastroProduto : MaterialSkin.Controls.MaterialForm
    {

        Produtos Produto = new Produtos();
        CtrlProdutos CtrlProduto = new CtrlProdutos();
        CtrlCategorias CtrlCategoria = new CtrlCategorias();
        CtrlFornecedores CtrlFornecedor = new CtrlFornecedores();
        public static object categoria;
        public static object fornecedor;

        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
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
                txtCodCategoria.Enabled = false;
                txtCategoriaGrupo.Enabled = false;
            }
        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {

            frmConsultaFornecedor frmConFornecedor = new frmConsultaFornecedor();
            frmConFornecedor.btnVoltar.Text = "SELECIONAR";
            if (frmConFornecedor.ShowDialog() == DialogResult.OK)
            {
                CarregaFornecedor();
            }
        }

        private void CarregaFornecedor()
        {
            if (fornecedor != null)
            {
                Fornecedores forn = fornecedor as Fornecedores;
                txtCodFornecedor.Text = Convert.ToString(forn.codigo);
                txtFornecedor.Text = forn.fornecedor;
                txtCodFornecedor.Enabled = false;
                txtFornecedor.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    Fornecedores forn = new Fornecedores();
                    Categorias cat = new Categorias();

                    Produto.produto = txtProduto.Text;
                    Produto.unidade = txtUnidade.Text;
                    Produto.codBarra = txtCodBarra.Text;
                    Produto.qtd = Convert.ToInt32("0");
                    cat.codigo = Convert.ToInt32("0" + txtCodCategoria.Text);
                    Produto.Categoria = cat;
                    forn.codigo = Convert.ToInt32("0" + txtCodFornecedor.Text);
                    Produto.Fornecedor = forn;
                    Produto.precoVenda = Decimal.Parse(txtPrecoVenda.Text, NumberStyles.Any);
                    Produto.custoUltCompra = Decimal.Parse("0", NumberStyles.Any);
                    Produto.dtUltCompra = DateTime.Now;
                    Produto.observacoes = txtObservacao.Text;
                    Produto.usuario = txtUsuario.Text;
                    
                    Produto.comissao = Double.Parse("0" + txtComissao.Text, NumberStyles.Any);
                    Produto.observacoes = txtObservacao.Text;
                    Produto.usuario = txtUsuario.Text;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        Produto.codigo = Convert.ToInt32(txtCodigo.Text);
                        Produto.dtAlteracao = DateTime.Now;
                        CtrlProduto.Editar(Produto);
                        MessageBox.Show("Produto alterado com Sucesso!");
                    }
                    else
                    {
                        Produto.dtCadastro = DateTime.Now;
                        Produto.dtAlteracao = DateTime.Now;
                        CtrlProduto.Inserir(Produto);
                        MessageBox.Show("Produto salvo com sucesso!");
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void limparCampos()
        {
            txtCodigo.Text = "";
            txtProduto.Text = "";
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

        public bool ValidaCampos()
        {
           
            if (String.IsNullOrEmpty(txtPrecoVenda.Text) || Decimal.Parse(txtPrecoVenda.Text, NumberStyles.Any) < 0)
            {
                MessageBox.Show("Preço inválido!", "Informe o Preço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoVenda.Focus();
                return false;
            }
            if (txtProduto.Text.Length < 3)
            {
                MessageBox.Show("Produto inválido!", "Verefique o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtProduto.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Produto", "Informe o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtProduto.Text))
            {
                MessageBox.Show("Produto inválido!", "Produto não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
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
            return true;
            return true;
        }

        public void Carregar(object codigo)
        {
            Produto = CtrlProduto.BuscarPorID(codigo) as Produtos;

            txtUnidade.Text = Produto.unidade;
            txtCodBarra.Text = Convert.ToString(Produto.codBarra);
            txtCodFornecedor.Text = Convert.ToString(Produto.Fornecedor.codigo);
            txtFornecedor.Text = Convert.ToString(Produto.Fornecedor.fornecedor);
            txtCustoUltCompra.Text = Convert.ToString(Produto.custoUltCompra);
            txtDtUltCompra.Text = Convert.ToString(Produto.dtUltCompra);
           
            txtCodigo.Text = Convert.ToString(Produto.codigo);
            txtProduto.Text = Produto.produto;
            txtCodCategoria.Text = Convert.ToString(Produto.Categoria.codigo);
            txtCategoriaGrupo.Text = Convert.ToString(Produto.Categoria.categoria);
            txtComissao.Text = Convert.ToString(Produto.comissao);
            txtPrecoVenda.Text = Convert.ToString(Produto.precoVenda);
            txtObservacao.Text = Produto.observacoes;
            txtDtCadastro.Text = Convert.ToString(Produto.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(Produto.dtAlteracao);
            txtUsuario.Text = Produto.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        String vlr;
        private void txtCodFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodFornecedor.Text))
            {
                if (Convert.ToInt32("0" + txtCodFornecedor.Text) < 1)
                return;
                Fornecedores forn = CtrlFornecedor.BuscarPorID(Convert.ToInt32(txtCodFornecedor.Text)) as Fornecedores;
                if (forn == null)
                {
                    MessageBox.Show("Nenhum resultado");
                    txtFornecedor.Text = "";
                    txtCodFornecedor.Text = "";
                    txtFornecedor.Enabled = true;
                    txtCodFornecedor.Enabled = true;
                }
                else
                {
                    txtFornecedor.Text = forn.fornecedor;
                    txtFornecedor.Enabled = false;
                    txtCodFornecedor.Enabled = false;
                }
                forn = null;
                
            }
        }

        private void txtCodCategoria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCategoria.Text))
                return;
            if (Convert.ToInt32("0" + txtCodCategoria.Text) < 1)
                return;
            Categorias cat = CtrlCategoria.BuscarPorID(Convert.ToInt32(txtCodCategoria.Text)) as Categorias;
            if (cat == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCategoriaGrupo.Text = "";
                txtCodCategoria.Text = "";
                txtCategoriaGrupo.Enabled = true;
                txtCodCategoria.Enabled = true;
            }
            else
            {
                txtCategoriaGrupo.Text = cat.categoria;
                txtCategoriaGrupo.Enabled = false;
                txtCodCategoria.Enabled = false;
            }
            cat = null;
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

        private void txtComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

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

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void txtPrecoVenda_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtCodCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);

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

        private void txtProdutoServico_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduto.Text))
            {
               
                if (txtProduto.Text.Length < 3)
                {
                    MessageBox.Show("Produto inválido!", "Informe o produto com mais de 3 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProduto.Focus();
                }
                else
                if (txtFornecedor.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Produto inválido!", "Informe o produto com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProduto.Focus();
                }
                else
                if (String.IsNullOrEmpty(txtProduto.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Produto", "Informe o produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProduto.Focus();
                }
                else
                if (!MaskForm.ValidaTexto(txtProduto.Text))
                {
                    MessageBox.Show("Produto inválido!", "Produto não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProduto.Focus();
                }
                
            }
        }

        private void txtUnidade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnidade.Text))
            {
                if (txtUnidade.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Não é possivel inserir esta unidade", "Informe uma unidade com menos de 10 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnidade.Focus();
                    txtUnidade.Text = "";
                }
            }
        }

        private void txtCodBarra_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodBarra.Text))
            {
                if (txtCodBarra.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Não é possivel inserir este codigo de barra", "Informe um codigo de barra com menos de 5 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodBarra.Focus();
                    txtCodBarra.Text = "";
                }
                else if (txtCodBarra.Text.Trim().Length < 5)
                {
                    MessageBox.Show("Não é possivel inserir este codigo de barra", "Informe um codigo de barra com menos de 5 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodBarra.Focus();
                    txtCodBarra.Text = "";
                }
            }
        }

        private void txtCodCategoria_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduto.Text))
            {

            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduto.Text))
            {

            }
        }

        private void txtDtUltCompra_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDtUltCompra.Text))
            {
                if (txtDtUltCompra.Value > DateTime.Now)
                {
                    MessageBox.Show("Não é possivel inserir esta data", "Informe uma data menor que a atual", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtUltCompra.Focus();
                    txtDtUltCompra.Value = DateTime.Now;
                }
            }
        }

        private void txtProdutoServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtUnidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }
    }
}
