namespace EquipMotos.View
{
    partial class frmCadastroProdutoServico
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProdutoServico = new System.Windows.Forms.Label();
            this.txtProdutoServico = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoriaGrupo = new System.Windows.Forms.Label();
            this.txtCategoriaGrupo = new System.Windows.Forms.TextBox();
            this.lblCodigoFornecedor = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblCustoUltCompra = new System.Windows.Forms.Label();
            this.txtCustoUltCompra = new System.Windows.Forms.TextBox();
            this.lblDtUltCompra = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.btnBuscarCategoria = new System.Windows.Forms.PictureBox();
            this.txtDtUltCompra = new System.Windows.Forms.DateTimePicker();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(19, 109);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // lblProdutoServico
            // 
            this.lblProdutoServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProdutoServico.AutoSize = true;
            this.lblProdutoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoServico.Location = new System.Drawing.Point(185, 83);
            this.lblProdutoServico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProdutoServico.Name = "lblProdutoServico";
            this.lblProdutoServico.Size = new System.Drawing.Size(78, 20);
            this.lblProdutoServico.TabIndex = 30;
            this.lblProdutoServico.Text = "Produto *";
            // 
            // txtProdutoServico
            // 
            this.txtProdutoServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProdutoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoServico.Location = new System.Drawing.Point(190, 109);
            this.txtProdutoServico.Margin = new System.Windows.Forms.Padding(5);
            this.txtProdutoServico.Name = "txtProdutoServico";
            this.txtProdutoServico.Size = new System.Drawing.Size(365, 26);
            this.txtProdutoServico.TabIndex = 2;
            this.txtProdutoServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdutoServico_KeyPress);
            this.txtProdutoServico.Leave += new System.EventHandler(this.txtProdutoServico_Leave);
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(561, 83);
            this.lblUnidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(81, 20);
            this.lblUnidade.TabIndex = 5;
            this.lblUnidade.Text = "Unidade *";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(566, 109);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(86, 26);
            this.txtUnidade.TabIndex = 3;
            this.txtUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidade_KeyPress);
            this.txtUnidade.Leave += new System.EventHandler(this.txtUnidade_Leave);
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarra.Location = new System.Drawing.Point(658, 82);
            this.lblCodigoBarra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(131, 20);
            this.lblCodigoBarra.TabIndex = 7;
            this.lblCodigoBarra.Text = "Código de Barra";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarra.Location = new System.Drawing.Point(662, 109);
            this.txtCodBarra.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(127, 26);
            this.txtCodBarra.TabIndex = 4;
            this.txtCodBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarra_KeyPress);
            this.txtCodBarra.Leave += new System.EventHandler(this.txtCodBarra_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Código";
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.Location = new System.Drawing.Point(19, 175);
            this.txtCodCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(60, 26);
            this.txtCodCategoria.TabIndex = 5;
            this.txtCodCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCategoria.TextChanged += new System.EventHandler(this.txtCodCategoria_TextChanged);
            this.txtCodCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCategoria_KeyPress);
            this.txtCodCategoria.Leave += new System.EventHandler(this.txtCodCategoria_Leave);
            // 
            // lblCategoriaGrupo
            // 
            this.lblCategoriaGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoriaGrupo.AutoSize = true;
            this.lblCategoriaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaGrupo.Location = new System.Drawing.Point(84, 150);
            this.lblCategoriaGrupo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoriaGrupo.Name = "lblCategoriaGrupo";
            this.lblCategoriaGrupo.Size = new System.Drawing.Size(92, 20);
            this.lblCategoriaGrupo.TabIndex = 11;
            this.lblCategoriaGrupo.Text = "Categoria *";
            // 
            // txtCategoriaGrupo
            // 
            this.txtCategoriaGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoriaGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoriaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaGrupo.Location = new System.Drawing.Point(89, 175);
            this.txtCategoriaGrupo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCategoriaGrupo.Name = "txtCategoriaGrupo";
            this.txtCategoriaGrupo.Size = new System.Drawing.Size(340, 26);
            this.txtCategoriaGrupo.TabIndex = 6;
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(18, 206);
            this.lblCodigoFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(61, 20);
            this.lblCodigoFornecedor.TabIndex = 13;
            this.lblCodigoFornecedor.Text = "Código";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFornecedor.Location = new System.Drawing.Point(19, 231);
            this.txtCodFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(60, 26);
            this.txtCodFornecedor.TabIndex = 15;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.TextChanged += new System.EventHandler(this.txtCodFornecedor_TextChanged);
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(84, 206);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(105, 20);
            this.lblFornecedor.TabIndex = 15;
            this.lblFornecedor.Text = "Fornecedor *";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(89, 231);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(340, 26);
            this.txtFornecedor.TabIndex = 16;
            // 
            // lblCustoUltCompra
            // 
            this.lblCustoUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustoUltCompra.AutoSize = true;
            this.lblCustoUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoUltCompra.Location = new System.Drawing.Point(14, 324);
            this.lblCustoUltCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustoUltCompra.Name = "lblCustoUltCompra";
            this.lblCustoUltCompra.Size = new System.Drawing.Size(170, 20);
            this.lblCustoUltCompra.TabIndex = 25;
            this.lblCustoUltCompra.Text = "Custo da Ult. Compra";
            // 
            // txtCustoUltCompra
            // 
            this.txtCustoUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustoUltCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustoUltCompra.Enabled = false;
            this.txtCustoUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustoUltCompra.Location = new System.Drawing.Point(22, 347);
            this.txtCustoUltCompra.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustoUltCompra.Name = "txtCustoUltCompra";
            this.txtCustoUltCompra.Size = new System.Drawing.Size(100, 26);
            this.txtCustoUltCompra.TabIndex = 17;
            this.txtCustoUltCompra.Text = "R$0.00";
            this.txtCustoUltCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustoUltCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustoUltCompra_KeyPress);
            this.txtCustoUltCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustoUltCompra_KeyUp);
            this.txtCustoUltCompra.Leave += new System.EventHandler(this.txtCustoUltCompra_Leave);
            // 
            // lblDtUltCompra
            // 
            this.lblDtUltCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtUltCompra.AutoSize = true;
            this.lblDtUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtUltCompra.Location = new System.Drawing.Point(218, 324);
            this.lblDtUltCompra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtUltCompra.Name = "lblDtUltCompra";
            this.lblDtUltCompra.Size = new System.Drawing.Size(162, 20);
            this.lblDtUltCompra.TabIndex = 27;
            this.lblDtUltCompra.Text = "Data da Ult. Compra";
            // 
            // lblComissao
            // 
            this.lblComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.Location = new System.Drawing.Point(424, 322);
            this.lblComissao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(116, 20);
            this.lblComissao.TabIndex = 29;
            this.lblComissao.Text = "Comissão (%)";
            // 
            // txtComissao
            // 
            this.txtComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(428, 347);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(5);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(74, 26);
            this.txtComissao.TabIndex = 19;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtComissao_KeyPress);
            this.txtComissao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtComissao_KeyUp);
            this.txtComissao.Leave += new System.EventHandler(this.TxtComissao_Leave);
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(18, 509);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(85, 15);
            this.lblDtCadastro.TabIndex = 31;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(146, 509);
            this.lblDtAlteracao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(87, 15);
            this.lblDtAlteracao.TabIndex = 33;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(274, 509);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(123, 15);
            this.lblUsuario.TabIndex = 35;
            this.lblUsuario.Text = "Alterado pelo usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(276, 530);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 21);
            this.txtUsuario.TabIndex = 23;
            // 
            // rbProduto
            // 
            this.rbProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbProduto.AutoSize = true;
            this.rbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProduto.Location = new System.Drawing.Point(86, 81);
            this.rbProduto.Margin = new System.Windows.Forms.Padding(5);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(88, 24);
            this.rbProduto.TabIndex = 1;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.RbProduto_CheckedChanged);
            // 
            // rbServico
            // 
            this.rbServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbServico.AutoSize = true;
            this.rbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbServico.Location = new System.Drawing.Point(86, 109);
            this.rbServico.Margin = new System.Windows.Forms.Padding(5);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(86, 24);
            this.rbServico.TabIndex = 1;
            this.rbServico.TabStop = true;
            this.rbServico.Text = "Serviço";
            this.rbServico.UseVisualStyleBackColor = true;
            this.rbServico.CheckedChanged += new System.EventHandler(this.RbServico_CheckedChanged);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 386);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 20);
            this.label22.TabIndex = 50;
            this.label22.Text = "Observações";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(20, 410);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(624, 81);
            this.txtObservacao.TabIndex = 20;
            this.txtObservacao.Text = "";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(743, 520);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 31);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(456, 520);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 31);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(568, 520);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 31);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(22, 530);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(109, 21);
            this.txtDtCadastro.TabIndex = 21;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(149, 530);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(109, 21);
            this.txtDtAlteracao.TabIndex = 22;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFornecedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarFornecedor.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(443, 216);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(71, 52);
            this.btnBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFornecedor.TabIndex = 272;
            this.btnBuscarFornecedor.TabStop = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.BtnBuscarFornecedor_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCategoria.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCategoria.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCategoria.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(443, 154);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(71, 52);
            this.btnBuscarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCategoria.TabIndex = 271;
            this.btnBuscarCategoria.TabStop = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.BtnBuscarCategoria_Click);
            // 
            // txtDtUltCompra
            // 
            this.txtDtUltCompra.Enabled = false;
            this.txtDtUltCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtUltCompra.Location = new System.Drawing.Point(222, 347);
            this.txtDtUltCompra.Name = "txtDtUltCompra";
            this.txtDtUltCompra.Size = new System.Drawing.Size(134, 26);
            this.txtDtUltCompra.TabIndex = 273;
            this.txtDtUltCompra.Leave += new System.EventHandler(this.txtDtUltCompra_Leave);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(19, 295);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(102, 26);
            this.txtPrecoVenda.TabIndex = 274;
            this.txtPrecoVenda.Text = "R$0.00";
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyUp);
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(15, 274);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(125, 20);
            this.lblPrecoVenda.TabIndex = 275;
            this.lblPrecoVenda.Text = "Preço de venda";
            // 
            // frmCadastroProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 579);
            this.ControlBox = false;
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
            this.Controls.Add(this.rbServico);
            this.Controls.Add(this.rbProduto);
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
            this.Controls.Add(this.txtProdutoServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastroProdutoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos e Servicos";
            this.Load += new System.EventHandler(this.frmCadastroProdutoServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdutoServico;
        private System.Windows.Forms.TextBox txtProdutoServico;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label lblCategoriaGrupo;
        private System.Windows.Forms.TextBox txtCategoriaGrupo;
        private System.Windows.Forms.Label lblCodigoFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblCustoUltCompra;
        private System.Windows.Forms.TextBox txtCustoUltCompra;
        private System.Windows.Forms.Label lblDtUltCompra;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblDtAlteracao;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbServico;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.PictureBox btnBuscarCategoria;
        private System.Windows.Forms.PictureBox btnBuscarFornecedor;
        private System.Windows.Forms.DateTimePicker txtDtUltCompra;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
    }
}