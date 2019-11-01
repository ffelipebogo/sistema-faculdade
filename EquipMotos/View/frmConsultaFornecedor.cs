using EquipMotos.Codigo.View;
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmConsultaFornecedor : Form
    {
        CtrlFornecedores CtrlFornecedor = new CtrlFornecedores();
        Fornecedores fornecedor;
        public frmConsultaFornecedor()
        {
            InitializeComponent();
            gvFornecedor.DataSource = CtrlFornecedor.ListarTodos();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor frmCadFornecedor = new frmCadastroFornecedor();
            if (frmCadFornecedor.ShowDialog() == DialogResult.OK)
            {
                gvFornecedor.DataSource = CtrlFornecedor.ListarTodos();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaFornecedor();
                frmCadastroContaPagar.fornecedor = this.fornecedor;
                frmCadastroProdutoServico.fornecedor = this.fornecedor;
                frmCadastroCompra.fornecedor = this.fornecedor;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        public object SelecionaFornecedor()
        {
            fornecedor = null;
            var fornRow = gvFornecedor.CurrentRow.DataBoundItem as DataRowView;
            fornecedor = CtrlFornecedor.BuscarPorID(fornRow["codigo"]) as Fornecedores;
            return fornecedor;
        }

        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            string forn = txtPesquisar.Text;
            gvFornecedor.DataSource = CtrlFornecedor.Pesquisar(forn);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroFornecedor frmCadFornecedor = new frmCadastroFornecedor();
                var forRow = gvFornecedor.CurrentRow.DataBoundItem as DataRowView;
                var id = forRow["codigo"];
                frmCadFornecedor.Carregar(id);
                if (frmCadFornecedor.ShowDialog() == DialogResult.OK)
                {
                    gvFornecedor.DataSource = CtrlFornecedor.ListarTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var forRow = gvFornecedor.CurrentRow.DataBoundItem as DataRowView;
                var id = forRow["codigo"];
                CtrlFornecedor.Excluir(id);
                MessageBox.Show("Fornecedor foi excluido!");
                gvFornecedor.DataSource = CtrlFornecedor.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Fornecedor!");
            }
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetFornecedor.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.sistemaMoto2DataSetFornecedor.fornecedores);

        }
    }
}
