using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Produtos : Base
    {
        public string produto { get; set; }
        public string unidade { get; set; }
        public string codBarra { get; set; }
        public Categorias Categoria { get; set; }
        public int qtd { get; set; }
        public decimal custo { get; set; }
        public decimal precoVenda { get; set; }
        public Fornecedores Fornecedor { get; set; }
        public decimal custoUltCompra { get; set; }
        public DateTime? dtUltCompra { get; set; }
        public double comissao { get; set; }
    }
}
