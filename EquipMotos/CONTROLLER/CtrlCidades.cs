using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlCidades : Controller
    {
        CidadesDAO DaoCidade = null;

        public CtrlCidades() : base(new CidadesDAO())
        {
            DaoCidade = (CidadesDAO) this.Dao;
        }

    }
}
