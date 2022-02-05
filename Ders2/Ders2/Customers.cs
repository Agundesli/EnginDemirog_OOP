using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    class Customers
    {
        public int Id { get; set; }
        public String MusteriNo { get; set; }
    }
}
//Burada base sınıf dediğimiz yani temel sınıf olayı oluşuyor.
//Bizim base sınıfımız customer'dır.
//Customer sınıfı yani base sınıfı referans tutucudur.
//Miras verdiği sınıflar new yapıldığı zaman referansı case class'da tutulur.
//Aynı zamanda miras alan sınıflarda onun proporty'lerini tutabilir
