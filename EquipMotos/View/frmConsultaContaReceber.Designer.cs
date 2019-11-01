namespace EquipMotos.View
{
    partial class frmConsultaContaReceber
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvContaPagar = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBuscarContaPagar = new System.Windows.Forms.PictureBox();
            this.sistemaMoto2DataSetContaReceber = new EquipMotos.SistemaMoto2DataSetContaReceber();
            this.contaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contaReceberTableAdapter = new EquipMotos.SistemaMoto2DataSetContaReceberTableAdapters.contaReceberTableAdapter();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFormaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvContaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarContaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetContaReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(456, 468);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 42);
            this.btnExcluir.TabIndex = 282;
            this.btnExcluir.Text = "PAGAR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(607, 468);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(159, 42);
            this.btnVoltar.TabIndex = 281;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(297, 468);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 42);
            this.btnAlterar.TabIndex = 280;
            this.btnAlterar.Text = "VISUALIZAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 33);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(472, 26);
            this.txtPesquisar.TabIndex = 277;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 276;
            this.label1.Text = "Pesquisar Contas à Receber";
            // 
            // gvContaPagar
            // 
            this.gvContaPagar.AllowUserToAddRows = false;
            this.gvContaPagar.AllowUserToDeleteRows = false;
            this.gvContaPagar.AllowUserToOrderColumns = true;
            this.gvContaPagar.AutoGenerateColumns = false;
            this.gvContaPagar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvContaPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvContaPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvContaPagar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvContaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContaPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modeloDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.nrNotaDataGridViewTextBoxColumn,
            this.codClienteDataGridViewTextBoxColumn,
            this.nrParcelaDataGridViewTextBoxColumn,
            this.codFormaPagamentoDataGridViewTextBoxColumn,
            this.dtEmissaoDataGridViewTextBoxColumn,
            this.dtVencimentoDataGridViewTextBoxColumn,
            this.valorParcelaDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.pagoDataGridViewCheckBoxColumn});
            this.gvContaPagar.DataSource = this.contaReceberBindingSource;
            this.gvContaPagar.EnableHeadersVisualStyles = false;
            this.gvContaPagar.Location = new System.Drawing.Point(13, 78);
            this.gvContaPagar.Margin = new System.Windows.Forms.Padding(4);
            this.gvContaPagar.Name = "gvContaPagar";
            this.gvContaPagar.ReadOnly = true;
            this.gvContaPagar.RowHeadersWidth = 51;
            this.gvContaPagar.Size = new System.Drawing.Size(753, 362);
            this.gvContaPagar.TabIndex = 275;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(159, 468);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 42);
            this.btnNovo.TabIndex = 279;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnBuscarContaPagar
            // 
            this.btnBuscarContaPagar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarContaPagar.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarContaPagar.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarContaPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarContaPagar.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarContaPagar.Location = new System.Drawing.Point(491, 15);
            this.btnBuscarContaPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarContaPagar.Name = "btnBuscarContaPagar";
            this.btnBuscarContaPagar.Size = new System.Drawing.Size(66, 54);
            this.btnBuscarContaPagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarContaPagar.TabIndex = 278;
            this.btnBuscarContaPagar.TabStop = false;
            // 
            // sistemaMoto2DataSetContaReceber
            // 
            this.sistemaMoto2DataSetContaReceber.DataSetName = "SistemaMoto2DataSetContaReceber";
            this.sistemaMoto2DataSetContaReceber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contaReceberBindingSource
            // 
            this.contaReceberBindingSource.DataMember = "contaReceber";
            this.contaReceberBindingSource.DataSource = this.sistemaMoto2DataSetContaReceber;
            // 
            // contaReceberTableAdapter
            // 
            this.contaReceberTableAdapter.ClearBeforeFill = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "serie";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrNotaDataGridViewTextBoxColumn
            // 
            this.nrNotaDataGridViewTextBoxColumn.DataPropertyName = "nrNota";
            this.nrNotaDataGridViewTextBoxColumn.HeaderText = "nrNota";
            this.nrNotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrNotaDataGridViewTextBoxColumn.Name = "nrNotaDataGridViewTextBoxColumn";
            this.nrNotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrNotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            this.codClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrParcelaDataGridViewTextBoxColumn
            // 
            this.nrParcelaDataGridViewTextBoxColumn.DataPropertyName = "nrParcela";
            this.nrParcelaDataGridViewTextBoxColumn.HeaderText = "nrParcela";
            this.nrParcelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrParcelaDataGridViewTextBoxColumn.Name = "nrParcelaDataGridViewTextBoxColumn";
            this.nrParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrParcelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // codFormaPagamentoDataGridViewTextBoxColumn
            // 
            this.codFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "codFormaPagamento";
            this.codFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "codFormaPagamento";
            this.codFormaPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFormaPagamentoDataGridViewTextBoxColumn.Name = "codFormaPagamentoDataGridViewTextBoxColumn";
            this.codFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFormaPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtEmissaoDataGridViewTextBoxColumn
            // 
            this.dtEmissaoDataGridViewTextBoxColumn.DataPropertyName = "dtEmissao";
            this.dtEmissaoDataGridViewTextBoxColumn.HeaderText = "dtEmissao";
            this.dtEmissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtEmissaoDataGridViewTextBoxColumn.Name = "dtEmissaoDataGridViewTextBoxColumn";
            this.dtEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtEmissaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtVencimentoDataGridViewTextBoxColumn
            // 
            this.dtVencimentoDataGridViewTextBoxColumn.DataPropertyName = "dtVencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.HeaderText = "dtVencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtVencimentoDataGridViewTextBoxColumn.Name = "dtVencimentoDataGridViewTextBoxColumn";
            this.dtVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorParcelaDataGridViewTextBoxColumn
            // 
            this.valorParcelaDataGridViewTextBoxColumn.DataPropertyName = "valorParcela";
            this.valorParcelaDataGridViewTextBoxColumn.HeaderText = "valorParcela";
            this.valorParcelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorParcelaDataGridViewTextBoxColumn.Name = "valorParcelaDataGridViewTextBoxColumn";
            this.valorParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorParcelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Width = 125;
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
            // pagoDataGridViewCheckBoxColumn
            // 
            this.pagoDataGridViewCheckBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewCheckBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.pagoDataGridViewCheckBoxColumn.Name = "pagoDataGridViewCheckBoxColumn";
            this.pagoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pagoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // frmConsultaContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 520);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnBuscarContaPagar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvContaPagar);
            this.Name = "frmConsultaContaReceber";
            this.Text = "Consultar Contas à Receber";
            this.Load += new System.EventHandler(this.frmConsultaContaReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvContaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarContaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetContaReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox btnBuscarContaPagar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvContaPagar;
        private SistemaMoto2DataSetContaReceber sistemaMoto2DataSetContaReceber;
        private System.Windows.Forms.BindingSource contaReceberBindingSource;
        private SistemaMoto2DataSetContaReceberTableAdapters.contaReceberTableAdapter contaReceberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagoDataGridViewCheckBoxColumn;
    }
}