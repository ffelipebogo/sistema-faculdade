using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    class OrdemServicos : Base
    {
        public int numeroOS { get; set; }
        public DateTime dataOS { get; set; }
        public Clientes Cliente { get; set; }
        public Modelos Modelo { get; set; }
        public ProdutosServicos Produto { get; set; }
        public ProdutosServicos Servico { get; set; }
        public Funcionarios Funcionario { get; set; }
        public string ano { get; set; }
        public string placa { get; set; }
        public string km { get; set; }
        public string cor { get; set; }
        public int qtd { get; set; }
        public double valorProd { get; set; }
        public double desconto { get; set; }
        public double valorServ { get; set; }
        public double valorTotal { get; set; }
        public CondicaoPagamentos CondPagamento { get; set; }
        public List<ItensVenda> ListaProduto { get; set; }
        public List<ItensVenda> ListaServico { get; set; }

    }
}
