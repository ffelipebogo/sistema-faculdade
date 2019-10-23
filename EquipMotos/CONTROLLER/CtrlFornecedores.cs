using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlFornecedores:Controller
    {
        FornecedoresDAO DaoFornecedor = null;
        public CtrlFornecedores() : base(new FornecedoresDAO())
        {
            this.DaoFornecedor = (FornecedoresDAO)this.Dao;
        }

        public DataTable ListarTodosFornecedores_porNome(object obj)
        {
            return DaoFornecedor.ListarTodosFornecedores_porNome(obj);
        }
    }
}
