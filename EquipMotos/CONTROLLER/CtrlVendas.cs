using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    public class CtrlVendas : Controller
    {
        VendasDAO DaoVenda = new VendasDAO();

        public CtrlVendas() : base(new VendasDAO())
        {
            this.DaoVenda = (VendasDAO)this.Dao;
        }

        public void Desativar(object modelo, object serie, object nrNota, object idFornecedor)
        {
            //DaoVenda.Desativar(modelo, serie, nrNota, idFornecedor);
        }

        public void InserirVendaOs(object obj)
        {
            DaoVenda.InserirVendaOS(obj);
        }

        //public object BuscarPorID(object modelo, object serie, object nrNota, object idFornecedor)
        //{
        //    return DaoVenda.BuscarVendas_porID(modelo, serie, nrNota, idFornecedor);
        //}

    }
}
