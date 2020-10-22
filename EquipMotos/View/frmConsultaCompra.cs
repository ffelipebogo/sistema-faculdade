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

      

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var compraRow = gvCompra.CurrentRow.DataBoundItem as DataRowView;

            var modelo = compraRow["modelo"];
            var serie = compraRow["serie"];
            var nrNota = compraRow["nrNota"];
            var codFornecedor = compraRow["codFornecedor"];

            if ((MessageBox.Show("Será necessario informar o usuario Administrador do sistema.", "Deseja cancelar?",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & modelo != null)
            {
                frmConfirmaAdmin frmConfirma = new frmConfirmaAdmin();
                if(frmConfirma.ShowDialog() == DialogResult.OK)
                {

                    if(ValidarContasPagar(modelo, serie, nrNota, codFornecedor))
                    {
                        CtrlCompra.Desativar(modelo, serie, nrNota, codFornecedor);
                        gvCompra.DataSource = CtrlCompra.ListarTodos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cancelar a compra, pois teve contas a pagar vinculadas pagas.", "Parcelas vinculadas pagas!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
