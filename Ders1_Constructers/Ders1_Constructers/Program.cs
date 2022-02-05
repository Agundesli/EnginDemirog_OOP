using System;

namespace Ders1_Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contructer: Bir clası new ettiğimiz zaman çalışan bloktur
            //Bir class ilk kez oluşturulduğunda bir kere çalışır ve bir daha çalışmaz.
            //Yapıcı blok demektir.
            //Constructer bir metot gibi çalışır.Metot mantığı ile çalışır.
            //Yani default hali ile de kullanabilirim. Yada  içerisine parametre tanımlayabilirim.
            //Daha sonra bu metotları claslar içerisinde kullanabilirim.

            Customer customer1 = new Customer {Id=1,FirstName="Abdullah",LastName="Gündeşli",City="Ankara" };
            //Console.WriteLine(customer1.City+" "+customer1.LastName);
            //new işlemi yapıldığı anda constructer arka planda bir defaya mahsus çalışıyor.
            //{} içerisineki tanımlama bir parametre değildir.
            Customer customer2 = new Customer(2, "Usame","Gündeşli","Ankara");
            Console.WriteLine(customer2.FirstName+" "+customer2.LastName+" "+customer2.City+" "+customer2.Id);
            //Sanki bir fonksiyonmuş=metotmuş gibi oluşturduk () içerisinde parametreler tanımlayarak
            //bu parametreleri bir metot gibi başka bir class içerisdinde tanımladıktan sonra new ile
            //() içerisinde yazabildik
        }
    }
    class Customer//Müşteri bilgilerini tutmak için hazırladığımız bir class create ediyoruz
    {
        //Default Constructer. Parameteresi olmayan yapıalrdır
        //Sanki bir metot gibi classın altında açılıyor ama void veya herhangi bir şey dönmüyor.
        //classın içerisinde tanımlansa da tanımlanmasa da arka planda default olarak çalışır
        public Customer()//C1'çalışmasını sağladık.Değişkenleri parametere olarak anlaşılmasın. Onlar class ile
                        //prop edilen özellikler.
        {

        }
        public Customer(int id, string firstname, string lastname, string city)//C2'nin çalışmasını sağladık
                                                                              //Parametere almadı C2 çünkü onları
                                                                              //Contructer çalışırken verdik
        {
            FirstName = firstname;
            LastName = lastname;
            City = city;
            Id = id;
            //class da customer adı altında oluşturulan problara yukarıdaki parametreli atmalıyız
            //çünü main de bunları çağıracağımız ya da yazdıracağım zaman bu özellik isimleri ile getirilebilsin
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
