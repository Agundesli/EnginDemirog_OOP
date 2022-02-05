using Ders2_Odev5_Uygulama.Abstract;
using Ders2_Odev5_Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev5_Uygulama.Concrete
{
    public class GamerManager : IDataManager
    {
        ICheckService _checkService;

        public GamerManager()
        {
        }

        public GamerManager(GamerManager gamerManager)
        {
        }

        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }
        public void Add(Gamer gamer)
        {
            if (_checkService.CheckService(gamer)) 
            {
                Console.WriteLine("Oyuncu "+ gamer.FirstName+ " Eklendi.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName+" İsimli Oyuncu Bulunamadı.");
            }
        }
        public void Add()
        {
            Console.WriteLine("Oyuncu Eklendi...");
        }
        public void Delete()
        {
            Console.WriteLine("Oyuncu Silindi");
        }
        public void Update()
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
