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
    public partial class frmConsultaContaPagar : Form
    {
        ContasPagarDAO dao = new ContasPagarDAO();

        public frmConsultaContaPagar()
        {
            InitializeComponent();
        }

        private void FrmConsultaContaPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaMoto2DataSetContasPagar.contaPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.contaPagarTableAdapter.Fill(this.sistemaMoto2DataSetContasPagar.contaPagar);
            gvContaPagar.DataSource = dao.ListarTodasContasPagar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroContaPagar frmCadContaPagar= new frmCadastroContaPagar();
            if (frmCadContaPagar.ShowDialog() == DialogResult.OK)
            {
                var lista = dao.ListarTodasContasPagar();
                if(lista != null)
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
                    var lista = dao.ListarTodasContasPagar();
                    if(lista != null)
                    {
                        gvContaPagar.DataSource = lista;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione uma conta à pagar!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var contaRow = gvContaPagar.CurrentRow.DataBoundItem as DataRowView;

            var modelo = contaRow["modelo"];
            var serie = contaRow["serie"];
            var nrNota = contaRow["nrNota"];
            var codFornecedor = contaRow["codFornecedor"];
            var nrParcela = contaRow["nrParcela"];

            if ((MessageBox.Show("Marcar como paga ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & modelo != null)
            {
                
                dao.MarcarPago(modelo, serie, nrNota, codFornecedor, nrParcela);
                gvContaPagar.DataSource = dao.ListarTodasContasPagar();
            }
        }
    }
}
