﻿using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.VIEW;
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
    public partial class frmConsultaFuncionario : MaterialSkin.Controls.MaterialForm
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
                if(gvFuncionario.CurrentRow != null) 
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
                else
                {
                    MessageBox.Show("Selecione o funcionario que deseja alterar!");
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
                if (gvFuncionario.CurrentRow != null)
                {
                    var funcRow = gvFuncionario.CurrentRow.DataBoundItem as DataRowView;
                    var codigo = funcRow["codigo"];

                    CtrlFuncionario.Excluir(codigo);
                    MessageBox.Show("Funcionario foi excluido!");

                    gvFuncionario.DataSource = CtrlFuncionario.ListarTodos();
                }
                else
                {
                    MessageBox.Show("Nenhum funcionario foi selecionado");
                }
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
                    frmCadastroOrdemServico.Funcionario = func;
                    frmCadastroServico.funcionario = func;

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
            if (gvFuncionario.CurrentRow != null)
            {
                var funcRow = gvFuncionario.CurrentRow.DataBoundItem as DataRowView;

                func = CtrlFuncionario.BuscarPorID(funcRow["codigo"]) as Funcionarios;
                return func;
            }
            else
            {
                MessageBox.Show("Nenhum funcionario foi selecionado");
                return null;
            }
        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetFuncionario.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.sistemaMoto2DataSetFuncionario.funcionarios);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string func = txtPesquisar.Text;
            
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlFuncionario.Pesquisar(func);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvFuncionario.DataSource = dtView.DataSource;
            }
        }

        private void gvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
