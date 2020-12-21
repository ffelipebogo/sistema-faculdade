using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    class OrdemServicos : Base
    { 
        public string NrNota { get; set; }
        public DateTime data { get; set; }
        public Clientes Cliente { get; set; }
        public Modelos Veiculo { get; set; }
        public Produtos Produto { get; set; }
        public Servicos Servico { get; set; }
        public Funcionarios Mecanico { get; set; }
        public string ano { get; set; }
        public string placa { get; set; }
        public string km { get; set; }
        public string cor { get; set; }
        public int qtd { get; set; }
        public decimal valorProduto { get; set; }
        public decimal desconto { get; set; }
        public decimal valorServico { get; set; }
        public decimal valorTotal { get; set; }
        public CondicaoPagamentos CondPagamento { get; set; }
        public List<ItensOrdemServico> ListaProduto { get; set; }
        public List<ItensOrdemServico> ListaServico { get; set; }
        public bool finalizada { get; set; }

    }
}
