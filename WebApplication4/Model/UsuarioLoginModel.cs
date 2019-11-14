using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplication4.Model
{
    public class UsuarioLoginModel
    {
        [DataMember]
        public string Cpf { get; set; }
        public string Senha { get; set; }
    }
}
