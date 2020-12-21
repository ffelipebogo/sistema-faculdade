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
    public partial class frmCadastroCidade : MaterialSkin.Controls.MaterialForm
    {
        public static object estado;

        Cidades cid = new Cidades();
        CtrlCidades CtrlCidade = new CtrlCidades();
        CtrlEstados CtrlEstado = new CtrlEstados();

        public frmCadastroCidade()
        {
            InitializeComponent();
        }

        private void BtnBuscarEstado_Click(object sender, EventArgs e)
        {
            frmConsultaEstado frmConEstado = new frmConsultaEstado();
            frmConEstado.btnVoltar.Text = "SELECIONAR";
            if (frmConEstado.ShowDialog() == DialogResult.OK)
            {
                CarregaEstado();
            }
        }

        private void CarregaEstado()
        {
            if (estado != null)
            {
                Estados est = estado as Estados;
                txtCodEstado.Text = Convert.ToString(est.codigo);
                txtEstado.Text = est.estado;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Estados est = new Estados();

                cid.cidade = txtCidade.Text;
                est.codigo = Convert.ToInt32(txtCodEstado.Text);
                cid.Estado = est;
                cid.usuario = UsuarioLogado.Usuario;

                if (btnSalvar.Text == "ALTERAR")
                {
                    cid.codigo = Convert.ToInt32(txtCodigo.Text);
                    cid.dtAlteracao = DateTime.Now;
                    CtrlCidade.Editar(cid);

                    MessageBox.Show("Cidade alterada com Sucesso!");
                }
                else
                {
                    cid.dtAlteracao = DateTime.Now;
                    cid.dtCadastro = DateTime.Now;
                    CtrlCidade.Inserir(cid);
                    MessageBox.Show("Cidade cadastrada com Sucesso!");

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Verifique se todos os campos foram preenchidos corretamente");
                MessageBox.Show(ex.Message);
            }
        }

        internal void Carregar(object id)
        {
            
            cid = CtrlCidade.BuscarPorID(id) as Cidades;
            txtCodigo.Text = Convert.ToString(cid.codigo);
            txtCidade.Text = cid.cidade;
            txtCodEstado.Text = Convert.ToString(cid.Estado.codigo);
            txtEstado.Text = cid.Estado.estado;
            txtDtCadastro.Text = Convert.ToString(cid.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(cid.dtAlteracao);
            txtUsuario.Text = cid.usuario;
            
            btnSalvar.Text = "ALTERAR";
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtCidade.Text = "";
            txtCodEstado.Text = "";
            txtCodigo.Text = "";
            txtEstado.Text = "";
        }

        private void frmCadastroCidade_Load(object sender, EventArgs e)
        {

        }

        private void txtCodEstado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodEstado.Text))
                return;
             
            Estados estad = CtrlEstado.BuscarPorID(Convert.ToInt32(txtCodEstado.Text)) as Estados;
            if (estad == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtEstado.Clear();
                txtCodEstado.Clear();
                txtEstado.Enabled = true;
                txtCodEstado.Enabled = true;
                txtCodEstado.Focus();

            }
            else
            {
                estado = estad;
                txtEstado.Text = estad.estado;
                txtEstado.Enabled = false;
                txtCodEstado.Focus();
            }
        }
    }
}
