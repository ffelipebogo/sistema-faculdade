namespace EquipMotos.View
{
    partial class frmConsultaContaPagar
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
            this.contaPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaMoto2DataSetContasPagar = new EquipMotos.SistemaMoto2DataSetContasPagar();
            this.contaPagarTableAdapter = new EquipMotos.SistemaMoto2DataSetContasPagarTableAdapters.contaPagarTableAdapter();
            this.gvContaPagar = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFormaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnBuscarContaPagar = new System.Windows.Forms.PictureBox();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.contaPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetContasPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarContaPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // contaPagarBindingSource
            // 
            this.contaPagarBindingSource.DataMember = "contaPagar";
            this.contaPagarBindingSource.DataSource = this.sistemaMoto2DataSetContasPagar;
            // 
            // sistemaMoto2DataSetContasPagar
            // 
            this.sistemaMoto2DataSetContasPagar.DataSetName = "SistemaMoto2DataSetContasPagar";
            this.sistemaMoto2DataSetContasPagar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contaPagarTableAdapter
            // 
            this.contaPagarTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.codFornecedorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.codFormaPagamentoDataGridViewTextBoxColumn,
            this.dtEmissaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.observacoesDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.pagoDataGridViewCheckBoxColumn});
            this.gvContaPagar.DataSource = this.contaPagarBindingSource;
            this.gvContaPagar.EnableHeadersVisualStyles = false;
            this.gvContaPagar.Location = new System.Drawing.Point(17, 141);
            this.gvContaPagar.Name = "gvContaPagar";
            this.gvContaPagar.ReadOnly = true;
            this.gvContaPagar.RowHeadersWidth = 51;
            this.gvContaPagar.Size = new System.Drawing.Size(565, 294);
            this.gvContaPagar.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nrNota";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nrº Nota";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "serie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "Codigo Fornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nrParcela";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nr Parcela";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // codFormaPagamentoDataGridViewTextBoxColumn
            // 
            this.codFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "codFormaPagamento";
            this.codFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "Codigo Forma Pagamento";
            this.codFormaPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFormaPagamentoDataGridViewTextBoxColumn.Name = "codFormaPagamentoDataGridViewTextBoxColumn";
            this.codFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFormaPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtEmissaoDataGridViewTextBoxColumn
            // 
            this.dtEmissaoDataGridViewTextBoxColumn.DataPropertyName = "dtEmissao";
            this.dtEmissaoDataGridViewTextBoxColumn.HeaderText = "Data Emissão";
            this.dtEmissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtEmissaoDataGridViewTextBoxColumn.Name = "dtEmissaoDataGridViewTextBoxColumn";
            this.dtEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtEmissaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dtVencimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Vencimento";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valorParcela";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor Parcela";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtCadastroDataGridViewTextBoxColumn
            // 
            this.dtCadastroDataGridViewTextBoxColumn.DataPropertyName = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.HeaderText = "Data Cadastro";
            this.dtCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtCadastroDataGridViewTextBoxColumn.Name = "dtCadastroDataGridViewTextBoxColumn";
            this.dtCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtCadastroDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "Data Alteração";
            this.dtAlteracaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtAlteracaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // pagoDataGridViewCheckBoxColumn
            // 
            this.pagoDataGridViewCheckBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewCheckBoxColumn.HeaderText = "Paga";
            this.pagoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.pagoDataGridViewCheckBoxColumn.Name = "pagoDataGridViewCheckBoxColumn";
            this.pagoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pagoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 268;
            this.label1.Text = "Pesquisar Contas à Pagar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(16, 104);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(355, 23);
            this.txtPesquisar.TabIndex = 269;
            // 
            // btnBuscarContaPagar
            // 
            this.btnBuscarContaPagar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarContaPagar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarContaPagar.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarContaPagar.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarContaPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarContaPagar.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarContaPagar.Location = new System.Drawing.Point(376, 85);
            this.btnBuscarContaPagar.Name = "btnBuscarContaPagar";
            this.btnBuscarContaPagar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarContaPagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarContaPagar.TabIndex = 270;
            this.btnBuscarContaPagar.TabStop = false;
            this.btnBuscarContaPagar.Click += new System.EventHandler(this.btnBuscarContaPagar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Depth = 0;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(132, 461);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 271;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(236, 461);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 272;
            this.btnAlterar.Text = "VISUALIZAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(488, 461);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 273;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(342, 461);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 274;
            this.btnExcluir.Text = "PAGAR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // frmConsultaContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 514);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnBuscarContaPagar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvContaPagar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Contas à Pagar";
            this.Load += new System.EventHandler(this.FrmConsultaContaPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contaPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetContasPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarContaPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimentoDataGridViewTextBoxColumn;
        private SistemaMoto2DataSetContasPagar sistemaMoto2DataSetContasPagar;
        private System.Windows.Forms.BindingSource contaPagarBindingSource;
        private SistemaMoto2DataSetContasPagarTableAdapters.contaPagarTableAdapter contaPagarTableAdapter;
        private System.Windows.Forms.DataGridView gvContaPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.PictureBox btnBuscarContaPagar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        public MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagoDataGridViewCheckBoxColumn;
    }
}