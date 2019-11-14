namespace EquipMotos.View
{
    partial class frmCadastroCompra
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
            this.label16 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCodCondPagamento = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtOutrasDesp = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.btnBuscarProduto = new System.Windows.Forms.PictureBox();
            this.btnBuscarCondPagamento = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtCondPagamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNrNota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.rbTipoFrete1 = new System.Windows.Forms.RadioButton();
            this.rbTipoFrete2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lvItem = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoCusto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvContaPagar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtDtChegada = new System.Windows.Forms.DateTimePicker();
            this.chkSituacao = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(741, 145);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 117;
            this.label16.Text = "Valor *";
            // 
            // txtCusto
            // 
            this.txtCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCusto.Location = new System.Drawing.Point(745, 170);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(5);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(75, 26);
            this.txtCusto.TabIndex = 12;
            this.txtCusto.Text = "R$0.00";
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCusto_KeyPress);
            this.txtCusto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCusto_KeyUp);
            this.txtCusto.Leave += new System.EventHandler(this.TxtCusto_Leave);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(635, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 115;
            this.label15.Text = "Quantidade *";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtd.Location = new System.Drawing.Point(639, 170);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(5);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(65, 26);
            this.txtQtd.TabIndex = 11;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 145);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 113;
            this.label14.Text = "Produto *";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(105, 167);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(348, 26);
            this.txtProduto.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 111;
            this.label13.Text = "Código";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProduto.Location = new System.Drawing.Point(19, 167);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(74, 26);
            this.txtCodProduto.TabIndex = 8;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Fornecedor *";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Location = new System.Drawing.Point(105, 94);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(348, 26);
            this.txtFornecedor.TabIndex = 7;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.TxtFornecedor_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Código";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.Location = new System.Drawing.Point(19, 94);
            this.txtCodFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(74, 26);
            this.txtCodFornecedor.TabIndex = 6;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.TextChanged += new System.EventHandler(this.TxtCodFornecedor_TextChanged);
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Data emissão *";
            // 
            // btnRemProduto
            // 
            this.btnRemProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemProduto.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnRemProduto.Location = new System.Drawing.Point(903, 162);
            this.btnRemProduto.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemProduto.Name = "btnRemProduto";
            this.btnRemProduto.Size = new System.Drawing.Size(47, 37);
            this.btnRemProduto.TabIndex = 124;
            this.btnRemProduto.UseVisualStyleBackColor = true;
            this.btnRemProduto.Click += new System.EventHandler(this.BtnRemProduto_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduto.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnAddProduto.Location = new System.Drawing.Point(849, 162);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(44, 37);
            this.btnAddProduto.TabIndex = 123;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacoes.Location = new System.Drawing.Point(19, 650);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(716, 51);
            this.txtObservacoes.TabIndex = 20;
            this.txtObservacoes.Text = "";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 625);
            this.label34.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(108, 20);
            this.label34.TabIndex = 146;
            this.label34.Text = "Observações";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(255, 717);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(123, 15);
            this.lblUsuario.TabIndex = 145;
            this.lblUsuario.Text = "Alterado pelo usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(260, 736);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 21);
            this.txtUsuario.TabIndex = 144;
            // 
            // lblAlteracao
            // 
            this.lblAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlteracao.AutoSize = true;
            this.lblAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteracao.Location = new System.Drawing.Point(106, 717);
            this.lblAlteracao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAlteracao.Name = "lblAlteracao";
            this.lblAlteracao.Size = new System.Drawing.Size(87, 15);
            this.lblAlteracao.TabIndex = 143;
            this.lblAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(16, 717);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(85, 15);
            this.lblDtCadastro.TabIndex = 141;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(97, 427);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(202, 20);
            this.label28.TabIndex = 139;
            this.label28.Text = "Condição de Pagamento *";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 427);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 20);
            this.label27.TabIndex = 137;
            this.label27.Text = "Código";
            // 
            // txtCodCondPagamento
            // 
            this.txtCodCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCondPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondPagamento.Location = new System.Drawing.Point(16, 452);
            this.txtCodCondPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodCondPagamento.Name = "txtCodCondPagamento";
            this.txtCodCondPagamento.Size = new System.Drawing.Size(74, 26);
            this.txtCodCondPagamento.TabIndex = 18;
            this.txtCodCondPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCondPagamento_KeyPress);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(378, 372);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 20);
            this.label26.TabIndex = 135;
            this.label26.Text = "Outras despesas";
            // 
            // txtOutrasDesp
            // 
            this.txtOutrasDesp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutrasDesp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutrasDesp.Location = new System.Drawing.Point(382, 395);
            this.txtOutrasDesp.Margin = new System.Windows.Forms.Padding(5);
            this.txtOutrasDesp.Name = "txtOutrasDesp";
            this.txtOutrasDesp.Size = new System.Drawing.Size(106, 26);
            this.txtOutrasDesp.TabIndex = 17;
            this.txtOutrasDesp.Text = "R$0.00";
            this.txtOutrasDesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutrasDesp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOutrasDesp_KeyPress);
            this.txtOutrasDesp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOutrasDesp_KeyUp);
            this.txtOutrasDesp.Leave += new System.EventHandler(this.TxtOutrasDesp_Leave);
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(264, 372);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 20);
            this.label25.TabIndex = 133;
            this.label25.Text = "Valor seguro";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeguro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSeguro.Location = new System.Drawing.Point(273, 395);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(5);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(97, 26);
            this.txtSeguro.TabIndex = 16;
            this.txtSeguro.Text = "R$0.00";
            this.txtSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSeguro_KeyPress);
            this.txtSeguro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSeguro_KeyUp);
            this.txtSeguro.Leave += new System.EventHandler(this.TxtSeguro_Leave);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(136, 372);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 20);
            this.label23.TabIndex = 129;
            this.label23.Text = "Valor frete";
            // 
            // txtFrete
            // 
            this.txtFrete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFrete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFrete.Location = new System.Drawing.Point(140, 395);
            this.txtFrete.Margin = new System.Windows.Forms.Padding(5);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(103, 26);
            this.txtFrete.TabIndex = 15;
            this.txtFrete.Text = "R$0.00";
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFrete_KeyPress);
            this.txtFrete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFrete_KeyUp);
            this.txtFrete.Leave += new System.EventHandler(this.TxtFrete_Leave);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Location = new System.Drawing.Point(898, 726);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 155;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Location = new System.Drawing.Point(661, 726);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpar.TabIndex = 154;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(553, 726);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 31);
            this.btnSalvar.TabIndex = 153;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(19, 736);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(70, 21);
            this.txtDtCadastro.TabIndex = 158;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(107, 736);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(71, 21);
            this.txtDtAlteracao.TabIndex = 159;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFornecedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarFornecedor.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(459, 81);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(82, 51);
            this.btnBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFornecedor.TabIndex = 265;
            this.btnBuscarFornecedor.TabStop = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.BtnBuscarFornecedor_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarProduto.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarProduto.Location = new System.Drawing.Point(459, 157);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(82, 50);
            this.btnBuscarProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarProduto.TabIndex = 266;
            this.btnBuscarProduto.TabStop = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.BtnBuscarProduto_Click);
            // 
            // btnBuscarCondPagamento
            // 
            this.btnBuscarCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCondPagamento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCondPagamento.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Location = new System.Drawing.Point(461, 439);
            this.btnBuscarCondPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarCondPagamento.Name = "btnBuscarCondPagamento";
            this.btnBuscarCondPagamento.Size = new System.Drawing.Size(82, 51);
            this.btnBuscarCondPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCondPagamento.TabIndex = 267;
            this.btnBuscarCondPagamento.TabStop = false;
            this.btnBuscarCondPagamento.Click += new System.EventHandler(this.BtnBuscarCondPagamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 270;
            this.label5.Text = "Lista de Itens";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(19, 34);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(5);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(74, 26);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModelo_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Modelo *";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 273;
            this.label7.Text = "Série *";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.Location = new System.Drawing.Point(140, 34);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(5);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(74, 26);
            this.txtSerie.TabIndex = 2;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_KeyPress);
            // 
            // txtCondPagamento
            // 
            this.txtCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCondPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondPagamento.Location = new System.Drawing.Point(102, 452);
            this.txtCondPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCondPagamento.Name = "txtCondPagamento";
            this.txtCondPagamento.Size = new System.Drawing.Size(351, 26);
            this.txtCondPagamento.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 277;
            this.label8.Text = "Nrº Nota *";
            // 
            // txtNrNota
            // 
            this.txtNrNota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNrNota.Location = new System.Drawing.Point(261, 34);
            this.txtNrNota.Margin = new System.Windows.Forms.Padding(5);
            this.txtNrNota.Name = "txtNrNota";
            this.txtNrNota.Size = new System.Drawing.Size(74, 26);
            this.txtNrNota.TabIndex = 3;
            this.txtNrNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNrNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrNota_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 278;
            this.label9.Text = "Data chegada *";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(541, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 281;
            this.label10.Text = "Und. *";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidade.Location = new System.Drawing.Point(544, 170);
            this.txtUnidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(65, 26);
            this.txtUnidade.TabIndex = 10;
            // 
            // rbTipoFrete1
            // 
            this.rbTipoFrete1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTipoFrete1.AutoSize = true;
            this.rbTipoFrete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoFrete1.Location = new System.Drawing.Point(20, 395);
            this.rbTipoFrete1.Name = "rbTipoFrete1";
            this.rbTipoFrete1.Size = new System.Drawing.Size(49, 21);
            this.rbTipoFrete1.TabIndex = 13;
            this.rbTipoFrete1.TabStop = true;
            this.rbTipoFrete1.Text = "CIF";
            this.rbTipoFrete1.UseVisualStyleBackColor = true;
            this.rbTipoFrete1.CheckedChanged += new System.EventHandler(this.RbTipoFrete1_CheckedChanged);
            // 
            // rbTipoFrete2
            // 
            this.rbTipoFrete2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTipoFrete2.AutoSize = true;
            this.rbTipoFrete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoFrete2.Location = new System.Drawing.Point(75, 395);
            this.rbTipoFrete2.Name = "rbTipoFrete2";
            this.rbTipoFrete2.Size = new System.Drawing.Size(57, 21);
            this.rbTipoFrete2.TabIndex = 14;
            this.rbTipoFrete2.TabStop = true;
            this.rbTipoFrete2.Text = "FOB";
            this.rbTipoFrete2.UseVisualStyleBackColor = true;
            this.rbTipoFrete2.CheckedChanged += new System.EventHandler(this.RbTipoFrete2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 285;
            this.label12.Text = "Tipo frete";
            // 
            // lvItem
            // 
            this.lvItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.produto,
            this.unid,
            this.qtd,
            this.precoCusto,
            this.valorTotal});
            this.lvItem.FullRowSelect = true;
            this.lvItem.GridLines = true;
            this.lvItem.HideSelection = false;
            this.lvItem.Location = new System.Drawing.Point(20, 222);
            this.lvItem.Name = "lvItem";
            this.lvItem.Size = new System.Drawing.Size(720, 146);
            this.lvItem.TabIndex = 286;
            this.lvItem.UseCompatibleStateImageBehavior = false;
            this.lvItem.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Código";
            this.id.Width = 70;
            // 
            // produto
            // 
            this.produto.Text = "Produto";
            this.produto.Width = 330;
            // 
            // unid
            // 
            this.unid.Text = "Unidade";
            this.unid.Width = 80;
            // 
            // qtd
            // 
            this.qtd.Text = "Qtd";
            // 
            // precoCusto
            // 
            this.precoCusto.Text = "Valor";
            this.precoCusto.Width = 80;
            // 
            // valorTotal
            // 
            this.valorTotal.Text = "Valor Total";
            this.valorTotal.Width = 100;
            // 
            // lvContaPagar
            // 
            this.lvContaPagar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvContaPagar.GridLines = true;
            this.lvContaPagar.HideSelection = false;
            this.lvContaPagar.Location = new System.Drawing.Point(15, 502);
            this.lvContaPagar.Name = "lvContaPagar";
            this.lvContaPagar.Size = new System.Drawing.Size(564, 120);
            this.lvContaPagar.TabIndex = 287;
            this.lvContaPagar.UseCompatibleStateImageBehavior = false;
            this.lvContaPagar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Conta à Pagar";
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 289;
            this.label6.Text = "Valor total de produtos";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(550, 395);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(114, 26);
            this.txtValorTotal.TabIndex = 288;
            this.txtValorTotal.Text = "R$0.00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorTotal_KeyPress);
            this.txtValorTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtValorTotal_KeyUp);
            this.txtValorTotal.Leave += new System.EventHandler(this.TxtValorTotal_Leave);
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataEmissao.Location = new System.Drawing.Point(390, 34);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(130, 27);
            this.txtDataEmissao.TabIndex = 290;
            // 
            // txtDtChegada
            // 
            this.txtDtChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDtChegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtChegada.Location = new System.Drawing.Point(553, 34);
            this.txtDtChegada.Name = "txtDtChegada";
            this.txtDtChegada.Size = new System.Drawing.Size(132, 26);
            this.txtDtChegada.TabIndex = 291;
            this.txtDtChegada.ValueChanged += new System.EventHandler(this.TxtDtChegada_ValueChanged);
            // 
            // chkSituacao
            // 
            this.chkSituacao.AutoSize = true;
            this.chkSituacao.Location = new System.Drawing.Point(853, 37);
            this.chkSituacao.Name = "chkSituacao";
            this.chkSituacao.Size = new System.Drawing.Size(68, 24);
            this.chkSituacao.TabIndex = 292;
            this.chkSituacao.Text = "Ativa";
            this.chkSituacao.UseVisualStyleBackColor = true;
            this.chkSituacao.CheckedChanged += new System.EventHandler(this.ChkSituacao_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(847, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 293;
            this.label11.Text = "Situação";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(732, 372);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 20);
            this.label17.TabIndex = 295;
            this.label17.Text = "Valor total à pagar";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(736, 395);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(94, 26);
            this.txtTotalPagar.TabIndex = 294;
            this.txtTotalPagar.Text = "R$0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 772);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkSituacao);
            this.Controls.Add(this.txtDtChegada);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lvContaPagar);
            this.Controls.Add(this.lvItem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbTipoFrete2);
            this.Controls.Add(this.rbTipoFrete1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNrNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarCondPagamento);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.btnBuscarFornecedor);
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
            this.Controls.Add(this.txtOutrasDesp);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtFrete);
            this.Controls.Add(this.btnRemProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModelo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastroCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Compra";
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblAlteracao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCodCondPagamento;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtOutrasDesp;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.PictureBox btnBuscarFornecedor;
        private System.Windows.Forms.PictureBox btnBuscarProduto;
        private System.Windows.Forms.PictureBox btnBuscarCondPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtCondPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNrNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.RadioButton rbTipoFrete1;
        private System.Windows.Forms.RadioButton rbTipoFrete2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvItem;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader produto;
        private System.Windows.Forms.ColumnHeader unid;
        private System.Windows.Forms.ColumnHeader qtd;
        private System.Windows.Forms.ColumnHeader precoCusto;
        private System.Windows.Forms.ListView lvContaPagar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.DateTimePicker txtDtChegada;
        private System.Windows.Forms.ColumnHeader valorTotal;
        private System.Windows.Forms.CheckBox chkSituacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalPagar;
    }
}