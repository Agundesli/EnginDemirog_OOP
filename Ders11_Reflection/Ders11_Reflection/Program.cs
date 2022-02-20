using System;

namespace Ders11_Reflection
{
    class Program
    {
        //Reflection: Çalışma anında nesneler hakkında bilgi almak. ve istersek bu nesneleri çalıştırabilmek için kullanılır
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(2, 3);
            Console.WriteLine(dortIslem.Topla2());
            Console.WriteLine(dortIslem.Topla(3, 4));

            var type = typeof(DortIslem);

            var dortislem= Activator.CreateInstance(type);

            Console.ReadLine();
        }
    }
    class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1+_sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
