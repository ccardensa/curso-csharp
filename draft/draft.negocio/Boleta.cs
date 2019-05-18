using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.entity
{
    public class Boleta : DTE
    {
        public int Id { get; }
        public int Rut { get; }
        public string RazonSocial { get; }
        public string Direccion { get; set; }
        public decimal Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public int Impuesto { get; }
        public int SubTotal { get; }
        public int Total { get; }

        public override Producto EliminarItem()
        {
            throw new NotImplementedException();
        }

        public override List<Producto> ListarItems()
        {
            throw new NotImplementedException();
        }

        public override Producto ModificarItem()
        {
            throw new NotImplementedException();
        }

        public override Producto UpdateItem()
        {
            throw new NotImplementedException();
        }
    }
}
