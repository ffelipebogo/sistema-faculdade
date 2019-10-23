﻿namespace EquipMotos.View
{
    partial class frmConsultaCondicaoPagamento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvCondPagamento = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCondPag = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.sistemaMoto2DataSetCondicaoPagamento = new EquipMotos.SistemaMoto2DataSetCondicaoPagamento();
            this.condicaoPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condicaoPagamentoTableAdapter = new EquipMotos.SistemaMoto2DataSetCondicaoPagamentoTableAdapters.condicaoPagamentoTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCondPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetCondicaoPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoPagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCondPagamento
            // 
            this.gvCondPagamento.AllowUserToAddRows = false;
            this.gvCondPagamento.AllowUserToDeleteRows = false;
            this.gvCondPagamento.AllowUserToOrderColumns = true;
            this.gvCondPagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvCondPagamento.AutoGenerateColumns = false;
            this.gvCondPagamento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvCondPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCondPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCondPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCondPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCondPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.gvCondPagamento.DataSource = this.condicaoPagamentoBindingSource;
            this.gvCondPagamento.EnableHeadersVisualStyles = false;
            this.gvCondPagamento.Location = new System.Drawing.Point(17, 85);
            this.gvCondPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.gvCondPagamento.Name = "gvCondPagamento";
            this.gvCondPagamento.ReadOnly = true;
            this.gvCondPagamento.RowHeadersWidth = 51;
            this.gvCondPagamento.Size = new System.Drawing.Size(882, 362);
            this.gvCondPagamento.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(730, 473);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(169, 42);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 36);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(531, 26);
            this.txtPesquisar.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Pesquisar Condição Pagamento";
            // 
            // btnBuscarCondPag
            // 
            this.btnBuscarCondPag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCondPag.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarCondPag.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPag.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarCondPag.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarCondPag.Location = new System.Drawing.Point(554, 23);
            this.btnBuscarCondPag.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCondPag.Name = "btnBuscarCondPag";
            this.btnBuscarCondPag.Size = new System.Drawing.Size(66, 54);
            this.btnBuscarCondPag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarCondPag.TabIndex = 267;
            this.btnBuscarCondPag.TabStop = false;
            this.btnBuscarCondPag.Click += new System.EventHandler(this.BtnBuscarCondPag_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(570, 473);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 42);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::EquipMotos.Properties.Resources._1398756462_Modify;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(432, 473);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 42);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(294, 473);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 42);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // sistemaMoto2DataSetCondicaoPagamento
            // 
            this.sistemaMoto2DataSetCondicaoPagamento.DataSetName = "SistemaMoto2DataSetCondicaoPagamento";
            this.sistemaMoto2DataSetCondicaoPagamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condicaoPagamentoBindingSource
            // 
            this.condicaoPagamentoBindingSource.DataMember = "condicaoPagamento";
            this.condicaoPagamentoBindingSource.DataSource = this.sistemaMoto2DataSetCondicaoPagamento;
            // 
            // condicaoPagamentoTableAdapter
            // 
            this.condicaoPagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "condicao";
            this.dataGridViewTextBoxColumn9.HeaderText = "condicao";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "multa";
            this.dataGridViewTextBoxColumn10.HeaderText = "multa";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "juros";
            this.dataGridViewTextBoxColumn11.HeaderText = "juros";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "desconto";
            this.dataGridViewTextBoxColumn12.HeaderText = "desconto";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "dtCadastro";
            this.dataGridViewTextBoxColumn13.HeaderText = "dtCadastro";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "dtAlteracao";
            this.dataGridViewTextBoxColumn14.HeaderText = "dtAlteracao";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn15.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // frmConsultaCondicaoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 537);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscarCondPag);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gvCondPagamento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaCondicaoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Condicao de Pagamento";
            this.Load += new System.EventHandler(this.FrmConsultaCondicaoPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCondPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarCondPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetCondicaoPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoPagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCondPagamento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBuscarCondPag;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private SistemaMoto2DataSetCondicaoPagamento sistemaMoto2DataSetCondicaoPagamento;
        private System.Windows.Forms.BindingSource condicaoPagamentoBindingSource;
        private SistemaMoto2DataSetCondicaoPagamentoTableAdapters.condicaoPagamentoTableAdapter condicaoPagamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}