using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Base
    {
        public int codigo { get; set; }
        public string observacoes { get; set; }
        public DateTime dtCadastro { get; set; }
        public DateTime dtAlteracao { get; set; }
        public string usuario { get; set; }
    }

}
