using CL.Curso.Productos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Curso.Productos.Domain.Commands
{
    public interface IProductosCommands
    {
        void CrearProducto(ProductoModel producto);
        void UpdateProducto(ProductoModel producto);
        void DeleteProducto(ProductoModel producto);
    }
}
