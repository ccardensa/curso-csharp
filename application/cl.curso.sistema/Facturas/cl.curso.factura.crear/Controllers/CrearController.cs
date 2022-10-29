using cl.curso.facturas.crear.domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cl.curso.facturas.crear.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrearController : ControllerBase
    {
        private readonly ILogger<CrearController> _logger;
        private readonly IFacturaServices _services = new FacturaServices();

        public CrearController(ILogger<CrearController> logger)
        {
            _logger = logger;
        }

        // POST: CrearController/HealthCheck
        [Route("[action]")]
        [HttpGet]
        public bool HealthCheck()
        {
            return false;
        }

        // Post: CrearController
        [Route("[action]")]
        [HttpPost]
        public int Create(FacturaModel Factura)
        {
            if (Factura == null)
                throw new ArgumentNullException(nameof(Factura));
            
            return _services.CrearFactura(Factura);
        }

        [Route("[action]")]
        [HttpPost]
        public bool MassiveCreate(IEnumerable<FacturaModel> Factura)
        {
            if (Factura == null)
                throw new ArgumentNullException(nameof(Factura));

            return false;
        }

    }
}
