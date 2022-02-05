using Ders2_Odev5_Uygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev5_Uygulama.Entities
{
    public class Campaign : Cooperate, IEntity
    {   
        public string CampaignName { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignFinishDate { get; set; }
        public String CampaignDescription { get; set; }
    }
}
