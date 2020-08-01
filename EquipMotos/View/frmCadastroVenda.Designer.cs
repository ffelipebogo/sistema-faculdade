namespace EquipMotos.View
{
    partial class frmCadastroVenda
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
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtCondPagamento = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCodCondPagamento = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtValorItens = new System.Windows.Forms.TextBox();
            this.lvProdutosVenda = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.txtValorProd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroVenda = new System.Windows.Forms.TextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.PictureBox();
            this.btnBuscarProduto = new System.Windows.Forms.PictureBox();
            this.btnBuscarCondPagamento = new System.Windows.Forms.PictureBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lvContaReceber = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkSituacao = new System.Windows.Forms.CheckBox();
            this.btnAddProduto = new System.Windows.Forms.PictureBox();
            this.btnRemProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(846, 711);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 205;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(675, 711);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 204;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(571, 711);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 203;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(14, 658);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(564, 32);
            this.txtObservacoes.TabIndex = 201;
            this.txtObservacoes.Text = "";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(16, 638);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 17);
            this.label34.TabIndex = 200;
            this.label34.Text = "Observações";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(229, 706);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(106, 13);
            this.lblUsuario.TabIndex = 199;
            this.lblUsuario.Text = "Alterado pelo usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(233, 723);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 18);
            this.txtUsuario.TabIndex = 198;
            // 
            // lblAlteracao
            // 
            this.lblAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlteracao.AutoSize = true;
            this.lblAlteracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAlteracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlteracao.Location = new System.Drawing.Point(101, 706);
            this.lblAlteracao.Name = "lblAlteracao";
            this.lblAlteracao.Size = new System.Drawing.Size(78, 13);
            this.lblAlteracao.TabIndex = 197;
            this.lblAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtCadastro.Location = new System.Drawing.Point(11, 706);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 195;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(85, 431);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(163, 17);
            this.label28.TabIndex = 193;
            this.label28.Text = "Condição de Pagamento";
            // 
            // txtCondPagamento
            // 
            this.txtCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCondPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondPagamento.Location = new System.Drawing.Point(85, 452);
            this.txtCondPagamento.Name = "txtCondPagamento";
            this.txtCondPagamento.Size = new System.Drawing.Size(294, 23);
            this.txtCondPagamento.TabIndex = 192;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(11, 431);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 17);
            this.label27.TabIndex = 191;
            this.label27.Text = "Código";
            // 
            // txtCodCondPagamento
            // 
            this.txtCodCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCondPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCondPagamento.Location = new System.Drawing.Point(15, 452);
            this.txtCodCondPagamento.Name = "txtCodCondPagamento";
            this.txtCodCondPagamento.Size = new System.Drawing.Size(59, 23);
            this.txtCodCondPagamento.TabIndex = 190;
            this.txtCodCondPagamento.TextChanged += new System.EventHandler(this.txtCodCondPagamento_TextChanged);
            this.txtCodCondPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPagamento_KeyPress);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(571, 381);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 17);
            this.label26.TabIndex = 189;
            this.label26.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValorTotal.Location = new System.Drawing.Point(575, 403);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(101, 21);
            this.txtValorTotal.TabIndex = 188;
            this.txtValorTotal.Text = "R$0.00";
            // 
            // txtDescontos
            // 
            this.txtDescontos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Location = new System.Drawing.Point(15, 403);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(101, 23);
            this.txtDescontos.TabIndex = 186;
            this.txtDescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontos_KeyPress);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(203, 381);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 17);
            this.label24.TabIndex = 185;
            this.label24.Text = "Valor Total de Itens";
            // 
            // txtValorItens
            // 
            this.txtValorItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorItens.Enabled = false;
            this.txtValorItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorItens.Location = new System.Drawing.Point(208, 403);
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.Size = new System.Drawing.Size(85, 21);
            this.txtValorItens.TabIndex = 184;
            this.txtValorItens.Text = "R$0.00";
            this.txtValorItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorItens_KeyPress);
            this.txtValorItens.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorItens_KeyUp);
            this.txtValorItens.Leave += new System.EventHandler(this.txtValorItens_Leave);
            // 
            // lvProdutosVenda
            // 
            this.lvProdutosVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.produto,
            this.qtd,
            this.precoVenda,
            this.total});
            this.lvProdutosVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProdutosVenda.FullRowSelect = true;
            this.lvProdutosVenda.GridLines = true;
            this.lvProdutosVenda.HideSelection = false;
            this.lvProdutosVenda.Location = new System.Drawing.Point(11, 247);
            this.lvProdutosVenda.Name = "lvProdutosVenda";
            this.lvProdutosVenda.Size = new System.Drawing.Size(696, 121);
            this.lvProdutosVenda.TabIndex = 181;
            this.lvProdutosVenda.UseCompatibleStateImageBehavior = false;
            this.lvProdutosVenda.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            // 
            // produto
            // 
            this.produto.Text = "Produto";
            this.produto.Width = 300;
            // 
            // qtd
            // 
            this.qtd.DisplayIndex = 3;
            this.qtd.Text = "QTD";
            // 
            // precoVenda
            // 
            this.precoVenda.DisplayIndex = 2;
            this.precoVenda.Text = "Preço Venda";
            this.precoVenda.Width = 113;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 80;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(613, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 172;
            this.label16.Text = "Valor *";
            // 
            // txtValorProd
            // 
            this.txtValorProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtValorProd.Location = new System.Drawing.Point(616, 194);
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.Size = new System.Drawing.Size(101, 23);
            this.txtValorProd.TabIndex = 171;
            this.txtValorProd.Text = "R$0.00";
            this.txtValorProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProd_KeyPress);
            this.txtValorProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorProd_KeyUp);
            this.txtValorProd.Leave += new System.EventHandler(this.txtValorProd_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(501, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 17);
            this.label15.TabIndex = 170;
            this.label15.Text = "Quantidade *";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(504, 194);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(59, 23);
            this.txtQtd.TabIndex = 169;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(86, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 168;
            this.label14.Text = "Produto *";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(87, 194);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(330, 23);
            this.txtProduto.TabIndex = 167;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(11, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 166;
            this.label13.Text = "Código";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(15, 194);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(59, 23);
            this.txtCodProduto.TabIndex = 165;
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(83, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 164;
            this.label4.Text = "Cliente *";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(87, 135);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(330, 23);
            this.txtCliente.TabIndex = 163;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 162;
            this.label3.Text = "Código";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(15, 135);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(59, 23);
            this.txtCodCliente.TabIndex = 161;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(544, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 160;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(277, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 158;
            this.label1.Text = "Nrº Nota *";
            this.label1.Visible = false;
            // 
            // txtNumeroVenda
            // 
            this.txtNumeroVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVenda.Location = new System.Drawing.Point(280, 85);
            this.txtNumeroVenda.Name = "txtNumeroVenda";
            this.txtNumeroVenda.Size = new System.Drawing.Size(99, 23);
            this.txtNumeroVenda.TabIndex = 293;
            this.txtNumeroVenda.Visible = false;
            this.txtNumeroVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroVenda_KeyPress);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(15, 723);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(65, 18);
            this.txtDtCadastro.TabIndex = 208;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(104, 723);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(65, 18);
            this.txtDtAlteracao.TabIndex = 209;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 213;
            this.label6.Text = "Lista de Produtos";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCliente.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCliente.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCliente.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCliente.Location = new System.Drawing.Point(424, 118);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCliente.TabIndex = 272;
            this.btnBuscarCliente.TabStop = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarProduto.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.Location = new System.Drawing.Point(424, 177);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarProduto.TabIndex = 273;
            this.btnBuscarProduto.TabStop = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.BtnBuscarProduto_Click_1);
            // 
            // btnBuscarCondPagamento
            // 
            this.btnBuscarCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCondPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCondPagamento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCondPagamento.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Location = new System.Drawing.Point(389, 438);
            this.btnBuscarCondPagamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarCondPagamento.Name = "btnBuscarCondPagamento";
            this.btnBuscarCondPagamento.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarCondPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCondPagamento.TabIndex = 274;
            this.btnBuscarCondPagamento.TabStop = false;
            this.btnBuscarCondPagamento.Click += new System.EventHandler(this.BtnBuscarCondPagamento_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(534, 84);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(127, 23);
            this.txtData.TabIndex = 275;
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // lvContaReceber
            // 
            this.lvContaReceber.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvContaReceber.GridLines = true;
            this.lvContaReceber.HideSelection = false;
            this.lvContaReceber.Location = new System.Drawing.Point(11, 519);
            this.lvContaReceber.Name = "lvContaReceber";
            this.lvContaReceber.Size = new System.Drawing.Size(564, 103);
            this.lvContaReceber.TabIndex = 288;
            this.lvContaReceber.UseCompatibleStateImageBehavior = false;
            this.lvContaReceber.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Conta à Receber";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vencimento";
            this.columnHeader2.Width = 206;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor da Parcela";
            this.columnHeader3.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(11, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 289;
            this.label5.Text = "Lista conta à receber";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(11, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 290;
            this.label7.Text = "Desconto(%)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(11, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 292;
            this.label8.Text = "Modelo *";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(15, 85);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(101, 23);
            this.txtModelo.TabIndex = 157;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(146, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 294;
            this.label9.Text = "Série *";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(149, 85);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(102, 23);
            this.txtSerie.TabIndex = 291;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(843, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 296;
            this.label11.Text = "Situação";
            // 
            // chkSituacao
            // 
            this.chkSituacao.AutoSize = true;
            this.chkSituacao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkSituacao.Location = new System.Drawing.Point(846, 85);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Size = new System.Drawing.Size(58, 21);
            this.chkSituacao.TabIndex = 295;
            this.chkSituacao.Text = "Ativa";
            this.chkSituacao.UseVisualStyleBackColor = false;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduto.ErrorImage = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnAddProduto.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnAddProduto.InitialImage = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnAddProduto.Location = new System.Drawing.Point(737, 187);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(50, 40);
            this.btnAddProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddProduto.TabIndex = 371;
            this.btnAddProduto.TabStop = false;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnRemProduto
            // 
            this.btnRemProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemProduto.ErrorImage = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnRemProduto.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnRemProduto.InitialImage = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnRemProduto.Location = new System.Drawing.Point(803, 187);
            this.btnRemProduto.Name = "btnRemProduto";
            this.btnRemProduto.Size = new System.Drawing.Size(50, 40);
            this.btnRemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRemProduto.TabIndex = 373;
            this.btnRemProduto.TabStop = false;
            this.btnRemProduto.Click += new System.EventHandler(this.btnRemProduto_Click);
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 765);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkSituacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvContaReceber);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnBuscarCondPagamento);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtCondPagamento);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtCodCondPagamento);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtDescontos);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtValorItens);
            this.Controls.Add(this.lvProdutosVenda);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtValorProd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroVenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "frmCadastroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venda";
            this.Load += new System.EventHandler(this.frmCadastroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblAlteracao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtCondPagamento;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCodCondPagamento;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtValorItens;
        private System.Windows.Forms.ListView lvProdutosVenda;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtValorProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroVenda;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnBuscarCliente;
        private System.Windows.Forms.PictureBox btnBuscarProduto;
        private System.Windows.Forms.PictureBox btnBuscarCondPagamento;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader produto;
        private System.Windows.Forms.ColumnHeader qtd;
        private System.Windows.Forms.ColumnHeader precoVenda;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ListView lvContaReceber;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkSituacao;
        private System.Windows.Forms.PictureBox btnAddProduto;
        private System.Windows.Forms.PictureBox btnRemProduto;
    }
}