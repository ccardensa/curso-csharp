using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.entity
{
    public abstract class DTE
    {
        public abstract List<Producto> ListarItems();        
        public abstract Producto UpdateItem();
        public abstract Producto ModificarItem();
        public abstract Producto EliminarItem();
        /// <summary>
        /// Retorna el impuesto del 19% (IVA)
        /// </summary>
        /// <returns></returns>
        public virtual int CalcularImpuestoIVA(int subTotal)
        {
            int impuesto = 19;
            subTotal = subTotal * (impuesto / 100);
            return subTotal;
        }

        /// <summary>
        /// Calcular Total
        /// </summary>
        /// <returns></returns>
        public virtual int CalculoTotal(int impuesto, int subtotal)
        {
            return impuesto + subtotal;
        }
    }
}
