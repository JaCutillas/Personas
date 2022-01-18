using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vistasModelo
{
    class NuevaPersonaVM : ObservableObject
    {

        public NuevaPersonaVM()
        {
            ListaNacionalidades = new DatosServicio().GetSampleNacionalidades();
            AñadirCommand = new RelayCommand(AbrirVentanaAñadir);
            servicioNavegacion = new NavegacionServicio();
        }

        private void AbrirVentanaAñadir()
        {
            _ = servicioNavegacion.CrearDialogAñadir();
        }

        private readonly NavegacionServicio servicioNavegacion;

        private ObservableCollection<string> _listaNacionalidades;

        public ObservableCollection<string> ListaNacionalidades
        {
            get { return _listaNacionalidades; }
            set { SetProperty(ref _listaNacionalidades, value); }
        }

        public RelayCommand AñadirCommand { get; }
    }
}
