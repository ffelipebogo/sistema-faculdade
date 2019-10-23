using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlPaises: Controller
    {
        PaisesDAO DaoPais = null;
        public CtrlPaises() : base(new PaisesDAO())
        {
            this.DaoPais = (PaisesDAO)this.Dao;
        }
    }
}
