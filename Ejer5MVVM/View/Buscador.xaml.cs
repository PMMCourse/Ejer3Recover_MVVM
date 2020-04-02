using Ejer5MVVM.Model;
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

namespace Ejer5MVVM.View
{
    /// <summary>
    /// Interaction logic for Buscador.xaml
    /// </summary>
    public partial class Buscador : Window
    {
        List<Palabra> palabra;


        public Buscador(List<Palabra> p)
        {
            InitializeComponent();
            this.palabra = p;
        }

    }
}
