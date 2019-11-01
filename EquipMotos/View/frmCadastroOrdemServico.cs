using EquipMotos.Codigo.View;
using EquipMotos.CONTROLLER;
using EquipMotos.DAO;
using EquipMotos.MODEL;
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
    public partial class frmCadastroOrdemServico : Form
    {

        OrdemServicos OrdemServico = new OrdemServicos();
        CtrlOrdemServicos CtrlOrdemServico = new CtrlOrdemServicos();
        CondicaoPagamentos CondicaoPagamento = new CondicaoPagamentos();
        CtrlProdutosServicos CtrlProdutoServico = new CtrlProdutosServicos();
        CtrlClientes CtrlCliente = new CtrlClientes();
        List<ProdutosServicos> ListaProdutos;
        List<ProdutosServicos> ListaServicos;

        public static object Cliente;
        public static object Modelo;
        public static object Produto = null;
        public static object Servico = null;
        public static object Funcionario;
        public static object CondPagamento;

        public frmCadastroOrdemServico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                OrdemServico = new OrdemServicos();
                var listContaReceber = new List<ContasReceber>();
                var listItemVenda = new List<ItensVenda>();
                var listItemServico = new List<ItensVenda>();
                // using (dao = new ComprasDAO())
                {
                    //var clietenDao = new ClientesDAO(dao.conexao);

                    if (ValidaCampos())
                    {
                        OrdemServico.dataOS = txtData.Value;
                        var cliente = new Clientes();
                        cliente.codigo = Convert.ToInt32(txtCodCliente.Text);
                        OrdemServico.Cliente = cliente;

                        var modelo = new Modelos();
                        modelo.codigo = Convert.ToInt32(txtCodVeiculo.Text);
                        OrdemServico.Modelo = modelo;

                        var produto = new ProdutosServicos();
                        produto.codigo = Convert.ToInt32(txtCodProduto.Text);
                        OrdemServico.Produto = produto;

                        var condPag = new CondicaoPagamentos();

                        condPag.codigo = Convert.ToInt32(txtCodCondPagamento.Text);

                        OrdemServico.ano = txtAno.Text;
                        OrdemServico.placa = txtPlaca.Text;
                        OrdemServico.km = txtKm.Text;
                        OrdemServico.cor = txtCor.Text;

                        OrdemServico.observacoes = txtObservacoes.Text;
                        OrdemServico.dtCadastro = DateTime.Now;
                        OrdemServico.dtAlteracao = DateTime.Now;
                        var dtEmissao = txtData.Value;
                        OrdemServico.usuario = txtUsuario.Text;
                       // ProdutosServicos produto = new ProdutosServicos();
                        for (int i = 0; i < lvProduto.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvProduto.Items[i].SubItems[0].Text);
                            var qtdItem = Convert.ToInt32(lvProduto.Items[i].SubItems[3].Text);
                            var custoItem = Convert.ToDecimal(Double.Parse(lvProduto.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("N2"));
                            //var totalItens = getTotal();
                            //var totalDespesas = Convert.ToDecimal(OrdemServico.frete + OrdemServico.seguro + OrdemServico.despesa);
                            //var porcentagemItem = ((custoItem * qtdItem) / totalItens);
                            //var vlrFinal = totalDespesas * porcentagemItem;
                            //vlrFinal /= qtdItem;

                            listItemVenda.Add(new ItensVenda()
                            {
                                //modelo = OrdemServico.modelo,
                                //serie = OrdemServico.serie,
                                //nrNota = OrdemServico.nrNota,
                                //Fornecedor = OrdemServico.fornecedor,
                                codigo = idItem,
                                qtd = qtdItem,
                                //custo = custoItem,
                                precoVenda = custoItem ,//+ vlrFinal,
                                dtCadastro = OrdemServico.dtCadastro,
                                dtAlteracao = OrdemServico.dtAlteracao,
                            });
                        }
                        OrdemServico.ListaProduto = listItemVenda;

                        for (int i = 0; i < lvProduto.Items.Count; i++)
                        {
                            var idItem = Convert.ToInt32(lvProduto.Items[i].SubItems[0].Text);
                            var qtdItem = Convert.ToInt32(lvProduto.Items[i].SubItems[3].Text);
                            var custoItem = Convert.ToDecimal(Double.Parse(lvProduto.Items[i].SubItems[4].Text, NumberStyles.Any).ToString("N2"));
                            //var totalItens = getTotal();
                            //var totalDespesas = Convert.ToDecimal(OrdemServico.frete + OrdemServico.seguro + OrdemServico.despesa);
                            //var porcentagemItem = ((custoItem * qtdItem) / totalItens);
                            //var vlrFinal = totalDespesas * porcentagemItem;
                            //vlrFinal /= qtdItem;
                            listItemServico.Add(new ItensVenda()
                            {
                                //modelo = OrdemServico.modelo,
                                //serie = OrdemServico.serie,
                                //nrNota = OrdemServico.nrNota,
                                //Fornecedor = OrdemServico.fornecedor,
                                codigo = idItem,
                                //qtd = qtdItem,
                                //custo = custoItem,
                                precoVenda = custoItem,//+ vlrFinal,
                                dtCadastro = OrdemServico.dtCadastro,
                                dtAlteracao = OrdemServico.dtAlteracao,
                            });
                        }
                        OrdemServico.ListaServico = listItemServico;

                        for (int i = 0; i < lvContaReceber.Items.Count; i++)
                        {
                            listContaReceber.Add(new ContasReceber()
                            {
                                //modelo = OrdemServico.modelo,
                                //serie = OrdemServico.serie,
                                //nrNota = OrdemServico.nrNota,
                                cliente = OrdemServico.Cliente,
                                nrParcela = i + 1,
                                dtVecimento = Convert.ToDateTime(lvContaReceber.Items[i].SubItems[1].Text),
                                vlrParcela = Double.Parse(lvContaReceber.Items[i].SubItems[2].Text, NumberStyles.Any),
                                dtAlteracao = DateTime.Now,
                                dtCadastro = DateTime.Now,
                                dtEmissao = dtEmissao,
                                usuario = txtUsuario.Text
                            });
                        }
                        //OrdemServico.lista = listContaReceber;
                        //OrdemServico.situacao = chkSituacao.Checked;
                        CtrlOrdemServico.Inserir(OrdemServico);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel gerar a OrdemServico.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OrdemServico.ListaServico = null;
                        OrdemServico.ListaProduto = null;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.LimparCampos();
            }
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

                if ( String.IsNullOrEmpty(txtVeiculo.Text.Trim()))
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
                else if (Convert.ToInt32(txtAno.Text) < 0)
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

        public bool ValidaPlaca(String placa)
        { 
            Regex rg = new Regex("[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}|[A-Z]{3}-[0-9]{4}");

            return rg.IsMatch(placa);
        }

        private bool ValidaProduto()
        {
            if (txtCodProduto.Text == String.Empty & txtCodProduto.Text.Length < 0)
            {
                MessageBox.Show("Faltou informar o Código Produto", "Informe o Código Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtCodProduto.Text) < 0)
            {
                MessageBox.Show("Código Produto inválido", "Informe o Código do Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProduto.Focus();
                return false;
            }
            if (txtProduto.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar o Produto", "Informe o Produto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
                return false;
            }
            if (txtQtd.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar a Quantidade", "Informe uma Quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtQtd.Text) < 0)
            {
                MessageBox.Show("Quantidade inválida", "Informe a Quantidade!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaServico()
        {
            if (txtCodServico.Text == String.Empty & txtCodServico.Text.Length < 0)
            {
                MessageBox.Show("Faltou informar o Código Serviço", "Informe o Código Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodServico.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtCodServico.Text) < 0)
            {
                MessageBox.Show("Código Serviço inválido", "Informe o Código do Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodServico.Focus();
                return false;
            }
            if (txtServico.Text == String.Empty)
            {
                MessageBox.Show("Faltou informar o Serviço", "Informe o Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServico.Focus();
                return false;
            }

            if (txtCodMecanico.Text == String.Empty & txtCodMecanico.Text.Length < 0)
            {
                MessageBox.Show("Faltou informar o Código Mecanico", "Informe o Código Mecanico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodMecanico.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtCodMecanico.Text) < 0)
            {
                MessageBox.Show("Código Serviço Mecanico", "Informe o Código do Mecanico!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodMecanico.Focus();
                return false;
            }
            if (txtMecanico.Text == String.Empty)
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
                if (Double.Parse(txtValorTotal.Text, NumberStyles.Any) <= 0)
                {
                    MessageBox.Show("É necessario informar o valor total para gerar contas à receber", "Valor total inválido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValorTotal.Focus();
                }
                else
                {
                    CarregaCondicao();
                    lvContaReceber.Items.Clear();
                    for (int i = 0; i < CondicaoPagamento.listaParcela.Count; i++)
                    {
                        var parcela = CondicaoPagamento.listaParcela.ElementAt(i);
                        var dtVencimento = Convert.ToDateTime(txtData.Text);
                        dtVencimento = dtVencimento.AddDays(parcela.nrDia);
                        var valorTot = Double.Parse(txtValorTotal.Text, NumberStyles.Any) - Double.Parse(txtDescontos.Text, NumberStyles.Any);
                        var valorParcela = valorTot * (parcela.porcentagem / 100);
                        string[] row = { txtCliente.Text + "/" + Convert.ToString(parcela.nrParcela), dtVencimento.ToString("dd/MM/yyyy"), valorParcela.ToString("C", CultureInfo.CurrentCulture) };
                        var lvi = new ListViewItem(row);
                        lvContaReceber.Items.Add(lvi);
                    }
                }
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
            frmConsultaProdutosServicos frmConProd = new frmConsultaProdutosServicos();
            frmConProd.btnVoltar.Text = "SELECIONAR";
            if (frmConProd.ShowDialog() == DialogResult.OK)
            {
                CarregaProduto();
            }
        }

        private void CarregaProduto()
        {
            if (Produto != null)
            {
                ProdutosServicos prod = Produto as ProdutosServicos;
                txtCodProduto.Text = Convert.ToString(prod.codigo);
                txtProduto.Text = prod.produto;
                Servico = null;
            }
        }

        private void btnBuscarServico_Click(object sender, EventArgs e)
        {
            frmConsultaProdutosServicos frmConServ = new frmConsultaProdutosServicos();
            frmConServ.btnVoltar.Text = "SELECIONAR";
            if (frmConServ.ShowDialog() == DialogResult.OK)
            {
                CarregaServico();
            }
        }

        private void CarregaServico()
        {
            if (Servico != null)
            {
                ProdutosServicos pro = Servico as ProdutosServicos;
                txtCodServico.Text = Convert.ToString(pro.codigo);
                txtServico.Text = pro.produto;
                Produto = null;
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
                ProdutosServicos prod = Produto as ProdutosServicos;
                if (ValidaProduto())
                {
                    var qtd = Convert.ToInt32(txtQtd.Text);
                    var totalRow = Convert.ToString(qtd * prod.custo);

                    string[] row = { Convert.ToString(prod.codigo), prod.produto, prod.unidade, txtQtd.Text, Convert.ToString(prod.custo), Convert.ToString(totalRow) };
                    var lvi = new ListViewItem(row);
                    lvProduto.Items.Add(lvi);

                    var vlTotalincial = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);
                    if (vlTotalincial <= 0)
                    {
                        txtValorProdutos.Text = lvProduto.Items[0].SubItems[5].Text;
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);
                        for (int i = 0; i < lvProduto.Items.Count; i++)
                        {
                            txtValorProdutos.Text = Double.Parse(lvProduto.Items[i].SubItems[5].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
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
                    Produto = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutosServicos serv = Servico as ProdutosServicos;
                Funcionarios func = Funcionario as Funcionarios;
                if (ValidaServico())
                {
                    var totalRow = Convert.ToString(serv.custo);
                    string[] row = { Convert.ToString(serv.codigo), serv.produto, func.funcionario, Convert.ToString(totalRow) };
                    var lvi = new ListViewItem(row);
                    lvServico.Items.Add(lvi);

                    var vlTotalincial = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
                    if (vlTotalincial <= 0)
                    {
                        txtValorServicos.Text = lvServico.Items[0].SubItems[3].Text;
                    }
                    else
                    {
                        var vltotal = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
                        for (int i = 0; i < lvServico.Items.Count; i++)
                        {
                            txtValorServicos.Text = Double.Parse(lvServico.Items[i].SubItems[3].Text, NumberStyles.Any).ToString("C", CultureInfo.CurrentCulture);
                        }
                        //vltotal + txtvalortoal
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
            }
            catch
            {
                MessageBox.Show("Algo de errado não está certo!");
            }
        }

        private void SomaTotal()
        {
            var total = Double.Parse(txtValorTotal.Text, NumberStyles.Any);
            var totalServico = Double.Parse(txtValorServicos.Text, NumberStyles.Any);
            var totalProduto = Double.Parse(txtValorProdutos.Text, NumberStyles.Any);

            if (totalServico > 0 && totalProduto > 0)
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

            txtNumeroOS.Text = Convert.ToString(OrdemServico.numeroOS);
            txtData.Text = Convert.ToString(OrdemServico.dataOS);
            txtCodCliente.Text = Convert.ToString(OrdemServico.Cliente.codigo);
            txtCliente.Text = OrdemServico.Cliente.cliente;
            txtCodVeiculo.Text = Convert.ToString(OrdemServico.Modelo.codigo);
            txtVeiculo.Text = OrdemServico.Modelo.modelo;
            txtAno.Text = OrdemServico.ano;
            txtPlaca.Text = Convert.ToString(OrdemServico.placa);
            txtKm.Text = Convert.ToString(OrdemServico.km);
            txtCor.Text = OrdemServico.cor;
            txtCodProduto.Text = Convert.ToString(OrdemServico.Produto.codigo);
            txtProduto.Text = OrdemServico.Produto.produto;
            txtQtd.Text = Convert.ToString(OrdemServico.qtd);
            txtCodServico.Text = Convert.ToString(OrdemServico.Servico.codigo);
            txtServico.Text = OrdemServico.Servico.produto;
            txtCodMecanico.Text = Convert.ToString(OrdemServico.Funcionario.codigo);
            txtMecanico.Text = OrdemServico.Funcionario.funcionario;
            txtValorProdutos.Text = Convert.ToString(OrdemServico.valorProd);
            txtValorServicos.Text = Convert.ToString(OrdemServico.valorServ);
            txtDescontos.Text = Convert.ToString(OrdemServico.desconto);
            txtValorTotal.Text = Convert.ToString(OrdemServico.valorTotal);

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
            txtObservacoes.Text = OrdemServico.observacoes;
            txtDtCadastro.Text = Convert.ToString(OrdemServico.dtCadastro);
            txtDtAlteracao.Text = Convert.ToString(OrdemServico.dtAlteracao);
            txtUsuario.Text = OrdemServico.usuario;
            btnSalvar.Text = "ALTERAR";
        }
    }
}
