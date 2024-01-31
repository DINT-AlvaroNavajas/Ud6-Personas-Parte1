using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonas
{
    internal class Personas : ObservableObject
    {
        private string nombre;
        private int edad;
        private string nacionalidad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad;}
            set { edad = value; }
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }

        public Personas() { }

        public Personas(string nombre, int edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }
    }
}
