using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace CatalogoTV
{
    public class TvServicio : Television
    {
        //Coleccion para objetos de tipo television
        //Antes privado
        public ObservableCollection<Television> _televisores { get; set; }
        
        
        public ObservableCollection<Television> televisores
        {
            get { return _televisores;  }
            set
            {
                _televisores = value;
                //RaisePropertyChanged("televisores");
            }

        }
        

        public void RellenarTv()
        {
            ObservableCollection<Television> temp = new ObservableCollection<Television>();
            temp.Add(new Television()
            {
                Marca = "LG",
                Modelo = "lqop",
                Tamaño = 55,
                Resolucion = "FHD"
            });

            temp.Add(new Television()
            {
                Marca = "Samsung",
                Modelo = "12345",
                Tamaño = 42,
                Resolucion = "4k"
            });

            temp.Add(new Television()
            {
                Marca = "Philips",
                Modelo = "werfd",
                Tamaño = 43,
                Resolucion = "HD"
            });

            televisores = temp;
        }

        //Muestra todos los objetos de la lista Televisores (como un SELECT *)
        public ObservableCollection<Television> Mostrar()
        {
            return televisores;
        }
    }
}
