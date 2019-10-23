using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlCondicaoPagamento: Controller
    {
        CondicaoPagamentoDAO DaoCondicao = null;

        public CtrlCondicaoPagamento() : base(new CidadesDAO())
        {
            DaoCondicao = (CondicaoPagamentoDAO)this.Dao;
        }

     
    }
}
