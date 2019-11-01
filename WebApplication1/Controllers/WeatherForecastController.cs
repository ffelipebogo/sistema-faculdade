using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/contas")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "AGORA VAI";
        }
    }
}
