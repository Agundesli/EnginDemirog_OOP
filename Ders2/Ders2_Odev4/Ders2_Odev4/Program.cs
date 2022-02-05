using Ders2_Odev4.Abstract;
using Ders2_Odev4.Adapters;
using Ders2_Odev4.Concrete;
using Ders2_Odev4.Entities;
using System;

namespace Ders2_Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapters());
            customerManager.Save(new Customer
            {
                DateOfBirth = 1994,
                FirstName = "Abdullah Usame ",
                LastName = "Gündeşli",
                NationalityId = 34681593032
            });

            Console.ReadLine();
         }
    }
}