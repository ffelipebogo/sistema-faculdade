using EquipMotos.DAO;
using EquipMotos.MODEL;
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

        public void Desativar(object modelo, object serie, object nrNota, object codCliente) 
        {
            DaoVenda.Desativar(modelo, serie, nrNota, codCliente);
        }

        public List<ContasReceber> BuscarContaReceber(object modelo, object serie, object nrNota, object codCliente)
        {
            return DaoVenda.BuscarContasReceber(modelo, serie, nrNota, codCliente);
        }

        public void InserirVendaOs(object obj)
        {
            DaoVenda.InserirVendaOS(obj);
        }


        public object BuscarPorID( object nrNota)
        {
            return DaoVenda.BuscarVenda_porID(nrNota);
        }

    }
}
