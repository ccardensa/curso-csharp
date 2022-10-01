using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Facturas.Infraestructure.Entitys
{
    public partial class Cliente
    {
        public Cliente()
        {
            DocumentoElectronicos = new HashSet<DocumentoElectronico>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Fono { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<DocumentoElectronico> DocumentoElectronicos { get; set; }
    }
}
