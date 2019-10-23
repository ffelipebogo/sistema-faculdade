using EquipMotos.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlProdutosServicos : Controller
    {
        ProdutosServicosDAO DaoProdutoServico = null;
        public CtrlProdutosServicos() : base(new ProdutosServicosDAO())
        {
            this.DaoProdutoServico = (ProdutosServicosDAO)this.Dao;
        }

        public DataTable ListarTodosServicos()
        {
            return DaoProdutoServico.ListarTodosServicos();
        }

        public DataTable ListarTodosProdutos()
        {
            return DaoProdutoServico.ListarTodosProdutos();
        }
        public DataTable ListarTodosProdutosServicos_porNome(object obj)
        {
            return DaoProdutoServico.ListarTodosProdutosServicos_porNome(obj);        
        }

    }
}
