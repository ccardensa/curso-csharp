using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Productos.Infraestructure
{
    public partial class Producto
    {
        public Producto()
        {
            ListaPrecios = new HashSet<ListaPrecio>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ListaPrecio> ListaPrecios { get; set; }
    }
}
