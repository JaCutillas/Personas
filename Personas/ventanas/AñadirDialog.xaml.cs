using Personas.vistasModelo;
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

namespace Personas.ventanas
{
    /// <summary>
    /// Lógica de interacción para AñadirDialog.xaml
    /// </summary>
    public partial class AñadirDialog : Window
    {
        AñadirDialogVM vm;
        public AñadirDialog()
        {
            InitializeComponent();
            vm = new AñadirDialogVM();
            DataContext = vm;
        }

        private void AceptadoClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
