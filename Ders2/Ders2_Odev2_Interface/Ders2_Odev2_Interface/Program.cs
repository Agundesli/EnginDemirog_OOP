using System;

namespace Ders2_Odev2_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customer = new Customer();
            //customer.Add();
            //IPersonManager employee = new Employee();
            //employee.Update();



            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new Customer());
            projectManager.Update(new Employee());
            projectManager.Add(new Intern());
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class Customer : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi..");
        }
    }
    class Employee : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi..");
        }
    }
    class Intern : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer Eklendi..");
        }

        public void Update()
        {
            Console.WriteLine("Stajer Güncellendi..");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
