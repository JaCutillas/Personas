using Personas.ventanas;
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

        public bool? CrearDialogAñadir()
        {
            return new AñadirDialog().ShowDialog();
        }
    }
}
