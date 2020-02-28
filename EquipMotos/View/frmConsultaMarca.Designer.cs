﻿namespace EquipMotos.View
{
    partial class frmConsultaMarca
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvMarca = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaMoto2DataSetMarca = new EquipMotos.SistemaMoto2DataSetMarca();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBuscarMarca = new System.Windows.Forms.PictureBox();
            this.marcasTableAdapter = new EquipMotos.SistemaMoto2DataSetMarcaTableAdapters.marcasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(570, 529);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(157, 42);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 95);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(445, 26);
            this.txtPesquisar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesquisar Marca";
            // 
            // gvMarca
            // 
            this.gvMarca.AllowUserToAddRows = false;
            this.gvMarca.AllowUserToDeleteRows = false;
            this.gvMarca.AllowUserToOrderColumns = true;
            this.gvMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvMarca.AutoGenerateColumns = false;
            this.gvMarca.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.gvMarca.DataSource = this.marcasBindingSource;
            this.gvMarca.EnableHeadersVisualStyles = false;
            this.gvMarca.Location = new System.Drawing.Point(12, 144);
            this.gvMarca.Margin = new System.Windows.Forms.Padding(4);
            this.gvMarca.Name = "gvMarca";
            this.gvMarca.ReadOnly = true;
            this.gvMarca.RowHeadersWidth = 51;
            this.gvMarca.Size = new System.Drawing.Size(698, 322);
            this.gvMarca.TabIndex = 19;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            this.marcasBindingSource.DataSource = this.sistemaMoto2DataSetMarca;
            // 
            // sistemaMoto2DataSetMarca
            // 
            this.sistemaMoto2DataSetMarca.DataSetName = "SistemaMoto2DataSetMarca";
            this.sistemaMoto2DataSetMarca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(405, 529);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 42);
            this.btnExcluir.TabIndex = 26;
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
            this.btnAlterar.Location = new System.Drawing.Point(267, 529);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 42);
            this.btnAlterar.TabIndex = 24;
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
            this.btnNovo.Location = new System.Drawing.Point(129, 529);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 42);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarMarca.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarMarca.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarMarca.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarMarca.Location = new System.Drawing.Point(464, 76);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(67, 60);
            this.btnBuscarMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarMarca.TabIndex = 277;
            this.btnBuscarMarca.TabStop = false;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 584);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvMarca);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsultaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Marcas";
            this.Load += new System.EventHandler(this.FrmConsultaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvMarca;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnBuscarMarca;
        private SistemaMoto2DataSetMarca sistemaMoto2DataSetMarca;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private SistemaMoto2DataSetMarcaTableAdapters.marcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}