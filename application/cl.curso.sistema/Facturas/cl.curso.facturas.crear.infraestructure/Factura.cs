using System;
using System.Collections.Generic;

#nullable disable

namespace cl.curso.facturas.crear.infraestructure
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int IdFactura { get; set; }
        public DateTime? Fecha { get; set; }
        public string Direccion { get; set; }
        public string Giro { get; set; }
        public int? NumeroFactura { get; set; }
        public int? IdVendedor { get; set; }
        public string TipoVenta { get; set; }
        public int IdCliente { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
