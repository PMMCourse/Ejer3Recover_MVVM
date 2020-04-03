using Ejer5MVVM.Model;
using Ejer5MVVM.View;
using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
    
    public class MainViewModel : Base.BaseViewModel
    {
        public List<Palabra> p1 = new List<Palabra>();

        private RelayCommand _addButton;
        public ICommand AddButton => _addButton;

        private RelayCommand _navegar;
        public ICommand Navegar => _navegar;

        public MainViewModel()
        {
            _navegar = new RelayCommand(Navigate);
        }

        private void Navigate()
        {
            Buscador b1 = new Buscador(p1);
            b1.Show();
        }
    }
}
