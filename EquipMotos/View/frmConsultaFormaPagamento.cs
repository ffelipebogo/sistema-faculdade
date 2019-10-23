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
    public partial class frmConsultaFormaPagamento : Form
    {
        FormaPagamentoDAO dao = new FormaPagamentoDAO();
        FormaPagamentos formaPag;
        public frmConsultaFormaPagamento()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroFormaPagamento frmCadFormaPag = new frmCadastroFormaPagamento();
            if (frmCadFormaPag.ShowDialog() == DialogResult.OK)
            {
                gvFormaPag.DataSource = dao.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroFormaPagamento frmCadFormaPag = new frmCadastroFormaPagamento();
                var formRow = gvFormaPag.CurrentRow.DataBoundItem as DataRowView;

                var id = formRow["codigo"];

                frmCadFormaPag.Carregar(id);
                if (frmCadFormaPag.ShowDialog() == DialogResult.OK)
                {
                    gvFormaPag.DataSource = dao.ListarTodos();
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
                var formRow = gvFormaPag.CurrentRow.DataBoundItem as DataRowView;
                var id = formRow["codigo"];

                dao.Excluir(id);
               
                gvFormaPag.DataSource = dao.ListarTodos();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir a Forma de Pagamento!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaForma();
                frmCadastroCondicaoPagamento.formaPag = formaPag;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        private object SelecionaForma()
        {
            formaPag = null;

            var formaRow = gvFormaPag.CurrentRow.DataBoundItem as DataRowView;
            
            formaPag = dao.BuscarPorID(formaRow["codigo"]) as FormaPagamentos;
            return formaPag;
        }

        private void BtnBuscarFormaPag_Click(object sender, EventArgs e)
        {
            string form = txtPesquisar.Text;
            gvFormaPag.DataSource = dao.Pesquisar(form);
        }

        private void FrmConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetFormaPagamento.formaPagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.formaPagamentoTableAdapter.Fill(this.sistemaMoto2DataSetFormaPagamento.formaPagamento);
        }
    }
}
