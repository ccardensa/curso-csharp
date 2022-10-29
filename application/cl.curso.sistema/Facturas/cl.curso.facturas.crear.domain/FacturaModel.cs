using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cl.curso.facturas.crear.domain
{
    public class FacturaModel
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }

        [Required]
        public string Giro { get; set; }
        public string TipoVenta { get; set; }
        public int NumeroFactura { get; set; }
        public int Vendedor { get; set; }
        public int Cliente { get; set; }
        public List<DetalleModel> Detalle { get; set; }
    }
}
