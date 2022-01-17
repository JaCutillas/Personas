using Personas.ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.servicios
{
    class NavegacionServicio
    {
        public UserControl ListaPersonas { get; }

        public NavegacionServicio()
        {
            ListaPersonas = instanciarListado();
        }

        private UserControl instanciarListado()
        {
            return new Listado();
        }

        public UserControl instanciarNuevaPersona()
        {
            return new NuevaPersona();
        }
    }
}
