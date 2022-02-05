using Ders2_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ders2_Odev4.Abstract
{
    //Normalde ICustomerService Interface sınıfını ilgili Customerlar için implemente edebilirdik.
    //Aynı işlem ile veri tabanına kayıt olacağı için Abstract sınıf açıp Save işlemini burada tanımlayıp
    //Customer classlara bu şekilde referans verebilirim
    public abstract class BaseCustomerManager :ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("FirstName: "+customer.FirstName);
            Console.ReadLine();
            Console.WriteLine("LastName: "+ customer.LastName);
            Console.ReadLine();
            Console.WriteLine("DateOfBirth: " + customer.DateOfBirth);
            Console.ReadLine();
            Console.WriteLine("NationalityId: " + customer.NationalityId);
            Console.ReadLine();
            Console.Write("Saved to DataBase");
            Console.ReadLine();
        }
    }
}
