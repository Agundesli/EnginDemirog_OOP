using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5.Concrete
{
    public class GameManager : IGameService
    {

        public void Add(Gamer entity)
        {
            Console.WriteLine("Oyun Eklendi...");
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine("Oyun Silindi...");
        }

        public Gamer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("Oyun Güncellendi...");
        }
    }
}
