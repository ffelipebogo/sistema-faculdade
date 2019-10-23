using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    class Modelos : Base
    {
        //public int id { get; set; }
        public string modelo { get; set; }
        public Marcas Marca { get; set; }
    }
}
