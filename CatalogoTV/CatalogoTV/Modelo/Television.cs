using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CatalogoTV
{
    public class Television : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propiedad="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
        }

        private String marca;
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private String modelo;
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int tamaño;
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        
        private String resolucion;
        public String Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }

    }
}
