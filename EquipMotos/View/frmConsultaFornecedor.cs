using EquipMotos.Codigo.View;
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.VIEW;
using System;
using System.Data;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmConsultaFornecedor : MaterialSkin.Controls.MaterialForm
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
                frmCadastroProduto.fornecedor = this.fornecedor;
                frmCadastroCompra.Fornecedor = this.fornecedor;
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
            try
            {
                fornecedor = null;
                var fornRow = gvFornecedor.CurrentRow.DataBoundItem as DataRowView;
                fornecedor = CtrlFornecedor.BuscarPorID(fornRow["codigo"]) as Fornecedores;
                return fornecedor;
            }
            catch
            {
                return null;
            }
        }

        private void BtnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            string forn = txtPesquisar.Text;
            DataGridView dtFornecedor = new DataGridView();
            dtFornecedor.DataSource = CtrlFornecedor.Pesquisar(forn);
            var test = dtFornecedor.DataSource.ToString();

            if (dtFornecedor.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvFornecedor.DataSource = dtFornecedor.DataSource;
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvFornecedor.CurrentRow != null)
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
                else
                {
                    MessageBox.Show("Selecione o fornecedor que deseja alterar!");
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
            //this.fornecedoresTableAdapter.Fill(this.sistemaMoto2DataSetFornecedor.fornecedores);

        }
    }
}
