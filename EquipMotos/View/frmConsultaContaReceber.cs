﻿using EquipMotos.CONTROLLER;
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
    public partial class frmConsultaContaReceber : Form
    {
        frmCadastroContaReceber frmCadContaReceber;
        CtrlContasReceber CtrlContaReceber = new CtrlContasReceber();
        public frmConsultaContaReceber()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadContaReceber = new frmCadastroContaReceber();
            if (frmCadContaReceber.ShowDialog() == DialogResult.OK)
            {
                gvContaReceber.DataSource = CtrlContaReceber.ListarTodos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroContaReceber frmCadConta = new frmCadastroContaReceber();

                var contaRow = gvContaReceber.CurrentRow.DataBoundItem as DataRowView;

                var modelo = contaRow["modelo"];
                var serie = contaRow["serie"];
                var nrNota = contaRow["nrNota"];
                var codCliente = contaRow["codCliente"];
                var nrParcela = contaRow["nrParcela"];

                frmCadConta.Carregar(modelo, serie, nrNota, codCliente, nrParcela);
                frmCadConta.Disable();
                if (frmCadConta.ShowDialog() == DialogResult.OK)
                {
                    var lista = CtrlContaReceber.ListarTodos();
                    if (lista != null)
                    {
                        gvContaReceber.DataSource = lista;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma conta à receber!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var contaRow = gvContaReceber.CurrentRow.DataBoundItem as DataRowView;

            var modelo = contaRow["modelo"];
            var serie = contaRow["serie"];
            var nrNota = contaRow["nrNota"];
            var codFornecedor = contaRow["codCliente"];
            var nrParcela = contaRow["nrParcela"];

            if ((MessageBox.Show("Marcar conta como recebida ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & modelo != null)
            {
                CtrlContaReceber.MarcarPago(modelo, serie, nrNota, codFornecedor, nrParcela);
                gvContaReceber.DataSource = CtrlContaReceber.ListarTodos();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaContaReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetContaReceber.contaReceber'. Você pode movê-la ou removê-la conforme necessário.
           // this.contaReceberTableAdapter.Fill(this.sistemaMoto2DataSetContaReceber.contaReceber);

        }

        private void btnBuscarContaPagar_Click(object sender, EventArgs e)
        {
            string conta = txtPesquisar.Text;
            gvContaReceber.DataSource = CtrlContaReceber.Pesquisar(conta);
        }
    }
}
