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
    public partial class frmConsultaCategoria : Form
    {
        CtrlCategorias CtrlCategoria = new CtrlCategorias();
        Categorias categoria;
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCadCategoria = new frmCadastroCategoria();
            if (frmCadCategoria.ShowDialog() == DialogResult.OK)
            {
                gvCategoria.DataSource = CtrlCategoria.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroCategoria frmCadCategoria = new frmCadastroCategoria();
                var catRow = gvCategoria.CurrentRow.DataBoundItem as DataRowView;

                var codigo = catRow["codigo"];

                frmCadCategoria.Carregar(codigo);
                if (frmCadCategoria.ShowDialog() == DialogResult.OK)
                {
                    gvCategoria.DataSource = CtrlCategoria.ListarTodos();
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

                var catRow = gvCategoria.CurrentRow.DataBoundItem as DataRowView;
                var codigo = catRow["codigo"];

                CtrlCategoria.Excluir(codigo);
                MessageBox.Show("Categoria foi excluida!");

                gvCategoria.DataSource = CtrlCategoria.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                try
                {
                    SelecionaCategoria();
                    frmCadastroProdutoServico.categoria = this.categoria;
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        public object SelecionaCategoria()
        {
            categoria = null;
            var catRow = gvCategoria.CurrentRow.DataBoundItem as DataRowView;

            categoria = CtrlCategoria.BuscarPorID(catRow["codigo"]) as Categorias;
            return categoria;
        }

        private void FrmConsultaCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetCategoria.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.sistemaMoto2DataSetCategoria.categorias);
        }

        private void BtnBuscarCategoria_Click(object sender, EventArgs e)
        {
            string cat = txtPesquisar.Text;
            gvCategoria.DataSource = CtrlCategoria.Pesquisar(cat);
        }
    }
}
