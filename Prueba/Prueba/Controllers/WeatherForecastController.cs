using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba.Dto;
using Prueba.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Conexion context;

        public WeatherForecastController(Conexion context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Contacto> Get()
        {
            return context.Contacto.ToList();
        }
    }
}
