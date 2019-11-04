using EquipMotos.Codigo.View;
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmConsultaCondicaoPagamento : Form
    {

        CondicaoPagamentos condPagamento = new CondicaoPagamentos();
        private CtrlCondicaoPagamento CtrlCondPagamento = new CtrlCondicaoPagamento();
        public frmConsultaCondicaoPagamento()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroCondicaoPagamento frmCadCondPagamento = new frmCadastroCondicaoPagamento();
            
            if (frmCadCondPagamento.ShowDialog() == DialogResult.OK)
            {
                gvCondPagamento.DataSource = CtrlCondPagamento.ListarTodos();
            }
        }

        private void BtnBuscarCondPag_Click(object sender, EventArgs e)
        {
            string cond = txtPesquisar.Text;
            gvCondPagamento.DataSource = CtrlCondPagamento.Pesquisar(cond);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCondicaoPagamento frmCadCondPagamento = new frmCadastroCondicaoPagamento();
                var condRow = gvCondPagamento.CurrentRow.DataBoundItem as DataRowView;

                var codigo = condRow["codigo"];
                frmCadCondPagamento.Carregar(codigo);
                if (frmCadCondPagamento.ShowDialog() == DialogResult.OK)
                {
                    gvCondPagamento.DataSource = CtrlCondPagamento.ListarTodos();
                }
                //gvCondPagamento.DataSource = dao.ListarTodasCondicoes();
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
                var condRow = gvCondPagamento.CurrentRow.DataBoundItem as DataRowView;
                var codigo = condRow["codigo"];
                if ((MessageBox.Show("Remover condição ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & codigo != null)
                {
                    
                    CtrlCondPagamento.Excluir(codigo);
                }
            }
            catch  
            {
            }
            finally
            {
                gvCondPagamento.DataSource = CtrlCondPagamento.ListarTodos();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaCondicao();
                frmCadastroContaPagar.condPagamento = this.condPagamento;
                frmCadastroCliente.condPagamento = this.condPagamento;
                frmCadastroFornecedor.condPagamento = this.condPagamento;
                frmCadastroCompra.condPagamento = this.condPagamento;
                frmCadastroVenda.CondPagamento = this.condPagamento;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        public object SelecionaCondicao()
        {
            condPagamento = null;

            var condRow = gvCondPagamento.CurrentRow.DataBoundItem as DataRowView;
            CondicaoPagamentoDAO dao = new CondicaoPagamentoDAO();
            condPagamento = dao.BuscarPorID(condRow["codigo"]) as CondicaoPagamentos;
            return condPagamento;

        }
        private void FrmConsultaCondicaoPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetCondicaoPagamento.condicaoPagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.condicaoPagamentoTableAdapter.Fill(this.sistemaMoto2DataSetCondicaoPagamento.condicaoPagamento);
        }
    }
}
