using System;
using System.Collections.Generic;
using System.Text;

namespace cl.curso.facturas.crear.domain
{
    public interface IFacturaServices
    {
        int CrearFactura(FacturaModel factura);
    }
}
