using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        /// <summary>
        /// Crea una persona según parametros entregados     
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        public Persona(string nombre, string apellido, int edad, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        /// <summary>
        /// Crea una persona con datos de ejemplo
        /// </summary>
        public Persona()
        {
            this.nombre = "Julia";
            this.apellido = "Perez";
            this.edad = 30;
        }
        //Propiedad de una clase
        public string nombre { get; set; }
        public string apellido { get; }
        public int edad;

        //Metodos de una clase
        public string ObtenerNombreCompleto()
        {
            return nombre + " " + apellido;
        }

       
        private int ModificarEdad(int edad)
        {
            this.edad = edad;
            return this.edad;
        }

        /// <summary>
        /// Procedimiento que calcula la edad
        /// </summary>
        private void CalcularEdad()
        {

        }

        /// <summary>
        /// Función obtener edad
        /// </summary>
        /// <returns></returns>
        public int ObtenerEdad()
        {
            return edad;
        }

    }
}
