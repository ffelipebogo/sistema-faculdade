using EquipMotos.View.helper;
using System.Windows.Forms;

namespace EquipMotos.View
{
    partial class frmCadastroCondicaoPagamento
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarFormaPag = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtCondicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listviewParcelas = new System.Windows.Forms.ListView();
            this.nrParcela = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcentagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormaPagamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNrParcelas = new System.Windows.Forms.TextBox();
            this.txtNrDias = new System.Windows.Forms.TextBox();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.btnLimparListaParcela = new System.Windows.Forms.Button();
            this.codFormaPag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFormaPag)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 276;
            this.label6.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 98);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesconto.Location = new System.Drawing.Point(550, 73);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(93, 17);
            this.lblDesconto.TabIndex = 279;
            this.lblDesconto.Text = "Desconto % *";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(554, 98);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(5);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(60, 23);
            this.txtDesconto.TabIndex = 5;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.TxtDesconto_Leave);
            // 
            // lblMulta
            // 
            this.lblMulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMulta.AutoSize = true;
            this.lblMulta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMulta.Location = new System.Drawing.Point(461, 73);
            this.lblMulta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(67, 17);
            this.lblMulta.TabIndex = 277;
            this.lblMulta.Text = "Multa % *";
            // 
            // txtMulta
            // 
            this.txtMulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMulta.Location = new System.Drawing.Point(465, 98);
            this.txtMulta.Margin = new System.Windows.Forms.Padding(5);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(60, 23);
            this.txtMulta.TabIndex = 4;
            this.txtMulta.Text = "0";
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMulta_KeyPress);
            this.txtMulta.Leave += new System.EventHandler(this.TxtMulta_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(422, 507);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 31);
            this.btnSalvar.TabIndex = 272;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(530, 507);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpar.TabIndex = 273;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(680, 507);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 274;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(9, 494);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 266;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(97, 494);
            this.lblDtAlteracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(77, 13);
            this.lblDtAlteracao.TabIndex = 267;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(203, 495);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(107, 13);
            this.lblUsuario.TabIndex = 268;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(206, 515);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 18);
            this.txtUsuario.TabIndex = 269;
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(12, 514);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(65, 18);
            this.txtDtCadastro.TabIndex = 270;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(102, 514);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(65, 18);
            this.txtDtAlteracao.TabIndex = 271;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // btnBuscarFormaPag
            // 
            this.btnBuscarFormaPag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFormaPag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarFormaPag.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarFormaPag.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFormaPag.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFormaPag.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFormaPag.Location = new System.Drawing.Point(603, 147);
            this.btnBuscarFormaPag.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarFormaPag.Name = "btnBuscarFormaPag";
            this.btnBuscarFormaPag.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarFormaPag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFormaPag.TabIndex = 265;
            this.btnBuscarFormaPag.TabStop = false;
            this.btnBuscarFormaPag.Click += new System.EventHandler(this.BtnBuscarFormaPag_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(238, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cod.";
            // 
            // txtCodFormaPagamento
            // 
            this.txtCodFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFormaPagamento.Location = new System.Drawing.Point(241, 157);
            this.txtCodFormaPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFormaPagamento.Name = "txtCodFormaPagamento";
            this.txtCodFormaPagamento.Size = new System.Drawing.Size(60, 23);
            this.txtCodFormaPagamento.TabIndex = 9;
            this.txtCodFormaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFormaPagamento.TextChanged += new System.EventHandler(this.txtCodFormaPagamento_TextChanged);
            this.txtCodFormaPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodFormaPagamento_KeyPress);
            this.txtCodFormaPagamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodFormaPagamento_KeyUp);
            this.txtCodFormaPagamento.Leave += new System.EventHandler(this.TxtCodFormaPagamento_Leave);
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFormaPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormaPagamento.Location = new System.Drawing.Point(314, 157);
            this.txtFormaPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(279, 23);
            this.txtFormaPagamento.TabIndex = 10;
            // 
            // txtCondicao
            // 
            this.txtCondicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicao.Location = new System.Drawing.Point(81, 98);
            this.txtCondicao.Margin = new System.Windows.Forms.Padding(5);
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.Size = new System.Drawing.Size(266, 23);
            this.txtCondicao.TabIndex = 2;
            this.txtCondicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondicao_KeyPress);
            this.txtCondicao.Leave += new System.EventHandler(this.txtCondicao_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(78, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Condição *";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(311, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forma de Pagamento *";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(376, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juros % *";
            // 
            // listviewParcelas
            // 
            this.listviewParcelas.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listviewParcelas.AllowColumnReorder = true;
            this.listviewParcelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listviewParcelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listviewParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nrParcela,
            this.nrDia,
            this.porcentagem,
            this.codFormaPag,
            this.FormaPagamento});
            this.listviewParcelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listviewParcelas.FullRowSelect = true;
            this.listviewParcelas.GridLines = true;
            this.listviewParcelas.HideSelection = false;
            this.listviewParcelas.HoverSelection = true;
            this.listviewParcelas.Location = new System.Drawing.Point(12, 228);
            this.listviewParcelas.Name = "listviewParcelas";
            this.listviewParcelas.Size = new System.Drawing.Size(732, 264);
            this.listviewParcelas.TabIndex = 285;
            this.listviewParcelas.UseCompatibleStateImageBehavior = false;
            this.listviewParcelas.View = System.Windows.Forms.View.Details;
            // 
            // nrParcela
            // 
            this.nrParcela.Text = "Nrº da Parcela";
            this.nrParcela.Width = 83;
            // 
            // nrDia
            // 
            this.nrDia.Text = "Nrº de Dias";
            this.nrDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nrDia.Width = 84;
            // 
            // porcentagem
            // 
            this.porcentagem.Text = "Porcentagem";
            this.porcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.porcentagem.Width = 66;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.Text = "Forma de Pag.";
            this.FormaPagamento.Width = 310;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnAdd.Location = new System.Drawing.Point(668, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Tag = "";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNrParcelas
            // 
            this.txtNrParcelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrParcelas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNrParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNrParcelas.Enabled = false;
            this.txtNrParcelas.Location = new System.Drawing.Point(13, 157);
            this.txtNrParcelas.Name = "txtNrParcelas";
            this.txtNrParcelas.Size = new System.Drawing.Size(60, 23);
            this.txtNrParcelas.TabIndex = 6;
            this.txtNrParcelas.Text = "1";
            this.txtNrParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNrParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNrParcelas_KeyPress);
            // 
            // txtNrDias
            // 
            this.txtNrDias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNrDias.Location = new System.Drawing.Point(81, 157);
            this.txtNrDias.Name = "txtNrDias";
            this.txtNrDias.Size = new System.Drawing.Size(60, 23);
            this.txtNrDias.TabIndex = 7;
            this.txtNrDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNrDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNrDias_KeyPress);
            this.txtNrDias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNrDias_KeyUp);
            this.txtNrDias.Leave += new System.EventHandler(this.TxtNrDias_Leave);
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPorcentagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPorcentagem.Location = new System.Drawing.Point(156, 157);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(60, 23);
            this.txtPorcentagem.TabIndex = 8;
            this.txtPorcentagem.Text = "0";
            this.txtPorcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPorcentagem_KeyPress);
            this.txtPorcentagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPorcentagem_KeyUp);
            this.txtPorcentagem.Leave += new System.EventHandler(this.TxtPorcentagem_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 291;
            this.label5.Text = "Parcela";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(78, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 292;
            this.label7.Text = "Dia *";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(154, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 293;
            this.label8.Text = "Porc % *";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnRemove.Location = new System.Drawing.Point(715, 153);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(41, 35);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 295;
            this.label9.Text = "Lista de Parcela";
            // 
            // txtJuros
            // 
            this.txtJuros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJuros.Location = new System.Drawing.Point(380, 98);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(5);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(60, 23);
            this.txtJuros.TabIndex = 3;
            this.txtJuros.Text = "0";
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtJuros_KeyPress);
            this.txtJuros.Leave += new System.EventHandler(this.TxtJuros_Leave);
            // 
            // btnLimparListaParcela
            // 
            this.btnLimparListaParcela.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparListaParcela.Location = new System.Drawing.Point(656, 228);
            this.btnLimparListaParcela.Name = "btnLimparListaParcela";
            this.btnLimparListaParcela.Size = new System.Drawing.Size(88, 30);
            this.btnLimparListaParcela.TabIndex = 297;
            this.btnLimparListaParcela.Text = "Limpar lista";
            this.btnLimparListaParcela.UseVisualStyleBackColor = false;
            this.btnLimparListaParcela.Click += new System.EventHandler(this.btnLimparListaParcela_Click);
            // 
            // codFormaPag
            // 
            this.codFormaPag.Text = "Cod. Forma";
            this.codFormaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.codFormaPag.Width = 99;
            // 
            // frmCadastroCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 560);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimparListaParcela);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.txtNrDias);
            this.Controls.Add(this.txtNrParcelas);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listviewParcelas);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDtAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.btnBuscarFormaPag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodFormaPagamento);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.txtCondicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastroCondicaoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condicao Pagamento";
            this.Load += new System.EventHandler(this.FrmCondicaoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFormaPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolTip tooltip;

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtMulta;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblDtAlteracao;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.PictureBox btnBuscarFormaPag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.TextBox txtCondicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNrParcelas;
        private System.Windows.Forms.TextBox txtNrDias;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader nrParcela;
        private System.Windows.Forms.ColumnHeader nrDia;
        private System.Windows.Forms.ColumnHeader porcentagem;
        private System.Windows.Forms.ColumnHeader FormaPagamento;
        private System.Windows.Forms.ListView listviewParcelas;
        private Button btnRemove;
        private Label label9;
        private TextBox txtJuros;
        private Button btnLimparListaParcela;
        private ColumnHeader codFormaPag;
    }
}