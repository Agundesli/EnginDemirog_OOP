using Ders2_Odev4.Abstract;
using Ders2_Odev4.Entities;
using MernisServiceReference;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace Ders2_Odev4.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                (customer.NationalityId, customer.FirstName, customer.LastName,
                customer.DateOfBirth).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
