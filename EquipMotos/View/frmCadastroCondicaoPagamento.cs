using EquipMotos.CONTROLLER;
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
    public partial class frmCadastroCondicaoPagamento : MaterialSkin.Controls.MaterialForm
    {
        
        CondicaoPagamentos condPagamento = new CondicaoPagamentos();
        CtrlCondicaoPagamento CtrlCondPagamento = new CtrlCondicaoPagamento();
        CtrlFormaPagamentos CtrlFormaPagamento = new CtrlFormaPagamentos();
        public static object formaPag = null;
        List<CondicaoParcelada> listaParcela = new List<CondicaoParcelada>();

        public frmCadastroCondicaoPagamento()
        {            
            InitializeComponent();
            ToolTip toolTip = new ToolTip();

            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.btnAdd, "Adicionar Parcela");
            toolTip.SetToolTip(this.btnRemove, "Remover a ultima Parcela");
            toolTip.SetToolTip(this.btnLimparListaParcela, "Remover todas Parcelas");
            toolTip.SetToolTip(this.btnBuscarFormaPag, "Pesquisar Forma de Pagamento");
            toolTip.SetToolTip(this.btnSalvar, "Salvar");
            toolTip.SetToolTip(this.btnLimpar, "Limpar");
            toolTip.SetToolTip(this.btnVoltar, "Voltar");
        }

        private void FrmCondicaoPagamento_Load(object sender, EventArgs e)
        {
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
                txtFormaPagamento.Enabled = false;
                txtCodFormaPagamento.Enabled = false;
            }
        }
        #endregion

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (SomaPorcentagem() == 100) 
            {
                condPagamento.condicao = txtCondicao.Text;
                condPagamento.juros = Double.Parse(txtJuros.Text);
                condPagamento.multa = Double.Parse(txtMulta.Text);
                condPagamento.desconto = Double.Parse(txtDesconto.Text);
                condPagamento.usuario = UsuarioLogado.Usuario;
                if (btnSalvar.Text == "ALTERAR")
                {
                    condPagamento.codigo = Convert.ToInt32(txtCodigo.Text);
                    condPagamento.dtAlteracao = DateTime.Now; 
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
                            dtAlteracao = DateTime.Now,
                            dtCadastro = condPagamento.dtCadastro,
                            usuario = UsuarioLogado.Usuario
                        }) ;
                    }
                    condPagamento.listaParcela = listaParcela;
                    CtrlCondPagamento.Editar(condPagamento);
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
                            dtAlteracao = DateTime.Now,
                            usuario = UsuarioLogado.Usuario
                        });
                    }
                    condPagamento.listaParcela = listaParcela;
                    condPagamento.dtAlteracao = DateTime.Now;
                    condPagamento.dtCadastro = DateTime.Now;
                    CtrlCondPagamento.Inserir(condPagamento);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Porcentagem não atingiu 100%", "Porcentagem inválida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtNrParcelas.Text = Convert.ToString(listviewParcelas.Items.Count + 1 );
                    txtNrDias.Focus();
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

        #region Reorganiza table
        private void Reorganiza(ListView lvi)
        {
            if (lvi.Items.Count > 0)
            {
                for( int i = 1; i < lvi.Items.Count; i++)
                {
                    for( int j = 0; j < (lvi.Items.Count - i); j++)
                    {
                        if ( Convert.ToInt64(lvi.Items[j].SubItems[1].Text) > Convert.ToInt64(lvi.Items[j + 1].SubItems[1].Text))
                        {
                            ListViewItem item = lvi.Items[j];
                            lvi.Items[j].SubItems[1].Text = lvi.Items[j + 1].SubItems[1].Text;
                            lvi.Items[j].SubItems[2].Text = lvi.Items[j + 1].SubItems[2].Text;
                            lvi.Items[j].SubItems[3].Text = lvi.Items[j + 1].SubItems[3].Text;
                            lvi.Items[j].SubItems[4].Text = lvi.Items[j + 1].SubItems[4].Text;
                            lvi.Items[j + 1].SubItems[1].Text = item.SubItems[1].Text;
                            lvi.Items[j + 1].SubItems[2].Text = item.SubItems[2].Text;
                            lvi.Items[j + 1].SubItems[3].Text = item.SubItems[3].Text;
                            lvi.Items[j + 1].SubItems[4].Text = item.SubItems[4].Text;
                        }
                    }
                }
                listviewParcelas = lvi;
            }
            else
            {
                txtNrParcelas.Text = Convert.ToString(1);
            }
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
                var item = listviewParcelas.Items[listviewParcelas.Items.Count - 1];
                if (MessageBox.Show("Remover parcela "+ item.SubItems[0].Text + " ? ", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    if (listviewParcelas.Items.Count > 0)
                    {

                        listviewParcelas.Items.Remove(item);
                        txtNrParcelas.Text = Convert.ToString(listviewParcelas.Items.Count + 1);
                    }
                    else
                    {
                        txtNrParcelas.Text = Convert.ToString(1);
                    }
                }     
            }
            catch
            {
                MessageBox.Show("Não foi possivel remover a parcela! ");
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
            //txtCodFormaPagamento.Enabled = false;
            //txtFormaPagamento.Enabled = false;
        }

        public void Carregar(object id)
        {
            condPagamento = CtrlCondPagamento.BuscarPorID(id) as CondicaoPagamentos;

            txtCodigo.Text = Convert.ToString(condPagamento.codigo);
            txtCondicao.Text = condPagamento.condicao;
            txtJuros.Text = Convert.ToString(condPagamento.juros);
            txtMulta.Text = Convert.ToString(condPagamento.multa);
            txtDesconto.Text = Convert.ToString(condPagamento.desconto);
            txtDtAlteracao.Text = condPagamento.dtAlteracao.ToString();
            txtDtCadastro.Text = condPagamento.dtCadastro.ToString();
            txtUsuario.Text = condPagamento.usuario.ToString();
            foreach (var parcela in condPagamento.listaParcela)
            {
                string[] row = { Convert.ToString(parcela.nrParcela), Convert.ToString(parcela.nrDia), Convert.ToString(parcela.porcentagem), Convert.ToString(parcela.formaPagamento.codigo), Convert.ToString(parcela.formaPagamento.forma) };
                var lvi = new ListViewItem(row);

                listviewParcelas.Items.Add(lvi);

            }
            btnSalvar.Text = "ALTERAR";
        }

        #region Validate Filds

        private void TxtJuros_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtJuros.Text))
            {
                var jurosInt = double.Parse(txtJuros.Text);
                var juros = jurosInt / 100;
                if (txtJuros.Text.Trim().Length > 5)
                {
                    MessageBox.Show("Não é possivel inserir este juro", "Informe um juros com menos de 4 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJuros.Focus();
                    txtJuros.Text = "";
                }else if((juros < 0.00) | ( juros > 100.00) )
                {
                    if(juros > 100.00)
                    {
                        MessageBox.Show("Não é possivel inserir este juro", "Informe um juros menor que 100 %", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel inserir este juro", "Informe um juros maior que 0 %", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtJuros.Focus();
                }
            }
        }

        private void TxtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyPress(sender, e);
        }

        private void TxtMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Valida_KeyPress(sender, e);
        }

        private void TxtNrDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void TxtNrParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void TxtCodFormaPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtCondicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void TxtJuros_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtPorcentagem_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }

        private void TxtPorcentagem_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtMulta_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtMulta_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMulta.Text))
            {
                var multaInt = double.Parse(txtMulta.Text);
                var multa = multaInt / 100;
                if (txtMulta.Text.Trim().Length > 5)
                {
                    MessageBox.Show("Não é possivel inserir esta multa", "Informe uma multa com menos de 4 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMulta.Focus();
                    txtMulta.Text = "";
                }
                else if ((multa < 0) | (multa > 100))
                {
                    if (multa > 100)
                    {
                        MessageBox.Show("Não é possivel inserir esta multa", "Informe uma multa menor que 100 %", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel inserir esta multa", "Informe uma multa maior que 0 %", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtJuros.Focus();
                }
            }
        }

        private void TxtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtDesconto_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDesconto.Text))
            {
                var descontoInt = double.Parse(txtDesconto.Text);
                var desconto = descontoInt / 100;
                if (txtDesconto.Text.Trim().Length > 5)
                {
                    MessageBox.Show("Não é possivel inserir este desconto", "Informe um desconto com menos de 4 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesconto.Focus();
                    txtDesconto.Clear();
                }
                else if ((desconto < 0) & (desconto > 100))
                {
                    if (desconto > 100)
                    {
                        MessageBox.Show("Não é possivel inserir este desconto", "Informe um desconto menor que 100 %", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel inserir este desconto", "Informe um desconto maior que 0 %", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtJuros.Focus();
                }
            }
        }

        private void TxtNrDias_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void TxtNrDias_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNrDias.Text))
            {
                var dias = double.Parse(txtNrDias.Text);
                if (dias == 0)
                {
                    MessageBox.Show("Não é possivel inserir esta quatidade de dias", "Informe uma quantidade maior que 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNrDias.Focus();
                    txtNrDias.Clear();
                }
                else if(dias > 365)
                {
                    MessageBox.Show("Não é possivel inserir esta quatidade de dias", "Informe uma quantidade menor que 365", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNrDias.Focus();
                    txtNrDias.Clear();
                }
            }
        }

        private void TxtNrParcelas_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TxtNrParcelas_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNrParcelas.Text))
            {
                if (txtNrParcelas.Text.Trim().Length > 2)
                {
                    MessageBox.Show("Não é possivel inserir este valor", "Informe um valor com menos de 3 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNrParcelas.Focus();
                    txtNrParcelas.Clear();
                }
            }
        }

        private void TxtCodFormaPagamento_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_KeyUp(sender, e);
        }

        private void TxtCodFormaPagamento_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Porcentagem_Leave(sender, e);
        }
        #endregion

        private void txtCodFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodFormaPagamento.Text))
                return;
            if (Convert.ToInt32("0" + txtCodFormaPagamento.Text) < 1)
                return;
            FormaPagamentos formaPag = CtrlFormaPagamento.BuscarPorID(Convert.ToInt32(txtCodFormaPagamento.Text)) as FormaPagamentos;
            if (formaPag == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCodFormaPagamento.Text = "";
                txtFormaPagamento.Text = "";
                txtCodFormaPagamento.Enabled = true;
                txtFormaPagamento.Enabled = true;
            }
            else
            {
                txtFormaPagamento.Text = formaPag.forma;
                txtCodFormaPagamento.Enabled = false;
                txtFormaPagamento.Enabled = false;
            }
        }

        private void txtCondicao_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCondicao.Text))
            {
                if(txtCondicao.Text.Length > 30)
                {
                    MessageBox.Show("Não é possivel inserir esta condição", "Informe uma condição com menos de 30 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCondicao.Focus();
                }else if (txtCondicao.Text.Length < 5)
                {
                    MessageBox.Show("Não é possivel inserir esta condição", "Informe uma condição com mais de 5 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCondicao.Focus();
                }
            }
        }

        private void btnLimparListaParcela_Click(object sender, EventArgs e)
        {
            listviewParcelas.Items.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
