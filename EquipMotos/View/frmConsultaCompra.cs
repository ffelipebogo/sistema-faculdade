using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
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
    public partial class frmConsultaCompra : Form
    {
        CtrlCompras CtrlCompra = new CtrlCompras();
        public frmConsultaCompra()
        {
            InitializeComponent();
        }
        
        private void FrmConsultaCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetCompra.compras'. Você pode movê-la ou removê-la conforme necessário.
            this.comprasTableAdapter.Fill(this.sistemaMoto2DataSetCompra.compras);

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroCompra frmCadCompra = new frmCadastroCompra();
            if (frmCadCompra.ShowDialog() == DialogResult.OK)
            {
                var lista = CtrlCompra.ListarTodos();
                if(lista != null)
                {
                    gvCompra.DataSource = lista;
                }
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCompra frmCadCompra = new frmCadastroCompra();

                var compraRow = gvCompra.CurrentRow.DataBoundItem as DataRowView;

                var modelo = compraRow["modelo"];
                var serie = compraRow["serie"];
                var nrNota = compraRow["nrNota"];
                var codFornecedor = compraRow["codFornecedor"];

                frmCadCompra.Carregar(modelo, serie, nrNota, codFornecedor);
                frmCadCompra.Disable();
                if (frmCadCompra.ShowDialog() == DialogResult.OK)
                {
                    var lista = CtrlCompra.ListarTodos();
                    if(lista != null)
                    {
                        gvCompra.DataSource = lista;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Selecione uma compra!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var compraRow = gvCompra.CurrentRow.DataBoundItem as DataRowView;

            var modelo = compraRow["modelo"];
            var serie = compraRow["serie"];
            var nrNota = compraRow["nrNota"];
            var codFornecedor = compraRow["codFornecedor"];

            if ((MessageBox.Show("Desativar compra ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & modelo != null)
            {
                CtrlCompra.Desativar(modelo, serie, nrNota, codFornecedor);
                gvCompra.DataSource = CtrlCompra.ListarTodos();
            }
        }

        private void BtnBuscarCompra_Click(object sender, EventArgs e)
        {
            string compra = txtPesquisar.Text;
            gvCompra.DataSource = CtrlCompra.Pesquisar(compra);
        }
    }
}
