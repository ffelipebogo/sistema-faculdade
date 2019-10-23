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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtObeservacoes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(137, 273);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(6);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(104, 21);
            this.txtDtAlteracao.TabIndex = 274;
            this.txtDtAlteracao.UseWaitCursor = true;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(19, 273);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(6);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(104, 21);
            this.txtDtCadastro.TabIndex = 273;
            this.txtDtCadastro.UseWaitCursor = true;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(253, 273);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 21);
            this.txtUsuario.TabIndex = 269;
            this.txtUsuario.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(248, 248);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 15);
            this.lblUsuario.TabIndex = 268;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(132, 248);
            this.lblDtAlteracao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(87, 15);
            this.lblDtAlteracao.TabIndex = 267;
            this.lblDtAlteracao.Text = "Data Alteração";
            this.lblDtAlteracao.UseWaitCursor = true;
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(14, 248);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(85, 15);
            this.lblDtCadastro.TabIndex = 266;
            this.lblDtCadastro.Text = "Data Cadastro";
            this.lblDtCadastro.UseWaitCursor = true;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(10, 152);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(108, 20);
            this.lblObservacoes.TabIndex = 265;
            this.lblObservacoes.Text = "Observações";
            this.lblObservacoes.UseWaitCursor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 31);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 26);
            this.txtCodigo.TabIndex = 263;
            this.txtCodigo.UseWaitCursor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(10, 9);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 20);
            this.lblCodigo.TabIndex = 262;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 276;
            this.label1.Text = "Categoria";
            this.label1.UseWaitCursor = true;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(113, 30);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(458, 27);
            this.txtCategoria.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(164, 312);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 31);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(278, 312);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 31);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(450, 312);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(121, 31);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtObeservacoes
            // 
            this.txtObeservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObeservacoes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtObeservacoes.Location = new System.Drawing.Point(14, 176);
            this.txtObeservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObeservacoes.Name = "txtObeservacoes";
            this.txtObeservacoes.Size = new System.Drawing.Size(557, 68);
            this.txtObeservacoes.TabIndex = 281;
            this.txtObeservacoes.Text = "";
            // 
            // frmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 366);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCadastroCategoria";
            this.Text = "Cadastro de Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        protected System.Windows.Forms.MaskedTextBox txtDtCadastro;
        protected System.Windows.Forms.TextBox txtUsuario;
        protected System.Windows.Forms.Label lblUsuario;
        protected System.Windows.Forms.Label lblDtAlteracao;
        protected System.Windows.Forms.Label lblDtCadastro;
        protected System.Windows.Forms.Label lblObservacoes;
        protected System.Windows.Forms.TextBox txtCodigo;
        protected System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RichTextBox txtObeservacoes;
    }
}