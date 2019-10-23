using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Messaging;
using System.Windows.Forms;
using Message = System.Windows.Forms.Message;

namespace EquipMotos.Codigo.View
{
    public partial class frmConsultaCliente : Form
    {
        Clientes cliente;
        private readonly string usuario;
        private ClientesDAO dao = new ClientesDAO();
        

        public frmConsultaCliente(string pusuario)
        {
            InitializeComponent();
            this.usuario = pusuario;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                frmCadastroCliente frmCadCliente = new frmCadastroCliente(usuario);
                var cliRow = gvClientes.CurrentRow.DataBoundItem as DataRowView;

                var codigo  = cliRow["codigo"];

                frmCadCliente.Carregar(codigo);
                if (frmCadCliente.ShowDialog() == DialogResult.OK)
                {
                    gvClientes.DataSource = dao.ListarTodos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

            
        }


        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                
                var cliRow = gvClientes.CurrentRow.DataBoundItem as DataRowView;
                var codigo = cliRow["codigo"];
                
                dao.Excluir(codigo);
                MessageBox.Show("Cliente foi excluido!");

                gvClientes.DataSource = dao.ListarTodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadCliente = new frmCadastroCliente(usuario);
            if (frmCadCliente.ShowDialog() == DialogResult.OK)
            {
                gvClientes.DataSource = dao.ListarTodos();
            }
        }


        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaCliente();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        public object SelecionaCliente()
        {
            try
            {
                cliente = null;

                var cliRow = gvClientes.CurrentRow.DataBoundItem as DataRowView;

                cliente = dao.BuscarPorID(cliRow["codigo"]) as Clientes;
                return cliente;
            }
            catch
            {
                Close();
                return null;
            }
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetCliente.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.sistemaMoto2DataSetCliente.clientes);
            gvClientes.DataSource = dao.ListarTodos();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cli = txtPesquisar.Text;
            gvClientes.DataSource = dao.Pesquisar(cli);
        }

       
    }
}
