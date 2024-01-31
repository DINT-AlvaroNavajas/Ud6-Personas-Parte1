using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EjercicioPersonas
{
    internal class NavegacionService
    {
        public UserControl CargarFormulario()
        {
            return new UserControl1();
        }

        public UserControl CargarLista()
        {
            return new UserControl2();
        }

        public void AbrirDialogo()
        {
            Dialogo dialogoNacionalidad = new Dialogo();
            dialogoNacionalidad.ShowDialog();
        }
    }
}
