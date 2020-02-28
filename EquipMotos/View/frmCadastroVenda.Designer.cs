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
            this.label34 = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAlteracao = new MaterialSkin.Controls.MaterialLabel();
            this.lblDtCadastro = new MaterialSkin.Controls.MaterialLabel();
            this.label28 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCondPagamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label27 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodCondPagamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label26 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValorTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescontos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label24 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValorItens = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lvProdutosVenda = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValorProd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQtd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodProduto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumeroVenda = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.btnRemProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarCliente = new System.Windows.Forms.PictureBox();
            this.btnBuscarProduto = new System.Windows.Forms.PictureBox();
            this.btnBuscarCondPagamento = new System.Windows.Forms.PictureBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lvContaReceber = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtModelo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSerie = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label11 = new MaterialSkin.Controls.MaterialLabel();
            this.chkSituacao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(805, 713);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(125, 36);
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
            this.btnLimpar.Location = new System.Drawing.Point(549, 713);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(98, 36);
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
            this.btnSalvar.Location = new System.Drawing.Point(432, 713);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(103, 36);
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
            this.label34.Depth = 0;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(16, 638);
            this.label34.MouseState = MaterialSkin.MouseState.HOVER;
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(97, 18);
            this.label34.TabIndex = 200;
            this.label34.Text = "Observações";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(229, 706);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(143, 17);
            this.lblUsuario.TabIndex = 199;
            this.lblUsuario.Text = "Alterado pelo usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(233, 723);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(146, 28);
            this.txtUsuario.TabIndex = 198;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblAlteracao
            // 
            this.lblAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlteracao.AutoSize = true;
            this.lblAlteracao.Depth = 0;
            this.lblAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblAlteracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlteracao.Location = new System.Drawing.Point(101, 706);
            this.lblAlteracao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAlteracao.Name = "lblAlteracao";
            this.lblAlteracao.Size = new System.Drawing.Size(102, 17);
            this.lblAlteracao.TabIndex = 197;
            this.lblAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Depth = 0;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtCadastro.Location = new System.Drawing.Point(11, 706);
            this.lblDtCadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(99, 17);
            this.lblDtCadastro.TabIndex = 195;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Depth = 0;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(85, 431);
            this.label28.MouseState = MaterialSkin.MouseState.HOVER;
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(172, 18);
            this.label28.TabIndex = 193;
            this.label28.Text = "Condição de Pagamento";
            // 
            // txtCondPagamento
            // 
            this.txtCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCondPagamento.Depth = 0;
            this.txtCondPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondPagamento.Hint = "";
            this.txtCondPagamento.Location = new System.Drawing.Point(85, 452);
            this.txtCondPagamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCondPagamento.Name = "txtCondPagamento";
            this.txtCondPagamento.PasswordChar = '\0';
            this.txtCondPagamento.SelectedText = "";
            this.txtCondPagamento.SelectionLength = 0;
            this.txtCondPagamento.SelectionStart = 0;
            this.txtCondPagamento.Size = new System.Drawing.Size(294, 28);
            this.txtCondPagamento.TabIndex = 192;
            this.txtCondPagamento.UseSystemPasswordChar = false;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Depth = 0;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(11, 431);
            this.label27.MouseState = MaterialSkin.MouseState.HOVER;
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 18);
            this.label27.TabIndex = 191;
            this.label27.Text = "Código";
            // 
            // txtCodCondPagamento
            // 
            this.txtCodCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCondPagamento.Depth = 0;
            this.txtCodCondPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCondPagamento.Hint = "";
            this.txtCodCondPagamento.Location = new System.Drawing.Point(15, 452);
            this.txtCodCondPagamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodCondPagamento.Name = "txtCodCondPagamento";
            this.txtCodCondPagamento.PasswordChar = '\0';
            this.txtCodCondPagamento.SelectedText = "";
            this.txtCodCondPagamento.SelectionLength = 0;
            this.txtCodCondPagamento.SelectionStart = 0;
            this.txtCodCondPagamento.Size = new System.Drawing.Size(59, 28);
            this.txtCodCondPagamento.TabIndex = 190;
            this.txtCodCondPagamento.UseSystemPasswordChar = false;
            this.txtCodCondPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPagamento_KeyPress);
            this.txtCodCondPagamento.TextChanged += new System.EventHandler(this.txtCodCondPagamento_TextChanged);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Depth = 0;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(571, 381);
            this.label26.MouseState = MaterialSkin.MouseState.HOVER;
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 18);
            this.label26.TabIndex = 189;
            this.label26.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorTotal.Depth = 0;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValorTotal.Hint = "";
            this.txtValorTotal.Location = new System.Drawing.Point(575, 403);
            this.txtValorTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.PasswordChar = '\0';
            this.txtValorTotal.SelectedText = "";
            this.txtValorTotal.SelectionLength = 0;
            this.txtValorTotal.SelectionStart = 0;
            this.txtValorTotal.Size = new System.Drawing.Size(101, 28);
            this.txtValorTotal.TabIndex = 188;
            this.txtValorTotal.Text = "R$0.00";
            this.txtValorTotal.UseSystemPasswordChar = false;
            // 
            // txtDescontos
            // 
            this.txtDescontos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescontos.Depth = 0;
            this.txtDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontos.Hint = "";
            this.txtDescontos.Location = new System.Drawing.Point(15, 403);
            this.txtDescontos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.PasswordChar = '\0';
            this.txtDescontos.SelectedText = "";
            this.txtDescontos.SelectionLength = 0;
            this.txtDescontos.SelectionStart = 0;
            this.txtDescontos.Size = new System.Drawing.Size(101, 28);
            this.txtDescontos.TabIndex = 186;
            this.txtDescontos.UseSystemPasswordChar = false;
            this.txtDescontos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontos_KeyPress);
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Depth = 0;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(203, 381);
            this.label24.MouseState = MaterialSkin.MouseState.HOVER;
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 18);
            this.label24.TabIndex = 185;
            this.label24.Text = "Valor Total de Itens";
            // 
            // txtValorItens
            // 
            this.txtValorItens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorItens.Depth = 0;
            this.txtValorItens.Enabled = false;
            this.txtValorItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorItens.Hint = "";
            this.txtValorItens.Location = new System.Drawing.Point(208, 403);
            this.txtValorItens.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.PasswordChar = '\0';
            this.txtValorItens.SelectedText = "";
            this.txtValorItens.SelectionLength = 0;
            this.txtValorItens.SelectionStart = 0;
            this.txtValorItens.Size = new System.Drawing.Size(85, 28);
            this.txtValorItens.TabIndex = 184;
            this.txtValorItens.Text = "R$0.00";
            this.txtValorItens.UseSystemPasswordChar = false;
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
            this.label16.Depth = 0;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(613, 173);
            this.label16.MouseState = MaterialSkin.MouseState.HOVER;
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 172;
            this.label16.Text = "Valor *";
            // 
            // txtValorProd
            // 
            this.txtValorProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorProd.Depth = 0;
            this.txtValorProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValorProd.Hint = "";
            this.txtValorProd.Location = new System.Drawing.Point(616, 194);
            this.txtValorProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorProd.Name = "txtValorProd";
            this.txtValorProd.PasswordChar = '\0';
            this.txtValorProd.SelectedText = "";
            this.txtValorProd.SelectionLength = 0;
            this.txtValorProd.SelectionStart = 0;
            this.txtValorProd.Size = new System.Drawing.Size(101, 28);
            this.txtValorProd.TabIndex = 171;
            this.txtValorProd.Text = "R$0.00";
            this.txtValorProd.UseSystemPasswordChar = false;
            this.txtValorProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProd_KeyPress);
            this.txtValorProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorProd_KeyUp);
            this.txtValorProd.Leave += new System.EventHandler(this.txtValorProd_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Depth = 0;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(501, 173);
            this.label15.MouseState = MaterialSkin.MouseState.HOVER;
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 170;
            this.label15.Text = "Quantidade *";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtd.Depth = 0;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Hint = "";
            this.txtQtd.Location = new System.Drawing.Point(504, 194);
            this.txtQtd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PasswordChar = '\0';
            this.txtQtd.SelectedText = "";
            this.txtQtd.SelectionLength = 0;
            this.txtQtd.SelectionStart = 0;
            this.txtQtd.Size = new System.Drawing.Size(59, 28);
            this.txtQtd.TabIndex = 169;
            this.txtQtd.UseSystemPasswordChar = false;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Depth = 0;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(83, 172);
            this.label14.MouseState = MaterialSkin.MouseState.HOVER;
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 168;
            this.label14.Text = "Produto *";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProduto.Depth = 0;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Hint = "";
            this.txtProduto.Location = new System.Drawing.Point(87, 194);
            this.txtProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PasswordChar = '\0';
            this.txtProduto.SelectedText = "";
            this.txtProduto.SelectionLength = 0;
            this.txtProduto.SelectionStart = 0;
            this.txtProduto.Size = new System.Drawing.Size(330, 28);
            this.txtProduto.TabIndex = 167;
            this.txtProduto.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Depth = 0;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(11, 173);
            this.label13.MouseState = MaterialSkin.MouseState.HOVER;
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 166;
            this.label13.Text = "Código";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodProduto.Depth = 0;
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Hint = "";
            this.txtCodProduto.Location = new System.Drawing.Point(15, 194);
            this.txtCodProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.PasswordChar = '\0';
            this.txtCodProduto.SelectedText = "";
            this.txtCodProduto.SelectionLength = 0;
            this.txtCodProduto.SelectionStart = 0;
            this.txtCodProduto.Size = new System.Drawing.Size(59, 28);
            this.txtCodProduto.TabIndex = 165;
            this.txtCodProduto.UseSystemPasswordChar = false;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            this.txtCodProduto.TextChanged += new System.EventHandler(this.txtCodProduto_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(83, 114);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 164;
            this.label4.Text = "Cliente *";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Hint = "";
            this.txtCliente.Location = new System.Drawing.Point(87, 135);
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(330, 28);
            this.txtCliente.TabIndex = 163;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 162;
            this.label3.Text = "Código";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCliente.Depth = 0;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Hint = "";
            this.txtCodCliente.Location = new System.Drawing.Point(15, 135);
            this.txtCodCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.PasswordChar = '\0';
            this.txtCodCliente.SelectedText = "";
            this.txtCodCliente.SelectionLength = 0;
            this.txtCodCliente.SelectionStart = 0;
            this.txtCodCliente.Size = new System.Drawing.Size(59, 28);
            this.txtCodCliente.TabIndex = 161;
            this.txtCodCliente.UseSystemPasswordChar = false;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            this.txtCodCliente.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(544, 67);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 160;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(277, 67);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 158;
            this.label1.Text = "Nrº Nota *";
            this.label1.Visible = false;
            // 
            // txtNumeroVenda
            // 
            this.txtNumeroVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumeroVenda.Depth = 0;
            this.txtNumeroVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVenda.Hint = "";
            this.txtNumeroVenda.Location = new System.Drawing.Point(280, 85);
            this.txtNumeroVenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroVenda.Name = "txtNumeroVenda";
            this.txtNumeroVenda.PasswordChar = '\0';
            this.txtNumeroVenda.SelectedText = "";
            this.txtNumeroVenda.SelectionLength = 0;
            this.txtNumeroVenda.SelectionStart = 0;
            this.txtNumeroVenda.Size = new System.Drawing.Size(99, 28);
            this.txtNumeroVenda.TabIndex = 293;
            this.txtNumeroVenda.UseSystemPasswordChar = false;
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
            this.txtDtCadastro.Size = new System.Drawing.Size(75, 21);
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
            this.txtDtAlteracao.Size = new System.Drawing.Size(75, 21);
            this.txtDtAlteracao.TabIndex = 209;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // btnRemProduto
            // 
            this.btnRemProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemProduto.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnRemProduto.Location = new System.Drawing.Point(805, 188);
            this.btnRemProduto.Name = "btnRemProduto";
            this.btnRemProduto.Size = new System.Drawing.Size(53, 41);
            this.btnRemProduto.TabIndex = 178;
            this.btnRemProduto.UseVisualStyleBackColor = true;
            this.btnRemProduto.Click += new System.EventHandler(this.btnRemProduto_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnAddProduto.Location = new System.Drawing.Point(746, 188);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(53, 41);
            this.btnAddProduto.TabIndex = 177;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(13, 228);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 213;
            this.label6.Text = "Lista de Produtos";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCliente.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCliente.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCliente.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCliente.Location = new System.Drawing.Point(424, 118);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(69, 51);
            this.btnBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCliente.TabIndex = 272;
            this.btnBuscarCliente.TabStop = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarProduto.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.Location = new System.Drawing.Point(424, 177);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(69, 51);
            this.btnBuscarProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarProduto.TabIndex = 273;
            this.btnBuscarProduto.TabStop = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.BtnBuscarProduto_Click_1);
            // 
            // btnBuscarCondPagamento
            // 
            this.btnBuscarCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCondPagamento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCondPagamento.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Location = new System.Drawing.Point(389, 438);
            this.btnBuscarCondPagamento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBuscarCondPagamento.Name = "btnBuscarCondPagamento";
            this.btnBuscarCondPagamento.Size = new System.Drawing.Size(71, 52);
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
            this.txtData.Size = new System.Drawing.Size(127, 27);
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
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(11, 500);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 289;
            this.label5.Text = "Lista conta à receber";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(11, 381);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 290;
            this.label7.Text = "Desconto(%)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(11, 67);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 292;
            this.label8.Text = "Modelo *";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Depth = 0;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Hint = "";
            this.txtModelo.Location = new System.Drawing.Point(15, 85);
            this.txtModelo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.Size = new System.Drawing.Size(101, 28);
            this.txtModelo.TabIndex = 157;
            this.txtModelo.UseSystemPasswordChar = false;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(146, 67);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 294;
            this.label9.Text = "Série *";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerie.Depth = 0;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Hint = "";
            this.txtSerie.Location = new System.Drawing.Point(149, 85);
            this.txtSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.PasswordChar = '\0';
            this.txtSerie.SelectedText = "";
            this.txtSerie.SelectionLength = 0;
            this.txtSerie.SelectionStart = 0;
            this.txtSerie.Size = new System.Drawing.Size(102, 28);
            this.txtSerie.TabIndex = 291;
            this.txtSerie.UseSystemPasswordChar = false;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Depth = 0;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(843, 67);
            this.label11.MouseState = MaterialSkin.MouseState.HOVER;
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 296;
            this.label11.Text = "Situação";
            // 
            // chkSituacao
            // 
            this.chkSituacao.AutoSize = true;
            this.chkSituacao.Location = new System.Drawing.Point(846, 85);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Size = new System.Drawing.Size(61, 21);
            this.chkSituacao.TabIndex = 295;
            this.chkSituacao.Text = "Ativa";
            this.chkSituacao.UseVisualStyleBackColor = true;
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 765);
            this.ControlBox = false;
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
            this.Controls.Add(this.btnRemProduto);
            this.Controls.Add(this.btnAddProduto);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private MaterialSkin.Controls.MaterialLabel label34;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblAlteracao;
        private MaterialSkin.Controls.MaterialLabel lblDtCadastro;
        private MaterialSkin.Controls.MaterialLabel label28;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCondPagamento;
        private MaterialSkin.Controls.MaterialLabel label27;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodCondPagamento;
        private MaterialSkin.Controls.MaterialLabel label26;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescontos;
        private MaterialSkin.Controls.MaterialLabel label24;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorItens;
        private System.Windows.Forms.ListView lvProdutosVenda;
        private System.Windows.Forms.Button btnRemProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private MaterialSkin.Controls.MaterialLabel label16;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorProd;
        private MaterialSkin.Controls.MaterialLabel label15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtQtd;
        private MaterialSkin.Controls.MaterialLabel label14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProduto;
        private MaterialSkin.Controls.MaterialLabel label13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodProduto;
        private MaterialSkin.Controls.MaterialLabel label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MaterialSkin.Controls.MaterialLabel label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodCliente;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroVenda;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private MaterialSkin.Controls.MaterialLabel label6;
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
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtModelo;
        private MaterialSkin.Controls.MaterialLabel label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSerie;
        private MaterialSkin.Controls.MaterialLabel label11;
        private System.Windows.Forms.CheckBox chkSituacao;
    }
}