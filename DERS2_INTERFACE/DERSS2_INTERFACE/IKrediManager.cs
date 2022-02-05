using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERSS2_INTERFACE
{

    //Interface bizim için şablondur.
    //Eğer bir sınıf bir ınterface ı kullanıyorsa o interfacein metotlarına 
    //sahip olmalıdır.
    //ortak işlemlere sahip yüzlerce sınıfın olsun.
    //hepsinde hesaplama yapmam gerekeiyor ama her hesapla birbirinden farklı çalışıyor. 
    //o zamam bu metodu ınterfacede tanımlıyorum.
    //ınterfaceden beslenen bütün sınıflara da bu metodu ataıyorum.
    //bütün classlara gidip implement işlemini uyguluyorum.

    //özet:Bir ınterface var, bu interface kurallar içerir. Ve onu implement eden yani onu uygulayan classlar
    //o kuralları kendine göre doldurmak zorundalar

    //Genelde interface'i operasyonel metotlarda kullanırız

    //İnterfaceleri birbirinin alternatifi olan ama kod içerikli fartklı olan içerikler için kullanırız.
    //örenek kredi hesaplama. her kredi için ortaktır sadece yöntemi farklıdır. bu yüzden hesaplama metotu 
    //ınterfacede tanımlanıyor. Peki her clasın altında tanımlayamaz mıydım? Tanımlardım. Ama interface
    //kullanma sebebim ilgili kredi sınıflarının referansını tutmak ve daha sonra ki gereken işlemlerde
    //bu referanslar üzerinden işleme geçmek.

    interface IKrediManager
    {
        void Hesapla();
    }

}
