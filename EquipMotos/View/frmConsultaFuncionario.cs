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
    public partial class frmConsultaFuncionario : Form
    {
        Funcionarios func;
        private CtrlFuncionarios CtrlFuncionario = new CtrlFuncionarios();
        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frmCadFuncionario = new frmCadastroFuncionario();
            if (frmCadFuncionario.ShowDialog() == DialogResult.OK)
            {
                gvFuncionario.DataSource = CtrlFuncionario.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroFuncionario frmCadFuncionario = new frmCadastroFuncionario();
                var funRow = gvFuncionario.CurrentRow.DataBoundItem as DataRowView;

                var codigo = funRow["codigo"];

                frmCadFuncionario.Carregar(codigo);
                if (frmCadFuncionario.ShowDialog() == DialogResult.OK)
                {
                    gvFuncionario.DataSource = CtrlFuncionario.ListarTodos();
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
                var funcRow = gvFuncionario.CurrentRow.DataBoundItem as DataRowView;
                var codigo = funcRow["codigo"];

                CtrlFuncionario.Excluir(codigo);
                MessageBox.Show("Funcionario foi excluido!");

                gvFuncionario.DataSource = CtrlFuncionario.ListarTodos();
            }
            catch (Exception )
            {
                MessageBox.Show("Não foi possivel excluir o Funcionario!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                try 
                { 
                    SelecionaFuncionario();
                    frmCadastroProdutoServico.funcionario = func;
                    frmCadastroOrdemServico.Funcionario = func;
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

        private object SelecionaFuncionario()
        {
            func = null;

            var funcRow = gvFuncionario.CurrentRow.DataBoundItem as DataRowView;

            func = CtrlFuncionario.BuscarPorID(funcRow["codigo"]) as Funcionarios;
            return func;
        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetFuncionario.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistemaMoto2DataSetFuncionario.funcionarios);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string func = txtPesquisar.Text;
            gvFuncionario.DataSource = CtrlFuncionario.Pesquisar(func);
        }
    }
}
