using Ders2_Odev4.Abstract;
using Ders2_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev4.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");

            }
        }
    }
}
