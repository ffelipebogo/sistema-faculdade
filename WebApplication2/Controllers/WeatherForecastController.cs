using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EquipMotos.MODEL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ContasReceber Get()
        {
            ContasReceber contasReceber = new ContasReceber();
            contasReceber.nome = "teste";
            return contasReceber;

        }
    }
}
