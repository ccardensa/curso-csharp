using Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Factura : DTE, IFactura
    {
        public int numeroFactura;
        public string RazonSocial;

        public override int CalculoImpuesto()
        {
            //puedo crear mi pripio moto de calculo de impuestos
            //return base.CalcularIVANacional();
            return 0;
        }

        public override int[] ObtenerItems()
        {
            throw new NotImplementedException();
        }

        public string[] ObtenerProveedor()
        {
            throw new NotImplementedException();
        }
    }
}
