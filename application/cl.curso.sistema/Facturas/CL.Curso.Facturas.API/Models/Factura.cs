using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CL.Curso.Facturas.API.Models
{
    public class Factura
    {
        public DateTime FechaCreacion { get; set; }
        public string RutEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public decimal Total { get; set; }
        public FacturaDetalle DetalleFactura { get; set; }
    }

    public class FacturaDetalle
    {
        public int IdProducto { get; set; }
        public int CantidadExistencia { get; set; }

    }


}
