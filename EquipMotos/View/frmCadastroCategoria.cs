using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
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
    public partial class frmCadastroCategoria : frmCadastro
    {
        CtrlCategorias CtrlCategoria = new CtrlCategorias();
        Categorias cat = new Categorias();

        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampo())
            {
                cat.categoria = txtCategoria.Text;
                cat.dtAlteracao = DateTime.Now;
                cat.dtCadastro = DateTime.Now;
                cat.usuario = "";

                if (btnSalvar.Text == "ALTERAR")
                {
                    cat.codigo = Convert.ToInt32("0" + txtCodigo.Text);
                    cat.dtAlteracao = DateTime.Now;
                    CtrlCategoria.Editar(cat);

                    MessageBox.Show("Categoria alterada com Sucesso!");
                }
                else
                {
                    cat.dtAlteracao = DateTime.Now;
                    cat.dtCadastro = DateTime.Now;
                    CtrlCategoria.Inserir(cat);
                    MessageBox.Show("Categoria cadastrada com Sucesso!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
            }
            this.DialogResult = DialogResult.OK;

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = "";
            txtCodigo.Text = "";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidaCampo()
        {
            if (txtCategoria.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar a Categoria", "Informe a Categoria!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                return false;
            }
            return true;
        }

        public void Carregar(object id)
        {
            Categorias cat = CtrlCategoria.BuscarPorID(id) as Categorias;
            txtCodigo.Text = Convert.ToString(cat.codigo);
            txtCategoria.Text = cat.categoria;
            txtDtCadastro.Text = Convert.ToString(cat.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(cat.dtAlteracao);
            txtObeservacoes.Text = cat.observacoes;
            txtUsuario.Text = cat.usuario;
            btnSalvar.Text = "ALTERAR";

        }

    }
}
