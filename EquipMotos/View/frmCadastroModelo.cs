using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
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
    public partial class frmCadastroModelo : Form
    {
        public static object marca;
        Modelos Modelo = new Modelos();
        CtrlModelos CtrlModelo = new CtrlModelos();
        public frmCadastroModelo()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscarMarca_Click(object sender, EventArgs e)
        {
            frmConsultaMarca frmConMarca = new frmConsultaMarca();
            frmConMarca.btnVoltar.Text = "SELECIONAR";
            if (frmConMarca.ShowDialog() == DialogResult.OK)
            {
                CarregaMarca();
            }
        }

        private void CarregaMarca()
        {
            if (marca != null)
            {
                Marcas mar = marca as Marcas;
                txtCodMarca.Text = Convert.ToString(mar.codigo);
                txtMarca.Text = mar.marca;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCompos())
                {
                    Marcas mar = new Marcas();
                    Modelo.modelo = txtModelo.Text;
                    mar.codigo = Convert.ToInt32(txtCodMarca.Text);
                    Modelo.Marca = mar;
                    Modelo.usuario = UsuarioLogado.Usuario;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        Modelo.codigo = Convert.ToInt32(txtCodModelo.Text);
                        Modelo.dtAlteracao = DateTime.Now;
                        CtrlModelo.Editar(Modelo);
                        MessageBox.Show("Modelo alterado com Sucesso!");
                    }
                    else
                    {
                        Modelo.dtAlteracao = DateTime.Now;
                        Modelo.dtCadastro = DateTime.Now;
                        CtrlModelo.Inserir(Modelo);
                        MessageBox.Show("Modelo cadastrado com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        private bool ValidaCompos()
        {
            if (txtModelo.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este modelo", "Informe o modelo com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtModelo.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Modelo", "Informe o Modelo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            if (txtMarca.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir esta marca", "Informe a marca com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtMarca.Text.Trim()))
            {
                MessageBox.Show("Faltou informar a Marca", "Informe a Marca!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }
            return true;
        }

        internal void Carregar(object id)
        {
            Modelo = CtrlModelo.BuscarPorID(id) as Modelos;
            txtCodModelo.Text = Convert.ToString(Modelo.codigo);
            txtModelo.Text = Modelo.modelo;
            txtCodMarca.Text = Convert.ToString(Modelo.Marca.codigo);
            txtMarca.Text = Modelo.Marca.marca;
            txtDtCadastro.Text = Convert.ToString(Modelo.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(Modelo.dtAlteracao);
            txtUsuario.Text = Modelo.usuario;

            btnSalvar.Text = "ALTERAR";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodModelo.Text = "";
            txtCodMarca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDtAlteracao.Text = "";
            txtDtCadastro.Text = "";
            txtUsuario.Text = "";
        }

        private void txtCodMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }
    }
}
