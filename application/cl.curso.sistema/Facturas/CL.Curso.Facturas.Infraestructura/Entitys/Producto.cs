using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Facturas.Infraestructure.Entitys
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleDtes = new HashSet<DetalleDte>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }

        public virtual ICollection<DetalleDte> DetalleDtes { get; set; }
    }
}
