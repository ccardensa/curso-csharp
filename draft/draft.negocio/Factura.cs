using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.entity
{
    public class Factura : DTE
    {
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

        public override int CalculoTotal(int impuesto, int subtotal)
        {
            return base.CalculoTotal(impuesto, subtotal);
        }
        public override int CalcularImpuestoIVA(int subTotal)
        {
            int impuesto = base.CalcularImpuestoIVA(subTotal);
            int total = impuesto + 100;

            return total;
        }

    }
}
