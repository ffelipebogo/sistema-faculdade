using EquipMotos.CONTROLLER;
using EquipMotos.MODEL;
using EquipMotos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.VIEW
{
    public partial class frmConsultaProduto : MaterialSkin.Controls.MaterialForm
    {
        Produtos Produto = new Produtos();
        CtrlProdutos CtrlProduto = new CtrlProdutos();
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetProdutos.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.sistemaMoto2DataSetProdutos.produtos);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string prod = txtPesquisaProduto.Text;
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlProduto.Pesquisar(prod);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvProdutos.DataSource = dtView.DataSource;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroProduto frmCadProduto = new frmCadastroProduto();
            if (frmCadProduto.ShowDialog() == DialogResult.OK)
            {
                gvProdutos.DataSource = CtrlProduto.ListarTodos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvProdutos.CurrentRow != null) 
                { 
                    frmCadastroProduto frmCadProduto = new frmCadastroProduto();
                    var cliRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;

                    var codigo = cliRow["codigo"];

                    frmCadProduto.Carregar(codigo);
                    if (frmCadProduto.ShowDialog() == DialogResult.OK)
                    {
                        gvProdutos.DataSource = CtrlProduto.ListarTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a venda que deseja alterar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar alterar o produto!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var proRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;
                var codigo = proRow["codigo"];
                CtrlProduto.Excluir(codigo);
                MessageBox.Show("Produto foi excluido!");
                gvProdutos.DataSource = CtrlProduto.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Produto!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaProduto();
                if (Produto != null)
                {
                    frmCadastroCompra.Produto = Produto;
                    frmCadastroVenda.Produto = Produto;
                    frmCadastroOrdemServico.Produto = Produto;
                    frmCadastroOrdemServico.Servico = Produto;
                    this.DialogResult = DialogResult.OK;
                }
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        private object SelecionaProduto()
        {
            Produto = null;
            if (gvProdutos.CurrentRow != null)
            {
                var proRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;
                 
                Produtos Prod = CtrlProduto.BuscarPorID(proRow["codigo"]) as Produtos;
                return Produto = Prod;
            }
            else
            {
                return null;
            }
        }
    }
}
