using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlMarcas: Controller
    {
        MarcasDAO DaoMarca = null;
        public CtrlMarcas() : base(new MarcasDAO())
        {
            this.DaoMarca = (MarcasDAO)this.Dao;
        }

    }
}
