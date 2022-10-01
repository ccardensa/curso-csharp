using System;
using System.Collections.Generic;

#nullable disable

namespace CL.Curso.Facturas.Infraestructure.Entitys
{
    public partial class DocumentoElectronico
    {
        public DocumentoElectronico()
        {
            DetalleDtes = new HashSet<DetalleDte>();
        }

        public int Id { get; set; }
        public int? IdTipoDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalExistencias { get; set; }
        public decimal Impuesto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime CreacionDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<DetalleDte> DetalleDtes { get; set; }
    }
}
