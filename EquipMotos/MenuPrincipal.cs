using System;
using System.Windows.Forms;
using EquipMotos.Codigo.View;
using EquipMotos.View;

namespace EquipMotos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string pusuario)
        {
            InitializeComponent();
            statusUser.Name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            statusUser.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            status_data.Text = Convert.ToString(DateTime.Now);
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

        private void ProdutosEServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProdutosServicos frmConProServ = new frmConsultaProdutosServicos();
            frmConProServ.ShowDialog();
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
            frmConsultaProdutosServicos frmConProdutos = new frmConsultaProdutosServicos();
            frmConProdutos.ShowDialog();
            
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


        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria frmConCat = new frmConsultaCategoria();
            frmConCat.ShowDialog();
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
    }
}
