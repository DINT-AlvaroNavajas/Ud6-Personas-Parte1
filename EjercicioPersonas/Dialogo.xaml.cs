using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EjercicioPersonas
{
    /// <summary>
    /// Lógica de interacción para Dialogo.xaml
    /// </summary>
    public partial class Dialogo : Window
    {
        DialogoVM vm;
        public Dialogo()
        {
            InitializeComponent();
            vm = new DialogoVM();
            this.DataContext = vm;
        }
    }
}
