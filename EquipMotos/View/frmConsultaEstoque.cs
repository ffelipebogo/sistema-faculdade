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

namespace EquipMotos.VIEW
{
    public partial class frmConsultaEstoque : MaterialSkin.Controls.MaterialForm
    {

        CtrlProdutos CtrlProduto = new CtrlProdutos();

        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void frmConsultaEstoque_Load(object sender, EventArgs e)
        {
            gvEstoque.DataSource = CtrlProduto.ListarTodos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string prod = txtPesquisar.Text;
            DataGridView dtView = new DataGridView();
            dtView.DataSource = CtrlProduto.Pesquisar(prod);
            if (dtView.DataSource == null)
            {
                MessageBox.Show("Não encotrado");
            }
            else
            {
                gvEstoque.DataSource = dtView.DataSource;
            }
        }
    }
}
