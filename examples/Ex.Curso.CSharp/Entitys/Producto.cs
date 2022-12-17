using System;
using System.Collections.Generic;

#nullable disable

namespace Examples.Curso.Entitys
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public int? IdProveedor { get; set; }
        public string Nombre { get; set; }
        public int? Size { get; set; }
        public decimal? Precio { get; set; }
        public string IsActive { get; set; }

        public virtual Proveedor IdProveedorNavigation { get; set; }
    }
}
