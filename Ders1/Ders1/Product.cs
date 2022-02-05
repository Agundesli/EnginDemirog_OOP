using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    class Product//entity tanımlayan class
    {
        //Burada bir encapsulation oluşturuyorum. İleride ürün clasına bir ekleme çıkarma yada herhangi bir güncelleme
        //yapacağım zaman gelip bu class da ilgili yeri revize etmem yeterli olacaktır.
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //Ürün sınıfı tanımladım. Bu tip classlar için sadece ürün özelliklerİ tanımlanır. Başka hiçbir amacı yoktur.
        //ilgili anahtar tablo ne ise;
        //Ürün-Personel-Müşteri vs onun ile ilgili database de tutmak istediğimiz kriterler hazırlanır.

    }
}
