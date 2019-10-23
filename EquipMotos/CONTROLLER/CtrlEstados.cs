using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlEstados:Controller
    {
        EstadosDAO DaoEstado= null;
        public CtrlEstados() : base(new EstadosDAO())
        {
            this.DaoEstado = (EstadosDAO)this.Dao;
        }
    }
}
