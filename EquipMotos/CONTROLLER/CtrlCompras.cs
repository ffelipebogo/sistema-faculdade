using EquipMotos.DAO;
using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    public class CtrlCompras : Controller
    {
        ComprasDAO DaoCompra = null;

        public CtrlCompras() : base(new ComprasDAO())
        {
           this.DaoCompra = (ComprasDAO) this.Dao;
        }


        public void Desativar(object modelo, object serie, object nrNota, object idFornecedor)
        {
            DaoCompra.Desativar(modelo, serie, nrNota, idFornecedor);
        }

        public object BuscarPorID(object modelo, object serie, object nrNota, object idFornecedor)
        {
            return DaoCompra.BuscarCompra_porID(modelo, serie, nrNota, idFornecedor);
        }

        public List<ContasPagar> BuscarContaPagar(object modelo, object serie, object nrNota, object idFornecedor)
        {
            return DaoCompra.BuscarContasPagar(modelo, serie, nrNota, idFornecedor);
        }

    }
}
