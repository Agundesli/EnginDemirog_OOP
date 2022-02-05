using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal float boolean değer tiplerinin ataması yapıldıktan sonra değişken ile bir bağlantısı
            //kalmaz.
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 2000;

            //Console.WriteLine("sayi1: "+sayi1);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
           // Console.WriteLine("Sayılar1[0]: "+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            //person1 = person2;

            //New ile tanımlandığı için stack hafızaya ek olarak heap hafızada bu değişkenlere
            //bir referans numarası atandı. Bu andan itibaren referans tipli değişkenlerde
            //herhengi bir revizyona gidildiğinde bu referans no sahip olan tüm değş.
            //için durun aynı olacaktır.Çünkü burada mantık değer eşitlemesi değil adres eşitlemesi yapıyoruz

            person2 = person1;

            Console.WriteLine(person1.FirstName);
            Console.WriteLine("***************");
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Abdullah";
            customer.CredictCardNumber="123456789";
            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CredictCardNumber);
            Console.WriteLine(customer.FirstName);

            //Customer classına Employees'ı Employees classınada Custumer'ı atayamaz iken
            //Customer ve Employees classlarına Person'ı atayabiliyorum. Neden?
            //Customer ve Employees classı Person clasından miras almıştır. İnherit yapıdadır. Yani;
            //Miras aldığımız sınıf özelliklerini kullanabiliriz.
            //
            Employees employees = new Employees();
            employees.FirstName = "Veli";

            Console.WriteLine("*******************************");
            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employees);
            Console.WriteLine("**************************");

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
        //base class: Person
    class Customer:Person
    {
        public string CredictCardNumber { get; set; }
    }
        //base class: Person
    class Employees :Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.LastName);
            
        }

    }
}
