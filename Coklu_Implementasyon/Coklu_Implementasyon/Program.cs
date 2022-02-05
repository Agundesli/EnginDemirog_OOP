using System;

namespace Coklu_Implementasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            //Inheritance(Kalıtım):Person sınıfı base yani babadır. Miras, kalıtım verdiği classlar onun 
            //özelliklerini taşır. 
            //Bağımsız olarak kendilerine ait özellikleride olabilir
            //Bir Inheritance sınıfı ınterface den bağımsız olarak kendini new edebilir.
            //Yani ınheritenceler tek başına da bir anlam ifade edebilir
            //Miras alan sınıflar sadece bir classı miras alabilir. Ama birden fazla ınterface miras alabilir
            //ınheritence ile ınterface arasındaki farklardan biride budur.
            Personel[] personels = new Personel[3]
            {
                new Customer{ 
                    FirstName="Abdullah"
                }, 
                new Personel{ 
                    FirstName="Usame"
                }, 
                new Student{
                    FirstName="Yusuf"
                }
            };
            foreach (var p in personels)
            {
                Console.WriteLine(p.FirstName);
            }
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
           
        }
        public void Salary()
        {
           
        }
        public void Work()
        {
          
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {

        }

        public void Salary()
        {
            
        }

        public void Work()
        {
            
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            
        }
    }
}
