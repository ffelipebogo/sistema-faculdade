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
    public partial class frmConsultaModelo : Form
    {
        Modelos modelo;
        ModelosDAO dao = new ModelosDAO(); 
        public frmConsultaModelo()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroModelo frmCadModelo = new frmCadastroModelo();
            if (frmCadModelo.ShowDialog() == DialogResult.OK)
            {
                gvModelo.DataSource = dao.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroModelo frmCadModelo = new frmCadastroModelo();
                var modRow = gvModelo.CurrentRow.DataBoundItem as DataRowView;

                var id = modRow["id"];

                frmCadModelo.Carregar(id);
                if (frmCadModelo.ShowDialog() == DialogResult.OK)
                {
                    gvModelo.DataSource = dao.ListarTodos();
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
                var modRow = gvModelo.CurrentRow.DataBoundItem as DataRowView;
                var id = modRow["id"];

                dao.Excluir(id);
                MessageBox.Show("Modelo foi excluido!");

                gvModelo.DataSource = dao.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Modelo!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaModelo();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        private object SelecionaModelo()
        {
            try
            {
                modelo = null;
                var modRow = gvModelo.CurrentRow.DataBoundItem as DataRowView;
                modelo = dao.BuscarPorID(modRow["codigo"]) as Modelos;
                return modelo;
            }
            catch
            {
                Close();
                return null;
            }
        }

        private void FrmConsultaModelo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetModelo.modelos'. Você pode movê-la ou removê-la conforme necessário.
            this.modelosTableAdapter.Fill(this.sistemaMoto2DataSetModelo.modelos);
        }

        private void BtnBuscarModelo_Click(object sender, EventArgs e)
        {
            string mod = txtPesquisar.Text;
            gvModelo.DataSource = dao.Pesquisar(mod);
        }
    }
}
