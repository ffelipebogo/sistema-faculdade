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
    public partial class frmConsultaContaPagar : MaterialSkin.Controls.MaterialForm
    {
        CtrlContasPagar CtrlContaPagar = new CtrlContasPagar();

        public frmConsultaContaPagar()
        {
            InitializeComponent();
            gvContaPagar.DataSource = CtrlContaPagar.ListarTodos();
        }

        private void FrmConsultaContaPagar_Load(object sender, EventArgs e)
        { 
            gvContaPagar.DataSource = CtrlContaPagar.ListarTodos();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroContaPagar frmCadContaPagar= new frmCadastroContaPagar();
            if (frmCadContaPagar.ShowDialog() == DialogResult.OK)
            {
                var lista = CtrlContaPagar.ListarTodos();
                if (lista != null)
                {
                    gvContaPagar.DataSource = lista;
                } else
                {
                    gvContaPagar.DataSource = null;
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvContaPagar.CurrentRow != null) { 
                    frmCadastroContaPagar frmCadConta = new frmCadastroContaPagar();

                    var contaRow = gvContaPagar.CurrentRow.DataBoundItem as DataRowView;

                    var modelo = contaRow["modelo"];
                    var serie = contaRow["serie"];
                    var nrNota = contaRow["nrNota"];
                    var codFornecedor = contaRow["codFornecedor"];
                    var nrParcela = contaRow["nrParcela"];

                    frmCadConta.Carregar(modelo, serie, nrNota, codFornecedor, nrParcela);
                    frmCadConta.Disable();
                    if (frmCadConta.ShowDialog() == DialogResult.OK)
                    {
                        var lista = CtrlContaPagar.ListarTodos();
                        if (lista != null)
                        {
                            gvContaPagar.DataSource = lista;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a conta que deseja!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione uma conta à pagar!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (gvContaPagar.CurrentRow != null)
            {
                var contaRow = gvContaPagar.CurrentRow.DataBoundItem as DataRowView;

                var modelo = contaRow["modelo"];
                var serie = contaRow["serie"];
                var nrNota = contaRow["nrNota"];
                var codFornecedor = contaRow["codFornecedor"];
                var nrParcela = contaRow["nrParcela"];
                var paga = contaRow["pago"];

                if ( !bool.Parse(paga.ToString()))
                {
                    if ((MessageBox.Show("Marcar como paga ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & modelo != null)
                    {
                        CtrlContaPagar.MarcarPago(modelo, serie, nrNota, codFornecedor, nrParcela);
                        gvContaPagar.DataSource = CtrlContaPagar.ListarTodos();
                    }
                }
            }
        }

        private void btnBuscarContaPagar_Click(object sender, EventArgs e)
        {
            string conta = txtPesquisar.Text;
            
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlContaPagar.Pesquisar(conta);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado Conta a Pagar!");
            }
            else
            {
                gvContaPagar.DataSource = dtView.DataSource;
            }
        }

       
    }
}
