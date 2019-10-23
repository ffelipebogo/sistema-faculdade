using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
   public  class Funcionarios : Pessoa
    {
        
        public string funcionario { get; set; }
        public string apelido { get; set; }
        public DateTime dtNascimento { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
        public decimal comissao { get; set; }
        public string carteiraTrabalho { get; set; }
        public string ctSerie { get; set; }
        public string ctUf { get; set; }
        public DateTime ctDtEmissao { get; set; }
        public string ctPis { get; set; }
        public string cnh { get; set; }
        public string cnhEmissor { get; set; }
        public string cnhUf { get; set; }
        public DateTime cnhDtExpedicao { get; set; }
        public DateTime cnhDtValidade { get; set; }
        public DateTime cnhDtPrimeira { get; set; }
        public string cnhCategoria { get; set; }

    }
}
