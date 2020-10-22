using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Servicos: Base
    {
        public string servico { get; set; }
        public Categorias Categoria { get; set; }
        public decimal custo { get; set; }
        public decimal precoVenda { get; set; }
        public Funcionarios Funcionario { get; set; }
        public double comissao { get; set; }
    }
}
