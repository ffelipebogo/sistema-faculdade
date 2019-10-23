namespace EquipMotos.View
{
    partial class frmConsultaEstado
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBuscarEstado = new System.Windows.Forms.PictureBox();
            this.gvEstado = new System.Windows.Forms.DataGridView();
            this.sistemaMoto2DataSetCategoria = new EquipMotos.SistemaMoto2DataSetCategoria();
            this.sistemaMoto2DataSetEstado = new EquipMotos.SistemaMoto2DataSetEstado();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new EquipMotos.SistemaMoto2DataSetEstadoTableAdapters.estadosTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 274;
            this.label2.Text = "Lista de Estados";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(439, 439);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(162, 42);
            this.btnVoltar.TabIndex = 272;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 268;
            this.label1.Text = "Pesquisar Estado";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(13, 33);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(431, 26);
            this.txtPesquisar.TabIndex = 266;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(279, 439);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 42);
            this.btnExcluir.TabIndex = 273;
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
            this.btnAlterar.Location = new System.Drawing.Point(137, 439);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(134, 42);
            this.btnAlterar.TabIndex = 271;
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
            this.btnNovo.Location = new System.Drawing.Point(18, 439);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(111, 42);
            this.btnNovo.TabIndex = 270;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnBuscarEstado
            // 
            this.btnBuscarEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarEstado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarEstado.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarEstado.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarEstado.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarEstado.Location = new System.Drawing.Point(452, 8);
            this.btnBuscarEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEstado.Name = "btnBuscarEstado";
            this.btnBuscarEstado.Size = new System.Drawing.Size(92, 76);
            this.btnBuscarEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarEstado.TabIndex = 267;
            this.btnBuscarEstado.TabStop = false;
            this.btnBuscarEstado.Click += new System.EventHandler(this.BtnBuscarEstado_Click);
            // 
            // gvEstado
            // 
            this.gvEstado.AllowUserToAddRows = false;
            this.gvEstado.AllowUserToDeleteRows = false;
            this.gvEstado.AllowUserToOrderColumns = true;
            this.gvEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvEstado.AutoGenerateColumns = false;
            this.gvEstado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvEstado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvEstado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.codPaisDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.gvEstado.DataSource = this.estadosBindingSource;
            this.gvEstado.EnableHeadersVisualStyles = false;
            this.gvEstado.Location = new System.Drawing.Point(12, 101);
            this.gvEstado.Name = "gvEstado";
            this.gvEstado.ReadOnly = true;
            this.gvEstado.RowHeadersWidth = 51;
            this.gvEstado.RowTemplate.Height = 24;
            this.gvEstado.Size = new System.Drawing.Size(532, 304);
            this.gvEstado.TabIndex = 275;
            // 
            // sistemaMoto2DataSetCategoria
            // 
            this.sistemaMoto2DataSetCategoria.DataSetName = "SistemaMoto2DataSetCategoria";
            this.sistemaMoto2DataSetCategoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaMoto2DataSetEstado
            // 
            this.sistemaMoto2DataSetEstado.DataSetName = "SistemaMoto2DataSetEstado";
            this.sistemaMoto2DataSetEstado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.sistemaMoto2DataSetEstado;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn1.HeaderText = "uf";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // codPaisDataGridViewTextBoxColumn
            // 
            this.codPaisDataGridViewTextBoxColumn.DataPropertyName = "codPais";
            this.codPaisDataGridViewTextBoxColumn.HeaderText = "codPais";
            this.codPaisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codPaisDataGridViewTextBoxColumn.Name = "codPaisDataGridViewTextBoxColumn";
            this.codPaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.codPaisDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn2.HeaderText = "estado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtAlteracaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtCadastroDataGridViewTextBoxColumn
            // 
            this.dtCadastroDataGridViewTextBoxColumn.DataPropertyName = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.HeaderText = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtCadastroDataGridViewTextBoxColumn.Name = "dtCadastroDataGridViewTextBoxColumn";
            this.dtCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtCadastroDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmConsultaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 494);
            this.ControlBox = false;
            this.Controls.Add(this.gvEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarEstado);
            this.Controls.Add(this.txtPesquisar);
            this.Name = "frmConsultaEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Estados";
            this.Load += new System.EventHandler(this.FrmConsultaEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBuscarEstado;
        private System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView gvEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaisDataGridViewTextBoxColumn;
        private SistemaMoto2DataSetCategoria sistemaMoto2DataSetCategoria;
        private SistemaMoto2DataSetEstado sistemaMoto2DataSetEstado;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private SistemaMoto2DataSetEstadoTableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}