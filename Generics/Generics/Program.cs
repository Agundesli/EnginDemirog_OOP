using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> sehirler = new List<string>();
            //new yaptığımız anda eleman sayısı sıfırlanıyor yani yeni bir ref ıd ekleniyor ve eleman sayısı
            //belirtilmediği için içerisi sıfır oluyor. Bunun sebebi bir metot gibi çalışan constructer tetikle
            //niyor.
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);
            //count ifadesi bir proporty yani özelliktir. Metot olsyadı count() şeklinde kullanmam gerekirdi.
         

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count);
            
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _temparray;
        public MyList()
        {
            _array = new T[0];
        }
            //hangi tipte gönderirsem o tipte oluşması için bir array tanımlıyorum. Amaç aray new edildiği zaman
            //içeriyi sıfırlayacak bir tatiklenme. Yani constructer yapısı oluşturmak.
        public void Add(T item)
        {
            _temparray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
