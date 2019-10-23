using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlContasPagar:Controller
    {
        ContasPagarDAO DaoContasPagar = null;
        public CtrlContasPagar() : base(new ContasPagarDAO())
        {
            this.DaoContasPagar = (ContasPagarDAO)this.Dao;
        }
    }
}
