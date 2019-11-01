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
        OrdemServicosDAO dao = new OrdemServicosDAO();
        public frmConsultaOrdemServico()
        {
            InitializeComponent();
        }

        private void btnBuscarOS_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroOrdemServico frmCadOS = new frmCadastroOrdemServico();
            if (frmCadOS.ShowDialog() == DialogResult.OK)
            {
                gvOS.DataSource = dao.ListarTodos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroOrdemServico frmCadOrdemServico = new frmCadastroOrdemServico();
                var cliRow = gvOS.CurrentRow.DataBoundItem as DataRowView;

                var codigo = cliRow["codigo"];

                frmCadOrdemServico.Carregar(codigo);
                if (frmCadOrdemServico.ShowDialog() == DialogResult.OK)
                {
                    gvOS.DataSource = dao.ListarTodos();
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
                var osRow = gvOS.CurrentRow.DataBoundItem as DataRowView;
                var codigo = osRow["codigo"];

                dao.Excluir(codigo);
                MessageBox.Show("Ordem de Serviço foi excluida!");

                gvOS.DataSource = dao.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir a Ordem de Serviço!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaOrdemServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetOrdemServico.ordemServicos'. Você pode movê-la ou removê-la conforme necessário.
            //this.ordemServicosTableAdapter.Fill(this.sistemaMoto2DataSetOrdemServico.ordemServicos);

        }
    }
}
