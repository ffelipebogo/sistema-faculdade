using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
     public class ItensOrdemServico : ItensVenda
    {
        public  Modelos Veiculo { get; set; }

        public Funcionarios Mecanico { get; set; }
    }
}
