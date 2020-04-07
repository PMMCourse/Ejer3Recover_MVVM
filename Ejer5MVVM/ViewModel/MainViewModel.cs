using Ejer5MVVM.Models;
using Ejer5MVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private User user;

        public string FirstName
        {
            get { return user.FirstName; }
            set
            {
                if (user.FirstName != value)
                {
                    user.FirstName = value;
                    OnPropertyChange("FirstName");
                  
                    OnPropertyChange("FullName");
                }
            }
        }

        public string LastName
        {
            get { return user.LastName; }
            set
            {
                if (user.LastName != value)
                {
                    user.LastName = value;
                    OnPropertyChange("LastName");
                   
                    OnPropertyChange("FullName");
                }
            }
        }


        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - user.BirthDate.Year;
                if (user.BirthDate > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public MainViewModel()
        {
            user = new User
            {
                FirstName = "Tomás",
                LastName = "Moreno",
                BirthDate = DateTime.Now.AddYears(-20)
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
