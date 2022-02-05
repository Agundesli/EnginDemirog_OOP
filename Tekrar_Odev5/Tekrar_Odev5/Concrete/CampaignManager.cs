using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5.Concrete
{
    public class CampaignManager : ICampaingService
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Kampanya Eklendi...");
        }
        public void Delete(Campaign entity)
        {
            Console.WriteLine("Kampanya Silindi...");
        }
        public Campaign GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Update(Campaign entity)
        {
            Console.WriteLine("Kampanya Güncellendi...");
        }
    }
}
