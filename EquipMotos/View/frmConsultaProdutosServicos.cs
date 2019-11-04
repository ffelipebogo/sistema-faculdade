using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmConsultaProdutosServicos : Form
    {
        ProdutosServicos prodServ;

        CtrlProdutosServicos CtrlProdutoServico = new CtrlProdutosServicos();
        public frmConsultaProdutosServicos()
        {
            InitializeComponent();
            rbProduto.Checked = true;
        }

        private void FrmConsultaProdutosServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetProduto.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.sistemaMoto2DataSetProduto.produtos);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroProdutoServico frmCadProServ = new frmCadastroProdutoServico();
            if (frmCadProServ.ShowDialog() == DialogResult.OK)
            {
                gvProdutos.DataSource = CtrlProdutoServico.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroProdutoServico frmCadProServ = new frmCadastroProdutoServico();
                var cliRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;

                var id = cliRow["codigo"];

                frmCadProServ.Carregar(id);
                if (frmCadProServ.ShowDialog() == DialogResult.OK)
                {
                    gvProdutos.DataSource = CtrlProdutoServico.ListarTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaProdutoServico();
                if(prodServ != null)
                {
                    frmCadastroCompra.prod = prodServ;
                    frmCadastroVenda.Produto = prodServ;
                    frmCadastroOrdemServico.Produto = prodServ;
                    frmCadastroOrdemServico.Servico = prodServ;
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

        private object SelecionaProdutoServico()
        {
            prodServ = null;
            if(gvProdutos.CurrentRow != null)
            {
           
                var proRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;
                var serv = CtrlProdutoServico.BuscarPorID(proRow["codigo"]) as ProdutosServicos;

                return prodServ = serv ;
            }
            else
            {
                return null;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var proRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;
                var id = proRow["codigo"];

                CtrlProdutoServico.Excluir(id);
                MessageBox.Show("Produto foi excluido!");

                gvProdutos.DataSource = CtrlProdutoServico.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Produto!");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string prod = txtPesquisar.Text;
            gvProdutos.DataSource = CtrlProdutoServico.Pesquisar(prod);
        }

        private void RbProduto_CheckedChanged(object sender, EventArgs e)
        {
            gvProdutos.DataSource = CtrlProdutoServico.ListarTodosProdutos();
            this.prdutoGridViewTextBoxColumn.HeaderText = "Produtos";
        }

        private void RbServico_CheckedChanged(object sender, EventArgs e)
        {
            gvProdutos.DataSource = CtrlProdutoServico.ListarTodosServicos();
            this.prdutoGridViewTextBoxColumn.HeaderText = "Serviços";
        }
    }
}
