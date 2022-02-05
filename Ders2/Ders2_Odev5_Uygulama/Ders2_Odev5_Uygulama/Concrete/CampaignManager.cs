using Ders2_Odev5_Uygulama.Abstract;
using Ders2_Odev5_Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev5_Uygulama.Concrete
{
    public class CampaignManager : IDataManager
    {
        public void Add()
        {
            Console.WriteLine("KampanyaEklendi...");
        }
        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi");
        }
        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
