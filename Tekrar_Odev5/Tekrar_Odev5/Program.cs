using System;
using Tekrar_Odev5.Abstract;
using Tekrar_Odev5.Adapters;
using Tekrar_Odev5.Concrete;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                GamerName = "Abdullah Usame",
                GamerLastName = "Gündeşli",
                Id = 1,
                BirthYear = 1994,
                NationalityId = 34681593032
            };
            Gamer gamer2 = new Gamer
            {
                GamerName = "Abdullah",
                GamerLastName = "Gündeşli",
                Id = 1,
                BirthYear = 1994,
                NationalityId = 34681593032
            };
            Game game1 = new Game
            {
                GameName = "Chess",
                GamePrice = 100,
                Id = 1,
                GameType = "Strateji"
            };
            Game game2 = new Game
            {
                GameName = "Call of Duty",
                GamePrice = 100,
                Id = 1,
                GameType = "Savaş"
            };

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CamapignName = "Herkes Satranç Öğrensin"
            };
            Campaign campaign2 = new Campaign
            {
                Id = 1,
                CamapignName = "Herkes Savaş Öğrensin"
            };

            GamerManager gamerr = new GamerManager(new MernisServiceAdapters());
            gamerr.Add(gamer1);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            SaleManger saleManger = new SaleManger();
            saleManger.Sale(gamer1, game1, campaign1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign());


            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            GameManager gameManager = new GameManager();
            gameManager.Delete(new Gamer());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new GamerManager());



        }
    }
}
