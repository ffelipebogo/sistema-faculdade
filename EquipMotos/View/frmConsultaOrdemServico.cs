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
    public partial class frmConsultaOrdemServico : Form
    {
        
        CtrlOrdemServicos CtrlOrdemServico = new CtrlOrdemServicos();
        public frmConsultaOrdemServico()
        {
            InitializeComponent();
        }

        private void btnBuscarOS_Click(object sender, EventArgs e)
        {
            string os = txtPesquisar.Text;
            gvOS.DataSource = CtrlOrdemServico.Pesquisar(os);
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
                
                var cliRow = gvOS.CurrentRow.DataBoundItem as DataRowView;

                var codigo = cliRow["nrNota"];

                frmCadOrdemServico.Carregar(codigo);
                if (frmCadOrdemServico.ShowDialog() == DialogResult.OK)
                {
                    gvOS.DataSource = CtrlOrdemServico.ListarTodos();
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
                frmCadastroOrdemServico frmCadOrdemServico = new frmCadastroOrdemServico();

                var cliRow = gvOS.CurrentRow.DataBoundItem as DataRowView;

                var codigo = cliRow["nrNota"];

                frmCadOrdemServico.Carregar(codigo);
                frmCadOrdemServico.Disable();
                if (frmCadOrdemServico.ShowDialog() == DialogResult.OK)
                {
                    gvOS.DataSource = CtrlOrdemServico.ListarTodos();
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
