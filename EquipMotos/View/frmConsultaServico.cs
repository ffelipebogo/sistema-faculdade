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
    public partial class frmConsultaServico : MaterialSkin.Controls.MaterialForm
    {
        Servicos Servico = new Servicos();
        CtrlServicos CtrlServico = new CtrlServicos();
        public frmConsultaServico()
        {
            InitializeComponent();
        }

        private void frmConsultaServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetServicos.servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.sistemaMoto2DataSetServicos.servicos);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string servico = txtPesquisar.Text;
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlServico.Pesquisar(servico);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvServico.DataSource = dtView.DataSource;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroServico frmCadServico = new frmCadastroServico();
            if (frmCadServico.ShowDialog() == DialogResult.OK)
            {
                gvServico.DataSource = CtrlServico.ListarTodos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvServico.CurrentRow != null)
                {

                    frmCadastroServico frmCadServico = new frmCadastroServico();
                    var cliRow = gvServico.CurrentRow.DataBoundItem as DataRowView;

                    var codigo = cliRow["codigo"];

                    frmCadServico.Carregar(codigo);
                    if (frmCadServico.ShowDialog() == DialogResult.OK)
                    {
                        gvServico.DataSource = CtrlServico.ListarTodos();
                    }

                }
                else
                {
                    MessageBox.Show("Selecione o serviço que deseja alterar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var servRow = gvServico.CurrentRow.DataBoundItem as DataRowView;
                var codigo = servRow["codigo"];

                CtrlServico.Excluir(codigo);
                MessageBox.Show("Produto foi excluido!");

                gvServico.DataSource = CtrlServico.ListarTodos();
                
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
                SelecionaServico();
                if (Servico != null)
                {
                    frmCadastroCompra.Produto = Servico;
                    frmCadastroVenda.Produto = Servico;
                    frmCadastroOrdemServico.Produto = Servico;
                    frmCadastroOrdemServico.Servico = Servico;
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

        private object SelecionaServico()
        {
            Servico = null;
            if (gvServico.CurrentRow != null)
            {
                var proRow = gvServico.CurrentRow.DataBoundItem as DataRowView;
                 

                 Servicos Serv = CtrlServico.BuscarPorID(proRow["codigo"]) as  Servicos;
                

                return Servico = Serv;
            }
            else
            {
                return null;
            }
        }
    }
}
