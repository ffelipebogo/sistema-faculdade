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

        ProdutosServicosDAO dao = new ProdutosServicosDAO();
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
                gvProdutos.DataSource = dao.ListarTodos();
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
                    gvProdutos.DataSource = dao.ListarTodos();
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
            if(gvProdutos.CurrentRow == null)
            {
                return null;
            }
            else
            {
                var proRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;
                var serv = dao.BuscarPorID(proRow["codigo"]) as ProdutosServicos;

                return prodServ = serv ;
            }
            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var proRow = gvProdutos.CurrentRow.DataBoundItem as DataRowView;
                var id = proRow["codigo"];

                dao.Excluir(id);
                MessageBox.Show("Produto foi excluido!");

                gvProdutos.DataSource = dao.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Produto!");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string prod = txtPesquisar.Text;
            gvProdutos.DataSource = dao.Pesquisar(prod);
        }

        private void RbProduto_CheckedChanged(object sender, EventArgs e)
        {
            gvProdutos.DataSource = dao.ListarTodosProdutos();
            this.prdutoGridViewTextBoxColumn.HeaderText = "Produtos";
        }

        private void RbServico_CheckedChanged(object sender, EventArgs e)
        {
            gvProdutos.DataSource = dao.ListarTodosServicos();
            this.prdutoGridViewTextBoxColumn.HeaderText = "Serviços";
        }
    }
}
