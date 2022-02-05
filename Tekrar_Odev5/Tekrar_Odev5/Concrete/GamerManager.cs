using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5.Concrete
{
    public class GamerManager : IGamerService
    {
        private ICheckService _checkService;

        public GamerManager()
        {
        }

        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }


        public void Add(Gamer gamer)
        {
           
            if (_checkService.CheckService(gamer))
              Console.WriteLine("Oyuncu Eklendi...");
            else
                Console.WriteLine("Geçersiz Kullanıcı Tespit Edildi");
        }
        public void Delete(Gamer entity)
        {
            Console.WriteLine("Oyuncu Silindi...");
        }

        public Gamer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("Oyuncu Güncellendi...");
        }

        internal void Add(GamerManager gamerManager)
        {
            Console.WriteLine("Oyuncu Eklendi...");
        }
    }
}
