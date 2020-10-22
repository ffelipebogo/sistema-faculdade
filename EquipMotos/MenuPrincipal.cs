using System;
using System.Windows.Forms;
using EquipMotos.Codigo.View;
using EquipMotos.View;
using System.Diagnostics;
using EquipMotos.VIEW;

namespace EquipMotos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string pusuario)
        {
            InitializeComponent();
        }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConCliente = new frmConsultaCliente();
            frmConCliente.ShowDialog();
            
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor frmConfonercedor = new frmConsultaFornecedor();
            frmConfonercedor.ShowDialog();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServico frmConServico = new frmConsultaServico();
            frmConServico.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario frmConFuncionario = new frmConsultaFuncionario();
            frmConFuncionario.ShowDialog();
        }

        private void ModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaModelo frmConModelo = new frmConsultaModelo();
            frmConModelo.ShowDialog();
        }

        private void MarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMarca frmConMarca = new frmConsultaMarca();
            frmConMarca.ShowDialog();
        }

        private void ConsultarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstoque frmConEstoque = new frmConsultaEstoque();
            frmConEstoque.ShowDialog();
            
        }

        private void EstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPais frmConPais = new frmConsultaPais();
            frmConPais.ShowDialog();
        }

        private void EstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEstado frmConEstado = new frmConsultaEstado();
            frmConEstado.ShowDialog();
        }

        private void CidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCidade frmConCidade = new frmConsultaCidade();
            frmConCidade.ShowDialog();
        }

        private void FormasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento frmConFormaPag = new frmConsultaFormaPagamento();
            frmConFormaPag.ShowDialog();
        }

        private void CondiçõesDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCondicaoPagamento frmConCondPag = new frmConsultaCondicaoPagamento();
            frmConCondPag.ShowDialog();
        }

        private void ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCompra frmConCompra = new frmConsultaCompra();
            frmConCompra.ShowDialog();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVenda frmConVenda = new frmConsultaVenda();
            frmConVenda.ShowDialog();
        }

        private void ContasÀPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaContaPagar frmConContaPagar = new frmConsultaContaPagar();
            frmConContaPagar.ShowDialog();
        }

        private void OrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaOrdemServico frmConOrdemServico = new frmConsultaOrdemServico();
            frmConOrdemServico.ShowDialog();
        }

        private void contasÀReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaContaReceber frmConContaReceber = new frmConsultaContaReceber();
            frmConContaReceber.ShowDialog();
        }

        private void statusUser_Click(object sender, EventArgs e)
        {

        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new  ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "C:\\dev\\faculdade\\reactJs\\report-reactjs\\script.bat";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void produtosStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProduto frmConProduto= new frmConsultaProduto();
            frmConProduto.ShowDialog();
        }

        private void categoriasStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frmConcategoria = new frmConsultaCategoria();
            frmConcategoria.ShowDialog();
        }
    }
}
