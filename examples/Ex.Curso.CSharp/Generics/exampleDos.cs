using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Curso.Generics
{
    public class exampleDos
    {
        //Método genérico en clase no genérica

        public T GenericMetodo<T>(T tipoGenerico)
        {
            return tipoGenerico;
        }
    }
}
