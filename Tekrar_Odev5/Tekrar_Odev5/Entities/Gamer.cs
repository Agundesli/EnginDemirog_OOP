using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;

namespace Tekrar_Odev5.Entities
{
    public class Gamer:ICooperate
    {
        public string GamerName { get; set; }
        public string GamerLastName { get; set; }
        public int BirthYear { get; set; }
        public long NationalityId { get; set; }
        public int Id { get; set; }
    }
}
