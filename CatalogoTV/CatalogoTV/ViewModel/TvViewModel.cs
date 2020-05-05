using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CatalogoTV.ViewModel
{
    public class TvViewModel : Television
    {
        public ObservableCollection<Television> Televisores { get; set; }
        TvServicio servicio = new TvServicio();

        public TvViewModel()
        {
            servicio.RellenarTv();
            Televisores = servicio.Mostrar();
        }


        public Command MostrarTv { get; set; }
    }
}
