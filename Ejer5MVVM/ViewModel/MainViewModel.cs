using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        private string nombre;
        private string contraseña;

        private ICommand loginCommand;
        public MainViewModel()
        {
            loginCommand=new Command(PerformMainCommand)
        }
        public string Nombre
        {
            get => nombre;
            set
            {
                Nombre = value;
                RaiseProperty();
            }
        }
        public string Contraseña
        {
            get => contraseña;
            set
            {
                contraseña = value;
                RaiseProperty();
            }
        }
        public ICommand LoginCommand
        {
            get => loginCommand;
        }
        public void PerformMainCommand()
        {
            
        }
    }
}
