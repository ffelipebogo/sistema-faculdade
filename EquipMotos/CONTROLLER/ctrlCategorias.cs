using EquipMotos.DAO;
using EquipMotos.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.CONTROLLER
{
    class CtrlCategorias : Controller
    {
        CategoriasDAO DaoCategoria = null;

       public CtrlCategorias() : base(new CategoriasDAO())
        {
            this.DaoCategoria = (CategoriasDAO)this.Dao;
        }

    }
}
