namespace EquipMotos.View
{
    partial class frmCadastroContaPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNrNota = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtDtEmissao = new System.Windows.Forms.DateTimePicker();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtObeservacoes = new System.Windows.Forms.RichTextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.chkPaga = new System.Windows.Forms.CheckBox();
            this.btnBuscarCondPagamento = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCodFormaPagamento = new System.Windows.Forms.TextBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNrParcela = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtModelo.Location = new System.Drawing.Point(22, 108);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(80, 23);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // txtNrNota
            // 
            this.txtNrNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNrNota.Location = new System.Drawing.Point(130, 108);
            this.txtNrNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrNota.Name = "txtNrNota";
            this.txtNrNota.Size = new System.Drawing.Size(80, 23);
            this.txtNrNota.TabIndex = 1;
            this.txtNrNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNrNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrNota_KeyPress);
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSerie.Location = new System.Drawing.Point(257, 108);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(80, 23);
            this.txtSerie.TabIndex = 2;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtValor.Location = new System.Drawing.Point(24, 170);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(90, 23);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "R$0.00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            this.txtValor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtValor_KeyUp);
            this.txtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(21, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modelo *";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(129, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nr Nota *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(252, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Série *";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(128, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Vencimento *";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(382, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Emissão *";
            // 
            // txtDtVencimento
            // 
            this.txtDtVencimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtVencimento.Location = new System.Drawing.Point(132, 170);
            this.txtDtVencimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtVencimento.Name = "txtDtVencimento";
            this.txtDtVencimento.Size = new System.Drawing.Size(150, 23);
            this.txtDtVencimento.TabIndex = 12;
            // 
            // txtDtEmissao
            // 
            this.txtDtEmissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtEmissao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtEmissao.Location = new System.Drawing.Point(387, 108);
            this.txtDtEmissao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtEmissao.Name = "txtDtEmissao";
            this.txtDtEmissao.Size = new System.Drawing.Size(150, 23);
            this.txtDtEmissao.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(618, 542);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 154;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(491, 542);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpar.TabIndex = 153;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(383, 542);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 31);
            this.btnSalvar.TabIndex = 152;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(101, 558);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(6);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(65, 18);
            this.txtDtAlteracao.TabIndex = 263;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(24, 558);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(6);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(65, 18);
            this.txtDtCadastro.TabIndex = 262;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblAlteracao
            // 
            this.lblAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlteracao.AutoSize = true;
            this.lblAlteracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteracao.Location = new System.Drawing.Point(98, 542);
            this.lblAlteracao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAlteracao.Name = "lblAlteracao";
            this.lblAlteracao.Size = new System.Drawing.Size(77, 13);
            this.lblAlteracao.TabIndex = 259;
            this.lblAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(22, 542);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 258;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(180, 542);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(107, 13);
            this.lblUsuario.TabIndex = 270;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtUsuario.Location = new System.Drawing.Point(183, 558);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 18);
            this.txtUsuario.TabIndex = 271;
            // 
            // txtObeservacoes
            // 
            this.txtObeservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObeservacoes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtObeservacoes.Location = new System.Drawing.Point(22, 492);
            this.txtObeservacoes.Margin = new System.Windows.Forms.Padding(5);
            this.txtObeservacoes.Name = "txtObeservacoes";
            this.txtObeservacoes.Size = new System.Drawing.Size(258, 33);
            this.txtObeservacoes.TabIndex = 283;
            this.txtObeservacoes.Text = "";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblObservacoes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(20, 471);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(90, 16);
            this.lblObservacoes.TabIndex = 282;
            this.lblObservacoes.Text = "Observações";
            this.lblObservacoes.UseWaitCursor = true;
            // 
            // chkPaga
            // 
            this.chkPaga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPaga.AutoSize = true;
            this.chkPaga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkPaga.Location = new System.Drawing.Point(643, 87);
            this.chkPaga.Name = "chkPaga";
            this.chkPaga.Size = new System.Drawing.Size(60, 21);
            this.chkPaga.TabIndex = 284;
            this.chkPaga.Text = "Paga";
            this.chkPaga.UseVisualStyleBackColor = false;
            this.chkPaga.Visible = false;
            // 
            // btnBuscarCondPagamento
            // 
            this.btnBuscarCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCondPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCondPagamento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCondPagamento.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Location = new System.Drawing.Point(453, 292);
            this.btnBuscarCondPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarCondPagamento.Name = "btnBuscarCondPagamento";
            this.btnBuscarCondPagamento.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarCondPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCondPagamento.TabIndex = 292;
            this.btnBuscarCondPagamento.TabStop = false;
            this.btnBuscarCondPagamento.Click += new System.EventHandler(this.BtnBuscarCondPagamento_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Location = new System.Drawing.Point(90, 282);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(153, 17);
            this.label28.TabIndex = 291;
            this.label28.Text = "Forma de Pagamento *";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.Location = new System.Drawing.Point(93, 304);
            this.txtFormaPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(350, 23);
            this.txtFormaPagamento.TabIndex = 289;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(19, 282);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 17);
            this.label27.TabIndex = 290;
            this.label27.Text = "Código";
            // 
            // txtCodFormaPagamento
            // 
            this.txtCodFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFormaPagamento.Location = new System.Drawing.Point(23, 304);
            this.txtCodFormaPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFormaPagamento.Name = "txtCodFormaPagamento";
            this.txtCodFormaPagamento.Size = new System.Drawing.Size(60, 23);
            this.txtCodFormaPagamento.TabIndex = 288;
            this.txtCodFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPagamento.TextChanged += new System.EventHandler(this.txtCodFormaPagamento_TextChanged);
            this.txtCodFormaPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPagamento_KeyPress);
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarFornecedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarFornecedor.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(454, 217);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFornecedor.TabIndex = 298;
            this.btnBuscarFornecedor.TabStop = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.BtnBuscarFornecedor_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(90, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 297;
            this.label7.Text = "Fornecedor *";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(93, 233);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(350, 23);
            this.txtFornecedor.TabIndex = 295;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(20, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 296;
            this.label8.Text = "Código";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.Location = new System.Drawing.Point(23, 233);
            this.txtCodFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(60, 23);
            this.txtCodFornecedor.TabIndex = 294;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.TextChanged += new System.EventHandler(this.txtCodFornecedor_TextChanged);
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(316, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 300;
            this.label9.Text = "Nr da Parcela *";
            // 
            // txtNrParcela
            // 
            this.txtNrParcela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNrParcela.Location = new System.Drawing.Point(317, 170);
            this.txtNrParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txtNrParcela.Name = "txtNrParcela";
            this.txtNrParcela.Size = new System.Drawing.Size(60, 23);
            this.txtNrParcela.TabIndex = 299;
            this.txtNrParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCadastroContaPagar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNrParcela);
            this.Controls.Add(this.btnBuscarFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.btnBuscarCondPagamento);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtCodFormaPagamento);
            this.Controls.Add(this.chkPaga);
            this.Controls.Add(this.txtObeservacoes);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.lblAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDtEmissao);
            this.Controls.Add(this.txtDtVencimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtNrNota);
            this.Controls.Add(this.txtModelo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Contas à Pagar";
            this.Load += new System.EventHandler(this.FrmCadastroContaPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNrNota;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDtVencimento;
        private System.Windows.Forms.DateTimePicker txtDtEmissao;
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.Label lblAlteracao;
        private System.Windows.Forms.Label lblDtCadastro;
        protected System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.RichTextBox txtObeservacoes;
        protected System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.CheckBox chkPaga;
        private System.Windows.Forms.PictureBox btnBuscarCondPagamento;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCodFormaPagamento;
        private System.Windows.Forms.PictureBox btnBuscarFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNrParcela;
    }
}