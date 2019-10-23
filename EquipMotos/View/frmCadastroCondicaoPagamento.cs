using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.Properties;
using EquipMotos.View.helper;
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
    public partial class frmCadastroCondicaoPagamento : Form
    {
        
        CondicaoPagamentos condPagamento = new CondicaoPagamentos();
        CondicaoPagamentoDAO dao = new CondicaoPagamentoDAO();
        public static object formaPag = null;
        List<CondicaoParcelada> listaParcela = new List<CondicaoParcelada>();

        public frmCadastroCondicaoPagamento()
        {            
            InitializeComponent();
            ToolTip toolTip = new ToolTip();

            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.btnAdd, "Adicionar Parcela");
            toolTip.SetToolTip(this.btnRemove, "Remover Parcela");
            toolTip.SetToolTip(this.btnBuscarFormaPag, "Pesquisar Forma de Pagamento");
            toolTip.SetToolTip(this.btnSalvar, "Salvar");
            toolTip.SetToolTip(this.btnLimpar, "Limpar");
            toolTip.SetToolTip(this.btnVoltar, "Voltar");
        }

        private void FrmCondicaoPagamento_Load(object sender, EventArgs e)
        {
            //if( listalblParcela.Count < 1)
            //{

            //    btnAdd.PerformClick();
            //}
        }

        #region Buscar Forma Pagamento
        public void BtnBuscarFormaPag_Click(object sender, EventArgs e)
        {
            frmConsultaFormaPagamento frmConFormaPag = new frmConsultaFormaPagamento();

            frmConFormaPag.btnVoltar.Text = "SELECIONAR";
            if (frmConFormaPag.ShowDialog() == DialogResult.OK)
            {
                
                CarregaForma();
            }
        }

        private  void CarregaForma()
        {
            if (formaPag != null)
            {
                FormaPagamentos forma = formaPag as FormaPagamentos;
                txtCodFormaPagamento.Text = Convert.ToString(forma.codigo);
                txtFormaPagamento.Text = forma.forma;
            }
        }
        #endregion

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (SomaPorcentagem() == 100) //TODO quando for 100 da true ainda
            {
                condPagamento.condicao = txtCondicao.Text;
                condPagamento.juros = Double.Parse(txtJuros.Text, NumberStyles.Any);
                condPagamento.multa = Double.Parse(txtMulta.Text, NumberStyles.Any);
                condPagamento.desconto = Double.Parse(txtDesconto.Text, NumberStyles.Any);
                condPagamento.usuario = txtUsuario.Text;
                if (btnSalvar.Text == "ALTERAR")
                {
                    condPagamento.codigo = Convert.ToInt32(txtCodigo.Text);
                    condPagamento.dtAlteracao = DateTime.Now;
                    //dao.ExcluirParcela(condPagamento.codigo);
                    for (int i = 0; i < listviewParcelas.Items.Count; i++)
                    {
                        FormaPagamentos formaPag = new FormaPagamentos();
                        formaPag.codigo = Convert.ToInt32(listviewParcelas.Items[i].SubItems[3].Text);
                        var parce = listviewParcelas.Items[i];


                        listaParcela.Add(new CondicaoParcelada()
                        {
                            nrParcela = Convert.ToInt32(listviewParcelas.Items[i].SubItems[0].Text),
                            nrDia = Convert.ToInt32(listviewParcelas.Items[i].SubItems[1].Text),
                            porcentagem = Double.Parse(listviewParcelas.Items[i].SubItems[2].Text),
                            formaPagamento = formaPag,
                            dtAlteracao = DateTime.Now,
                            dtCadastro = condPagamento.dtCadastro
                        }) ;
                    }
                    condPagamento.listaParcela = listaParcela;
                    dao.EditarCondicaoPagamento(condPagamento);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    for (int i = 0; i < listviewParcelas.Items.Count; i++)
                    {
                        FormaPagamentos formaPag = new FormaPagamentos();
                        formaPag.codigo = Convert.ToInt32(listviewParcelas.Items[i].SubItems[3].Text);
                        listaParcela.Add(new CondicaoParcelada()
                        {
                            nrParcela = Convert.ToInt32(listviewParcelas.Items[i].SubItems[0].Text),
                            nrDia = Convert.ToInt32(listviewParcelas.Items[i].SubItems[1].Text),
                            porcentagem = Double.Parse(listviewParcelas.Items[i].SubItems[2].Text),
                            formaPagamento = formaPag,
                            condPagamento = condPagamento,
                            dtCadastro = DateTime.Now,
                            dtAlteracao = DateTime.Now
                        });
                    }
                    condPagamento.listaParcela = listaParcela;
                    condPagamento.dtAlteracao = DateTime.Now;
                    condPagamento.dtCadastro = DateTime.Now;
                    dao.InserirCondicaoPagamento(condPagamento);


                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Porcentagem inválida!", "Porcentagem não deu 100%", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #region Limpar campos
        private void LimparCampos()
        {
            txtCodFormaPagamento.Text = "";
            txtCodigo.Text = "";
            txtCondicao.Text = "";
            txtDesconto.Text = "";
            txtFormaPagamento.Text = "";
            txtMulta.Text = "";
            txtJuros.Text = "";
            txtDtCadastro.Text = "";
            txtDtAlteracao.Text = "";
            txtUsuario.Text = "";
            listviewParcelas.Items.Clear();
        }
        #endregion

        #region Adicionar Parcela
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaParcela())
                {
                    string[] row = { txtNrParcelas.Text, txtNrDias.Text, Double.Parse(txtPorcentagem.Text, NumberStyles.Any).ToString(), txtCodFormaPagamento.Text, txtFormaPagamento.Text };

                    var lvi = new ListViewItem(row);

                    if (listviewParcelas.Items.Count <= 11)
                    {
                        listviewParcelas.Items.Add(lvi);
                        txtNrParcelas.Text = "";
                        txtNrDias.Text = "";
                        txtPorcentagem.Text = "";
                        txtCodFormaPagamento.Text = "";
                        txtFormaPagamento.Text = "";
                        txtCodFormaPagamento.Enabled = true;
                        txtFormaPagamento.Enabled = true;
                    }
                    else
                    {
                        btnAdd.Enabled = false;
                        txtNrParcelas.Text = "";
                        MessageBox.Show("Maximo de parcelas é 12");
                    }
                } 
            }
            catch
            {
                MessageBox.Show("Não foi possivel adicionar a parcela");
            }
                    
        }

        #region Validar parcelas
        private bool ValidaParcela()
        {
            if (Double.Parse(txtNrParcelas.Text) < 0)
            {
                MessageBox.Show("Numero de parcela ínvalida!");
                txtNrParcelas.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtNrParcelas.Text) < 0)
            {
                MessageBox.Show("Numero de parcela ínvalida!");
                txtNrParcelas.Focus();
                return false;
            }
            if (txtNrDias.Text == String.Empty)
            {
                MessageBox.Show("Numero de dias invalido!");
                txtNrDias.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtNrDias.Text) < 0)
            {
                MessageBox.Show("Numero de dias invalido!");
                txtNrDias.Focus();
                return false;
            }
            if (Double.Parse(txtPorcentagem.Text) <= 0)
            {
                MessageBox.Show("Porcentagem invalida!");
                txtPorcentagem.Focus();
                return false;
            }
         
            if (txtCodFormaPagamento.Text == String.Empty)
            {
                MessageBox.Show("Codigo da forma de pagamento ínvalido!");
                txtCodFormaPagamento.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtCodFormaPagamento.Text) < 0)
            {
                MessageBox.Show("Codigo da forma de pagamento ínvalido!");
                txtCodFormaPagamento.Focus();
                return false;
            }
            if (txtFormaPagamento.Text == String.Empty)
            {
                MessageBox.Show("Forma de pagamento ínvalida!");
                txtFormaPagamento.Focus();
                return false;
            }
            if (!ValidaPorcentagem())
            {
                MessageBox.Show("A soma da porcentagem não pode ser maior que 100%!");
                txtPorcentagem.Focus();
                return false;
            } 
            return true;
        }
        #endregion

        private double SomaPorcentagem()
        {
            double vlr = 0;
            for (int i = 0; i < listviewParcelas.Items.Count; i++)
            {
                vlr += Double.Parse(listviewParcelas.Items[i].SubItems[2].Text);
            }
            return vlr;
        }
        private bool ValidaPorcentagem()
        {
            var vl = SomaPorcentagem();
            var perct = vl + double.Parse("0" + txtPorcentagem.Text);
            if (perct <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region Remover Parcela
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Remover parcela ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & (listviewParcelas.SelectedIndices[0] != null))
                {
                    listviewParcelas.Items.RemoveAt(listviewParcelas.SelectedIndices[0]);
                }

            }
            catch
            {
                MessageBox.Show("Selecione uma parcela! ");
            }
        }
        #endregion

        private void ListviewParcelas_Click(object sender, EventArgs e)
        {
            if (listviewParcelas.Items.Count <= 12)
            {
                btnAdd.Enabled = true;
            }
        }

        private void TxtFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            txtCodFormaPagamento.Enabled = false;
            txtFormaPagamento.Enabled = false;
        }

        public void Carregar(object id)
        {
            condPagamento = dao.BuscarCondicao_porID(id);

            txtCodigo.Text = Convert.ToString(condPagamento.codigo);
            txtCondicao.Text = condPagamento.condicao;
            txtJuros.Text = Convert.ToString(condPagamento.juros);
            txtMulta.Text = Convert.ToString(condPagamento.multa);
            txtDesconto.Text = Convert.ToString(condPagamento.desconto);
            
            foreach (var parcela in condPagamento.listaParcela)
            {
                string[] row = { Convert.ToString(parcela.nrParcela), Convert.ToString(parcela.nrDia), Convert.ToString(parcela.porcentagem), Convert.ToString(parcela.formaPagamento.codigo), Convert.ToString(parcela.formaPagamento.forma) };
                var lvi = new ListViewItem(row);

                listviewParcelas.Items.Add(lvi);

            }
            btnSalvar.Text = "ALTERAR";
        }

        private void TxtJuros_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtJuros_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtPorcentagem_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyPress(sender, e);
        }

        private void TxtPorcentagem_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtMulta_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtMulta_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtDesconto_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtNrDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyPress(sender, e);
        }

        private void TxtNrDias_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtNrDias_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtNrParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtNrParcelas_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtNrParcelas_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtCodFormaPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtCodFormaPagamento_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtCodFormaPagamento_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }
    }
}
