using Ders2_Odev5_Uygulama.Abstract;
using Ders2_Odev5_Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev5_Uygulama
{
    public class Game:Cooperate, IEntity
    {
        public String GameName { get; set; }
        public string GameType { get; set; }
    }
}
