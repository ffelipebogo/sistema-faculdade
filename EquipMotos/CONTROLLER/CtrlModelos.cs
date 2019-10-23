using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlModelos: Controller
    {
        ModelosDAO DaoModelo = null;
        public CtrlModelos() : base(new ModelosDAO())
        {
            this.DaoModelo = (ModelosDAO)this.Dao;
        }
    }
}
