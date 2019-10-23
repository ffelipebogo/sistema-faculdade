using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlClientes:Controller
    {
        ClientesDAO DaoCliente = null;
        public CtrlClientes() : base(new ClientesDAO())
        {
            this.DaoCliente = (ClientesDAO)this.Dao;
        }

        public DataTable ListarTodosClientes_porNome(object cliente)
        {
            return DaoCliente.ListarTodosClientes_porNome(cliente);
        }
    }
}
