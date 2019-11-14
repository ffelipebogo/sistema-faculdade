using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Contas: Base
    {
        public string modelo { get; set; }
        public string serie { get; set; }
        public string nrNota { get; set; }
        public FormaPagamentos formaPagamento { get; set; }
        public int nrParcela { get; set; }
        public double vlrParcela { get; set; }
        public DateTime dtVencimento { get; set; }
        public DateTime dtEmissao { get; set; }
        public bool pago { get; set; }
    }
}
