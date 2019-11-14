using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    public class CtrlContasReceber : Controller
    {
         
        ContasReceberDAO DaoContasReceber = null;
        public CtrlContasReceber() : base(new ContasReceberDAO())
        {
            this.DaoContasReceber = (ContasReceberDAO)this.Dao;
        }

        public object BuscarContasPagar_porID(object modelo, object serie, object nrNota, object codFornecedor, object nrParcela)
        {
            return DaoContasReceber.BuscarContasReceber_porID(modelo, serie, nrNota, codFornecedor, nrParcela);
        }

        public void MarcarPago(object modelo, object serie, object nrNota, object codCliente, object nrParcela)
        {
            DaoContasReceber.MarcarPago(modelo, serie, nrNota, codCliente, nrParcela);
        }
    }
}
