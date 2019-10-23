using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipMotos.DAO;

namespace EquipMotos.CONTROLLER
{
    public class Controller
    {
        protected readonly DAO.DAO Dao;

        public Controller(DAO.DAO dao)
        {
            Dao = dao;
        }

        public Controller()
        {
        }

        public virtual void Inserir(Object obj)
        {
            Dao.Inserir(obj);
        }

        public virtual void Editar(Object obj)
        {
            Dao.Editar(obj);
        }

        public virtual void Excluir(Object obj)
        {
            Dao.Excluir(obj);
        }

        public virtual object BuscarPorID(Object obj)
        {
           return this.Dao.BuscarPorID(obj);
        }

        public virtual DataTable ListarTodos()
        {
            return Dao.ListarTodos();
        }

        public virtual object Pesquisar(string obj)
        {
            return Dao.Pesquisar(obj);
        }

    }
}
