using System;
using System.Collections.Generic;

#nullable disable

namespace Examples.Curso.Entitys
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdProveedor { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
