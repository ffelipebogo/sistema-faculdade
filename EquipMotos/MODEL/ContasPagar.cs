using System;

namespace EquipMotos.MODEL
{
    public class ContasPagar : Base
    {
        public string modelo { get; set; }
        public string serie { get; set; }
        public string nrNota { get; set; }
        public Fornecedores fornecedor { get; set; }
        public FormaPagamentos formaPagamento { get; set; }
        public int nrParcela { get; set; }
        public double vlrParcela { get; set; }
        public DateTime dtVecimento { get; set; }
        public DateTime dtEmissao { get; set; }
        public bool pago { get; set; }
    }
}
