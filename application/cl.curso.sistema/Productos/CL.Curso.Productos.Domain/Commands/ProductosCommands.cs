using CL.Curso.Productos.Domain.Model;
using CL.Curso.Productos.Infraestructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Curso.Productos.Domain.Commands
{
    //Command = Write
    public class ProductosCommands : IProductosCommands
    {
        public void DeleteProducto(ProductoModel producto)
        {
            throw new NotImplementedException();
        }

        public void CrearProducto(ProductoModel producto)
        {
            using (var context = new FacturacionCFContext())
            {
                var entity = new Producto();

                entity.Cantidad = producto.Cantidad;
                entity.Nombre = producto.Nombre;
                entity.Codigo = producto.Codigo;
                entity.IsActive = true;

                context.Productos.Add(entity);

                foreach (var item in producto.ListaPrecio)
                {
                    var ListaPrecio = new ListaPrecio();

                    ListaPrecio.Precio = item.Precio;
                    ListaPrecio.IsActive = true;
                    entity.ListaPrecios.Add(ListaPrecio);
                }

                context.SaveChanges();
            }
        }

        public void UpdateProducto(ProductoModel producto)
        {
            throw new NotImplementedException();
        }
    }
}
