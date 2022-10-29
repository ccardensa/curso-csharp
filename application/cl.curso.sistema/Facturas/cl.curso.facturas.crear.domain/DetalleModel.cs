using System;
using System.Collections.Generic;
using System.Text;

namespace cl.curso.facturas.crear.domain
{
    public class DetalleModel
    {
        public string Item { get; set; }
        public int Cantidad { get; set; }
        public string IdFactura { get; set; }
        public int CodigoItem { get; set; }
        public int PrecioUnitario { get; set; }
        public int Impuesto { get; set; } //Impuesto calculado o %
        public int Descuento { get; set; }
    }
}
