using System;
using System.Collections.Generic;

#nullable disable

namespace Examples.Curso.Entitys
{
    public partial class Ciudad
    {
        public Ciudad()
        {
            Comunas = new HashSet<Comuna>();
        }

        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public string Sufijo { get; set; }

        public virtual ICollection<Comuna> Comunas { get; set; }
    }
}
