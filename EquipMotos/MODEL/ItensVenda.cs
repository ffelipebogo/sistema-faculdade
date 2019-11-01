using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class ItensVenda: ItensCompra
    {
        public Clientes cliente { get; set; }
    }
}
