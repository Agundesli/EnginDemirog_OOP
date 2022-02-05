using Ders2_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev4.Abstract
{
    public interface ICustomerCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}
