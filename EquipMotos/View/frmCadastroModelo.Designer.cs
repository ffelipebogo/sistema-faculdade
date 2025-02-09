﻿namespace EquipMotos.View
{
    partial class frmCadastroModelo
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
            this.txtCodModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarMarca = new System.Windows.Forms.PictureBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.txtDtCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDtAlteracao = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodModelo
            // 
            this.txtCodModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodModelo.Enabled = false;
            this.txtCodModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodModelo.Location = new System.Drawing.Point(25, 107);
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.Size = new System.Drawing.Size(60, 23);
            this.txtCodModelo.TabIndex = 0;
            this.txtCodModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo *";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(91, 107);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(264, 23);
            this.txtModelo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código";
            // 
            // txtCodMarca
            // 
            this.txtCodMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodMarca.Location = new System.Drawing.Point(26, 177);
            this.txtCodMarca.Name = "txtCodMarca";
            this.txtCodMarca.Size = new System.Drawing.Size(60, 23);
            this.txtCodMarca.TabIndex = 2;
            this.txtCodMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodMarca_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca *";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(91, 178);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(264, 23);
            this.txtMarca.TabIndex = 3;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Location = new System.Drawing.Point(634, 523);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 154;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Location = new System.Drawing.Point(456, 523);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = true;
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 153;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(352, 523);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 152;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarMarca.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarMarca.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarMarca.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarMarca.Location = new System.Drawing.Point(364, 160);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarMarca.TabIndex = 270;
            this.btnBuscarMarca.TabStop = false;
            this.btnBuscarMarca.Click += new System.EventHandler(this.BtnBuscarMarca_Click);
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtAlteracao.Location = new System.Drawing.Point(112, 550);
            this.txtDtAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtAlteracao.Mask = "00/00/0000";
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.Size = new System.Drawing.Size(64, 18);
            this.txtDtAlteracao.TabIndex = 280;
            this.txtDtAlteracao.UseWaitCursor = true;
            this.txtDtAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDtCadastro.Enabled = false;
            this.txtDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtCadastro.Location = new System.Drawing.Point(31, 550);
            this.txtDtCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtDtCadastro.Mask = "00/00/0000";
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.Size = new System.Drawing.Size(64, 18);
            this.txtDtCadastro.TabIndex = 279;
            this.txtDtCadastro.UseWaitCursor = true;
            this.txtDtCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(200, 550);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(91, 18);
            this.txtUsuario.TabIndex = 278;
            this.txtUsuario.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(198, 535);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(107, 13);
            this.lblUsuario.TabIndex = 277;
            this.lblUsuario.Text = "Alterado pelo Usuário";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // lblDtAlteracao
            // 
            this.lblDtAlteracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtAlteracao.AutoSize = true;
            this.lblDtAlteracao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtAlteracao.Location = new System.Drawing.Point(110, 535);
            this.lblDtAlteracao.Name = "lblDtAlteracao";
            this.lblDtAlteracao.Size = new System.Drawing.Size(77, 13);
            this.lblDtAlteracao.TabIndex = 276;
            this.lblDtAlteracao.Text = "Data Alteração";
            this.lblDtAlteracao.UseWaitCursor = true;
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtCadastro.Location = new System.Drawing.Point(29, 535);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lblDtCadastro.TabIndex = 275;
            this.lblDtCadastro.Text = "Data Cadastro";
            this.lblDtCadastro.UseWaitCursor = true;
            // 
            // frmCadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 593);
            this.ControlBox = false;
            this.Controls.Add(this.txtDtAlteracao);
            this.Controls.Add(this.txtDtCadastro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDtAlteracao);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodModelo);
            this.Name = "frmCadastroModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Modelo";
            this.Load += new System.EventHandler(this.frmCadastroModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        private System.Windows.Forms.PictureBox btnBuscarMarca;
        protected System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        protected System.Windows.Forms.MaskedTextBox txtDtCadastro;
        protected System.Windows.Forms.TextBox txtUsuario;
        protected System.Windows.Forms.Label lblUsuario;
        protected System.Windows.Forms.Label lblDtAlteracao;
        protected System.Windows.Forms.Label lblDtCadastro;
    }
}