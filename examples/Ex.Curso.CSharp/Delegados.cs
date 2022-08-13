using System;
using System.Collections.Generic;
using System.Text;
using Examples.Curso;

namespace Examples.Curso
{
    public static class Delegados
    {
        public delegate int CalcularIvaDelegate(int impuesto, int valor);
        public delegate int DelegateMultiple(int impuesto, int valor);
        public delegate void FunctionDelegate();

        public static int Multiplicar(int a, int b)
        {
            
            return a * b;
        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static void MultiplicarVoid(int a, int b)
        {
           Console.WriteLine(a * b);
        }

        public static void SumaVoid(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void MetodoUno()
        {
            Console.WriteLine("Método 1");
        }

        public static void MetodoDos()
        {
            Console.WriteLine("Método 2");
        }

        /// <summary>
        /// Delegates
        /// </summary>
        public static void TestDelegate()
        {
            CalcularIvaDelegate sumaDelegate = Suma;
            Console.WriteLine("Suma: " + sumaDelegate(10, 20));

            CalcularIvaDelegate MultiDelegate = Multiplicar;
            Console.WriteLine("Multiplicación: " + MultiDelegate(10, 20));

            Console.WriteLine("Delegado multiple");
            FunctionDelegate Multiple = MetodoUno;
            Multiple += MetodoDos;

            Multiple();

            Console.WriteLine("Delegado Genericos");
            Action<int, int> action = SumaVoid;
            action(10,20);

            action = MultiplicarVoid;
            action(10, 20);

            Console.WriteLine("Delegado para funciones");
            //En el delegado Func adicional a los parametros de entrada debemos agregar en el último lugar el parametro de salida (out)
            Func<int, int, int> Funcion = Suma;
            Console.WriteLine(Funcion(10,20));
            Funcion = Multiplicar;
            Console.WriteLine(Funcion(10, 20));
            Console.ReadLine();

        }


    }
}
