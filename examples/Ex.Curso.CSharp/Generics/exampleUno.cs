using Example.Curso.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Curso.Generics
{
    public class exampleUno<T>
    {
        //Generics es una funcionalidad que nos da .NET la cual nos permite crear código reusable
        //entre multiples entidades

        //Cuando creamos código genérico lo hacemos pensando para que el código sea compatible
        //con cualquier dato y seguro ante diferentes tipos

        //Clase generica con métodos genéricos
        public bool Success;
        public List<string> Queue { get; set; }
        public T Factura { get; set; }

        public void NewQueue()
        {
            Queue = new List<string>();
        }

        public void addQueue(string mensaje)
        {
            Queue.Add(mensaje);
        }

        public void SetFactura(T factura)
        {
            this.Factura = factura;
        }

    }
}
