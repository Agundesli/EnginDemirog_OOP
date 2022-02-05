using System;
using System.Collections.Generic;

namespace Ders1_Koleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Abdullah", "Usame", "Yusuf", "Kürşat" };
            //add anahtarına alterhatif olarak
            //isimler.Add("Abdullah");
            //isimler.Add("Usame");
            //isimler.Add("Yusuf");
            //isimler.Add("Kürşat");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("Müjgan");
            Console.WriteLine("***********************************");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[4]);

        }
    }
}
