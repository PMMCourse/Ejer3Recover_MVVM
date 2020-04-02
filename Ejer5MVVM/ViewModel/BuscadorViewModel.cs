using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.ViewModel
{
    public class BuscadorViewModel : BaseViewModel
    {
        private List<string> _palabras = new List<string>()
        {
            "Pan",
            "Ruka",
            "Bloste",
            "Mantequilla",
            "Aceite"
        };

        private string _buscarPalabras;
        public string BuscarPalabras
        {
            get => _buscarPalabras;
            set
            {
                _buscarPalabras = value;
                EncontrarPalabras = _palabras.FirstOrDefault(x => x.ToLower().Contains(_buscarPalabras.ToLower()));
                RaiseProperty();
            }
        }

        private string _encontrarPalabras;
        public string EncontrarPalabras
        {
            get => _encontrarPalabras;
            set
            {
                _encontrarPalabras = value;
                RaiseProperty();
            }
        }
    }
}
