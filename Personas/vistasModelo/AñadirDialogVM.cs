using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vistasModelo
{
    class AñadirDialogVM: ObservableObject
    {
        private string _nacionalidad;

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { SetProperty(ref _nacionalidad, value); }
        }
    }
}
