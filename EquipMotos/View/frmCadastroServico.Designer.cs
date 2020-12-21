namespace EquipMotos.VIEW
{
    partial class frmCadastroServico
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
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodigoFornecedor = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.lblProdutoServico = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecoVenda.Location = new System.Drawing.Point(10, 211);
            this.lblPrecoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(108, 17);
            this.lblPrecoVenda.TabIndex = 351;
            this.lblPrecoVenda.Text = "Preço de venda";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoVenda.Location = new System.Drawing.Point(14, 232);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(102, 23);
            this.txtPrecoVenda.TabIndex = 350;
            this.txtPrecoVenda.Text = "R$0.00";
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoVenda_KeyPress);
            this.txtPrecoVenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyUp);
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(103, 477);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(65, 18);
            this.txtDtAlteracao.TabIndex = 334;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(20, 477);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(65, 18);
            this.txtDtCadastro.TabIndex = 333;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(449, 470);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 338;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(337, 470);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 336;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(567, 470);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 340;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(15, 400);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(266, 30);
            this.txtObservacao.TabIndex = 332;
            this.txtObservacao.Text = "";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 378);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 17);
            this.label22.TabIndex = 346;
            this.label22.Text = "Observações";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(191, 459);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(106, 13);
            this.lblUsuario.TabIndex = 345;
            this.lblUsuario.Text = "Alterado pelo usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(194, 477);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 18);
            this.txtUsuario.TabIndex = 335;
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(99, 459);
            this.lblDtAlteracao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(77, 13);
            this.lblDtAlteracao.TabIndex = 344;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(15, 459);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 343;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblComissao
            // 
            this.lblComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComissao.AutoSize = true;
            this.lblComissao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissao.Location = new System.Drawing.Point(173, 207);
            this.lblComissao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(95, 17);
            this.lblComissao.TabIndex = 341;
            this.lblComissao.Text = "Comissão (%)";
            // 
            // txtComissao
            // 
            this.txtComissao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(177, 232);
            this.txtComissao.Margin = new System.Windows.Forms.Padding(5);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(74, 23);
            this.txtComissao.TabIndex = 331;
            this.txtComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComissao_KeyPress);
            this.txtComissao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComissao_KeyUp);
            this.txtComissao.Leave += new System.EventHandler(this.txtComissao_Leave);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.Location = new System.Drawing.Point(84, 170);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(5);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(340, 23);
            this.txtFuncionario.TabIndex = 329;
            // 
            // lblCodigoFornecedor
            // 
            this.lblCodigoFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoFornecedor.AutoSize = true;
            this.lblCodigoFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFornecedor.Location = new System.Drawing.Point(12, 148);
            this.lblCodigoFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigoFornecedor.Name = "lblCodigoFornecedor";
            this.lblCodigoFornecedor.Size = new System.Drawing.Size(52, 17);
            this.lblCodigoFornecedor.TabIndex = 326;
            this.lblCodigoFornecedor.Text = "Código";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFornecedor.Location = new System.Drawing.Point(14, 170);
            this.txtCodFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(60, 23);
            this.txtCodFornecedor.TabIndex = 327;
            this.txtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodFornecedor.TextChanged += new System.EventHandler(this.txtCodFornecedor_TextChanged);
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            this.txtCodFornecedor.Leave += new System.EventHandler(this.txtCodFornecedor_Leave);
            // 
            // lblProdutoServico
            // 
            this.lblProdutoServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProdutoServico.AutoSize = true;
            this.lblProdutoServico.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProdutoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoServico.Location = new System.Drawing.Point(81, 77);
            this.lblProdutoServico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProdutoServico.Name = "lblProdutoServico";
            this.lblProdutoServico.Size = new System.Drawing.Size(60, 17);
            this.lblProdutoServico.TabIndex = 342;
            this.lblProdutoServico.Text = "Serviço*";
            // 
            // txtServico
            // 
            this.txtServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServico.Location = new System.Drawing.Point(84, 99);
            this.txtServico.Margin = new System.Windows.Forms.Padding(5);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(365, 23);
            this.txtServico.TabIndex = 317;
            this.txtServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdutoServico_KeyPress);
            this.txtServico.Leave += new System.EventHandler(this.txtProdutoServico_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 316;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 99);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(60, 23);
            this.txtCodigo.TabIndex = 315;
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
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(434, 148);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarFornecedor.TabIndex = 348;
            this.btnBuscarFornecedor.TabStop = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.btnBuscarFornecedor_Click);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(81, 148);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(87, 17);
            this.lblFornecedor.TabIndex = 328;
            this.lblFornecedor.Text = "Funcionario*";
            // 
            // frmCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 523);
            this.ControlBox = false;
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.btnBuscarFornecedor);
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
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lblCodigoFornecedor);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.lblProdutoServico);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCadastroServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviços";
            this.Load += new System.EventHandler(this.frmCadastroServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.PictureBox btnBuscarFornecedor;
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
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label lblCodigoFornecedor;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label lblProdutoServico;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFornecedor;
    }
}