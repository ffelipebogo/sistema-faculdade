using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlFuncionarios:Controller
    {
        FuncionariosDAO DaoFuncionario = null;
        public CtrlFuncionarios() : base(new FuncionariosDAO())
        {
            this.DaoFuncionario = (FuncionariosDAO)this.Dao;
        }
    }
}
