using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EjercicioPersonas
{
    class MainWindowVM : ObservableObject
    {
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }

        public RelayCommand Vista1Command { get; }
        public RelayCommand Vista2Command { get; }

        private NavegacionService servicioNavegacion;

        public MainWindowVM()
        {
            servicioNavegacion = new NavegacionService();
            Vista1Command = new RelayCommand(CargaVista1);
            Vista2Command = new RelayCommand(CargaVista2);
        }

        private void CargaVista1()
        {
            ContenidoVista = servicioNavegacion.CargarFormulario();
        }

        private void CargaVista2()
        {
            ContenidoVista = servicioNavegacion.CargarLista();
        }
    }
}
