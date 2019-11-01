using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EquipMotosWEB.Controllers
{
    [Route("api/contas")]
    public class ContaReceberController : ApiController
    {
        [HttpGet]
        [Route("teste")]
        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
    }
}
