using System;

namespace Ders1_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List,Koleksiyonlar vs olmasa idi kendi listelerimi nasıl olşturabilirim?
            //Generic Classların çalışacağı türü <> ifadelerinin arasında belirtmek zorundayım.
            //Çünkü genric classalar birden fazla değişken tipi barındırdığı için biz yazacağımız koda göre
            //gerenic methoda string mi int mi bool mu belirtmek zorundayız
            //GenericClass lar çalışacağın özel bir type olduğunu belirtmeni sağlar
            //ben sadece bir sabit değişken türü verirsem sadece o değş. ile çalışır.
            //ama ben bunu değş istediğim için <> ifadesini içerisne bit type etıyorum. Alakasız bir type
            //Bu type daha sonra new ettiğim dizi kullanılırken isteğe bağlı değş. atamamı sağlasın diye.
            //list arka planında bir array tutuyor.
            MyList<string> isimler = new MyList<string>();
        }
    }
}
 