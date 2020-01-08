namespace EquipMotos.Codigo.View
{
    partial class frmCadastroFornecedor
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtIdCidade = new System.Windows.Forms.TextBox();
            this.lblCodigoCidade = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDtFundacao = new System.Windows.Forms.Label();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtCodCondicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCondicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIe = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCidade = new System.Windows.Forms.PictureBox();
            this.btnBuscarCondPagamento = new System.Windows.Forms.PictureBox();
            this.txtDtFundacao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1039, 522);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 97;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(789, 522);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpar.TabIndex = 96;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(662, 522);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 31);
            this.btnSalvar.TabIndex = 95;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(286, 527);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 21);
            this.txtUsuario.TabIndex = 94;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(282, 507);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 15);
            this.lblUsuario.TabIndex = 93;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(108, 507);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(87, 15);
            this.lblDtAlteracao.TabIndex = 91;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(13, 507);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(85, 15);
            this.lblDtCadastro.TabIndex = 89;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(10, 384);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(108, 20);
            this.lblObservacoes.TabIndex = 88;
            this.lblObservacoes.Text = "Observações";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.EnableAutoDragDrop = true;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(15, 406);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(835, 75);
            this.txtObservacao.TabIndex = 24;
            this.txtObservacao.Text = "";
            // 
            // txtContato
            // 
            this.txtContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(661, 214);
            this.txtContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(140, 26);
            this.txtContato.TabIndex = 17;
            this.txtContato.Leave += new System.EventHandler(this.txtContato_Leave);
            // 
            // lblContato
            // 
            this.lblContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(658, 190);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(67, 20);
            this.lblContato.TabIndex = 85;
            this.lblContato.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(354, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(350, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 83;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(177, 190);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(73, 20);
            this.lblTelefone2.TabIndex = 81;
            this.lblTelefone2.Text = "Telefone";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(13, 190);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(73, 20);
            this.lblTelefone.TabIndex = 79;
            this.lblTelefone.Text = "Celular *";
            // 
            // txtUF
            // 
            this.txtUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(456, 153);
            this.txtUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(53, 26);
            this.txtUF.TabIndex = 13;
            // 
            // lblUF
            // 
            this.lblUF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(463, 130);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(42, 20);
            this.lblUF.TabIndex = 77;
            this.lblUF.Text = "UF *";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(97, 153);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(351, 26);
            this.txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(95, 130);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(72, 20);
            this.lblCidade.TabIndex = 74;
            this.lblCidade.Text = "Cidade *";
            // 
            // txtIdCidade
            // 
            this.txtIdCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCidade.Location = new System.Drawing.Point(14, 153);
            this.txtIdCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCidade.Name = "txtIdCidade";
            this.txtIdCidade.Size = new System.Drawing.Size(68, 26);
            this.txtIdCidade.TabIndex = 11;
            this.txtIdCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdCidade.Leave += new System.EventHandler(this.txtIdCidade_Leave);
            // 
            // lblCodigoCidade
            // 
            this.lblCodigoCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoCidade.AutoSize = true;
            this.lblCodigoCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCidade.Location = new System.Drawing.Point(13, 131);
            this.lblCodigoCidade.Name = "lblCodigoCidade";
            this.lblCodigoCidade.Size = new System.Drawing.Size(54, 20);
            this.lblCodigoCidade.TabIndex = 72;
            this.lblCodigoCidade.Text = "Cod. *";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(1047, 93);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(96, 26);
            this.txtCep.TabIndex = 10;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1043, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "CEP";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(788, 94);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(244, 26);
            this.txtBairro.TabIndex = 9;
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(785, 74);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(66, 20);
            this.lblBairro.TabIndex = 68;
            this.lblBairro.Text = "Bairro *";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(543, 93);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(236, 26);
            this.txtComplemento.TabIndex = 8;
            this.txtComplemento.Leave += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Complemento";
            // 
            // txtSexo
            // 
            this.txtSexo.AcceptsReturn = true;
            this.txtSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(1104, 32);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(38, 26);
            this.txtSexo.TabIndex = 5;
            this.txtSexo.Visible = false;
            this.txtSexo.Leave += new System.EventHandler(this.txtSexo_Leave);
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(1097, 8);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(57, 20);
            this.lblSexo.TabIndex = 64;
            this.lblSexo.Text = "Sexo *";
            this.lblSexo.Visible = false;
            // 
            // lblDtFundacao
            // 
            this.lblDtFundacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtFundacao.AutoSize = true;
            this.lblDtFundacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFundacao.Location = new System.Drawing.Point(915, 8);
            this.lblDtFundacao.Name = "lblDtFundacao";
            this.lblDtFundacao.Size = new System.Drawing.Size(82, 20);
            this.lblDtFundacao.TabIndex = 62;
            this.lblDtFundacao.Text = "Fundação";
            // 
            // rbJuridica
            // 
            this.rbJuridica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.Location = new System.Drawing.Point(456, 10);
            this.rbJuridica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(150, 24);
            this.rbJuridica.TabIndex = 61;
            this.rbJuridica.TabStop = true;
            this.rbJuridica.Text = "Pessoa Jurídica";
            this.rbJuridica.UseVisualStyleBackColor = true;
            this.rbJuridica.CheckedChanged += new System.EventHandler(this.RbJuridica_CheckedChanged);
            // 
            // rbFisica
            // 
            this.rbFisica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFisica.AutoSize = true;
            this.rbFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.Location = new System.Drawing.Point(456, 35);
            this.rbFisica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(136, 24);
            this.rbFisica.TabIndex = 60;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.RbFisica_CheckedChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(445, 94);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 26);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Número *";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(17, 94);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(399, 26);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 74);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(91, 20);
            this.lblEndereco.TabIndex = 56;
            this.lblEndereco.Text = "Endereço *";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(628, 32);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(272, 26);
            this.txtNomeFantasia.TabIndex = 3;
            this.txtNomeFantasia.Leave += new System.EventHandler(this.txtNomeFantasia_Leave);
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(625, 6);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(122, 20);
            this.lblNomeFantasia.TabIndex = 54;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(99, 32);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(348, 26);
            this.txtFornecedor.TabIndex = 2;
            this.txtFornecedor.Leave += new System.EventHandler(this.txtFornecedor_Leave);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(99, 10);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(105, 20);
            this.lblFornecedor.TabIndex = 52;
            this.lblFornecedor.Text = "Fornecedor *";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 32);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 50;
            this.lblCodigo.Text = "Código";
            // 
            // txtIe
            // 
            this.txtIe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIe.Location = new System.Drawing.Point(291, 276);
            this.txtIe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(175, 26);
            this.txtIe.TabIndex = 20;
            // 
            // lblCnpj
            // 
            this.lblCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(11, 252);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(64, 20);
            this.lblCnpj.TabIndex = 98;
            this.lblCnpj.Text = "CNPJ *";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtSite
            // 
            this.txtSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSite.Location = new System.Drawing.Point(849, 214);
            this.txtSite.Margin = new System.Windows.Forms.Padding(4);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(260, 26);
            this.txtSite.TabIndex = 18;
            this.txtSite.Leave += new System.EventHandler(this.txtSite_Leave);
            // 
            // lblSite
            // 
            this.lblSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(845, 190);
            this.lblSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(38, 20);
            this.lblSite.TabIndex = 103;
            this.lblSite.Text = "Site";
            // 
            // txtCodCondicao
            // 
            this.txtCodCondicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCondicao.Location = new System.Drawing.Point(19, 338);
            this.txtCodCondicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCondicao.Name = "txtCodCondicao";
            this.txtCodCondicao.Size = new System.Drawing.Size(67, 26);
            this.txtCodCondicao.TabIndex = 21;
            this.txtCodCondicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodCondicao.TextChanged += new System.EventHandler(this.txtCodCondicao_TextChanged);
            this.txtCodCondicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodCondicao_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Cod. ";
            // 
            // txtCondicao
            // 
            this.txtCondicao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicao.Location = new System.Drawing.Point(103, 338);
            this.txtCondicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.Size = new System.Drawing.Size(316, 26);
            this.txtCondicao.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "Condição de Pagamento";
            // 
            // lblIe
            // 
            this.lblIe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIe.AutoSize = true;
            this.lblIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIe.Location = new System.Drawing.Point(287, 252);
            this.lblIe.Name = "lblIe";
            this.lblIe.Size = new System.Drawing.Size(28, 20);
            this.lblIe.TabIndex = 100;
            this.lblIe.Text = "I.E";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLimiteCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteCredito.Location = new System.Drawing.Point(556, 338);
            this.txtLimiteCredito.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(91, 26);
            this.txtLimiteCredito.TabIndex = 23;
            this.txtLimiteCredito.Text = "R$ 0,00";
            this.txtLimiteCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLimiteCredito_KeyPress);
            this.txtLimiteCredito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtLimiteCredito_KeyUp);
            this.txtLimiteCredito.Leave += new System.EventHandler(this.TxtLimiteCredito_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Limite de Crédito";
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(16, 527);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(69, 21);
            this.txtDtCadastro.TabIndex = 245;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(112, 527);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(72, 21);
            this.txtDtAlteracao.TabIndex = 246;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(13, 276);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(164, 26);
            this.txtCnpj.TabIndex = 19;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(182, 214);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(135, 26);
            this.txtTelefone.TabIndex = 15;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(14, 214);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Mask = "(99) 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(135, 26);
            this.txtCelular.TabIndex = 14;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Leave += new System.EventHandler(this.txtCelular_Leave);
            // 
            // btnBuscarCidade
            // 
            this.btnBuscarCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCidade.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCidade.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCidade.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCidade.Location = new System.Drawing.Point(516, 131);
            this.btnBuscarCidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCidade.Name = "btnBuscarCidade";
            this.btnBuscarCidade.Size = new System.Drawing.Size(68, 58);
            this.btnBuscarCidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCidade.TabIndex = 268;
            this.btnBuscarCidade.TabStop = false;
            this.btnBuscarCidade.Click += new System.EventHandler(this.BtnBuscarCidade_Click);
            // 
            // btnBuscarCondPagamento
            // 
            this.btnBuscarCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCondPagamento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCondPagamento.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPagamento.Location = new System.Drawing.Point(427, 314);
            this.btnBuscarCondPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCondPagamento.Name = "btnBuscarCondPagamento";
            this.btnBuscarCondPagamento.Size = new System.Drawing.Size(68, 62);
            this.btnBuscarCondPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCondPagamento.TabIndex = 269;
            this.btnBuscarCondPagamento.TabStop = false;
            this.btnBuscarCondPagamento.Click += new System.EventHandler(this.BtnBuscarCondPagamento_Click);
            // 
            // txtDtFundacao
            // 
            this.txtDtFundacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtFundacao.Location = new System.Drawing.Point(919, 32);
            this.txtDtFundacao.Name = "txtDtFundacao";
            this.txtDtFundacao.Size = new System.Drawing.Size(146, 27);
            this.txtDtFundacao.TabIndex = 270;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 565);
            this.ControlBox = false;
            this.Controls.Add(this.txtDtFundacao);
            this.Controls.Add(this.btnBuscarCondPagamento);
            this.Controls.Add(this.btnBuscarCidade);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLimiteCredito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCondicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodCondicao);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(this.lblIe);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDtAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtIdCidade);
            this.Controls.Add(this.lblCodigoCidade);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDtFundacao);
            this.Controls.Add(this.rbJuridica);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNomeFantasia);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmCadastroFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDtAlteracao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtIdCidade;
        private System.Windows.Forms.Label lblCodigoCidade;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDtFundacao;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label lblCnpj;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtCodCondicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCondicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIe;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.PictureBox btnBuscarCidade;
        private System.Windows.Forms.PictureBox btnBuscarCondPagamento;
        private System.Windows.Forms.DateTimePicker txtDtFundacao;
    }
}