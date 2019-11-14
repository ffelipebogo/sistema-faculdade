using EquipMotos.Codigo.View;
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
    public partial class frmConsultaCidade : Form
    {
        Cidades cidade;
        
        CtrlCidades CtrlCidade = new CtrlCidades();
        public frmConsultaCidade()
        {
            InitializeComponent();
        }
       
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
           if(btnVoltar.Text == "SELECIONAR")
            {
                SelecionaCidade();
                frmCadastroCliente.cidade = this.cidade;
                frmCadastroFornecedor.cidade = this.cidade;
                frmCadastroFuncionario.cidade = this.cidade;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
            
        }
        public object SelecionaCidade()
        {
            try
            {
                cidade = null;

                var cidRow = gvCidade.CurrentRow.DataBoundItem as DataRowView;
            
                cidade = CtrlCidade.BuscarPorID(cidRow["codigo"]) as Cidades;
                return cidade;

            }
            catch
            {
                return null;

            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                var cidRow = gvCidade.CurrentRow.DataBoundItem as DataRowView;
                var id = cidRow["codigo"];

                CtrlCidade.Excluir(id);
                MessageBox.Show("Cidade foi excluida!");

                gvCidade.DataSource = CtrlCidade.ListarTodos();
            }
            catch (Exception )
            {
                MessageBox.Show("Não foi possivel excluir a cidade!");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroCidade frmCadCidade = new frmCadastroCidade();
                var cidRow = gvCidade.CurrentRow.DataBoundItem as DataRowView;

                var id = cidRow["codigo"];

                frmCadCidade.Carregar(id);
                if (frmCadCidade.ShowDialog() == DialogResult.OK)
                {
                    gvCidade.DataSource = CtrlCidade.ListarTodos();
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroCidade frmCadCidade = new frmCadastroCidade();
            if (frmCadCidade.ShowDialog() == DialogResult.OK)
            {
                gvCidade.DataSource = CtrlCidade.ListarTodos();
            }
        }

        private void FrmConsultaCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetCidade.cidades'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadesTableAdapter.Fill(this.sistemaMoto2DataSetCidade.cidades);

        }

        private void BtnBuscarCidade_Click(object sender, EventArgs e)
        {
            string cid = txtPesquisar.Text;
            gvCidade.DataSource = CtrlCidade.Pesquisar(cid);
        }
    }
}
