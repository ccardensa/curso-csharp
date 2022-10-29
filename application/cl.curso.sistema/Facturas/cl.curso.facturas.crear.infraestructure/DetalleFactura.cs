using System;
using System.Collections.Generic;

#nullable disable

namespace cl.curso.facturas.crear.infraestructure
{
    public partial class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public string Item { get; set; }
        public int? Cantidad { get; set; }
        public int IdFactura { get; set; }
        public int? CodigoItem { get; set; }
        public int? PrecioUnitario { get; set; }
        public int? ImpuestoUnico { get; set; }
        public int? ImpuestoDos { get; set; }
        public int? ImpuestoTres { get; set; }
        public int? Descuento { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; }
    }
}
