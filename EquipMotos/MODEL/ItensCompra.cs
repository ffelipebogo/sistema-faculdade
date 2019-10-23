using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class ItensCompra: ProdutosServicos
    {
        public string modelo { get; set; }
        public string serie { get; set; }
        public string nrNota { get; set; }
        public decimal custoUnitario { get; set; }

    }
}
