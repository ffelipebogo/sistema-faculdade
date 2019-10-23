﻿namespace EquipMotos.View
{
    partial class frmConsultaProdutosServicos
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
            this.gvProdutos = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaMoto2DataSetProduto = new EquipMotos.SistemaMoto2DataSetProduto();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbServico = new System.Windows.Forms.RadioButton();
            this.produtosTableAdapter = new EquipMotos.SistemaMoto2DataSetProdutoTableAdapters.produtosTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdutoGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codBarraGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoUltCompraGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtUltCompraGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissaoGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obeservacoesGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
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
            this.prdutoGridViewTextBoxColumn,
            this.unidadeGridViewTextBoxColumn,
            this.codBarraGridViewTextBoxColumn,
            this.codCategoriaDataGridViewTextBoxColumn,
            this.qtdGridViewTextBoxColumn,
            this.precoCustoGridViewTextBoxColumn,
            this.codFornecedorDataGridViewTextBoxColumn,
            this.custoUltCompraGridViewTextBoxColumn,
            this.dtUltCompraGridViewTextBoxColumn,
            this.comissaoGridViewTextBoxColumn,
            this.obeservacoesGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.servicoDataGridViewCheckBoxColumn,
            this.codFuncionarioDataGridViewTextBoxColumn});
            this.gvProdutos.DataSource = this.produtosBindingSource;
            this.gvProdutos.EnableHeadersVisualStyles = false;
            this.gvProdutos.Location = new System.Drawing.Point(29, 96);
            this.gvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.ReadOnly = true;
            this.gvProdutos.RowHeadersWidth = 51;
            this.gvProdutos.Size = new System.Drawing.Size(1171, 497);
            this.gvProdutos.TabIndex = 20;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.sistemaMoto2DataSetProduto;
            // 
            // sistemaMoto2DataSetProduto
            // 
            this.sistemaMoto2DataSetProduto.DataSetName = "SistemaMoto2DataSetProduto";
            this.sistemaMoto2DataSetProduto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1055, 615);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(145, 42);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(28, 43);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(673, 26);
            this.txtPesquisar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pesquisar Produtos e Servicos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(861, 615);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 42);
            this.btnExcluir.TabIndex = 19;
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
            this.btnAlterar.Location = new System.Drawing.Point(711, 615);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(143, 42);
            this.btnAlterar.TabIndex = 17;
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
            this.btnNovo.Location = new System.Drawing.Point(581, 615);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 42);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscar.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscar.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscar.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscar.Location = new System.Drawing.Point(711, 26);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 62);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscar.TabIndex = 277;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Location = new System.Drawing.Point(844, 26);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(125, 21);
            this.rbProduto.TabIndex = 278;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Listar Produtos";
            this.rbProduto.UseVisualStyleBackColor = true;
            this.rbProduto.CheckedChanged += new System.EventHandler(this.RbProduto_CheckedChanged);
            // 
            // rbServico
            // 
            this.rbServico.AutoSize = true;
            this.rbServico.Location = new System.Drawing.Point(844, 53);
            this.rbServico.Name = "rbServico";
            this.rbServico.Size = new System.Drawing.Size(122, 21);
            this.rbServico.TabIndex = 279;
            this.rbServico.TabStop = true;
            this.rbServico.Text = "Listar Serviços";
            this.rbServico.UseVisualStyleBackColor = true;
            this.rbServico.CheckedChanged += new System.EventHandler(this.RbServico_CheckedChanged);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
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
            // prdutoGridViewTextBoxColumn
            // 
            this.prdutoGridViewTextBoxColumn.DataPropertyName = "produto";
            this.prdutoGridViewTextBoxColumn.HeaderText = "produto";
            this.prdutoGridViewTextBoxColumn.MinimumWidth = 6;
            this.prdutoGridViewTextBoxColumn.Name = "prdutoGridViewTextBoxColumn";
            this.prdutoGridViewTextBoxColumn.ReadOnly = true;
            this.prdutoGridViewTextBoxColumn.Width = 125;
            // 
            // unidadeGridViewTextBoxColumn
            // 
            this.unidadeGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeGridViewTextBoxColumn.HeaderText = "unidade";
            this.unidadeGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadeGridViewTextBoxColumn.Name = "unidadeGridViewTextBoxColumn";
            this.unidadeGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeGridViewTextBoxColumn.Width = 125;
            // 
            // codBarraGridViewTextBoxColumn
            // 
            this.codBarraGridViewTextBoxColumn.DataPropertyName = "codBarra";
            this.codBarraGridViewTextBoxColumn.HeaderText = "codBarra";
            this.codBarraGridViewTextBoxColumn.MinimumWidth = 6;
            this.codBarraGridViewTextBoxColumn.Name = "codBarraGridViewTextBoxColumn";
            this.codBarraGridViewTextBoxColumn.ReadOnly = true;
            this.codBarraGridViewTextBoxColumn.Width = 125;
            // 
            // codCategoriaDataGridViewTextBoxColumn
            // 
            this.codCategoriaDataGridViewTextBoxColumn.DataPropertyName = "codCategoria";
            this.codCategoriaDataGridViewTextBoxColumn.HeaderText = "codCategoria";
            this.codCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codCategoriaDataGridViewTextBoxColumn.Name = "codCategoriaDataGridViewTextBoxColumn";
            this.codCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtdGridViewTextBoxColumn
            // 
            this.qtdGridViewTextBoxColumn.DataPropertyName = "qtd";
            this.qtdGridViewTextBoxColumn.HeaderText = "qtd";
            this.qtdGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtdGridViewTextBoxColumn.Name = "qtdGridViewTextBoxColumn";
            this.qtdGridViewTextBoxColumn.ReadOnly = true;
            this.qtdGridViewTextBoxColumn.Width = 125;
            // 
            // precoCustoGridViewTextBoxColumn
            // 
            this.precoCustoGridViewTextBoxColumn.DataPropertyName = "precoCusto";
            this.precoCustoGridViewTextBoxColumn.HeaderText = "precoCusto";
            this.precoCustoGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoCustoGridViewTextBoxColumn.Name = "precoCustoGridViewTextBoxColumn";
            this.precoCustoGridViewTextBoxColumn.ReadOnly = true;
            this.precoCustoGridViewTextBoxColumn.Width = 125;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "codFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // custoUltCompraGridViewTextBoxColumn
            // 
            this.custoUltCompraGridViewTextBoxColumn.DataPropertyName = "custoUltCompra";
            this.custoUltCompraGridViewTextBoxColumn.HeaderText = "custoUltCompra";
            this.custoUltCompraGridViewTextBoxColumn.MinimumWidth = 6;
            this.custoUltCompraGridViewTextBoxColumn.Name = "custoUltCompraGridViewTextBoxColumn";
            this.custoUltCompraGridViewTextBoxColumn.ReadOnly = true;
            this.custoUltCompraGridViewTextBoxColumn.Width = 125;
            // 
            // dtUltCompraGridViewTextBoxColumn
            // 
            this.dtUltCompraGridViewTextBoxColumn.DataPropertyName = "dtUltCompra";
            this.dtUltCompraGridViewTextBoxColumn.HeaderText = "dtUltCompra";
            this.dtUltCompraGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtUltCompraGridViewTextBoxColumn.Name = "dtUltCompraGridViewTextBoxColumn";
            this.dtUltCompraGridViewTextBoxColumn.ReadOnly = true;
            this.dtUltCompraGridViewTextBoxColumn.Width = 125;
            // 
            // comissaoGridViewTextBoxColumn
            // 
            this.comissaoGridViewTextBoxColumn.DataPropertyName = "comissao";
            this.comissaoGridViewTextBoxColumn.HeaderText = "comissao";
            this.comissaoGridViewTextBoxColumn.MinimumWidth = 6;
            this.comissaoGridViewTextBoxColumn.Name = "comissaoGridViewTextBoxColumn";
            this.comissaoGridViewTextBoxColumn.ReadOnly = true;
            this.comissaoGridViewTextBoxColumn.Width = 125;
            // 
            // obeservacoesGridViewTextBoxColumn
            // 
            this.obeservacoesGridViewTextBoxColumn.DataPropertyName = "observacoes";
            this.obeservacoesGridViewTextBoxColumn.HeaderText = "observacoes";
            this.obeservacoesGridViewTextBoxColumn.MinimumWidth = 6;
            this.obeservacoesGridViewTextBoxColumn.Name = "obeservacoesGridViewTextBoxColumn";
            this.obeservacoesGridViewTextBoxColumn.ReadOnly = true;
            this.obeservacoesGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "dtCadastro";
            this.dataGridViewTextBoxColumn10.HeaderText = "dtCadastro";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dtAlteracao";
            this.dataGridViewTextBoxColumn11.HeaderText = "dtAlteracao";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn12.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // servicoDataGridViewCheckBoxColumn
            // 
            this.servicoDataGridViewCheckBoxColumn.DataPropertyName = "servico";
            this.servicoDataGridViewCheckBoxColumn.HeaderText = "servico";
            this.servicoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.servicoDataGridViewCheckBoxColumn.Name = "servicoDataGridViewCheckBoxColumn";
            this.servicoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.servicoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // codFuncionarioDataGridViewTextBoxColumn
            // 
            this.codFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "codFuncionario";
            this.codFuncionarioDataGridViewTextBoxColumn.HeaderText = "codFuncionario";
            this.codFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codFuncionarioDataGridViewTextBoxColumn.Name = "codFuncionarioDataGridViewTextBoxColumn";
            this.codFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFuncionarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmConsultaProdutosServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 670);
            this.ControlBox = false;
            this.Controls.Add(this.rbServico);
            this.Controls.Add(this.rbProduto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvProdutos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaProdutosServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produtos e Servicos";
            this.Load += new System.EventHandler(this.FrmConsultaProdutosServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gvProdutos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbServico;
        private SistemaMoto2DataSetProduto sistemaMoto2DataSetProduto;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private SistemaMoto2DataSetProdutoTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdutoGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBarraGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoUltCompraGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtUltCompraGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissaoGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obeservacoesGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn servicoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFuncionarioDataGridViewTextBoxColumn;
    }
}