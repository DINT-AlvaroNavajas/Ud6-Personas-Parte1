using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonas
{
    internal class UserControl1VM : ObservableObject
    {
        public NavegacionService servicioNavegacion;

        private Personas nuevaPersona;

        private ObservableCollection<string> listaNacionalidades;

        public Personas NuevaPersona
        {
            get => nuevaPersona;
            set => SetProperty<Personas>(ref this.nuevaPersona, value, nameof(NuevaPersona)); 
        }

        public ObservableCollection<string> ListaNacionalidades
        {
            get => this.listaNacionalidades;
            set => this.SetProperty<ObservableCollection<string>>(ref this.listaNacionalidades, value, nameof(ListaNacionalidades));
        }

        public RelayCommand AceptarNuevaPersonaCommand { get; }
        public RelayCommand AbrirDialogoCommand { get; }

        public UserControl1VM()
        {
            servicioNavegacion = new NavegacionService();
            AbrirDialogoCommand = new RelayCommand(AbrirDialogo);
            this.NuevaPersona = new Personas();
            ObservableCollection<string> observableCollection = new ObservableCollection<string>();
            observableCollection.Add("Italiana");
            observableCollection.Add("Española");
            observableCollection.Add("Francesa");
            this.ListaNacionalidades = observableCollection;
            this.AceptarNuevaPersonaCommand = new RelayCommand(new Action(this.AñadirPersona));
        }

        private void AbrirDialogo()
        {             
            servicioNavegacion.AbrirDialogo();
        }

        private void AñadirPersona()
        {
            throw new NotImplementedException();
        }
    }
}
