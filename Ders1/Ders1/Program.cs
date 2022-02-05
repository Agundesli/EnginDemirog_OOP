using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)//MAİN TABANI, ekranda gösterecek main
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            //referans tiplerin oluşabilmesi için onun new edilmesi gerekir.
            //new ile tanımlanan bir değişken string, class, list vs stack de kaydetmenin yanında,
            //o değişkeni heap e atıyorum
            //orada bir referans numarası veriyorum.
            //Ve bundan sonra o referans numarası üzerinden tanıyorum ilgili değişkeni
            //Değer tiplerde atamalar sadece değeri üzerinden olur ve bütün bağlantı kopar.Yani değişken aldığı değeri 
            //veriyor, atıyor ya da her ne yapmasını istediysen yapıyor ve tüm bağlantı kopuyor. Yani o değişkene,
            //tanımladığın o değişkeni daha sonra istediğin kadar revize et önemli değil ilk değer hep kalıcı olarak kalır.
            //Ama referans tiplerde herşey, yani bu tanımladığımız atamalar referans numarası ile yapılır.
            //referans Tipler oluşturulurken heap de ve stack de kaydedilerek olşturulur ve başka bir yere gönderilirken
            //ilgili heap'ın ona atadığı bellek numarası referans numarası ile gönderilir.
            // Bu yüzde başka bir class içinde veya herhangi yerde değişime update vs uğraması onun ref no üzerinden yapılır.
            // Sonuç olarak ilk atadığımız değer yeni eşitlik ile değiştirilmiş olur.
            // Her şey referans numarası üzerinden gider.
            //Buyüzden ilgili değiken okunurken referans numarası üzerinden okunur.
            //Gittiği her yere o referans no ile gider.

            //productManager.Topla2(3, 5);
            //int toplamasonucu = productManager.Topla(3, 5);
            //Console.WriteLine(toplamasonucu*2);
        }
    }
}
