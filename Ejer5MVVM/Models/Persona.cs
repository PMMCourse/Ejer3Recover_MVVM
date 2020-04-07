using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5MVVM.Models
{
    public class Persona
    {
        public string NameAndSurname { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Trabajo Work { get; set; }
    }
}
