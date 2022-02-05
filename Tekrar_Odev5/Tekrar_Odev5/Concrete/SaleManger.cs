using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5.Concrete
{
    class SaleManger : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(
                game.GameName+" Oyunu "+
                gamer.GamerName+
                " "+
                gamer.GamerLastName+" Adlı oyuncuya "+
                campaign.CamapignName+" Kampanyası ile "+
                game.GamePrice+" TL Fiyatına Satılmıştır"
                );
        }

   
    }
}
