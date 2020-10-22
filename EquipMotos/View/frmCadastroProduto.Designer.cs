namespace EquipMotos.VIEW
{
    partial class frmCadastroProduto
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
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtDtUltCompra = new System.Windows.Forms.DateTimePicker();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.lblDtUltCompra = new System.Windows.Forms.Label();
            this.lblCustoUltCompra = new System.Windows.Forms.Label();
            this.txtCustoUltCompra = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblCodigoFornecedor = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblCategoriaGrupo = new System.Windows.Forms.Label();
            this.txtCategoriaGrupo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.lblProdutoServico = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.btnBuscarCategoria = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecoVenda.Location = new System.Drawing.Point(10, 258);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(108, 17);
            this.lblPrecoVenda.TabIndex = 314;
            this.lblPrecoVenda.Text = "Preço de venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoVenda.Location = new System.Drawing.Point(14, 279);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(102, 23);
            this.txtPrecoVenda.TabIndex = 313;
            this.txtPrecoVenda.Text = "R$0.00";
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyUp);
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // txtDtUltCompra
            // 
            this.txtDtUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtUltCompra.Enabled = false;
            this.txtDtUltCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtUltCompra.Location = new System.Drawing.Point(217, 331);
            this.txtDtUltCompra.Name = "txtDtUltCompra";
            this.txtDtUltCompra.Size = new System.Drawing.Size(134, 23);
            this.txtDtUltCompra.TabIndex = 312;
            this.txtDtUltCompra.Leave += new System.EventHandler(this.txtDtUltCompra_Leave);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(147, 473);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(65, 18);
            this.txtDtAlteracao.TabIndex = 297;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(20, 473);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(65, 18);
            this.txtDtCadastro.TabIndex = 296;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(565, 466);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 301;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(453, 466);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 299;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(740, 466);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 303;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(15, 396);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(482, 40);
            this.txtObservacao.TabIndex = 295;
            this.txtObservacao.Text = "";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 374);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 17);
            this.label22.TabIndex = 309;
            this.label22.Text = "Observações";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(271, 455);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(106, 13);
            this.lblUsuario.TabIndex = 308;
            this.lblUsuario.Text = "Alterado pelo usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(274, 473);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 18);
            this.txtUsuario.TabIndex = 298;
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(143, 455);
            this.lblDtAlteracao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(77, 13);
            this.lblDtAlteracao.TabIndex = 307;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(15, 455);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 306;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblComissao
            // 
            this.lblComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComissao.AutoSize = true;
            this.lblComissao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.Location = new System.Drawing.Point(419, 308);
            this.lblComissao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(95, 17);
            this.lblComissao.TabIndex = 304;
            this.lblComissao.Text = "Comissão (%)";
            // 
            // txtComissao
            // 
            this.txtComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(423, 333);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(5);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(74, 23);
            this.txtComissao.TabIndex = 294;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComissao_KeyPress);
            this.txtComissao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComissao_KeyUp);
            this.txtComissao.Leave += new System.EventHandler(this.txtComissao_Leave);
            // 
            // lblDtUltCompra
            // 
            this.lblDtUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtUltCompra.AutoSize = true;
            this.lblDtUltCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtUltCompra.Location = new System.Drawing.Point(213, 310);
            this.lblDtUltCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtUltCompra.Name = "lblDtUltCompra";
            this.lblDtUltCompra.Size = new System.Drawing.Size(136, 17);
            this.lblDtUltCompra.TabIndex = 302;
            this.lblDtUltCompra.Text = "Data da Ult. Compra";
            // 
            // lblCustoUltCompra
            // 
            this.lblCustoUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustoUltCompra.AutoSize = true;
            this.lblCustoUltCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustoUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoUltCompra.Location = new System.Drawing.Point(11, 310);
            this.lblCustoUltCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustoUltCompra.Name = "lblCustoUltCompra";
            this.lblCustoUltCompra.Size = new System.Drawing.Size(142, 17);
            this.lblCustoUltCompra.TabIndex = 300;
            this.lblCustoUltCompra.Text = "Custo da Ult. Compra";
            // 
            // txtCustoUltCompra
            // 
            this.txtCustoUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustoUltCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustoUltCompra.Enabled = false;
            this.txtCustoUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoUltCompra.Location = new System.Drawing.Point(15, 331);
            this.txtCustoUltCompra.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustoUltCompra.Name = "txtCustoUltCompra";
            this.txtCustoUltCompra.Size = new System.Drawing.Size(100, 23);
            this.txtCustoUltCompra.TabIndex = 293;
            this.txtCustoUltCompra.Text = "R$0.00";
            this.txtCustoUltCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustoUltCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustoUltCompra_KeyPress);
            this.txtCustoUltCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustoUltCompra_KeyUp);
            this.txtCustoUltCompra.Leave += new System.EventHandler(this.txtCustoUltCompra_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(81, 195);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(90, 17);
            this.lblFornecedor.TabIndex = 291;
            this.lblFornecedor.Text = "Fornecedor *";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(84, 217);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(340, 23);
            this.txtFornecedor.TabIndex = 292;
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(12, 195);
            this.lblCodigoFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoFornecedor.TabIndex = 289;
            this.lblCodigoFornecedor.Text = "Código";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFornecedor.Location = new System.Drawing.Point(14, 217);
            this.txtCodFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(60, 23);
            this.txtCodFornecedor.TabIndex = 290;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.TextChanged += new System.EventHandler(this.txtCodFornecedor_TextChanged);
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblCategoriaGrupo
            // 
            this.lblCategoriaGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoriaGrupo.AutoSize = true;
            this.lblCategoriaGrupo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoriaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaGrupo.Location = new System.Drawing.Point(81, 139);
            this.lblCategoriaGrupo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoriaGrupo.Name = "lblCategoriaGrupo";
            this.lblCategoriaGrupo.Size = new System.Drawing.Size(78, 17);
            this.lblCategoriaGrupo.TabIndex = 288;
            this.lblCategoriaGrupo.Text = "Categoria *";
            // 
            // txtCategoriaGrupo
            // 
            this.txtCategoriaGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoriaGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoriaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaGrupo.Location = new System.Drawing.Point(84, 161);
            this.txtCategoriaGrupo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCategoriaGrupo.Name = "txtCategoriaGrupo";
            this.txtCategoriaGrupo.Size = new System.Drawing.Size(340, 23);
            this.txtCategoriaGrupo.TabIndex = 285;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 287;
            this.label5.Text = "Código";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.Location = new System.Drawing.Point(14, 161);
            this.txtCodCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(60, 23);
            this.txtCodCategoria.TabIndex = 283;
            this.txtCodCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCategoria.TextChanged += new System.EventHandler(this.txtCodCategoria_TextChanged);
            this.txtCodCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCategoria_KeyPress);
            this.txtCodCategoria.Leave += new System.EventHandler(this.txtCodCategoria_Leave);
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.Location = new System.Drawing.Point(654, 73);
            this.lblCodigoBarra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(111, 17);
            this.lblCodigoBarra.TabIndex = 286;
            this.lblCodigoBarra.Text = "Código de Barra";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.Location = new System.Drawing.Point(657, 95);
            this.txtCodBarra.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(127, 23);
            this.txtCodBarra.TabIndex = 282;
            this.txtCodBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarra_KeyPress);
            this.txtCodBarra.Leave += new System.EventHandler(this.txtCodBarra_Leave);
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(558, 73);
            this.lblUnidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(70, 17);
            this.lblUnidade.TabIndex = 284;
            this.lblUnidade.Text = "Unidade *";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(561, 95);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(86, 23);
            this.txtUnidade.TabIndex = 281;
            this.txtUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidade_KeyPress);
            this.txtUnidade.Leave += new System.EventHandler(this.txtUnidade_Leave);
            // 
            // lblProdutoServico
            // 
            this.lblProdutoServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProdutoServico.AutoSize = true;
            this.lblProdutoServico.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProdutoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoServico.Location = new System.Drawing.Point(81, 73);
            this.lblProdutoServico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProdutoServico.Name = "lblProdutoServico";
            this.lblProdutoServico.Size = new System.Drawing.Size(67, 17);
            this.lblProdutoServico.TabIndex = 305;
            this.lblProdutoServico.Text = "Produto *";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(84, 95);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(365, 23);
            this.txtProduto.TabIndex = 280;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdutoServico_KeyPress);
            this.txtProduto.Leave += new System.EventHandler(this.txtProdutoServico_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 279;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 95);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 23);
            this.txtCodigo.TabIndex = 276;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarFornecedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarFornecedor.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(434, 204);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFornecedor.TabIndex = 311;
            this.btnBuscarFornecedor.TabStop = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.btnBuscarFornecedor_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCategoria.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCategoria.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCategoria.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(433, 144);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCategoria.TabIndex = 310;
            this.btnBuscarCategoria.TabStop = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 523);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.txtDtUltCompra);
            this.Controls.Add(this.btnBuscarFornecedor);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblDtAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.lblDtUltCompra);
            this.Controls.Add(this.lblCustoUltCompra);
            this.Controls.Add(this.txtCustoUltCompra);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblCodigoFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.lblCategoriaGrupo);
            this.Controls.Add(this.txtCategoriaGrupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.lblCodigoBarra);
            this.Controls.Add(this.txtCodBarra);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.lblProdutoServico);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.DateTimePicker txtDtUltCompra;
        private System.Windows.Forms.PictureBox btnBuscarFornecedor;
        private System.Windows.Forms.PictureBox btnBuscarCategoria;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblDtAlteracao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label lblDtUltCompra;
        private System.Windows.Forms.Label lblCustoUltCompra;
        private System.Windows.Forms.TextBox txtCustoUltCompra;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblCodigoFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblCategoriaGrupo;
        private System.Windows.Forms.TextBox txtCategoriaGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label lblProdutoServico;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}