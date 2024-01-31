using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonas
{
    internal class PersonaService
    {
        public ObservableCollection<Personas> GetSample()
        {
            ObservableCollection<Personas> personas = new ObservableCollection<Personas>();

            personas.Add(new Personas("Pietro", 30, "Italiana"));
            personas.Add(new Personas("Julia", 25, "Española"));
            personas.Add(new Personas("Sophie", 35, "Francesa"));

            return personas;
        }
    }
}
