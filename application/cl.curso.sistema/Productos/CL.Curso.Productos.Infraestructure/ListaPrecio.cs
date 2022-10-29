using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Productos.Infraestructure
{
    public partial class ListaPrecio
    {
        public int IdListaPrecio { get; set; }
        public int Precio { get; set; }
        public string Temporada { get; set; }
        public int IdProducto { get; set; }
        public bool IsActive { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
    }
}
