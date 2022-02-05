using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coklu_Implementasyon
{
    class Personel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Personel 
    {
        public string City { get; set; }
    }
    class Student:Personel
    {
        public string Departman { get; set; }
    }
}
