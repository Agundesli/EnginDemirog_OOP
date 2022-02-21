using System;
using System.Reflection;

namespace Ders11_Reflection
{
    class Program
    {
        //Reflection: Çalışma anında nesneler hakkında bilgi almak. ve istersek bu nesneleri çalıştırabilmek için kullanılır.
        //Neden ihtiyaç var: çalışma anında hangi nesne ile çalışacağımızı bilmemizdir.
        //Kullanıcının girdiği değerlere göre;
        //Hangi nesnenin ve hangi metodun çalıştırılacağına o anda karar verdiğimiz durumlarda reflection devreye girer.
        //Bir diğer senaryo; Neneler, özellikler hakkında bilgi almak için kullanılabilir. Çalışma anında.

        static void Main(string[] args)
        {
            //activatör işleminin görevi ile new işlmeinin görevi aynı. fark activatör statik bir sınıf olduğu için onun
            //hafızaya atne yöntemi bu şekilde.Yukarıda verdiğim tipe göre bunu yapıyor

            DortIslem dortislem = new DortIslem(2, 3);
            Console.WriteLine(dortislem.Topla2());
            Console.WriteLine(dortislem.Topla(3, 4));


            //Bu işleri çalışma anında yapacağız diyelim;
            var tip = typeof(DortIslem);
            DortIslem dortislem2= (DortIslem)Activator.CreateInstance(tip,6,7);//Yeni dinamik instance üretiyoruz. Çalışma anında
            Console.WriteLine(dortislem2.Topla(4, 5));
            Console.WriteLine(dortislem2.Topla2());//Parametresiz ve ctor dan gelen _sayi1,_sayi2 yi çalıştırıyor
            //Alınan Hata:System.MissingMethodException: 'No parameterless constructor defined for type
            //'Ders11_Reflection.DortIslem'.'
            //İlgili tip için yani DortIslem Tipinde çalışan dortislem değişkeni için parametresiz ctor tanımlı değil
            //Ya parametre ver, ya da parametresiz ctor tanımla.
            Console.ReadLine();

            //Bazen mevcut metotları bilmeyebiliriz. Yani çalışma sırasında hangi metodun kullanılacağı belli olabilecek
            //dinamik durumlar da vardır. Reflection ile bir Instance oluşturduğumuzda onun metodunuda çalıştırabiliyoruz.
            var instance = Activator.CreateInstance(tip, 5, 10);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");//GetMethod ile istediğimiz metoda ulaşıyoruz       
            Console.WriteLine(methodInfo.Invoke(instance, null));//İnvoke ile de onu çalıştırabiliyoruz

            Console.WriteLine("**************Metot,Nesne vs özelleiklerine ulaşma**************************************");
            var metodlar = tip.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod İsmi: "+info.Name);

                foreach (var parametreinfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre ismi: "+parametreinfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute ismi: "+ attribute.GetType().Name);
                }
            }
        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1,int sayi2)//Kullanıcıdan aldığım değerlerin atamasını yaptım.
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()//Parametrsiz CTOR
        {

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
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    class MetodNameAttribute:Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
