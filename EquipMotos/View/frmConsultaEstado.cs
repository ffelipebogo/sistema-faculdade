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
    public partial class frmConsultaEstado : MaterialSkin.Controls.MaterialForm
    {
        Estados estado;
        CtrlEstados CtrlEstado = new CtrlEstados();
        public frmConsultaEstado()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaEstado();
                frmCadastroCidade.estado = estado;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        private object SelecionaEstado()
        {
            estado = null;
            if (gvEstado.CurrentRow != null)
            {
                var estRow = gvEstado.CurrentRow.DataBoundItem as DataRowView;

                estado = CtrlEstado.BuscarPorID(estRow["codigo"]) as Estados;
                return estado;
            }
            else
            {
                MessageBox.Show("Nenhum estado selecionado");
                return null;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEstado.CurrentRow != null)
                {
                    var estRow = gvEstado.CurrentRow.DataBoundItem as DataRowView;
                    var id = estRow["codigo"];

                    CtrlEstado.Excluir(id);
                    MessageBox.Show("Estado foi excluido!");

                    gvEstado.DataSource = CtrlEstado.ListarTodos();
                }
                else
                {
                    MessageBox.Show("Nenhum estado foi selecionado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Estado!");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEstado.CurrentRow != null)
                { 
                    frmCadastroEstado frmCadEstado = new frmCadastroEstado();
                    var estRow = gvEstado.CurrentRow.DataBoundItem as DataRowView;

                    var id = estRow["codigo"];

                    frmCadEstado.Carregar(id);
                    if (frmCadEstado.ShowDialog() == DialogResult.OK)
                    {
                        gvEstado.DataSource = CtrlEstado.ListarTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o estado que deseja alterar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel alterar o estado");
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroEstado frmCadEstado = new frmCadastroEstado();
            if (frmCadEstado.ShowDialog() == DialogResult.OK)
            {
                gvEstado.DataSource = CtrlEstado.ListarTodos();
            }
        }

        private void FrmConsultaEstado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetEstado.estados'. Você pode movê-la ou removê-la conforme necessário.
            this.estadosTableAdapter.Fill(this.sistemaMoto2DataSetEstado.estados);
        }

        private void BtnBuscarEstado_Click(object sender, EventArgs e)
        {
            string est = txtPesquisar.Text;
            
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlEstado.Pesquisar(est);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvEstado.DataSource = dtView.DataSource;
            }
        }
    }
}
