using CL.Curso.Productos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Curso.Productos.Domain.Querys
{
    public interface IProductosQuerys
    {
        ProductoModel FindById(int id);
        ProductoModel FindByPredicado();
    }
}
