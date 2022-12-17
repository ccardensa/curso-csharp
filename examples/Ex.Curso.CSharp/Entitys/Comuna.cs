using System;
using System.Collections.Generic;

#nullable disable

namespace Examples.Curso.Entitys
{
    public partial class Comuna
    {
        public int IdComuna { get; set; }
        public int? IdCiudad { get; set; }
        public string Nombre { get; set; }
        public string Sufijo { get; set; }

        public virtual Ciudad IdCiudadNavigation { get; set; }
    }
}
