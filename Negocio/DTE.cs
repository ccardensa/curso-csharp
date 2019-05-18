using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    //DTE = Documento Tributario Electronico 
    public abstract class DTE
    {       
        public abstract int[] ObtenerItems();
       
        public abstract int CalculoImpuesto();

        public virtual string Imprimir()
        {
            return "virtual función imprimir ";
        }

        public virtual int CalcularIVANacional()
        {
            //así se calcula el iva en Chile
            return 0;
        }




        
    }
}
