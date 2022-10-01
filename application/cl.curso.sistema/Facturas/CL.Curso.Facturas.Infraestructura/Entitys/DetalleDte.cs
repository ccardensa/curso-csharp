using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Facturas.Infraestructure.Entitys
{
    public partial class DetalleDte
    {
        public int IdDetalle { get; set; }
        public int IdDocTributario { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }

        public virtual DocumentoElectronico IdDocTributarioNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
