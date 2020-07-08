namespace EquipMotos.View
{
    partial class frmConsultaVenda
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
            this.btnBuscarVenda = new System.Windows.Forms.PictureBox();
            this.gvVendas = new System.Windows.Forms.DataGridView();
            this.nrNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCondPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaMoto2DataSetVenda = new EquipMotos.SistemaMoto2DataSetVenda();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.vendasTableAdapter = new EquipMotos.SistemaMoto2DataSetVendaTableAdapters.vendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarVenda
            // 
            this.btnBuscarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarVenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarVenda.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarVenda.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarVenda.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarVenda.Location = new System.Drawing.Point(476, 80);
            this.btnBuscarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarVenda.Name = "btnBuscarVenda";
            this.btnBuscarVenda.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarVenda.TabIndex = 265;
            this.btnBuscarVenda.TabStop = false;
            this.btnBuscarVenda.Click += new System.EventHandler(this.btnBuscarVenda_Click);
            // 
            // gvVendas
            // 
            this.gvVendas.AllowUserToAddRows = false;
            this.gvVendas.AllowUserToDeleteRows = false;
            this.gvVendas.AllowUserToOrderColumns = true;
            this.gvVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvVendas.AutoGenerateColumns = false;
            this.gvVendas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrNotaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.codClienteDataGridViewTextBoxColumn,
            this.codCondPagamentoDataGridViewTextBoxColumn,
            this.dtEmissaoDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.gvVendas.DataSource = this.vendasBindingSource;
            this.gvVendas.EnableHeadersVisualStyles = false;
            this.gvVendas.Location = new System.Drawing.Point(37, 142);
            this.gvVendas.Margin = new System.Windows.Forms.Padding(4);
            this.gvVendas.Name = "gvVendas";
            this.gvVendas.ReadOnly = true;
            this.gvVendas.RowHeadersWidth = 51;
            this.gvVendas.Size = new System.Drawing.Size(860, 424);
            this.gvVendas.TabIndex = 264;
            // 
            // nrNotaDataGridViewTextBoxColumn
            // 
            this.nrNotaDataGridViewTextBoxColumn.DataPropertyName = "nrNota";
            this.nrNotaDataGridViewTextBoxColumn.HeaderText = "Nrº Nota";
            this.nrNotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrNotaDataGridViewTextBoxColumn.Name = "nrNotaDataGridViewTextBoxColumn";
            this.nrNotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrNotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 125;
            // 
            // codClienteDataGridViewTextBoxColumn
            // 
            this.codClienteDataGridViewTextBoxColumn.DataPropertyName = "codCliente";
            this.codClienteDataGridViewTextBoxColumn.HeaderText = "Codigo Cliente";
            this.codClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codClienteDataGridViewTextBoxColumn.Name = "codClienteDataGridViewTextBoxColumn";
            this.codClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // codCondPagamentoDataGridViewTextBoxColumn
            // 
            this.codCondPagamentoDataGridViewTextBoxColumn.DataPropertyName = "codCondPagamento";
            this.codCondPagamentoDataGridViewTextBoxColumn.HeaderText = "Codigo Condição Pagamento";
            this.codCondPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codCondPagamentoDataGridViewTextBoxColumn.Name = "codCondPagamentoDataGridViewTextBoxColumn";
            this.codCondPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCondPagamentoDataGridViewTextBoxColumn.Width = 125;
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
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 125;
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
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.sistemaMoto2DataSetVenda;
            // 
            // sistemaMoto2DataSetVenda
            // 
            this.sistemaMoto2DataSetVenda.DataSetName = "SistemaMoto2DataSetVenda";
            this.sistemaMoto2DataSetVenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(648, 602);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 263;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(808, 602);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 262;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.Depth = 0;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(432, 602);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 260;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Depth = 0;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(37, 102);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(433, 23);
            this.txtPesquisar.TabIndex = 259;
            this.txtPesquisar.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 258;
            this.label1.Text = "Pesquisar Vendas";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(540, 602);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 261;
            this.btnAlterar.Text = "VISUALIZAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscarVenda);
            this.Controls.Add(this.gvVendas);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Vendas";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBuscarVenda;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        public MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private SistemaMoto2DataSetVenda sistemaMoto2DataSetVenda;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private SistemaMoto2DataSetVendaTableAdapters.vendasTableAdapter vendasTableAdapter;
        public System.Windows.Forms.DataGridView gvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCondPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}