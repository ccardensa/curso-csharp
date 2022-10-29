using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Example.CodeFirstEF
{
    public class ListaPrecio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdListaPrecio { get; set; }
        public decimal Precio { get; set; }
        public string Temporada { get; set; } //2022-1, 2022-2

        [ForeignKey("IdProducto")]
        public Producto Producto { get; set; }
        public int IdProducto { get; set; }
        public bool IsActive { get; set; }
    }
}
