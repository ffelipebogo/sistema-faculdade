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
    public partial class frmConsultaPais : Form
    {
        Paises pais;
        PaisesDAO dao = new PaisesDAO();
        public frmConsultaPais()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroPais frmCadPais = new frmCadastroPais();
            if (frmCadPais.ShowDialog() == DialogResult.OK)
            {
                gvPais.DataSource = dao.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroPais frmCadPais = new frmCadastroPais();
                var paisRow = gvPais.CurrentRow.DataBoundItem as DataRowView;

                var id = paisRow["id"];

                frmCadPais.Carregar(id);
                if (frmCadPais.ShowDialog() == DialogResult.OK)
                {
                    gvPais.DataSource = dao.ListarTodos();
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

                var paisRow = gvPais.CurrentRow.DataBoundItem as DataRowView;
                var id = paisRow["id"];

                dao.Excluir(id);
                MessageBox.Show("Pais foi excluido!");

                gvPais.DataSource = dao.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Pais!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaPais();
                frmCadastroEstado.paises = pais;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";

        }

        private object SelecionaPais()
        {
            pais = null;

            var paisRow = gvPais.CurrentRow.DataBoundItem as DataRowView;
            pais = dao.BuscarPorID(paisRow["codigo"]) as Paises;
            return pais;
        }

        private void FrmConsultaPais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetPais.paises'. Você pode movê-la ou removê-la conforme necessário.
            this.paisesTableAdapter.Fill(this.sistemaMoto2DataSetPais.paises);

        }

        private void BtnBuscarPais_Click(object sender, EventArgs e)
        {
            string pais = txtPesquisar.Text;
            gvPais.DataSource = dao.Pesquisar(pais);
        }
    }
}
