namespace EquipMotos.View
{
    partial class frmCadastroCategoria
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
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblDtAlteracao = new MaterialSkin.Controls.MaterialLabel();
            this.lblDtCadastro = new MaterialSkin.Controls.MaterialLabel();
            this.lblObservacoes = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCodigo = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtObeservacoes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(84, 260);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(64, 18);
            this.txtDtAlteracao.TabIndex = 274;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(13, 260);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(64, 18);
            this.txtDtCadastro.TabIndex = 273;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(154, 260);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(115, 23);
            this.txtUsuario.TabIndex = 269;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(161, 244);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(108, 13);
            this.lblUsuario.TabIndex = 268;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblDtAlteracao.Depth = 0;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDtAlteracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtAlteracao.Location = new System.Drawing.Point(82, 244);
            this.lblDtAlteracao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(78, 13);
            this.lblDtAlteracao.TabIndex = 267;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblDtCadastro.Depth = 0;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtCadastro.Location = new System.Drawing.Point(10, 244);
            this.lblDtCadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 266;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblObservacoes.Depth = 0;
            this.lblObservacoes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblObservacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObservacoes.Location = new System.Drawing.Point(12, 162);
            this.lblObservacoes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(96, 19);
            this.lblObservacoes.TabIndex = 265;
            this.lblObservacoes.Text = "Observações";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(13, 91);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(50, 23);
            this.txtCodigo.TabIndex = 263;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblCodigo.Depth = 0;
            this.lblCodigo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigo.Location = new System.Drawing.Point(12, 70);
            this.lblCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 19);
            this.lblCodigo.TabIndex = 262;
            this.lblCodigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(75, 70);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 276;
            this.label1.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Hint = "";
            this.txtCategoria.Location = new System.Drawing.Point(73, 90);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.Size = new System.Drawing.Size(276, 23);
            this.txtCategoria.TabIndex = 1;
            this.txtCategoria.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(315, 260);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(81, 28);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(400, 260);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(81, 28);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(516, 260);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(81, 28);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtObeservacoes
            // 
            this.txtObeservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObeservacoes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtObeservacoes.Location = new System.Drawing.Point(13, 183);
            this.txtObeservacoes.Margin = new System.Windows.Forms.Padding(2);
            this.txtObeservacoes.Name = "txtObeservacoes";
            this.txtObeservacoes.Size = new System.Drawing.Size(336, 36);
            this.txtObeservacoes.TabIndex = 281;
            this.txtObeservacoes.Text = "";
            // 
            // frmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 311);
            this.ControlBox = false;
            this.Controls.Add(this.txtObeservacoes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDtAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCadastroCategoria";
            this.Text = "Cadastro de Categoria";
            this.Load += new System.EventHandler(this.frmCadastroCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        protected System.Windows.Forms.MaskedTextBox txtDtCadastro;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        protected MaterialSkin.Controls.MaterialLabel lblUsuario;
        protected MaterialSkin.Controls.MaterialLabel lblDtAlteracao;
        protected MaterialSkin.Controls.MaterialLabel lblDtCadastro;
        protected MaterialSkin.Controls.MaterialLabel lblObservacoes;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        protected MaterialSkin.Controls.MaterialLabel lblCodigo;
        protected MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private System.Windows.Forms.RichTextBox txtObeservacoes;
    }
}