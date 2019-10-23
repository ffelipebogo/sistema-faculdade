namespace EquipMotos.View
{
    partial class frmCadastroPais
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
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPais
            // 
            this.txtPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(98, 34);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(305, 26);
            this.txtPais.TabIndex = 2;
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoPais.Enabled = false;
            this.txtCodigoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPais.Location = new System.Drawing.Point(18, 34);
            this.txtCodigoPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(60, 26);
            this.txtCodigoPais.TabIndex = 1;
            this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 295;
            this.label2.Text = "País";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 294;
            this.label1.Text = "Código";
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(116, 140);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(71, 21);
            this.txtDtAlteracao.TabIndex = 293;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(17, 140);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(69, 21);
            this.txtDtCadastro.TabIndex = 292;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(222, 140);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 21);
            this.txtUsuario.TabIndex = 288;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(219, 120);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(125, 15);
            this.lblUsuario.TabIndex = 287;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(110, 120);
            this.lblDtAlteracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(87, 15);
            this.lblDtAlteracao.TabIndex = 286;
            this.lblDtAlteracao.Text = "Data Alteração";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(15, 120);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(85, 15);
            this.lblDtCadastro.TabIndex = 285;
            this.lblDtCadastro.Text = "Data Cadastro";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(129, 185);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpar.TabIndex = 297;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(17, 185);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 31);
            this.btnSalvar.TabIndex = 296;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(304, 185);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 31);
            this.btnVoltar.TabIndex = 298;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // frmCadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 234);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDtAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Name = "frmCadastroPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.MaskedTextBox txtDtCadastro;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDtAlteracao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}