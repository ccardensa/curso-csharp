using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ejemploConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es la instanciación de la clase persona
            //person se convierte en un objeto
            var person = new Persona();
            
            Console.WriteLine(person.nombre + " " + person.apellido);
            Console.ReadKey();            
        }
    }
}
