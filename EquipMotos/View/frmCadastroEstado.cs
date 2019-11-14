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
    public partial class frmCadastroEstado : Form
    {
        //Paises paises = new Paises();
        Estados est = new Estados();
        CtrlEstados CtrlEstado = new CtrlEstados();
        public static object paises;
        public frmCadastroEstado()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampos())
                {
                    Paises paises = new Paises();
                    est.estado = txtEstado.Text;
                    est.uf = txtUf.Text;
                    paises.codigo = Convert.ToInt32(txtCodPais.Text);
                    est.Pais = paises;
                    est.usuario = UsuarioLogado.Usuario;

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        est.codigo = Convert.ToInt32(txtCodigo.Text);
                        est.dtAlteracao = DateTime.Now;
                        CtrlEstado.Editar(est);

                        MessageBox.Show("Estado alterado com Sucesso!");
                    }
                    else
                    {
                        est.dtAlteracao = DateTime.Now;
                        est.dtCadastro = DateTime.Now;
                        CtrlEstado.Inserir(est);
                        MessageBox.Show("Estado cadastrado com Sucesso!");

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

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Faltou informar o Estado", "Informe o Estado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtEstado.Text))
            {
                MessageBox.Show("Estado invalido", "Estado não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtUf.Text))
            {
                MessageBox.Show("Faltou informar o UF", "Informe o UF!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUf.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtUf.Text))
            {
                MessageBox.Show("UF invalido", "UF não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUf.Focus();
                return false;
            }

            return true;
        }

        private void BtnBuscarPais_Click(object sender, EventArgs e)
        {
            frmConsultaPais frmConPais = new frmConsultaPais();
            frmConPais.btnVoltar.Text = "SELECIONAR";
            if (frmConPais.ShowDialog() == DialogResult.OK)
            {
                CarregaPais();
            }
        }

        public void CarregaPais()
        {
            Paises pais = paises as Paises;
            txtCodPais.Text = Convert.ToString(pais.codigo);
            txtPais.Text = pais.pais;
        }

        internal void Carregar(object id)
        {
            est = CtrlEstado.BuscarPorID(id) as Estados;
            txtCodigo.Text = Convert.ToString(est.codigo);
            txtEstado.Text = est.estado;
            txtUf.Text = est.uf;
            txtCodPais.Text = Convert.ToString(est.Pais.codigo);
            txtPais.Text = est.Pais.pais;
            txtDtCadastro.Text = Convert.ToString(est.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(est.dtAlteracao);
            txtUsuario.Text = est.usuario;

            btnSalvar.Text = "ALTERAR";
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtCodPais.Text = "";
            txtEstado.Text = "";
            txtPais.Text = "";
            txtDtAlteracao.Text = "";
            txtDtCadastro.Text = "";
            txtUsuario.Text = "";
        }

    }
}

