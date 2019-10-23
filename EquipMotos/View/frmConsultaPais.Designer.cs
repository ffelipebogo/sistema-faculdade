namespace EquipMotos.View
{
    partial class frmConsultaPais
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
            this.gvPais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBuscarPais = new System.Windows.Forms.PictureBox();
            this.sistemaMoto2DataSetPais = new EquipMotos.SistemaMoto2DataSetPais();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisesTableAdapter = new EquipMotos.SistemaMoto2DataSetPaisTableAdapters.paisesTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 283;
            this.label2.Text = "Lista de Paises";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(484, 435);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(152, 42);
            this.btnVoltar.TabIndex = 281;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // gvPais
            // 
            this.gvPais.AllowUserToAddRows = false;
            this.gvPais.AllowUserToDeleteRows = false;
            this.gvPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvPais.AutoGenerateColumns = false;
            this.gvPais.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.gvPais.DataSource = this.paisesBindingSource;
            this.gvPais.EnableHeadersVisualStyles = false;
            this.gvPais.Location = new System.Drawing.Point(24, 105);
            this.gvPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvPais.Name = "gvPais";
            this.gvPais.ReadOnly = true;
            this.gvPais.RowHeadersWidth = 51;
            this.gvPais.RowTemplate.Height = 24;
            this.gvPais.Size = new System.Drawing.Size(612, 303);
            this.gvPais.TabIndex = 278;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 277;
            this.label1.Text = "Pesquisar Pais";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(24, 34);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(431, 26);
            this.txtPesquisar.TabIndex = 275;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(312, 438);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 42);
            this.btnExcluir.TabIndex = 282;
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
            this.btnAlterar.Location = new System.Drawing.Point(174, 438);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 42);
            this.btnAlterar.TabIndex = 280;
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
            this.btnNovo.Location = new System.Drawing.Point(36, 438);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 42);
            this.btnNovo.TabIndex = 279;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPais.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarPais.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarPais.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarPais.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarPais.Location = new System.Drawing.Point(463, 13);
            this.btnBuscarPais.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(67, 60);
            this.btnBuscarPais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarPais.TabIndex = 276;
            this.btnBuscarPais.TabStop = false;
            this.btnBuscarPais.Click += new System.EventHandler(this.BtnBuscarPais_Click);
            // 
            // sistemaMoto2DataSetPais
            // 
            this.sistemaMoto2DataSetPais.DataSetName = "SistemaMoto2DataSetPais";
            this.sistemaMoto2DataSetPais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "paises";
            this.paisesBindingSource.DataSource = this.sistemaMoto2DataSetPais;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pais";
            this.dataGridViewTextBoxColumn1.HeaderText = "pais";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtAlteracaoDataGridViewTextBoxColumn.Width = 125;
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
            // frmConsultaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 490);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gvPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarPais);
            this.Controls.Add(this.txtPesquisar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsultaPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Paises";
            this.Load += new System.EventHandler(this.FrmConsultaPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView gvPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnBuscarPais;
        private SistemaMoto2DataSetPais sistemaMoto2DataSetPais;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private SistemaMoto2DataSetPaisTableAdapters.paisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}