using System;

namespace Ders2_Odev1
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Bir class içerisinde bir takım metotlar barındırır.
            //Bu metotlar başka classlar tarafından kullanılabilir.
            //Yapmak istenilen işlemlerin gruplara ayrılması,işlemlerin gruplar üzerinden yapılmsını sağlamak
            //Claslar bir gruplama tekniği mantığı ile metotlarla kullanılabilir

            ProductManager productManager = new ProductManager();//New ile değişkeni
                                                                 //heap alanada kaydediyorum
            productManager.Add();
            productManager.Update();
            Console.ReadLine();

            //Classlar property dediğimiz(özellikleri) tutabilirler

            Customers customers = new Customers(); //Bir classın proportey Sİ eşitlendiği, new edildği zaman
                                                   //Set bloğu çalışır.Yani set edşyoruz değerşi veriyoruz.
                                                   //Get ilede verdiğimiz değeri çağırıyoruz. 
                                                   //SET ile verileni get ile alıyoruz
            customers.Id = 1;
            customers.FirstName = "Abdullah";
            customers.LastName = "Gündeşli";
            customers.Sehir = "Ankara";

            Customers customer2 = new Customers
            {
                Id = 2,
                FirstName = "Usame",
                LastName = "GÜNDEŞLİ",
                Sehir = "Ankara"
            };

            Console.WriteLine(customers.FirstName);
            Console.WriteLine(customer2.FirstName);

            Deneme deneme = new Deneme();
            deneme.FirstName = "Gizem";
            Console.WriteLine(deneme.FirstName);


            PersonelManager personelManager = new PersonelManager();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Usame";
            customer.LastName = "Gündeşli";
            customer.Adress = "Ankara";

            personelManager.Add(customer);

            Student student = new Student();
            student.Id = 2;
            student.FirstName = "Gamze";
            student.LastName = "Gündüz";
            student.Departman = "Finace";

            personelManager.Add(student);

            personelManager.Add(new Worker { Id = 3 ,FirstName="isci",LastName="Isci"}) ;
            personelManager.Add(new Student { Id = 1, FirstName = "Büşra", LastName = "Yılmaz", Departman = "Industrial" });
            personelManager.Add(new Customer { Id = 1, FirstName = "Abdullah", LastName = "Gündeşli", Adress = "Ankara" });
        }
    }
    class ProductManager
    {
        public  void Add()
        {
            Console.WriteLine("Ürün Eklendi...");//Add metotudu clas içinde tanımlandı
        }
        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi...");//Update metodu clas içinde tanımlandı
        }
    }


    interface IPerson
    {
        //Temal amacı: Bir temel operasyon, bir temel nesne oluşturup, bütün nesneleri ondan implemente etmektir.
        //interface soyut nenedir. Referans verdiği classlar somut nesnelerdir
        //soyut nesne tek başına anlma ifade etmez. Bize lazım olan somut yani manager(işlem) classlardır.
        //Somut classlar soyut clası implemente etti.
        //Biz soyut nesneleri somut neslere tanımlarız.
        //Yani bir interface birden fazla class tarafından implemente edilir
        //Interfacei implemente eden classalra, interface içerisindeki özellikleri tanımlamak zorundasın.
        //İlgili classlara daha sonradan ekle yapılırsa yani yeni bir class create edilirse, soyut sınıf ile implemente
        //edilir. başka bir revizyona gerek kalmaz. Çünkü manager clası içerisinde ılgili ınterface, ımolemente edilen 
        //soyut sınıf parametre oalrak ve tip olarak verildi
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Adress { get; set; }//sadece müşteriye ait bir özellik
    }
    class Student : IPerson
    {
        public int Id { get ; set; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
        public string Departman { get; set; }//sadece öğrenciye ait bir özellik

    }
    class Worker : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
    }
    class PersonelManager
    {
        //Manager ifadesi genelde iş katmanı classlarda kullanılır
        public void Add(IPerson person)//ekleme metotu tanımladık
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
