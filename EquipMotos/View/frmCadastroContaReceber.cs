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
    public partial class frmCadastroContaReceber : Form
    {
        CtrlFormaPagamentos ctrlFormaPagamento = new CtrlFormaPagamentos();
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

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCondPagamento_Click(object sender, EventArgs e)
        {

        }

        public void Carrega()
        {
            ContasReceber ContaReceber = new ContasReceber();
            FormaPagamentos Forma = new FormaPagamentos();
            txtModelo.Text = ContaReceber.modelo;
            txtSerie.Text = ContaReceber.serie;
            txtNrNota.Text = ContaReceber.nrNota;
            txtNrParcela.Text = Convert.ToString(ContaReceber.nrParcela);
            txtValor.Text = Convert.ToString(ContaReceber.vlrParcela);
            txtDtEmissao.Value = ContaReceber.dtEmissao;
            txtDtVencimento.Value = ContaReceber.dtVecimento;
            Forma = ctrlFormaPagamento.BuscarPorID(ContaReceber.formaPagamento.codigo) as FormaPagamentos;
            txtCodFormaPagamento.Text = Convert.ToString(Forma.codigo);
            txtFormaPagamento.Text = Forma.forma;
            txtDtCadastro.Text = Convert.ToString(ContaReceber.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(ContaReceber.dtAlteracao);
            txtUsuario.Text = ContaReceber.usuario;
        }
    }
}
