using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Facturas.Infraestructure.Entitys
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            DocumentoElectronicos = new HashSet<DocumentoElectronico>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool IsActive { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual ICollection<DocumentoElectronico> DocumentoElectronicos { get; set; }
    }
}
