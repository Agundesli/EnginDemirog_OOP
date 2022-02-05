using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;
using Tekrar_Odev5.Entities;
using static MernisServiceReference.KPSPublicSoapClient;

namespace Tekrar_Odev5.Adapters
{
    public class MernisServiceAdapters : ICheckService
    {
        public bool CheckService(Gamer gamer)
        {
            var mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync
                ((gamer.NationalityId), gamer.GamerName, gamer.GamerLastName, gamer.BirthYear).GetAwaiter().GetResult();
            return tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        }
    }
}
