using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlProdutos : Controller
    {
        ProdutosDAO DaoProduto = null;
        public CtrlProdutos() : base(new ProdutosDAO())
        {
            this.DaoProduto = (ProdutosDAO)this.Dao;
        }

        public DataTable ListarProdutos_porNome(object obj)
        {
            return DaoProduto.ListarProdutos_porNome(obj);
        }

    }
}
