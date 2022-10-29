using CL.Curso.Facturas.API.Models;
using CL.Curso.Facturas.Domain;
using CL.Curso.Facturas.Infraestructure.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CL.Curso.Facturas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturaController : ControllerBase
    {

        private readonly ILogger<FacturaController> _logger;

        public FacturaController(ILogger<FacturaController> logger)
        {
            _logger = logger;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Factura> Get()
        {
            //cl.curso.facturas.leer
            
            var facturas = new List<Factura>();
            var operations = new Operations();
            var DocumentoElectronico = operations.LeerDocumentosTributarios();

            foreach (var item in DocumentoElectronico)
            {
                var factura = new Factura();
                factura.FechaCreacion = item.CreacionDate;
                factura.Total = item.Total;
                facturas.Add(factura);
            }

            return facturas;
        }

        [HttpPost]
        public IEnumerable<DocumentoElectronico> Create(Factura value)
        {
            //cl.curso.facturas.crear

            var operations = new Operations();
            return operations.LeerDocumentosTributarios();
        }


        // PUT api/<ValuesController>/5
        [HttpPut]
        public void Put(Factura value)
        {

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
