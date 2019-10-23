using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class CondicaoPagamentos : Base
    {
        //public int id { get; set; }
        public string condicao { get; set; }
        public double multa { get; set; }
        public double juros { get; set; }
        public double desconto { get; set; }
        public List<CondicaoParcelada> listaParcela { get; set; }

    }
}
