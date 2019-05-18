using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    struct TipoDatos
    {
        int edad;
        double iva;
        long numeroLargo;
        decimal costo;
        float pension;
        string nombre;
        char caracter;

        //comment: definición de campos nulos
        bool? decision1;
        Nullable<bool> decision2;

        DateTime fecha;

        private void hola()
        {
            decision1 = null;
        }

    }
}
