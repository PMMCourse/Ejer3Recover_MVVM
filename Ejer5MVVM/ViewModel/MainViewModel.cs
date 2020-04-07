using Ejer5MVVM.Models;
using Ejer5MVVM.ViewModel.Base;
using Ejer5MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string _nameAndSurname;
        private string _id;
        private int _age;
        private Trabajo _work;
        private ObservableCollection<Persona> _persons = new ObservableCollection<Persona>();
        
        private ICommand _addPersonToObservable;

        public MainViewModel()
        {
            _addPersonToObservable = new Command(CanExecute,PerformsAddPersonCommand);
        }        
        public string NameAndSurname
        {
            get => _nameAndSurname;
            set
            {
                _nameAndSurname = value;
                RaiseProperty();
            }
        }
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                RaiseProperty();
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                RaiseProperty();
            }
        }
        public Trabajo Work
        {
            get => _work;
            set
            {
                _work = value;
                RaiseProperty();
            }
        }
        public ObservableCollection<Persona> Persons
        {
            get => _persons;
            set
            {
                _persons = value;
                RaiseProperty();
            }
        }
        public ICommand AddPersonToObservable => _addPersonToObservable;
        private void PerformsAddPersonCommand(object sender) // Le he hecho debug y se queda atrancado en CanExecute de la clase Command, Pero en principio si parece que almacena la variable
        {
            Persona p = new Persona();
            p.NameAndSurname = _nameAndSurname;
            p.Id = _id;
            p.Age = _age;
            p.Work = _work;
            _persons.Add(p);
        }
        private bool CanExecute(object parameter) // Lo he hecho para probar el funcionamiento, tendria que hacerlo con todos los parametros
        {
            if (_nameAndSurname == string.Empty)
            {
                return false;
            }
            else
            {                
                return true;
            }

            
        }
    }
    class Command : ICommand //Command artesano ante el Command obsoleto
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;
        public Command(Predicate<object> canExecute, Action<object> execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged
        { 
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter) //AQUI
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
