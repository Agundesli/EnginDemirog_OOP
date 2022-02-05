using Ders2_Odev4.Abstract;
using Ders2_Odev4.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                                                                           
using System.Threading.Tasks;

namespace Ders2_Odev4.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
