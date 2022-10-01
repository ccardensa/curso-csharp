using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL.Curso.Facturas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {

        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }
       
        // GET api/<ValuesController>/5
        [HttpGet]
        public string Check(int id)
        {
            return "Validar el funcionamiento de la API";
        }

        // POST api/<ValuesController>
        [HttpGet]
        public string DbCheck(int id)
        {
            return "Validar el funcionamiento de la API con la DB";
        }


    }
}
