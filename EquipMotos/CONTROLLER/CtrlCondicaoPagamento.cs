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
       CondicaoPagamentoDAO DaoCondicao;

        public CtrlCondicaoPagamento() : base(new CondicaoPagamentoDAO())
        {
            DaoCondicao = (CondicaoPagamentoDAO)this.Dao;
        }
    }
}
