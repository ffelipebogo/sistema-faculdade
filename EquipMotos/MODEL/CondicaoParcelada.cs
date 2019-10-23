using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class CondicaoParcelada: Base
    {
        public int nrParcela { get; set; }
        public int nrDia { get; set; }
        public double porcentagem { get; set; }
        public FormaPagamentos formaPagamento { get; set; }
        public CondicaoPagamentos condPagamento { get; set; }
       
    }
}
