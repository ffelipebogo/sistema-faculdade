﻿using EquipMotos.CONTROLLER;
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
    public partial class frmConsultaPais : MaterialSkin.Controls.MaterialForm
    {
        Paises pais;
        CtrlPaises CtrlPais = new CtrlPaises();
        public frmConsultaPais()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroPais frmCadPais = new frmCadastroPais();
            if (frmCadPais.ShowDialog() == DialogResult.OK)
            {
                gvPais.DataSource = CtrlPais.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvPais.CurrentRow != null)
                {
                    frmCadastroPais frmCadPais = new frmCadastroPais();
                    var paisRow = gvPais.CurrentRow.DataBoundItem as DataRowView;

                    var codigo = paisRow["codigo"];

                    frmCadPais.Carregar(codigo);
                    if (frmCadPais.ShowDialog() == DialogResult.OK)
                    {
                        gvPais.DataSource = CtrlPais.ListarTodos();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione o pais que deseja alterar!");
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
                if (gvPais.CurrentRow != null)
                {
                    var paisRow = gvPais.CurrentRow.DataBoundItem as DataRowView;
                    var codigo = paisRow["codigo"];

                    CtrlPais.Excluir(codigo);
                    MessageBox.Show("Pais foi excluido!");

                    gvPais.DataSource = CtrlPais.ListarTodos();
                }
                else
                {
                    MessageBox.Show("Nenhum pais foi selecionado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir o Pais!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaPais();
                frmCadastroEstado.paises = pais;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";

        }

        private object SelecionaPais()
        {
            pais = null;
            if (gvPais.CurrentRow != null)
            {
                var paisRow = gvPais.CurrentRow.DataBoundItem as DataRowView;
                pais = CtrlPais.BuscarPorID(paisRow["codigo"]) as Paises;
                return pais;
            }
            else
            {
                MessageBox.Show("Nenhum pais foi selecionado");
                return null;
            }
        }

        private void FrmConsultaPais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetPais.paises'. Você pode movê-la ou removê-la conforme necessário.
            this.paisesTableAdapter.Fill(this.sistemaMoto2DataSetPais.paises);

        }

        private void BtnBuscarPais_Click(object sender, EventArgs e)
        {
            string pais = txtPesquisar.Text;
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlPais.Pesquisar(pais);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvPais.DataSource = dtView.DataSource;
            }
        }
    }
}
