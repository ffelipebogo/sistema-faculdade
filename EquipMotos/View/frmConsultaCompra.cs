using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
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
    public partial class frmConsultaCompra : MaterialSkin.Controls.MaterialForm
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
            gvCompra.DataSource = CtrlCompra.ListarTodos();

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
                if (gvCompra.CurrentRow != null)
                {
                    frmCadastroCompra frmCadCompra = new frmCadastroCompra();

                    var compraRow = gvCompra.CurrentRow.DataBoundItem as DataRowView;

                    var modelo = compraRow["modelo"];
                    var serie = compraRow["serie"];
                    var nrNota = compraRow["nrNota"];
                    var codFornecedor = compraRow["codFornecedor"];

                    frmCadCompra.Carregar(modelo, serie, nrNota, codFornecedor);
                    frmCadCompra.DisableView();
                    if (frmCadCompra.ShowDialog() == DialogResult.OK)
                    {
                        var lista = CtrlCompra.ListarTodos();
                        if (lista != null)
                        {
                            gvCompra.DataSource = lista;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a compra que deseja!");
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

        private Boolean ValidarContasPagar(object modelo, object serie, object nrNota, object codFornecedor)
        {
            var listaContaPagar = CtrlCompra.BuscarContaPagar(modelo, serie, nrNota, codFornecedor);
            bool valida = true;
            foreach (var conta in listaContaPagar)
            {
                if (conta.pago)
                {
                    valida = false;
                }

            }
            return valida;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            frmCadastroCompra frmCadCompra = new frmCadastroCompra();
            frmCadCompra.btnExcluir.Visible = true;
            if (gvCompra.CurrentRow != null)
            {
                var compraRow = gvCompra.CurrentRow.DataBoundItem as DataRowView;

                var modelo = compraRow["modelo"];
                var serie = compraRow["serie"];
                var nrNota = compraRow["nrNota"];
                var codFornecedor = compraRow["codFornecedor"];

                frmCadCompra.Carregar(modelo, serie, nrNota, codFornecedor);
                frmCadCompra.DisableView();
                if (frmCadCompra.ShowDialog() == DialogResult.OK)
                {
                    var lista = CtrlCompra.ListarTodos();
                    if (lista != null)
                    {
                        gvCompra.DataSource = lista;
                    }
                }
            }
        }

        private void BtnBuscarCompra_Click(object sender, EventArgs e)
        {
            string compra = txtPesquisar.Text;
            
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlCompra.Pesquisar(compra);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvCompra.DataSource = dtView.DataSource;
            }
        }
    }
}
