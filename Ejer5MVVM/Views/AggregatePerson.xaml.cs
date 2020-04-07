using Ejer5MVVM.Models;
using Ejer5MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ejer5MVVM.Views
{
    /// <summary>
    /// Lógica de interacción para AggregatePerson.xaml
    /// </summary>
    public partial class AggregatePerson : Window
    {        
        public AggregatePerson()
        {
            InitializeComponent();
            
            DataContext = new MainViewModel();
        }        

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AggregateButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text == string.Empty || TextBoxId.Text == string.Empty || TextBoxAge.Text == string.Empty || TextBoxWork.Text == string.Empty) 
            {
                MessageBox.Show("No se puede dejar ningun parametro sin contenido", "Atención", MessageBoxButton.OK);
            }
            else
            {
                TextBoxName.Text = string.Empty;
                TextBoxId.Text = string.Empty;
                TextBoxAge.Text = string.Empty;
                TextBoxWork.Text = string.Empty;
            }
        }
    }
}
