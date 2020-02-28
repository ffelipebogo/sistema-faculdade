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
    public partial class frmCadastroPais : MaterialSkin.Controls.MaterialForm
    {
        Paises Pais = new Paises();
        CtrlPaises CtrlPais = new CtrlPaises();
        public frmCadastroPais()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPais.Text = "";
            txtCodigoPais.Text = "";
            txtDtAlteracao.Text = "  /  /";
            txtDtCadastro.Text = "  /  /";
            txtUsuario.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCampo())
                {
                    Pais.pais = txtPais.Text;
                   // pais.dtCadastro = DateTime.Now;
                    //pais.dtAlteracao = DateTime.Now;
                    Pais.usuario = txtUsuario.Text;



                    //dao.InserirPais(pais);

                    if (btnSalvar.Text == "ALTERAR")
                    {
                        Pais.codigo = Convert.ToInt32(txtCodigoPais.Text);
                        Pais.dtAlteracao = DateTime.Now;
                        CtrlPais.Editar(Pais);

                        MessageBox.Show("Pais alterado com Sucesso!");
                    }
                    else
                    {
                        Pais.dtAlteracao = DateTime.Now;
                        Pais.dtCadastro = DateTime.Now;
                        CtrlPais.Inserir(Pais);
                        MessageBox.Show("Pais cadastrado com Sucesso!");
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
            }
        }

        internal void Carregar(object id)
        {
            Pais = CtrlPais.BuscarPorID(id) as Paises;
            txtCodigoPais.Text = Convert.ToString(Pais.codigo);
            txtPais.Text = Pais.pais;
            txtDtCadastro.Text = Convert.ToString(Pais.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(Pais.dtAlteracao);
            txtUsuario.Text = Pais.usuario;
            btnSalvar.Text = "ALTERAR";
        }

        public bool ValidaCampo()
        {
            if (String.IsNullOrEmpty(txtPais.Text.Trim()))
            {
                MessageBox.Show("Faltou informar o Pais", "Informe Pais!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPais.Focus();
                return false;
            }
            if (!MaskForm.ValidaTexto(txtPais.Text))
            {
                MessageBox.Show("Pais invalido", "Nome Pais não pode conter numeros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPais.Focus();
                return false;
            }
            return true;
        }

        private void frmCadastroPais_Load(object sender, EventArgs e)
        {

        }
    }
}
