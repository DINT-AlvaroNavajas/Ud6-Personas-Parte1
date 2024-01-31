using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonas
{
    internal class UserControl2VM : ObservableObject
    {
        private PersonaService servicioPersonas;
        private ObservableCollection<Personas> listaPersonas;

        public ObservableCollection<Personas> ListaPersonas
        {
            get => this.listaPersonas;
            set => this.listaPersonas = value;
        }

        public UserControl2VM()
        {
            this.servicioPersonas = new PersonaService();
            this.ListaPersonas = servicioPersonas.GetSample();
        }
    }
}
