using CL.Curso.Productos.Domain.Commands;
using CL.Curso.Productos.Domain.Model;
using CL.Curso.Productos.Domain.Querys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL.Curso.Productos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {

        private readonly ILogger<ProductoController> _logger;
        private readonly IProductosCommands _command = new ProductosCommands();
        private readonly IProductosQuerys _querys = new ProductosQuerys();

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        [Route("[action]")]
        [HttpGet]
        public IEnumerable<ProductoModel> FindByPredicado(int id)
        {
            return null; //Retornará un json + HTTP 200
        }

        [Route("[action]")]
        [HttpPost]
        // GET: ProductoController/Create
        public ActionResult Create(ProductoModel producto)
        {
            _command.CrearProducto(producto);
            return Ok(); //Return id del producto + HTTP 200
        }

        [Route("[action]")]
        [HttpPost]
        // GET: ProductoController/Edit/5
        public ProductoModel FindById(int id)
        {
            
            return _querys.FindById(id); //Retornar un 200 si la operación fue exitosa
        }

        [Route("[action]")]
        [HttpGet]
        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return NoContent(); //Retornar un 200 si la operación fue exitosa
        }

       

       
    }
}
