using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Funcionales
{
    public class Condicionantes
    {
        //una condicional que determina si algo es verdadero o falso
        public void IfTest()
        {
            //Para los IF evaluan solo true/false

            string saludo = "hola";
            bool rsBooleano = false;

            string respEncuesta = "Hola, como estan";

            if (rsBooleano)
            {
                //Si es verdadero se ejecuta esta rutina
            }
            else
            {
                //si es false ejecute esta otra rutina
            }

            if (!rsBooleano)
            {
                //Si es false se ejecuta esta rutina
            }
            else
            {
                //si es true ejecute esta otra rutina
            }

            if (rsBooleano && saludo.Equals("hola"))
            {

            }
            else if (!rsBooleano && !saludo.Equals("hola"))
            {

            }
            else if (rsBooleano || saludo.Equals("hola"))
            {

            }
            else if (rsBooleano && !saludo.Equals("hola"))
            {

            }

            if (saludo.Equals("hola"))
            {

            }
        }

        public int switchTest(int numero)
        {
            switch (numero)
            {
                case 1:
                    return 10;
                case 10:
                    return 1;
                default:
                    return 0;
            }
        }

        public string switchTestString(int numero)
        {
            switch (numero)
            {
                case (2 * 20):
                    return "Hola, te ganaste la loteria";
                case (2 * 5):
                    return "Te toca lavar los platos";
                default:
                    return "Te toca dormir";
            }
        }


        public void ForTest()
        {
            //for/foreach
            string[] cadena = new string[10];
            cadena[0] = "factura";
            cadena[1] = "boleta";
            cadena[2] = "OC";
            cadena[9] = "Gd";

            for (int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }

            Console.WriteLine("=====================");

            var lstConceptos = new List<string>();
            lstConceptos.Add("Factura");
            lstConceptos.Add("Boleta");
            lstConceptos.Add("Oc");
            lstConceptos.Add("Gd");
            lstConceptos.Add("Otros Documentos");

            foreach (var item in lstConceptos)
            {
                Console.WriteLine(item);
            }
        }

        public void ForWhile()
        {
            string texto = "";
            bool estadoAnimo = false;

            while (string.IsNullOrEmpty(texto))
            {
                texto = "ahora el texto no esta vacio";
                Console.WriteLine("While: {0}; Saludo: {2}", texto, "Hola!", "Chao!");

                Console.WriteLine("While: " + texto + "; Saludo " + "Hola!");

                StringBuilder parrafo = new StringBuilder();
                parrafo.Append("Hola!, ");

                if (estadoAnimo)
                {
                    parrafo.Append("Como estas?");
                }
                else { parrafo.AppendLine("Vamos que se puede!"); }

                Console.WriteLine(parrafo);
                Console.ReadLine();
            }
        }
    }
}
