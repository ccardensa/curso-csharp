using cl.curso.facturas.crear.infraestructure;
using System;
using System.Linq;

namespace cl.curso.facturas.crear.domain
{
    public class FacturaServices : IFacturaServices
    {
        public int CrearFactura(FacturaModel factura)
        {
            using (var context = new FacturaContext())
            {
                try
                {
                    var entity = Mapeo(factura);

                    context.Add(entity);
                    context.SaveChanges();

                    //if (context.SaveChanges() == 0)

                    return entity.IdFactura;
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

        }

        private Factura Mapeo(FacturaModel factura)
        {
            var entity = new Factura();
            entity.IdCliente = factura.Cliente;
            entity.IdVendedor = factura.Vendedor;
            entity.TipoVenta = factura.TipoVenta;
            entity.Giro = factura.Giro;
            entity.CreateDate = DateTime.Now;

            foreach (var item in factura.Detalle)
            {
                var DetalleEntity = new DetalleFactura();
                DetalleEntity.Cantidad = item.Cantidad;
                DetalleEntity.CodigoItem = item.CodigoItem;
                DetalleEntity.Item = item.Item;
                DetalleEntity.PrecioUnitario = item.PrecioUnitario;
                DetalleEntity.ImpuestoUnico = item.Impuesto;
                DetalleEntity.Descuento = item.Descuento;
                entity.DetalleFacturas.Add(DetalleEntity);
            }

            return entity;
        }
    }
}
