﻿using EquipMotos.DAO;
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
    public partial class frmConsultaMarca : Form
    {
        MarcasDAO dao = new MarcasDAO();
        Marcas marca = new Marcas();
        public frmConsultaMarca()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroMarca frmCadMarca = new frmCadastroMarca();
            if (frmCadMarca.ShowDialog() == DialogResult.OK)
            {
                gvMarca.DataSource = dao.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroMarca frmCadMarca = new frmCadastroMarca();
                var marRow = gvMarca.CurrentRow.DataBoundItem as DataRowView;

                var codigo = marRow["codigo"];

                frmCadMarca.Carregar(codigo);
                if (frmCadMarca.ShowDialog() == DialogResult.OK)
                {
                    gvMarca.DataSource = dao.ListarTodos();
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
                var marRow = gvMarca.CurrentRow.DataBoundItem as DataRowView;
                var codigo = marRow["codigo"];

                dao.Excluir(codigo);
                MessageBox.Show("Marca foi excluida!");

                gvMarca.DataSource = dao.ListarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel excluir a Marca!");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (btnVoltar.Text == "SELECIONAR")
            {
                SelecionaMarca();
                frmCadastroModelo.marca = this.marca;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Close();
            }
            btnVoltar.Text = "VOLTAR";
        }

        public object SelecionaMarca()
        {
            marca = null;

            var marRow = gvMarca.CurrentRow.DataBoundItem as DataRowView;

            marca = dao.BuscarPorID(marRow["codigo"]) as Marcas;
            return marca;
        }

        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetMarca.marcas'. Você pode movê-la ou removê-la conforme necessário.
            this.marcasTableAdapter.Fill(this.sistemaMoto2DataSetMarca.marcas);

        }
    }
}
