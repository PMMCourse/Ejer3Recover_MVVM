using CatalogoTV.ViewModel;
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
    public partial class TelevisorView : ContentPage
    {
        public TelevisorView(String Marca, String Modelo, int Tamaño, String Resolucion)
        {
            InitializeComponent();
            _Marca.Text = Marca;
            _Modelo.Text = Modelo;
            _Tamaño.Text = Tamaño.ToString();
            _Resolucion.Text = Resolucion;
            _TituloPagina.Title = "Detalle " + Marca + " " + Modelo;
        }
    }
}