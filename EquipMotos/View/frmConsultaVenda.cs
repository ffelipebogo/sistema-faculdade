using EquipMotos.CONTROLLER;
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
using Material = MaterialSkin.Controls;

namespace EquipMotos.View
{
    public partial class frmConsultaVenda : Material.MaterialForm
    {
        CtrlVendas CtrlVenda =  new CtrlVendas();
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroVenda frmCadVenda = new frmCadastroVenda();
            if (frmCadVenda.ShowDialog() == DialogResult.OK)
            {
                gvVendas.DataSource = CtrlVenda.ListarTodos();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvVendas.CurrentRow != null)
                {
                    frmCadastroVenda frmCadVenda = new frmCadastroVenda();

                    var compraRow = gvVendas.CurrentRow.DataBoundItem as DataRowView;

                    var nrNota = compraRow["nrNota"];

                    frmCadVenda.Carregar(nrNota);
                    frmCadVenda.DisableView();
                    if (frmCadVenda.ShowDialog() == DialogResult.OK)
                    {
                        var lista = CtrlVenda.ListarTodos();
                        if (lista != null)
                        {
                            gvVendas.DataSource = lista;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a venda que deseja!");
                }
            }
            catch
            {

            }
        }

        

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var vendaRow = gvVendas.CurrentRow.DataBoundItem as DataRowView;

            var modelo = vendaRow["modelo"];
            var serie = vendaRow["serie"];
            var nrNota = vendaRow["nrNota"];
            var codCliente = vendaRow["codCliente"];

            if ((MessageBox.Show("Será necessario informar o usuario Administrador do sistema.", "Deseja cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & modelo != null)
            {
                frmConfirmaAdmin frmConfirma = new frmConfirmaAdmin();
                if (frmConfirma.ShowDialog() == DialogResult.OK)
                {
                    if (ValidarContasReceber(modelo, serie, nrNota, codCliente))
                    {
                        CtrlVenda.Desativar(modelo, serie, nrNota, codCliente);
                        gvVendas.DataSource = CtrlVenda.ListarTodos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cancelar a venda, pois teve contas a receber vinculadas pagas.", "Parcelas vinculadas recebidas!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetVenda.vendas'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.sistemaMoto2DataSetVenda.vendas);
        }

        private void btnBuscarVenda_Click(object sender, EventArgs e)
        {
            string venda = txtPesquisar.Text;
            
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlVenda.Pesquisar(venda);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvVendas.DataSource = dtView.DataSource;
            }
        }

       
    }
}
