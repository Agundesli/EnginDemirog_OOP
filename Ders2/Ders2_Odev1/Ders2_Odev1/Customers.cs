using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev1
{
    class Customers
        //Bir müşterinin özellikleirni tuttuğumuz bir class oluşturuyoruz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sehir { get; set; }
    }
    class Deneme
    {

        private string _firstname;
        public string FirstName 
        {
            get { return "Mrs."+ _firstname; } 
            set { _firstname = value; }
        }
    }
}
