using cl.curso.facturas.leer.infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cl.curso.facturas.leer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeerController : ControllerBase
    {
        private readonly ILogger<LeerController> _logger;
  
        public LeerController(ILogger<LeerController> logger)
        {
            _logger = logger;
        }

        [Route("[action]")]
        [HttpGet]
        public bool HealthCheck()
        {
            var hola = new MongoConnection();
            return false;
        }
    }
}
