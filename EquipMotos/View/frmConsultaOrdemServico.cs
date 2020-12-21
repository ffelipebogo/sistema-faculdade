using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
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
    public partial class frmConsultaOrdemServico : MaterialSkin.Controls.MaterialForm
    {
        
        CtrlOrdemServicos CtrlOrdemServico = new CtrlOrdemServicos();
        public frmConsultaOrdemServico()
        {
            InitializeComponent();
        }

        private void btnBuscarOS_Click(object sender, EventArgs e)
        {
            string os = txtPesquisar.Text;

            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlOrdemServico.Pesquisar(os);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvOS.DataSource = dtView.DataSource;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroOrdemServico frmCadOS = new frmCadastroOrdemServico();
            if (frmCadOS.ShowDialog() == DialogResult.OK)
            {
                gvOS.DataSource = CtrlOrdemServico.ListarTodos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroOrdemServico frmCadOrdemServico = new frmCadastroOrdemServico();
                if (gvOS.CurrentRow != null)
                { 
                    var cliRow = gvOS.CurrentRow.DataBoundItem as DataRowView; 
                    var codigo = cliRow["nrNota"]; 
                    frmCadOrdemServico.Carregar(codigo);
                    if (frmCadOrdemServico.ShowDialog() == DialogResult.OK)
                    {
                        gvOS.DataSource = CtrlOrdemServico.ListarTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a O.S que deseja alterar!");
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroOrdemServico frmCadOrdemServico = new frmCadastroOrdemServico();
                if (gvOS.CurrentRow != null)
                {
                    var cliRow = gvOS.CurrentRow.DataBoundItem as DataRowView;

                    var codigo = cliRow["nrNota"];

                    frmCadOrdemServico.CarregarFinalizar(codigo);
                    if (frmCadOrdemServico.ShowDialog() == DialogResult.OK)
                    {
                        gvOS.DataSource = CtrlOrdemServico.ListarTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Ordem de Serviço");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel carregar a Ordem de Serviço!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaOrdemServico_Load(object sender, EventArgs e)
        { 
            gvOS.DataSource = CtrlOrdemServico.ListarTodos(); 
        }
    }
}
