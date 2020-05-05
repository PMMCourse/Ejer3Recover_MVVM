using CatalogoTV.ViewModel;
using CatalogoTV.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatalogoTV.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaView : ContentPage
    {
        public ListaView()
        {
            BindingContext = new TvViewModel();
            InitializeComponent();
        }
        private async void  OnSelectedItem(object sender, ItemTappedEventArgs e)
        {
            var servicio = e.Item as Television;
            await Navigation.PushAsync(new TelevisorView(servicio.Marca, servicio.Modelo, servicio.Tamaño, servicio.Resolucion));
        }
    }
}