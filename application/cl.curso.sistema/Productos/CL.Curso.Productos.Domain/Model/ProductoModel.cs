using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Curso.Productos.Domain.Model
{
    public class ProductoModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public bool IsActive { get; set; }
        public List<ListaPrecioModel> ListaPrecio { get; set; }
    }

    public class ListaPrecioModel
    {
        public int IdListaPrecio { get; set; }
        public int Precio { get; set; }
        public string Temporada { get; set; }
        public int IdProducto { get; set; }
        public bool IsActive { get; set; }
    }
}
