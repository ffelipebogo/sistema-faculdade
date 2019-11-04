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
    public partial class frmConsultaVenda : Form
    {
        //VendasDAO dao =  new VendasDAO();
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frmCadVenda = new frmCadastroVenda();
            if (frmCadVenda.ShowDialog() == DialogResult.OK)
            {
                //gvVendas.DataSource = dao.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroVenda frmCadVenda = new frmCadastroVenda();
                var vendaRow = gvVendas.CurrentRow.DataBoundItem as DataRowView;

                var codigo = vendaRow["codigo"];

                frmCadVenda.Carregar(codigo);
                if (frmCadVenda.ShowDialog() == DialogResult.OK)
                {
                    // gvVendas.DataSource = CtrlVenda.ListarTodos();
                }
            }
            catch
            {

            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var venRow = gvVendas.CurrentRow.DataBoundItem as DataRowView;
                var id = venRow["codigo"];
                //dao.ExcluirCondicaoPagamento(id);
                MessageBox.Show("Condição de Pagamento foi excluida!");

               // gvVendas.DataSource = dao.ListarTodasVendas();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir a Condição de Pagamento!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetVenda.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.sistemaMoto2DataSetVenda.vendas);
        }
    }
}
