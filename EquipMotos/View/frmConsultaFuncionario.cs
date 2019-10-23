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
        private FuncionariosDAO dao = new FuncionariosDAO();
        public frmConsultaFuncionario(string pusuario)
        {
            InitializeComponent();

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frmCadFuncionario = new frmCadastroFuncionario();
            if (frmCadFuncionario.ShowDialog() == DialogResult.OK)
            {
                gvFuncionario.DataSource = dao.ListarTodos();
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
                    gvFuncionario.DataSource = dao.ListarTodos();
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

                dao.Excluir(codigo);
                MessageBox.Show("Funcionario foi excluido!");

                gvFuncionario.DataSource = dao.ListarTodos();
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
                SelecionaFuncionario();
                frmCadastroProdutoServico.funcionario = func;
                //frmCadastroFornecedor.cidade = this.cidade;
                //frmCadastroFuncionario.cidade = this.cidade;
                this.DialogResult = DialogResult.OK;
                Close();
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

            func = dao.BuscarPorID(funcRow["codigo"]) as Funcionarios;
            return func;
        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetFuncionario.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistemaMoto2DataSetFuncionario.funcionarios);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string func = txtPesquisar.Text;
            gvFuncionario.DataSource = dao.Pesquisar(func);
        }
    }
}
