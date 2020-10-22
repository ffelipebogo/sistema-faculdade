using EquipMotos.Codigo.View;
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
using EquipMotos.View.helper;
using EquipMotos.VIEW;
using Microsoft.AspNetCore.Rewrite.Internal;
using Microsoft.Extensions.FileSystemGlobbing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipMotos.View
{
    public partial class frmCadastroOrdemServico : MaterialSkin.Controls.MaterialForm
    {

        OrdemServicos OrdemServico = new OrdemServicos();
        CondicaoPagamentos CondicaoPagamento = new CondicaoPagamentos();

        CtrlOrdemServicos CtrlOrdemServico = new CtrlOrdemServicos();
        CtrlProdutos CtrlProduto = new CtrlProdutos();
        CtrlServicos CtrlServico = new CtrlServicos();
        CtrlClientes CtrlCliente = new CtrlClientes();
        CtrlVendas CtrlVenda = new CtrlVendas();
        CtrlModelos CtrlModelo = new CtrlModelos();
        CtrlCondicaoPagamento CtrlCondicao = new CtrlCondicaoPagamento();
        CtrlFuncionarios CtrlFuncionario = new CtrlFuncionarios();

        public static object Cliente;
        public static object Modelo;
        public static object Produto = null;
        public static object Servico = null;
        public static object Funcionario;
        public static object CondPagamento;

        ToolTip toolTip = new ToolTip();


        public frmCadastroOrdemServico()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnAddProduto, "Adicionar Produto");
            toolTip.SetToolTip(btnAddServico, "Adicionar Servicço");
            toolTip.SetToolTip(btnRemProduto, "Remover Produto");
            toolTip.SetToolTip(btnRemServico, "Adicionar Serviço");

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                OrdemServico = new OrdemServicos();
                var listItemProdutoOS = new List<ItensOrdemServico>();
                var listItemServicoOS = new List<ItensOrdemServico>();
                var modeloOs = "55";
                var serieOs = "1";

                if (String.IsNullOrEmpty(txtNumeroOS.Text))
                {
                    OrdemServico.modelo = modeloOs;
                    OrdemServico.serie = serieOs;
                }
                else
                {
                    var OS = CtrlOrdemServico.BuscarPorID(txtNumeroOS.Text) as OrdemServicos;
                    OrdemServico.modelo = OS.modelo;
                    OrdemServico.serie = OS.serie;
                    OrdemServico.NrNota = OS.NrNota;
                }
                {
                    if (ValidaCampos())
                    {
                        var cliente = new Clientes();
                        cliente.codigo = Convert.ToInt32(txtCodCliente.Text);
                        OrdemServico.Cliente = cliente;

                        var modelo = new Modelos();
                        modelo.codigo = Convert.ToInt32(txtCodVeiculo.Text);
                        OrdemServico.Veiculo = modelo;

                        var condPag = new CondicaoPagamentos();
                        condPag.codigo = Convert.ToInt32(txtCodCondPagamento.Text);
                        OrdemServico.CondPagamento = condPag;

                        OrdemServico.data = txtData.Value;
                        OrdemServico.ano = txtAno.Text;
                        OrdemServico.placa = txtPlaca.Text;
                        OrdemServico.km = txtKm.Text;
                        OrdemServico.cor = txtCor.Text;
                        OrdemServico.observacoes = txtObservacoes.Text;
                        OrdemServico.valorProduto = Decimal.Parse(txtValorProdutos.Text, NumberStyles.Any);
                        OrdemServico.valorServico = Decimal.Parse(txtValorServicos.Text, NumberStyles.Any);
                        OrdemServico.valorTotal = Decimal.Parse(txtValorTotal.Text, NumberStyles.Any);
                        OrdemServico.desconto = Decimal.Parse(txtDescontos.Text, NumberStyles.Any);
                        OrdemServico.dtCadastro = DateTime.Now;
                        OrdemServico.dtAlteracao = DateTime.Now;
                        OrdemServico.usuario = UsuarioLogado.Usuario;

                        for (int i = 0; i < lvProduto.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvProduto.Items[i].SubItems[0].Text);
                            var qtdItem = Convert.ToInt32(lvProduto.Items[i].SubItems[2].Text);
                            var custoItem = Decimal.Parse(lvProduto.Items[i].SubItems[4].Text, NumberStyles.Any);

                            listItemProdutoOS.Add(new ItensOrdemServico()
                            {
                                modelo = OrdemServico.modelo,
                                serie = OrdemServico.serie,
                                nrNota = OrdemServico.NrNota,
                                cliente = OrdemServico.Cliente,
                                Veiculo = OrdemServico.Veiculo,
                                codigo = idItem,
                                qtd = qtdItem,
                                precoVenda = custoItem,
                                dtCadastro = OrdemServico.dtCadastro,
                                dtAlteracao = OrdemServico.dtAlteracao,
                            });
                        }
                        OrdemServico.ListaProduto = listItemProdutoOS;

                        var Mecanico = new Funcionarios();
                        for (int i = 0; i < lvServico.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvServico.Items[i].SubItems[0].Text);
                            var custoItem = Decimal.Parse(lvServico.Items[i].SubItems[4].Text, NumberStyles.Any);
                            var codMecanico = Convert.ToInt32(lvServico.Items[i].SubItems[1].Text);
                            Mecanico.codigo = codMecanico;

                            listItemServicoOS.Add(new ItensOrdemServico()
                            {
                                modelo = OrdemServico.modelo,
                                serie = OrdemServico.serie,
                                nrNota = OrdemServico.NrNota,
                                cliente = OrdemServico.Cliente,
                                Veiculo = OrdemServico.Veiculo,
                                Mecanico = Mecanico,
                                codigo = idItem,
                                precoVenda = custoItem,
                                dtCadastro = OrdemServico.dtCadastro,
                                dtAlteracao = OrdemServico.dtAlteracao,
                            });
                        }
                        OrdemServico.ListaServico = listItemServicoOS;
                        if(btnSalvar.Text == "ALTERAR")
                        {
                            CtrlOrdemServico.Editar(OrdemServico);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            CtrlOrdemServico.Inserir(OrdemServico);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel gerar a OrdemServico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OrdemServico.ListaServico = null;
                        OrdemServico.ListaProduto = null;
                    }
                     //this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //this.LimparCampos();
            }
        }

        internal void Disable()
        {
            txtNumeroOS.Enabled = false;
            txtData.Enabled = false;
            txtCodCliente.Enabled = false;
            txtCliente.Enabled = false;
            txtCelular.Enabled = false;
            txtMarca.Enabled = false;
            txtCodVeiculo.Enabled = false;
            txtVeiculo.Enabled = false;
            txtAno.Enabled = false;
            txtPlaca.Enabled = false;
            txtKm.Enabled = false;
            txtCor.Enabled = false;
            txtCodProduto.Enabled = false;
            txtProduto.Enabled = false;
            txtQtd.Enabled = false;
            txtCodServico.Enabled = false;
            txtServico.Enabled = false;
            txtCodMecanico.Enabled = false;
            txtMecanico.Enabled = false;
            txtValorProdutos.Enabled = false;
            txtValorServicos.Enabled = false;
            txtDescontos.Enabled = false;
            txtValorTotal.Enabled = false;
            txtCodCondPagamento.Enabled = false;
            txtCondPagamento.Enabled = false;
            txtObservacoes.Enabled = false;
            btnLimpar.Visible = false;
            btnBuscarCliente.Enabled = false;
            btnBuscarCondPagamento.Enabled = false;
            btnBuscarFuncionario.Enabled = false;
            btnBuscarProduto.Enabled = false;
            btnBuscarServico.Enabled = false;
            btnSalvar.Visible = false;
            btnAddProduto.Enabled = false;
            btnAddServico.Enabled = false;
            btnRemProduto.Enabled = false;
            btnRemServico.Enabled = false;
            btnFinalizar.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        private void LimparCampos()
        {
            txtNumeroOS.Text = "";
            txtData.Value = DateTime.Now;
            txtCodCliente.Text = "";
            txtCliente.Text = "";
            txtCodVeiculo.Text = "";
            txtVeiculo.Text = "";
            txtAno.Text = "";
            txtPlaca.Text = "";
            txtKm.Text = "";
            txtCor.Text = "";
            txtCodProduto.Text = "";
            txtProduto.Text = "";
            txtQtd.Text = "";
            txtCodServico.Text = "";
            txtServico.Text = "";
            txtCodMecanico.Text = "";
            txtMecanico.Text = "";
            txtValorProdutos.Text = "";
            txtValorServicos.Text = "";
            txtDescontos.Text = "";
            txtValorTotal.Text = "";
            txtCodCondPagamento.Text = "";
            txtCondPagamento.Text = "";
            txtObservacoes.Text = "";
            //txtDtCadastro.Text = "";
            //txtDtAlteracao.Text = "";
            //txtUsuario.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaCampos()
        {
            try
            {

                if (txtData.Value > DateTime.Now && txtData.Value < DateTime.Now)
                {
                    MessageBox.Show("Data inválida, data não pode ser menor ou maior que hoje!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtData.Focus();
                    return false;
                }

                if (txtCliente.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este cliente", "Informe o cliente com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtCliente.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Cliente", "Informe o Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCliente.Focus();
                    return false;
                }
                else if (Convert.ToInt32(txtCodCliente.Text.Trim()) < 0)
                {
                    MessageBox.Show("Código Cliente inválido", "Informe o Código do Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodCliente.Focus();
                    return false;
                }
                if (txtVeiculo.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Não é possivel inserir este veiculo", "Informe o veiculo com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVeiculo.Focus();
                    return false;
                }
                if (String.IsNullOrEmpty(txtVeiculo.Text.Trim()))
                {
                    MessageBox.Show("Faltou informar o Veiculo", "Informe o Veiculo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVeiculo.Focus();
                    return false;
                }
                else if (Convert.ToInt32(txtCodVeiculo.Text) < 0)
                {
                    MessageBox.Show("Código Veiculo inválido", "Informe o Código do Veiculo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodVeiculo.Focus();
                    return false;
                }
                if (txtVeiculo.Text == String.Empty)
                {
                    MessageBox.Show("Faltou informar o Veiculo", "Informe o Veiculo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtVeiculo.Focus();
                    return false;
                }

                if (txtCodCondPagamento.Text == String.Empty & txtCodCondPagamento.Text.Length < 0)
                {
                    MessageBox.Show("Faltou informar o Código da Condição de Pagamento", "Informe o Código da Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodMecanico.Focus();
                    return false;
                }
                else if (Convert.ToInt32(txtCodCondPagamento.Text) < 0)
                {
                    MessageBox.Show("Código da Condição de Pagamento", "Informe o Código da Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodCondPagamento.Focus();
                    return false;
                }
                if (txtCondPagamento.Text == String.Empty)
                {
                    MessageBox.Show("Faltou informar a Condição de Pagamento", "Informe a Condição de Pagamento!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCondPagamento.Focus();
                    return false;
                }

                if (txtAno.Text == String.Empty)
                {
                    txtAno.Text = "0";
                }
                else if (Convert.ToInt32("0" + txtAno.Text) < 0)
                {
                    MessageBox.Show("Ano inválido", "Informe um Ano!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAno.Focus();
                    return false;
                }

                if (!ValidaPlaca(txtPlaca.Text))
                {
                    MessageBox.Show("Placa inválida", "Informe a Placa!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erroo");
                return false;
            }
        }

        public bool ValidaPlaca(string placa)
        {
            Regex rg = new Regex("[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}|[A-Z]{3}-[0-9]{4}");

            return rg.IsMatch(placa);
        }

        private bool ValidaProduto()
        {
            if (String.IsNullOrEmpty(txtCodProduto.Text) & txtCodProduto.Text.Length < 1)
            {
                MessageBox.Show("Faltou informar o Código Produto", "Informe o Código Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            else if (Convert.ToInt32("0" + txtCodProduto.Text) < 1)
            {
                MessageBox.Show("Código Produto inválido", "Informe o Código do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtProduto.Text))
            {
                MessageBox.Show("Faltou informar o Produto", "Informe o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtQtd.Text))
            {
                MessageBox.Show("Faltou informar a Quantidade", "Informe uma Quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtQtd.Text) < 1)
            {
                MessageBox.Show("Quantidade inválida", "Informe a Quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaServico()
        {
            if (String.IsNullOrEmpty(txtCodServico.Text) & txtCodServico.Text.Length < 1)
            {
                MessageBox.Show("Faltou informar o Código Serviço", "Informe o Código Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodServico.Focus();
                return false;
            }
            else if (Convert.ToInt32("0" + txtCodServico.Text) < 1)
            {
                MessageBox.Show("Código Serviço inválido", "Informe o Código do Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodServico.Focus();
                return false;
            }
            if (txtServico.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este servico", "Informe o serviço com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServico.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtServico.Text))
            {
                MessageBox.Show("Faltou informar o Serviço", "Informe o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServico.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtCodMecanico.Text) & txtCodMecanico.Text.Length < 1)
            {
                MessageBox.Show("Faltou informar o Código Mecanico", "Informe o Código Mecanico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodMecanico.Focus();
                return false;
            }
            else if (Convert.ToInt32("0" + txtCodMecanico.Text) < 1)
            {
                MessageBox.Show("Código Mecanico", "Informe o Código do Mecanico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodMecanico.Focus();
                return false;
            }
            if (txtMecanico.Text.Trim().Length > 100)
            {
                MessageBox.Show("Não é possivel inserir este servico", "Informe o serviço com menos de 100 caracteres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMecanico.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtMecanico.Text))
            {
                MessageBox.Show("Faltou informar o Mecanico", "Informe o Mecanico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMecanico.Focus();
                return false;
            }
            return true;
        }

        private void btnBuscarCondPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaCondicaoPagamento frmConCondPag = new frmConsultaCondicaoPagamento();
            frmConCondPag.btnVoltar.Text = "SELECIONAR";
            if (frmConCondPag.ShowDialog() == DialogResult.OK)
            {
                CarregaCondicao();
            }
        }

        private void CarregaCondicao()
        {
            if (CondPagamento != null)
            {
                CondicaoPagamento = CondPagamento as CondicaoPagamentos;
                txtCodCondPagamento.Text = Convert.ToString(CondicaoPagamento.codigo);
                txtCondPagamento.Text = CondicaoPagamento.condicao;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente frmConCliente = new frmConsultaCliente();
            frmConCliente.btnVoltar.Text = "SELECIONAR";
            if (frmConCliente.ShowDialog() == DialogResult.OK)
            {
                CarregaCliente();
            }
        }

        private void CarregaCliente()
        {
            if (Cliente != null)
            {
                Clientes cli = Cliente as Clientes;
                txtCodCliente.Text = Convert.ToString(cli.codigo);
                txtCliente.Text = cli.cliente;
                txtCelular.Text = cli.celular;
            }
        }

        private void btnBuscarVeiculo_Click(object sender, EventArgs e)
        {
            frmConsultaModelo frmConModelo = new frmConsultaModelo();
            frmConModelo.btnVoltar.Text = "SELECIONAR";
            if (frmConModelo.ShowDialog() == DialogResult.OK)
            {
                CarregaModelo();
            }
        }

        private void CarregaModelo()
        {
            if (Modelo != null)
            {
                Modelos mod = Modelo as Modelos;
                txtCodVeiculo.Text = Convert.ToString(mod.codigo);
                txtVeiculo.Text = mod.modelo;
                txtMarca.Text = mod.Marca.marca;
            }
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            frmConsultaProduto frmConProduto = new frmConsultaProduto();
            //for (int i = 0; i < lvProduto.Items.Count; i++)
            //{
            //    frmConProduto.FilterID.Add( lvProduto.Items[i].SubItems[0].Text);
            //}
            frmConProduto.btnVoltar.Text = "SELECIONAR";
            if (frmConProduto.ShowDialog() == DialogResult.OK)
            {
                CarregaProduto();
            }
        }

        private void CarregaProduto()
        {
            if (Produto != null)
            {
                Produtos prod = Produto as Produtos;
                txtCodProduto.Text = Convert.ToString(prod.codigo);
                txtProduto.Text = prod.produto;
                txtVlrProduto.Text = prod.precoVenda.ToString("C", CultureInfo.CurrentCulture);
                Servico = null;
            }
        }

        private void btnBuscarServico_Click(object sender, EventArgs e)
        {
            frmConsultaServico frmConServico = new frmConsultaServico();
            //for (int i = 0; i < lvServico.Items.Count; i++)
            //{
            //    frmConServico.FilterID.Add(lvServico.Items[i].SubItems[0].Text);
            //}
            frmConServico.btnVoltar.Text = "SELECIONAR";
            if (frmConServico.ShowDialog() == DialogResult.OK)
            {
                CarregaServico();
            }
        }

        private void CarregaServico()
        {
            if (Servico != null)
            {
                Servicos serv = Servico as Servicos;
                txtCodServico.Text = Convert.ToString(serv.codigo);
                txtServico.Text = serv.servico;
                txtCodMecanico.Text = Convert.ToString(serv.Funcionario.codigo);
                txtMecanico.Text = serv.Funcionario.funcionario;
                Funcionario = serv.Funcionario;
                // Produto = null;
            }
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario frmConFuncionario = new frmConsultaFuncionario();
            frmConFuncionario.btnVoltar.Text = "SELECIONAR";
            if (frmConFuncionario.ShowDialog() == DialogResult.OK)
            {
                CarregaFuncionario();
            }
        }

        private void CarregaFuncionario()
        {
            if (Funcionario != null)
            {
                Funcionarios func = Funcionario as Funcionarios;
                txtCodMecanico.Text = Convert.ToString(func.codigo);
                txtMecanico.Text = func.funcionario;
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos prod = Produto as Produtos;
                if (ValidaProduto() && prod != null)
                {
                    var qtd = Convert.ToInt32(txtQtd.Text);
                    var totalRow = Convert.ToString(qtd * prod.precoVenda);
                    var codigo = prod.codigo;
                    if (ValidaEstoque(codigo, qtd))
                    {
                        string[] row = { Convert.ToString(prod.codigo), prod.produto, txtQtd.Text, Convert.ToString(prod.precoVenda), Convert.ToString(totalRow) };
                        var lvi = new ListViewItem(row);
                        lvProduto.Items.Add(lvi);

                        var vlTotalincial = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);
                        if (vlTotalincial <= 0)
                        {
                            txtValorProdutos.Text = lvProduto.Items[0].SubItems[4].Text;
                        }
                        else
                        {
                            var vltotal = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);
                            for (int i = 0; i < lvProduto.Items.Count; i++)
                            {
                                txtValorProdutos.Text = Double.Parse(lvProduto.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                            }
                            //vltotal + txtvalortoal
                            var vlTotalGrid = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);
                            var ValorTotal = vltotal + vlTotalGrid;
                            txtValorProdutos.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                        }
                        SomaTotal();
                        txtCodProduto.Text = "";
                        txtProduto.Text = "";
                        txtQtd.Text = "";
                    }
                    //Produto = null;
                }
                else
                {
                    //MessageBox.Show("Produto inválido!", "Informe um produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                MessageBox.Show("Não foi possivel adicionar o produto");
            }
        }

        private bool ValidaEstoque(int codigo, int qtd)
        {
            var qtdItem = qtd;
            var Produto = CtrlProduto.BuscarPorID(codigo) as Produtos;
            if (Produto.qtd < qtdItem)
            {
                MessageBox.Show("Não há estoque para a venda de " + Produto.produto + ", o estoque atual é de " + Produto.qtd, "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            try
            {
                Servicos serv = Servico as Servicos;
                Funcionarios func = Funcionario as Funcionarios;
                if (ValidaServico())
                {
                    var totalRow = Convert.ToString(serv.precoVenda);
                    string[] row = { Convert.ToString(serv.codigo),  serv.servico, Convert.ToString(func.codigo), func.funcionario, Convert.ToString(totalRow) };
                    var lvi = new ListViewItem(row);
                    lvServico.Items.Add(lvi);

                    var vlTotalincial = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
                    if (vlTotalincial <= 0)
                    {
                        txtValorServicos.Text = lvServico.Items[0].SubItems[4].Text;
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
                        for (int i = 0; i < lvServico.Items.Count; i++)
                        {
                            txtValorServicos.Text = Double.Parse(lvServico.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        var vlTotalGrid = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
                        var ValorTotal = vltotal + vlTotalGrid;
                        txtValorServicos.Text = ValorTotal.ToString("C", CultureInfo.CurrentCulture);
                    }
                    SomaTotal();
                    txtCodServico.Text = "";
                    txtServico.Text = "";
                    txtCodMecanico.Text = "";
                    txtMecanico.Text = "";
                    Servico = null;
                }
                else
                {
                    MessageBox.Show("Verifique os campos obrigatorios em branco!");
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel adicionar o serviço");
            }
        }

        private void SomaTotal()
        {
            var total = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
            var totalServico = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
            var totalProduto = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);

            if (totalServico > 0 || totalProduto > 0)
            {
                total = totalServico + totalProduto;
            }
            txtValorTotal.Text = total.ToString("C", CultureInfo.CurrentCulture);
        }

        private void btnRemProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Remover produto ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & (lvProduto.SelectedIndices[0] != null))
                {
                    lvProduto.Items.RemoveAt(lvProduto.SelectedIndices[0]);
                    if (lvProduto.Items.Count > 0)
                    {
                        for (int i = 0; i < lvProduto.Items.Count; i++)
                        {
                            txtValorProdutos.Text = Double.Parse(lvProduto.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                    }
                    else
                    {
                        txtValorProdutos.Text = Double.Parse("0", NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                    }
                    SomaTotal();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um produto! ");
            }
        }

        private void btnRemServico_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Remover serviço ?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) & (lvServico.SelectedIndices[0] != null))
                {
                    lvServico.Items.RemoveAt(lvServico.SelectedIndices[0]);
                    if (lvServico.Items.Count > 0)
                    {
                        for (int i = 0; i < lvServico.Items.Count; i++)
                        {
                            txtValorServicos.Text = Double.Parse(lvServico.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                    }
                    else
                    {
                        txtValorServicos.Text = Double.Parse("0", NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                    }
                    SomaTotal();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um serviço! ");
            }
        }

        internal void Carregar(object codigo)
        {
            OrdemServico = CtrlOrdemServico.BuscarPorID(codigo) as OrdemServicos;

            txtNumeroOS.Text = Convert.ToString(OrdemServico.NrNota);
            txtData.Value = OrdemServico.data;
            txtCodCliente.Text = Convert.ToString(OrdemServico.Cliente.codigo);
            txtCliente.Text = OrdemServico.Cliente.cliente;
            txtCelular.Text = OrdemServico.Cliente.celular;
            txtCodVeiculo.Text = Convert.ToString(OrdemServico.Veiculo.codigo);
            txtVeiculo.Text = OrdemServico.Veiculo.modelo;
            txtMarca.Text = OrdemServico.Veiculo.Marca.marca;
            txtAno.Text = OrdemServico.ano;
            txtPlaca.Text = Convert.ToString(OrdemServico.placa);
            txtKm.Text = Convert.ToString(OrdemServico.km);
            txtCor.Text = OrdemServico.cor;
            txtValorProdutos.Text = (OrdemServico.valorProduto).ToString("C", CultureInfo.CurrentCulture);
            txtValorServicos.Text = (OrdemServico.valorServico).ToString("C", CultureInfo.CurrentCulture);
            txtDescontos.Text = (OrdemServico.desconto).ToString("C", CultureInfo.CurrentCulture);
            txtValorTotal.Text = (OrdemServico.valorTotal).ToString("C", CultureInfo.CurrentCulture);
            if (OrdemServico.CondPagamento == null)
            {
                txtCodCondPagamento.Text = "";
                txtCondPagamento.Text = "";
            }
            else
            {
                txtCodCondPagamento.Text = Convert.ToString(OrdemServico.CondPagamento.codigo);
                txtCondPagamento.Text = OrdemServico.CondPagamento.condicao;
            }
            foreach (var produto in OrdemServico.ListaProduto)
            {
                string[] row = { Convert.ToString(produto.codigo), produto.produto, Convert.ToString(produto.qtd), (produto.precoVenda/produto.qtd).ToString("C", CultureInfo.CurrentCulture), Convert.ToString(produto.precoVenda) };
                var lvi = new ListViewItem(row);
                lvProduto.Items.Add(lvi);
            }

            foreach (var servico in OrdemServico.ListaServico)
            {
                string[] row = { Convert.ToString(servico.codigo),  Convert.ToString(servico.Mecanico.codigo), servico.produto, servico.Mecanico.funcionario, servico.precoVenda.ToString("C", CultureInfo.CurrentCulture) };
                var lvi = new ListViewItem(row);
                lvServico.Items.Add(lvi);
            }

            txtObservacoes.Text = OrdemServico.observacoes;
            txtDtCadastro.Text = Convert.ToString(OrdemServico.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(OrdemServico.dtAlteracao);
            txtUsuario.Text = OrdemServico.usuario;
            btnSalvar.Text = "ALTERAR";
            btnFinalizar.Visible = false;
        }

        private void frmCadastroOrdemServico_Load(object sender, EventArgs e)
        {

        }

        private void txtValorProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtValorProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtValorProdutos_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void txtValorServicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtValorServicos_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtValorServicos_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void txtDescontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);

        }

        private void txtDescontos_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);

        }

        private void txtDescontos_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);

        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyPress(sender, e);
        }

        private void txtValorTotal_KeyUp(object sender, KeyEventArgs e)
        {
            MaskForm.TxtMask_Moeda_KeyUp(sender, e);
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            MaskForm.TxtMask_Moeda_Leave(sender, e);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            GerarVenda();
        }

        private void GerarVenda()
        {
            Vendas Venda = new Vendas();
            CtrlCondicaoPagamento CtrlCondPag = new CtrlCondicaoPagamento();
            var listItemProdutoOS = new List<ItensOrdemServico>();
            var listItemServicoOS = new List<ItensOrdemServico>();

            try
            {
                Venda.modelo = "65";
                Venda.serie = "E";
                //Venda.nrNota = txtNumeroOS.Text;
                Venda.dtEmissao = txtData.Value;
                Venda.desconto = Double.Parse(txtDescontos.Text, NumberStyles.Any);
                Venda.cliente = CtrlCliente.BuscarPorID(txtCodCliente.Text.Trim()) as Clientes;
                Venda.condPagamento = CtrlCondPag.BuscarPorID(Convert.ToInt32(txtCodCondPagamento.Text.Trim())) as CondicaoPagamentos;
                Venda.observacoes = txtObservacoes.Text;
                Venda.dtCadastro = DateTime.Now;
                Venda.dtAlteracao = DateTime.Now;
                var dtEmissao = txtData.Value;
                Venda.usuario = UsuarioLogado.Usuario;

                var veiculo = new Modelos();
                for (int i = 0; i < lvProduto.Items.Count; i++)
                {
                    var idItem = Convert.ToInt32(lvProduto.Items[i].SubItems[0].Text);
                    var qtdItem = Convert.ToInt32(lvProduto.Items[i].SubItems[2].Text);
                    var custoItem = Decimal.Parse(lvProduto.Items[i].SubItems[4].Text, NumberStyles.Any);
                    veiculo.codigo = Convert.ToInt32(txtCodVeiculo.Text);
                    listItemProdutoOS.Add(new ItensOrdemServico()
                    {
                        modelo = Venda.modelo,
                        serie = Venda.serie,
                        //nrNota = Venda.nrNota,
                        cliente = Venda.cliente,
                        Veiculo = veiculo,
                        codigo = idItem,
                        qtd = qtdItem,
                        precoVenda = custoItem,
                        dtCadastro = Venda.dtCadastro,
                        dtAlteracao = Venda.dtAlteracao,
                    });
                }
                Venda.listaItemProdutos = listItemProdutoOS;

                var mecanico = new Funcionarios();
                for (int i = 0; i < lvServico.Items.Count; i++)
                {
                    var idItem = Convert.ToInt32(lvServico.Items[i].SubItems[0].Text);
                    var custoItem = Decimal.Parse(lvServico.Items[i].SubItems[4].Text, NumberStyles.Any);
                    var codMecanico = Convert.ToInt32(lvServico.Items[i].SubItems[2].Text);
                    mecanico.codigo = codMecanico;
                    veiculo.codigo = Convert.ToInt32(txtCodVeiculo.Text);

                    listItemServicoOS.Add(new ItensOrdemServico()
                    {
                        modelo = Venda.modelo,
                        serie = Venda.serie,
                        //nrNota = Venda.nrNota,
                        cliente = Venda.cliente,
                        Mecanico = mecanico,
                        Veiculo = veiculo,
                        codigo = idItem,
                        precoVenda = custoItem,
                        dtCadastro = Venda.dtCadastro,
                        dtAlteracao = Venda.dtAlteracao,
                    }) ;
                }
                Venda.listaItemServico = listItemServicoOS;

                if(lvProduto.Items.Count > 0)
                {
                    var listContaReceberProdutos = new List<ContasReceber>();
                    for (int i = 0; i < lvProduto.Items.Count; i++)
                    {
                        var forma = Venda.condPagamento.listaParcela.ElementAt(i).formaPagamento;
                        var Parcela = Venda.condPagamento.listaParcela.ElementAt(i);
                        var valorParcelaProduto = Double.Parse(txtValorProdutos.Text, NumberStyles.Any) * (Parcela.porcentagem / 100);
                        listContaReceberProdutos.Add(new ContasReceber()
                        {
                            modelo = Venda.modelo,
                            serie = Venda.serie,
                            //nrNota = Venda.nrNota,
                            cliente = Venda.cliente,
                            formaPagamento = forma,
                            nrParcela = i + 1,
                            dtVencimento = DateTime.Now.AddDays(Parcela.nrDia),
                            vlrParcela = valorParcelaProduto,
                            dtAlteracao = DateTime.Now,
                            dtCadastro = DateTime.Now,
                            dtEmissao = dtEmissao,
                            usuario = UsuarioLogado.Usuario
                        });
                    }
                    Venda.listaContasReceberProdutos = listContaReceberProdutos;
                }

                var listContaReceberServicos = new List<ContasReceber>();
                for (int i = 0; i < lvServico.Items.Count; i++)
                {
                    var forma = Venda.condPagamento.listaParcela.ElementAt(i).formaPagamento;
                    var Parcela = Venda.condPagamento.listaParcela.ElementAt(i);
                    var valorParcelaServico = Double.Parse(txtValorServicos.Text, NumberStyles.Any) * (Parcela.porcentagem / 100);
                    listContaReceberServicos.Add(new ContasReceber()
                    {
                        modelo = Venda.modelo,
                        serie = Venda.serie,
                        //nrNota = Venda.nrNota,
                        cliente = Venda.cliente,
                        formaPagamento = forma,
                        nrParcela = i + 1,
                        dtVencimento = DateTime.Now.AddDays(Parcela.nrDia),
                        vlrParcela = valorParcelaServico,
                        dtAlteracao = DateTime.Now,
                        dtCadastro = DateTime.Now,
                        dtEmissao = dtEmissao,
                        usuario = UsuarioLogado.Usuario
                    });
                }
                Venda.listaContasReceberServicos = listContaReceberServicos;

                //enda.situacao = chkSituacao.Checked;
               
                CtrlVenda.InserirVendaOs(Venda);
                
                MessageBox.Show("Venda salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;


            }
            catch{
                MessageBox.Show("Erro ao gerar a venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Numero_KeyPress(sender, e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_ValidaNumeroLetras_KeyPress(sender, e);
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaskForm.TxtMask_Letras_KeyPress(sender, e);
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCelular.Text))
            {
                if (String.IsNullOrEmpty(txtCelular.Text))
                {
                    MessageBox.Show("Faltou informar o celular", "Informe o celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
                else if (txtCelular.Text.Length < 10)
                {
                    MessageBox.Show("Celular inválido, deve ter no mínimo 10 números", "Informe o celular!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCelular.Focus();
                }
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMarca.Text))
            {
                if(txtMarca.Text.Length < 3)
                {
                    MessageBox.Show("Informe uma marca com mais de 3 caracteres", "Marca invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarca.Focus();
                }else if (txtMarca.Text.Length > 20)
                {
                    MessageBox.Show("Informe uma marca com menos de 20 caracteres", "Marca invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarca.Focus();
                }
            }
        }

        private void txtAno_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAno.Text))
            {
                var ano = Convert.ToInt64(txtAno.Text);
                if (ano < 1900)
                {
                    MessageBox.Show("Informe um ano maior que 1900", "Ano inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAno.Text = "";
                    txtAno.Focus();
                }
                else if (ano > DateTime.Now.Year + 1 )
                {
                    MessageBox.Show("Informe um ano menor que "+ DateTime.Now.Year, "Marca invalida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAno.Text = "";
                    txtAno.Focus();
                }
            }
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlaca.Text))
            {
                if (!ValidaPlaca(txtPlaca.Text))
                {
                    MessageBox.Show("Informe a placa correta", "Placa inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    txtPlaca.Clear();
                }
            }
        }

        private void txtKm_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKm.Text))
            {
                if(txtKm.Text.Length > 11)
                {
                    MessageBox.Show("Informe o odomentro presente no veiculo", "Kilometragem inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKm.Focus();
                }
            }
        }

        private void txtCor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCor.Text))
            {
                if(txtCor.Text.Length < 3)
                {
                    MessageBox.Show("Informe uma cor com mais de 3 caracteres", "Numero de caracteres insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCor.Focus();
                }
            }
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQtd.Text))
            {
               
            }
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCliente.Text))
                return;
            if (Convert.ToInt32("0" + txtCodCliente.Text) < 1)
                return;
            Clientes cli = CtrlCliente.BuscarPorID(Convert.ToInt32(txtCodCliente.Text)) as Clientes;
            if (cli == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCodCliente.Text = "";
                txtCliente.Text = "";
                txtCelular.Text = "";
                txtCliente.Enabled = true;
                txtCelular.Enabled = true;
                txtCodCliente.Enabled = true;
                txtCodCliente.Focus();
            }
            else
            {
                txtCliente.Text = cli.cliente;
                txtCelular.Text = cli.celular;
                txtCliente.Enabled = false;
                txtCelular.Enabled = false;
                txtCodCliente.Focus();
            }
        }

        private void txtCodVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodVeiculo.Text))
                return;
            if (Convert.ToInt32("0" + txtCodVeiculo.Text) < 1)
                return;
            Modelos model = CtrlModelo.BuscarPorID(Convert.ToInt32("0" + txtCodVeiculo.Text)) as Modelos;
            if (model == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCodVeiculo.Text = "";
                txtVeiculo.Text = "";
                txtMarca.Text = "";
                txtVeiculo.Enabled = true;
                txtMarca.Enabled = true;
                txtCodVeiculo.Enabled = true;
                txtCodVeiculo.Focus();
            }
            else
            {
                txtVeiculo.Text = model.modelo;
                txtMarca.Text = model.Marca.marca;
                txtVeiculo.Enabled = false;
                txtMarca.Enabled = false;
                txtCodVeiculo.Focus();
            }
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodProduto.Text))
                return;
            if (Convert.ToInt32("0" + txtCodProduto.Text) < 1)
                return;
            Produtos prod = CtrlProduto.BuscarPorID(Convert.ToInt32("0" + txtCodProduto.Text)) as Produtos;
            if (prod == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCodProduto.Text = "";
                txtProduto.Text = "";
                txtProduto.Enabled = true;
                txtCodProduto.Enabled = true;
                txtCodProduto.Focus();
            }
            else
            {
                txtProduto.Text = prod.produto;
                txtProduto.Enabled = false;
                txtCodProduto.Focus();
            }
        }

        private void txtCodCondPagamento_TextChanged(object sender, EventArgs e)
        {
            CondicaoPagamentos Cond = CtrlCondicao.BuscarPorID(Convert.ToInt32("0" + txtCodCondPagamento.Text)) as CondicaoPagamentos;
            if (Cond == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtCondPagamento.Text = "";
                txtCodCondPagamento.Text = "";
                txtCondPagamento.Enabled = true;
                txtCodCondPagamento.Focus();
            }
            else
            {
                txtCondPagamento.Text = Cond.condicao;
                txtCondPagamento.Enabled = false;
                txtCodCondPagamento.Focus();
            }
        }

        private void txtCodServico_TextChanged(object sender, EventArgs e)
        {
            Servicos Serv = CtrlServico.BuscarPorID(Convert.ToInt32("0" + txtCodServico.Text)) as Servicos;
            if (Serv == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtServico.Text = "";
                txtCodServico.Text = "";
                txtServico.Enabled = true;
                txtCodServico.Focus();
            }
            else
            {
                txtServico.Text = Serv.servico;
                txtServico.Enabled = false;
                txtCodServico.Focus();
            }
        }

        private void txtCodMecanico_TextChanged(object sender, EventArgs e)
        {
            Funcionarios func = CtrlFuncionario.BuscarPorID(Convert.ToInt32("0" + txtCodMecanico.Text)) as Funcionarios;
            if (func == null)
            {
                MessageBox.Show("Nenhum resultado");
                txtMecanico.Text = "";
                txtCodMecanico.Text = "";
                txtMecanico.Enabled = true;
                txtCodMecanico.Focus();
            }
            else
            {
                txtMecanico.Text = func.funcionario;
                txtMecanico.Enabled = false;
                txtCodMecanico.Focus();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtValorServicos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}

