﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5.Abstract
{
     interface ISaleService
    {
         void Sale(Gamer gamer, Game game, Campaign campaign );
    }
}
