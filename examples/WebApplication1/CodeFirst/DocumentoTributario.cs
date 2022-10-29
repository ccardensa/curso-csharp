using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApplication1.CodeFirstEF
{
    public class DocumentoTributario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDocumento { get; set; }
        public DateTime Fecha { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdTipoDocumento")]
        public TipoDocumento TipoDocumento { get; set; }
        public int IdTipoDocumento { get; set; }

        public ICollection<Detalle> DetalleDocumentoTributarios { get; set; }
                        = new List<Detalle>();
    }
}
