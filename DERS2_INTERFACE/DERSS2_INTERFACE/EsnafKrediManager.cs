using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERSS2_INTERFACE
{
    class EsnafKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı...");
        }
    }
}
