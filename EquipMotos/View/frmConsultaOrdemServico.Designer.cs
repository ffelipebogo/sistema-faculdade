﻿namespace EquipMotos.View
{
    partial class frmConsultaOrdemServico
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
            this.btnBuscarOS = new System.Windows.Forms.PictureBox();
            this.gvOS = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sistemaMoto2DataSetOrdemServico = new EquipMotos.SistemaMoto2DataSetOrdemServico();
            this.ordemServicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordemServicosTableAdapter = new EquipMotos.SistemaMoto2DataSetOrdemServicoTableAdapters.ordemServicosTableAdapter();
            this.numeroOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorServDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCondPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetOrdemServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarOS
            // 
            this.btnBuscarOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarOS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBuscarOS.ErrorImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarOS.Image = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarOS.InitialImage = global::EquipMotos.Properties.Resources._1398754683_xmag;
            this.btnBuscarOS.Location = new System.Drawing.Point(551, 10);
            this.btnBuscarOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarOS.Name = "btnBuscarOS";
            this.btnBuscarOS.Size = new System.Drawing.Size(75, 62);
            this.btnBuscarOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarOS.TabIndex = 273;
            this.btnBuscarOS.TabStop = false;
            this.btnBuscarOS.Click += new System.EventHandler(this.btnBuscarOS_Click);
            // 
            // gvOS
            // 
            this.gvOS.AllowUserToAddRows = false;
            this.gvOS.AllowUserToDeleteRows = false;
            this.gvOS.AllowUserToOrderColumns = true;
            this.gvOS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvOS.AutoGenerateColumns = false;
            this.gvOS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroOSDataGridViewTextBoxColumn,
            this.dataOSDataGridViewTextBoxColumn,
            this.codClienteDataGridViewTextBoxColumn,
            this.codVeiculoDataGridViewTextBoxColumn,
            this.codProdutoDataGridViewTextBoxColumn,
            this.codServicoDataGridViewTextBoxColumn,
            this.codFuncionarioDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.qtdDataGridViewTextBoxColumn,
            this.valorProdDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.valorServDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.codCondPagamentoDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.dtCadastroDataGridViewTextBoxColumn,
            this.dtAlteracaoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.gvOS.DataSource = this.ordemServicosBindingSource;
            this.gvOS.EnableHeadersVisualStyles = false;
            this.gvOS.Location = new System.Drawing.Point(16, 91);
            this.gvOS.Margin = new System.Windows.Forms.Padding(4);
            this.gvOS.Name = "gvOS";
            this.gvOS.ReadOnly = true;
            this.gvOS.RowHeadersWidth = 51;
            this.gvOS.Size = new System.Drawing.Size(968, 497);
            this.gvOS.TabIndex = 272;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::EquipMotos.Properties.Resources._1398756469_Erase;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(591, 622);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 42);
            this.btnExcluir.TabIndex = 271;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(789, 622);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(153, 42);
            this.btnVoltar.TabIndex = 270;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::EquipMotos.Properties.Resources._1398756462_Modify;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(426, 622);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(139, 42);
            this.btnAlterar.TabIndex = 269;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::EquipMotos.Properties.Resources._1398756346_1;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(295, 622);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 42);
            this.btnNovo.TabIndex = 268;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(15, 38);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(495, 26);
            this.txtPesquisar.TabIndex = 267;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 266;
            this.label1.Text = "Pesquisar Ordem de Serviço";
            // 
            // sistemaMoto2DataSetOrdemServico
            // 
            this.sistemaMoto2DataSetOrdemServico.DataSetName = "SistemaMoto2DataSetOrdemServico";
            this.sistemaMoto2DataSetOrdemServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordemServicosBindingSource
            // 
            this.ordemServicosBindingSource.DataMember = "ordemServicos";
            this.ordemServicosBindingSource.DataSource = this.sistemaMoto2DataSetOrdemServico;
            // 
            // ordemServicosTableAdapter
            // 
            this.ordemServicosTableAdapter.ClearBeforeFill = true;
            // 
            // numeroOSDataGridViewTextBoxColumn
            // 
            this.numeroOSDataGridViewTextBoxColumn.DataPropertyName = "numeroOS";
            this.numeroOSDataGridViewTextBoxColumn.HeaderText = "numeroOS";
            this.numeroOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroOSDataGridViewTextBoxColumn.Name = "numeroOSDataGridViewTextBoxColumn";
            this.numeroOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataOSDataGridViewTextBoxColumn
            // 
            this.dataOSDataGridViewTextBoxColumn.DataPropertyName = "dataOS";
            this.dataOSDataGridViewTextBoxColumn.HeaderText = "dataOS";
            this.dataOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataOSDataGridViewTextBoxColumn.Name = "dataOSDataGridViewTextBoxColumn";
            this.dataOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataOSDataGridViewTextBoxColumn.Width = 125;
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
            // codVeiculoDataGridViewTextBoxColumn
            // 
            this.codVeiculoDataGridViewTextBoxColumn.DataPropertyName = "codVeiculo";
            this.codVeiculoDataGridViewTextBoxColumn.HeaderText = "codVeiculo";
            this.codVeiculoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codVeiculoDataGridViewTextBoxColumn.Name = "codVeiculoDataGridViewTextBoxColumn";
            this.codVeiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVeiculoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "codProduto";
            this.codProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codServicoDataGridViewTextBoxColumn
            // 
            this.codServicoDataGridViewTextBoxColumn.DataPropertyName = "codServico";
            this.codServicoDataGridViewTextBoxColumn.HeaderText = "codServico";
            this.codServicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codServicoDataGridViewTextBoxColumn.Name = "codServicoDataGridViewTextBoxColumn";
            this.codServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codServicoDataGridViewTextBoxColumn.Width = 125;
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
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "ano";
            this.anoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            this.anoDataGridViewTextBoxColumn.ReadOnly = true;
            this.anoDataGridViewTextBoxColumn.Width = 125;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "placa";
            this.placaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "km";
            this.kmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            this.kmDataGridViewTextBoxColumn.ReadOnly = true;
            this.kmDataGridViewTextBoxColumn.Width = 125;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "cor";
            this.corDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            this.corDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtdDataGridViewTextBoxColumn
            // 
            this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
            this.qtdDataGridViewTextBoxColumn.HeaderText = "qtd";
            this.qtdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
            this.qtdDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtdDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorProdDataGridViewTextBoxColumn
            // 
            this.valorProdDataGridViewTextBoxColumn.DataPropertyName = "valorProd";
            this.valorProdDataGridViewTextBoxColumn.HeaderText = "valorProd";
            this.valorProdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorProdDataGridViewTextBoxColumn.Name = "valorProdDataGridViewTextBoxColumn";
            this.valorProdDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorProdDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "desconto";
            this.descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorServDataGridViewTextBoxColumn
            // 
            this.valorServDataGridViewTextBoxColumn.DataPropertyName = "valorServ";
            this.valorServDataGridViewTextBoxColumn.HeaderText = "valorServ";
            this.valorServDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorServDataGridViewTextBoxColumn.Name = "valorServDataGridViewTextBoxColumn";
            this.valorServDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorServDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // codCondPagamentoDataGridViewTextBoxColumn
            // 
            this.codCondPagamentoDataGridViewTextBoxColumn.DataPropertyName = "codCondPagamento";
            this.codCondPagamentoDataGridViewTextBoxColumn.HeaderText = "codCondPagamento";
            this.codCondPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codCondPagamentoDataGridViewTextBoxColumn.Name = "codCondPagamentoDataGridViewTextBoxColumn";
            this.codCondPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCondPagamentoDataGridViewTextBoxColumn.Width = 125;
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
            // frmConsultaOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 677);
            this.Controls.Add(this.btnBuscarOS);
            this.Controls.Add(this.gvOS);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaOrdemServico";
            this.Text = "frmConsultaOrdemServico";
            this.Load += new System.EventHandler(this.frmConsultaOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaMoto2DataSetOrdemServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordemServicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBuscarOS;
        private System.Windows.Forms.DataGridView gvOS;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private SistemaMoto2DataSetOrdemServico sistemaMoto2DataSetOrdemServico;
        private System.Windows.Forms.BindingSource ordemServicosBindingSource;
        private SistemaMoto2DataSetOrdemServicoTableAdapters.ordemServicosTableAdapter ordemServicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorServDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCondPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}