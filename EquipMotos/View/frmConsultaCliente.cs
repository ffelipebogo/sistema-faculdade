﻿using EquipMotos.CONTROLLER;
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
    public partial class frmConsultaCliente : MaterialSkin.Controls.MaterialForm
    {
        Clientes cliente;
        private readonly string usuario;
        private CtrlClientes CtrlCliente = new CtrlClientes();
        

        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCliente frmCadCliente = new frmCadastroCliente(usuario);
                if (gvClientes.CurrentRow != null)
                {
                    var cliRow = gvClientes.CurrentRow.DataBoundItem as DataRowView;

                    var codigo = cliRow["codigo"];

                    frmCadCliente.Carregar(codigo);
                    if (frmCadCliente.ShowDialog() == DialogResult.OK)
                    {
                        gvClientes.DataSource = CtrlCliente.ListarTodos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Não foi possivel alterar Cliente!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvClientes.CurrentRow != null)
                {
                    var cliRow = gvClientes.CurrentRow.DataBoundItem as DataRowView;
                    var codigo = cliRow["codigo"];
                    CtrlCliente.Excluir(codigo);
                    MessageBox.Show("Cliente foi excluido!");
                    gvClientes.DataSource = CtrlCliente.ListarTodos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir o cliente");
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadCliente = new frmCadastroCliente(usuario);
            if (frmCadCliente.ShowDialog() == DialogResult.OK)
            {
                gvClientes.DataSource = CtrlCliente.ListarTodos();
            }
        }


        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaCliente();
                if (cliente != null)
                {
                    frmCadastroVenda.Cliente = cliente;
                    frmCadastroOrdemServico.Cliente = cliente;
                    this.DialogResult = DialogResult.OK;
                }
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
                if (gvClientes.CurrentRow != null)
                {
                    cliente = null;

                    var cliRow = gvClientes.CurrentRow.DataBoundItem as DataRowView;

                    cliente = CtrlCliente.BuscarPorID(cliRow["codigo"]) as Clientes;
                    return cliente;
                }
                else
                {
                    MessageBox.Show("Nenhum cliente foi selecionado");
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Nenhum cliente foi selecionado");
                return null;
            }
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetCliente.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.sistemaMoto2DataSetCliente.clientes);
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cli = txtPesquisar.Text;
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlCliente.Pesquisar(cli);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvClientes.DataSource = dtView.DataSource;
            }
        }
    }
}
