using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlOrdemServicos: Controller
    {
        OrdemServicosDAO DaoOrdemServico = null;
        public CtrlOrdemServicos() : base(new OrdemServicosDAO())
        {
            this.DaoOrdemServico = (OrdemServicosDAO)this.Dao;
        }

        public object SelecionaUltimoID()
        {
            return DaoOrdemServico.SelecionaUltimoID();
        }
    }
}
