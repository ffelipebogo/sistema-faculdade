using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Vendas:Base
    {
        public string modelo { get; set; }
        public string serie { get; set; }
        public string nrNota { get; set; }
        public Clientes cliente { get; set; }
        public CondicaoPagamentos condPagamento { get; set; }
        public DateTime dtEmissao { get; set; }
        public double desconto { get; set; }
        public bool situacao { get; set; }
        public List<ContasReceber> listaContasReceber { get; set; }
        public List<ContasReceber> listaContasReceberProdutos { get; set; }
        public List<ContasReceber> listaContasReceberServicos { get; set; }
        public List<ItensVenda> listaItem { get; set; }
        public List<ItensOrdemServico> listaItemProdutos { get; set; }
        public List<ItensOrdemServico> listaItemServico { get; set; }
    }
}
