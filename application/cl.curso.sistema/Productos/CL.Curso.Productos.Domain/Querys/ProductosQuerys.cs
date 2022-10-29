using CL.Curso.Productos.Domain.Model;
using CL.Curso.Productos.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CL.Curso.Productos.Domain.Querys
{
    //Querys = read
    public class ProductosQuerys : IProductosQuerys
    {
        public ProductoModel FindByPredicado()
        {
            throw new NotImplementedException();
        }

        public ProductoModel FindById(int id)
        {
            using (var context = new FacturacionCFContext())
            {
                var producto = new ProductoModel();
                try
                {
                    //var result1 = context.Productos.Where(x=>x.IdProducto == id);
                    var result2 = context.Productos.FirstOrDefault(x => x.IdProducto == id && x.IsActive == true);
                    if (result2 != null)
                    {
                        producto.IdProducto = result2.IdProducto;
                        producto.Nombre = result2.Nombre;
                        producto.Codigo = result2.Codigo;

                        foreach (var item in producto.ListaPrecio)
                        {
                            var lista = new ListaPrecioModel();
                            lista.Precio = item.Precio;
                            producto.ListaPrecio.Add(lista);
                        }

                        return producto;
                    }

                    return new ProductoModel();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
