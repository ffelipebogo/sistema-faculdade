using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipMotos.MODEL
{
    public class Estados : Base
    {
        //public int id { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }
        public Paises Pais { get; set; }
    }
}
