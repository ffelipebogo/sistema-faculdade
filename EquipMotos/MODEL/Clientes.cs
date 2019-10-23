using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    class Clientes : Pessoa
    {
        public string cliente { get; set; }
        public string apelido { get; set; }
        public DateTime dtNascimento { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string ie { get; set; }
        public string rg { get; set; }
        public string site { get; set; }
        public bool juridico { get; set; }

    }
}
