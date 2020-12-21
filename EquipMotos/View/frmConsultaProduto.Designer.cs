namespace EquipMotos.VIEW
{
    partial class frmConsultaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.gvProdutos = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaMoto2DataSetProdutos = new EquipMotos.SistemaMoto2DataSetProdutos();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.produtosTableAdapter = new EquipMotos.SistemaMoto2DataSetProdutosTableAdapters.produtosTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoUltCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtUltCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaProduto.Location = new System.Drawing.Point(11, 116);
            this.txtPesquisaProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(400, 23);
            this.txtPesquisaProduto.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pesquisar Produtos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscar.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscar.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscar.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscar.Location = new System.Drawing.Point(417, 98);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 50);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscar.TabIndex = 277;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gvProdutos
            // 
            this.gvProdutos.AllowUserToAddRows = false;
            this.gvProdutos.AllowUserToDeleteRows = false;
            this.gvProdutos.AllowUserToOrderColumns = true;
            this.gvProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvProdutos.AutoGenerateColumns = false;
            this.gvProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.categoria,
            this.fornecedor,
            this.qtdDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.precoCustoDataGridViewTextBoxColumn,
            this.codFornecedorDataGridViewTextBoxColumn,
            this.codCategoriaDataGridViewTextBoxColumn,
            this.codBarraDataGridViewTextBoxColumn,
            this.custoUltCompraDataGridViewTextBoxColumn,
            this.dtUltCompraDataGridViewTextBoxColumn,
            this.comissaoDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.gvProdutos.DataSource = this.produtosBindingSource;
            this.gvProdutos.EnableHeadersVisualStyles = false;
            this.gvProdutos.Location = new System.Drawing.Point(12, 156);
            this.gvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.ReadOnly = true;
            this.gvProdutos.RowHeadersWidth = 51;
            this.gvProdutos.Size = new System.Drawing.Size(1017, 450);
            this.gvProdutos.TabIndex = 278;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.sistemaMoto2DataSetProdutos;
            // 
            // sistemaMoto2DataSetProdutos
            // 
            this.sistemaMoto2DataSetProdutos.DataSetName = "SistemaMoto2DataSetProdutos";
            this.sistemaMoto2DataSetProdutos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(704, 628);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(100, 30);
            this.btnExcluir.TabIndex = 282;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(888, 628);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Primary = true;
            this.btnVoltar.Size = new System.Drawing.Size(115, 30);
            this.btnVoltar.TabIndex = 281;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(596, 628);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(100, 30);
            this.btnAlterar.TabIndex = 280;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.Depth = 0;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(488, 628);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = true;
            this.btnNovo.Size = new System.Drawing.Size(100, 30);
            this.btnNovo.TabIndex = 279;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.codigoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 60;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn.Width = 200;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "UND";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Width = 50;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "fornecedor";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            this.fornecedor.Visible = false;
            // 
            // qtdDataGridViewTextBoxColumn
            // 
            this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qtdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtdDataGridViewTextBoxColumn.HeaderText = "QTD";
            this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
            this.qtdDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdDataGridViewTextBoxColumn.Width = 50;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "precoVenda";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precoVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preço_Venda";
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoVendaDataGridViewTextBoxColumn.Width = 80;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "valorUnitario";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.valorUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "Vlr_Unit.";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioDataGridViewTextBoxColumn.Visible = false;
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 60;
            // 
            // precoCustoDataGridViewTextBoxColumn
            // 
            this.precoCustoDataGridViewTextBoxColumn.DataPropertyName = "precoCusto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precoCustoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.precoCustoDataGridViewTextBoxColumn.HeaderText = "Preço_Custo";
            this.precoCustoDataGridViewTextBoxColumn.Name = "precoCustoDataGridViewTextBoxColumn";
            this.precoCustoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoCustoDataGridViewTextBoxColumn.Width = 70;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "codFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // codCategoriaDataGridViewTextBoxColumn
            // 
            this.codCategoriaDataGridViewTextBoxColumn.DataPropertyName = "codCategoria";
            this.codCategoriaDataGridViewTextBoxColumn.HeaderText = "codCategoria";
            this.codCategoriaDataGridViewTextBoxColumn.Name = "codCategoriaDataGridViewTextBoxColumn";
            this.codCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codBarraDataGridViewTextBoxColumn
            // 
            this.codBarraDataGridViewTextBoxColumn.DataPropertyName = "codBarra";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.codBarraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.codBarraDataGridViewTextBoxColumn.HeaderText = "Cod_Barra";
            this.codBarraDataGridViewTextBoxColumn.Name = "codBarraDataGridViewTextBoxColumn";
            this.codBarraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codBarraDataGridViewTextBoxColumn.Visible = false;
            // 
            // custoUltCompraDataGridViewTextBoxColumn
            // 
            this.custoUltCompraDataGridViewTextBoxColumn.DataPropertyName = "custoUltCompra";
            this.custoUltCompraDataGridViewTextBoxColumn.HeaderText = "custoUltCompra";
            this.custoUltCompraDataGridViewTextBoxColumn.Name = "custoUltCompraDataGridViewTextBoxColumn";
            this.custoUltCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.custoUltCompraDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtUltCompraDataGridViewTextBoxColumn
            // 
            this.dtUltCompraDataGridViewTextBoxColumn.DataPropertyName = "dtUltCompra";
            this.dtUltCompraDataGridViewTextBoxColumn.HeaderText = "dtUltCompra";
            this.dtUltCompraDataGridViewTextBoxColumn.Name = "dtUltCompraDataGridViewTextBoxColumn";
            this.dtUltCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtUltCompraDataGridViewTextBoxColumn.Visible = false;
            // 
            // comissaoDataGridViewTextBoxColumn
            // 
            this.comissaoDataGridViewTextBoxColumn.DataPropertyName = "comissao";
            this.comissaoDataGridViewTextBoxColumn.HeaderText = "comissao";
            this.comissaoDataGridViewTextBoxColumn.Name = "comissaoDataGridViewTextBoxColumn";
            this.comissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.comissaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtCadastroDataGridViewTextBoxColumn
            // 
            this.dtCadastroDataGridViewTextBoxColumn.DataPropertyName = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.HeaderText = "dtCadastro";
            this.dtCadastroDataGridViewTextBoxColumn.Name = "dtCadastroDataGridViewTextBoxColumn";
            this.dtCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtCadastroDataGridViewTextBoxColumn.Visible = false;
            // 
            // dtAlteracaoDataGridViewTextBoxColumn
            // 
            this.dtAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.HeaderText = "dtAlteracao";
            this.dtAlteracaoDataGridViewTextBoxColumn.Name = "dtAlteracaoDataGridViewTextBoxColumn";
            this.dtAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtAlteracaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 683);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gvProdutos);
            this.Controls.Add(this.txtPesquisaProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produtos";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBuscar;
        public System.Windows.Forms.DataGridView gvProdutos;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
        public MaterialSkin.Controls.MaterialRaisedButton btnVoltar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNovo;
        private SistemaMoto2DataSetProdutos sistemaMoto2DataSetProdutos;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private SistemaMoto2DataSetProdutosTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoUltCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtUltCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}