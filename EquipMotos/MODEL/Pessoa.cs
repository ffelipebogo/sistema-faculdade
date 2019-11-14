using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Pessoa : Base
    {
        public char sexo { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string telefone { get; set; }
        public string contato { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public bool estrangeiro { get; set; }
        public Cidades Cidade { get; set; }
        public CondicaoPagamentos CondPagamento { get; set; }
        public double limiteCredito { get; set; }
    }
}
