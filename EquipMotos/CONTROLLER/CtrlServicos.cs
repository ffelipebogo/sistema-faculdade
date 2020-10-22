using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlServicos : Controller
    {
        ServicosDAO DaoServico = null;
        public CtrlServicos() : base(new ServicosDAO())
        {
            this.DaoServico = (ServicosDAO)this.Dao;
        }

        public DataTable ListarServicos_porNome(object obj)
        {
            return DaoServico.ListarServicos_porNome(obj);
        }
    }
}
