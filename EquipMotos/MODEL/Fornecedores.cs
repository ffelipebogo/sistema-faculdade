using System;

namespace EquipMotos.MODEL
{
    public class Fornecedores : Pessoa
    {

        public string fornecedor { get; set; }
        public string nomeFantasia { get; set; }
        public DateTime? dtFundacao { get; set; }
        public string cnpj { get; set; }
        public string ie { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string site { get; set; }
        public Boolean fisico { get; set; }

    }
}
