using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases.Persona
{
    class Persona
    {
        public int Edad { get; set; }

        public string Nombre { get; set; }

        public string Nacionalidad { get; set; }

        public Persona(int edad, string nombre, string nacionalidad)
        {
            Edad = edad;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
        }

        public Persona() {; }

    }
}
