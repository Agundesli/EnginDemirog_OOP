using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Abstract;

namespace Tekrar_Odev5.Entities
{
    public class Game:ICooperate
    {
        public string GameName { get; set; }
        public string GameType { get; set; }
        public int GamePrice { get; set; }
        public int Id { get ; set ; }
    }
}
