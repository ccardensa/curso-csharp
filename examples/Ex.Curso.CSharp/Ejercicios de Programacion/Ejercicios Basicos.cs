using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.Curso
{
    public static class Ejercicios
    {
        ///1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.
        ///2) Ingresa por consola tu nombre completo y tu edad y muestra el siguiente mensaje: «Me llamas » <nombre> » y tengo » <años> » años»
        ///3) Ingresa 5 números y muestra su promedio
        ///4) Escribir una funcion que te permita ordenar una lista de 5 números de mayor a menor (puedes usar una lista o un arreglo)
        ///5) Mostrar números impares entre el 0 y el 300
        ///6) Mostrar números pares entre el 0 y el 300
        ///7) Mostrar números entre el 0 y el 200
        ///8) Mostrar la cantidad de vocales que tiene una frase, la frase debe ser capturada desde el teclado
        ///

#region ejercicio de matriz

        public static int[] TwoNum(int[] nums, int root)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++) //2=11
            {
                for (int j = i + 1; j < nums.Length; j++) // 3= 7
                {

                    if (nums[i] + nums[j] == root) //suma la 
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        /// método optimizado de recorrido de una matriz
        /// 
        public static int[] TwoNumOptimizado(int[] nums, int root)
        {
            int[] result = new int[2];
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                hash.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int resto = root - nums[i];
                //var diferencia = Array.IndexOf(nums, resto) == -1 ? 99 : Array.IndexOf(nums, resto);

                //return new int[] { i, diferencia };
                if (hash.ContainsKey(resto) && hash[resto] != i)
                {
                    return new int[] { i, hash[resto] };
                }
            }

            return result;
        }

        public static List<int> TwoNumList(List<int> nums, int root)
        {
            List<int> result = new List<int>();
            //result.IndexOf();
            for (int i = 0; i < nums.Count; i++) //2=11
            {
                for (int j = i + 1; j < nums.Count; j++) // 3= 7
                {
                    if (nums[i] + nums[j] == root) //suma la 
                    {
                        result.Add(i);
                        result.Add(j);
                        return result;
                    }
                }
            }
            return result;
        }

        public static int[] TwoNumOptimizado(List<int> nums, int root)
        {
            int[] result = new int[2];
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < nums.Count; i++)
            {
                hash.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Count; i++)
            {
                int resto = root - nums[i];

                if (hash.ContainsKey(resto) && hash[resto] != i)
                {
                    return new int[] { i, hash[resto] };
                }
            }

            return result;
        }
#endregion
    }
}
