using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApplication1.CodeFirstEF
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public bool IsActive { get; set; }

        public ICollection<ListaPrecio> ListaPrecioProductos { get; set; }
                        = new List<ListaPrecio>();
    }
}
