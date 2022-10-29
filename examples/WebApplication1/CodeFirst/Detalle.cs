using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApplication1.CodeFirstEF
{
    public class Detalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalle { get; set; }
        public string Item { get; set; }
        public int Cantidad { get; set; }

        [ForeignKey("IdDocumento")]
        public DocumentoTributario DocumentoTributario { get; set; }
        public int IdDocumento { get; set; }
    }
}
