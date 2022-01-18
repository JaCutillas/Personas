using Personas.clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.servicios
{
    class DatosServicio
    {
        public ObservableCollection<Persona> GetSamplePersonas() =>
            new ObservableCollection<Persona>{
                new Persona(58, "Bisonia", "Italiana"),
                new Persona(46, "Juan", "Española"),
            };

        public ObservableCollection<String> GetSampleNacionalidades() =>
            new ObservableCollection<String>() { "Italiana", "Española", "Francesa" };

        public DatosServicio() {; }
    }
}
