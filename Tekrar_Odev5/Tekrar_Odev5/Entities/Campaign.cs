using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;

namespace Tekrar_Odev5.Entities
{
    public class Campaign: ICooperate
    {
        public string CamapignName { get; set; }
        public int Id { get; set; }
    }
}
