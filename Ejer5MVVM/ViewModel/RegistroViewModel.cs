using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
    public class RegistroViewModel:Base.BaseViewModel
    {
        private string nombre;
        private string apellidos;
        private string dni;
        private string contraseña;
        private ICommand RegistroCommand;
        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                RaiseProperty();
            }
        }

        public string Apellidos
        {
            get => apellidos;
            set
            {
                apellidos = value;
                RaiseProperty();
            }
        }
        public string Dni
        {
            get => dni;
            set
            {
                dni = value;
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
        public ICommand registroCommand => RegistroCommand;
    }
}
