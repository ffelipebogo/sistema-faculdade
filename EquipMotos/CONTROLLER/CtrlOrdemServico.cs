using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlOrdemServico: Controller
    {
        OrdemServicosDAO DaoOrdemServico = null;
        public CtrlOrdemServico() : base(new OrdemServicosDAO())
        {
            this.DaoOrdemServico = (OrdemServicosDAO)this.Dao;
        }
    }
}
