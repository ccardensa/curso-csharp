using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApplication1.CodeFirstEF
{
    public class TipoDocumento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoDocumento { get; set; }
        public string Nombre { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan Timestamp { get; set; }
    }
}
