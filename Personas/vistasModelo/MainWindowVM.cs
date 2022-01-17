using clases.Persona;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.vistasModelo
{
    class MainWindowVM : ObservableObject
    {
        public MainWindowVM()
        {
            NuevaPersonaCommand = new RelayCommand(MostrarNuevaPersona);
            ListadoCommand = new RelayCommand(MostrarListado);
        }

        private void MostrarListado()
        {
            PestañaActual = servicioNavegacion.ListaPersonas;
        }

        private void MostrarNuevaPersona()
        {
            PestañaActual = servicioNavegacion.instanciarNuevaPersona();
        }


        private readonly NavegacionServicio servicioNavegacion = new NavegacionServicio(); 
        public RelayCommand NuevaPersonaCommand { get; }
        public RelayCommand ListadoCommand { get; }

        private UserControl _pestañaActual;

        public UserControl PestañaActual
        {
            get { return _pestañaActual; }
            set { SetProperty(ref _pestañaActual, value); }
        }

        private ObservableCollection<Persona> _listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return _listaPersonas; }
            set { SetProperty(ref _listaPersonas, value); }
        }


    }
}
