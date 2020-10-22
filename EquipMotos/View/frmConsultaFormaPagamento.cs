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
    public partial class frmConsultaFormaPagamento : MaterialSkin.Controls.MaterialForm
    {
        CtrlFormaPagamentos CtrlFormaPagamento = new CtrlFormaPagamentos();
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
                gvFormaPag.DataSource = CtrlFormaPagamento.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvFormaPag.CurrentRow != null)
                {
                    frmCadastroFormaPagamento frmCadFormaPag = new frmCadastroFormaPagamento();
                    var formRow = gvFormaPag.CurrentRow.DataBoundItem as DataRowView;

                    var id = formRow["codigo"];

                    frmCadFormaPag.Carregar(id);
                    if (frmCadFormaPag.ShowDialog() == DialogResult.OK)
                    {
                        gvFormaPag.DataSource = CtrlFormaPagamento.ListarTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a forma de pagamento que deseja alterar!");
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

                CtrlFormaPagamento.Excluir(id);
               
                gvFormaPag.DataSource = CtrlFormaPagamento.ListarTodos();
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
                frmCadastroContaPagar.formaPag = formaPag;
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
            try
            {
                formaPag = null;

                var formaRow = gvFormaPag.CurrentRow.DataBoundItem as DataRowView;
            
                formaPag = CtrlFormaPagamento.BuscarPorID(formaRow["codigo"]) as FormaPagamentos;
                return formaPag;
            }
            catch
            {
                return null;
            }
        }

        private void BtnBuscarFormaPag_Click(object sender, EventArgs e)
        {
            string form = txtPesquisar.Text;
            
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlFormaPagamento.Pesquisar(form);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvFormaPag.DataSource = dtView.DataSource;
            }
        }

        private void FrmConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
        //TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetFormaPagamento.formaPagamento'.Você pode movê-la ou removê-la conforme necessário.
            this.formaPagamentoTableAdapter.Fill(this.sistemaMoto2DataSetFormaPagamento.formaPagamento);
        }
    }
}
