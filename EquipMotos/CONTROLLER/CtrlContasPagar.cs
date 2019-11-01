using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EquipMotos.CONTROLLER
{
    class CtrlContasPagar:Controller

    {
        ContasPagarDAO DaoContasPagar = null;
        public CtrlContasPagar() : base(new ContasPagarDAO())
        {
            this.DaoContasPagar = (ContasPagarDAO)this.Dao;
        }

        public object BuscarContasPagar_porID(object modelo, object serie, object nrNota, object codFornecedor, object nrParcela)
        {
            return DaoContasPagar.BuscarContasPagar_porID(modelo, serie, nrNota, codFornecedor, nrParcela);
        }

        public void MarcarPago(object modelo, object serie, object nrNota, object codFornecedor, object nrParcela)
        {
            DaoContasPagar.MarcarPago(modelo, serie, nrNota, codFornecedor, nrParcela);
        }
    }
}
