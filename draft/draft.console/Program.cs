using Ex.Funcionales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var exFunc = new Condicionantes();
            //exFunc.IfTest();

            //Console.WriteLine("Resultado de la condición del Switch: {0}", exFunc.switchTestString(10));
            //exFunc.ForTest();
            exFunc.ForWhile();

            Console.ReadLine();
           
        }
    }
}
