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
    public partial class frmConsultaModelo : Form
    {
        Modelos modelo;
        CtrlModelos CtrlModelo = new CtrlModelos(); 
        public frmConsultaModelo()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroModelo frmCadModelo = new frmCadastroModelo();
            if (frmCadModelo.ShowDialog() == DialogResult.OK)
            {
                gvModelo.DataSource = CtrlModelo.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroModelo frmCadModelo = new frmCadastroModelo();
                var modRow = gvModelo.CurrentRow.DataBoundItem as DataRowView;

                var codigo = modRow["codigo"];

                frmCadModelo.Carregar(codigo);
                if (frmCadModelo.ShowDialog() == DialogResult.OK)
                {
                    gvModelo.DataSource = CtrlModelo.ListarTodos();
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
                var codigo = modRow["codigo"];

                CtrlModelo.Excluir(codigo);
                MessageBox.Show("Modelo foi excluido!");

                gvModelo.DataSource = CtrlModelo.ListarTodos();
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
                modelo = CtrlModelo.BuscarPorID(modRow["codigo"]) as Modelos;
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
            gvModelo.DataSource = CtrlModelo.Pesquisar(mod);
        }
    }
}
