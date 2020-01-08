using EquipMotos.CONTROLLER;
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
    public partial class frmConsultaVenda : Form
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
                frmCadastroVenda frmCadVenda = new frmCadastroVenda();

                var compraRow = gvVendas.CurrentRow.DataBoundItem as DataRowView;

                var nrNota = compraRow["nrNota"];

                frmCadVenda.Carregar(nrNota);
                //frmCadVenda.DisableView();
                if (frmCadVenda.ShowDialog() == DialogResult.OK)
                {
                    var lista = CtrlVenda.ListarTodos();
                    if (lista != null)
                    {
                        gvVendas.DataSource = lista;
                    }
                }
            }
            catch
            {

            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var venRow = gvVendas.CurrentRow.DataBoundItem as DataRowView;
            //    var id = venRow["codigo"];
            //    CtrlVenda.Marca(id);
            //    MessageBox.Show("Condição de Pagamento foi excluida!");

            //    gvVendas.DataSource = CtrlVenda.ListarTodasVendas();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Não foi possivel excluir a Condição de Pagamento!");
            //}
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
            gvVendas.DataSource = CtrlVenda.Pesquisar(venda);
        }
    }
}
