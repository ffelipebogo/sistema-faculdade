using EquipMotos.CONTROLLER;
using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroContaReceber : MaterialSkin.Controls.MaterialForm
    {
        CtrlFormaPagamentos ctrlFormaPagamento = new CtrlFormaPagamentos();
        ContasReceber ContaReceber = new ContasReceber();
        CtrlContasReceber CtrlContaReceber = new CtrlContasReceber();
        public static object Cliente = null;
        public static object FormaPag = null;
        public frmCadastroContaReceber()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCondPagamento_Click(object sender, EventArgs e)
        {

        }

        public void Carregar(object modelo, object serie, object nrNota, object idCliente, object nrParcela)
        {
            ContaReceber = CtrlContaReceber.BuscarContasPagar_porID(modelo, serie, nrNota, idCliente, nrParcela) as ContasReceber;
            txtModelo.Text = ContaReceber.modelo;
            txtSerie.Text = ContaReceber.serie;
            txtNrNota.Text = ContaReceber.nrNota;
            txtNrParcela.Text = Convert.ToString(ContaReceber.nrParcela);
            txtValor.Text = ContaReceber.vlrParcela.ToString("C", CultureInfo.CurrentCulture);
            txtFornecedor.Text =  ContaReceber.cliente.cliente;
            txtCodFornecedor.Text = Convert.ToString(ContaReceber.cliente.codigo);
            txtDtEmissao.Text = Convert.ToString(ContaReceber.dtEmissao);
            txtDtVencimento.Text = Convert.ToString(ContaReceber.dtVencimento);
            txtCodFormaPagamento.Text = Convert.ToString(ContaReceber.formaPagamento.codigo);
            txtFormaPagamento.Text = ContaReceber.formaPagamento.forma;
            txtObeservacoes.Text = ContaReceber.observacoes;
            txtDtCadastro.Text = Convert.ToString(ContaReceber.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(ContaReceber.dtAlteracao);
            txtUsuario.Text = ContaReceber.usuario;
            chkPaga.Checked = ContaReceber.pago;
            //lvContaPagar.Visible = false;
            btnSalvar.Visible = false;
            btnLimpar.Visible = false;
        }

        internal void Disable()
        {
            txtModelo.Enabled = false;
            txtSerie.Enabled = false;
            txtNrNota.Enabled = false;
            txtValor.Enabled = false;
            txtNrParcela.Enabled = false;
            txtFornecedor.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtDtEmissao.Enabled = false;
            txtDtVencimento.Enabled = false;
            txtCodFormaPagamento.Enabled = false;
            txtFormaPagamento.Enabled = false;
            txtObeservacoes.Enabled = false;
            txtDtCadastro.Enabled = false;
            txtDtAlteracao.Enabled = false;
            txtUsuario.Enabled = false;
            chkPaga.Enabled = false;
        }

        private void frmCadastroContaReceber_Load(object sender, EventArgs e)
        {

        }

      
    }
}
