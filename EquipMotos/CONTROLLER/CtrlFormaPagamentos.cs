using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    public class CtrlFormaPagamentos:Controller
    {
        FormaPagamentoDAO DaoFormaPagamento = null;

        public CtrlFormaPagamentos() : base(new FormaPagamentoDAO())
        {
            this.DaoFormaPagamento = (FormaPagamentoDAO)this.Dao;
        }
    }
}
