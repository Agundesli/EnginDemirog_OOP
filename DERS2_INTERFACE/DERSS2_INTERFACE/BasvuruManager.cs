using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERSS2_INTERFACE
{
    class BasvuruManager
    {
        //BaşvuruYap manager hesaplanır ya da yönetilirken yüzlerce kredi çeşidine göre başvuru girilecektir
 

        //bu işelem ile ben method injection yaptım.
        //Yani Başvuru Yap methoduna iki parametre verdim bu parametre değişkenleri interface ile 
        //referans numarası tutulan birden fazla class.Böylece Başvuru işlemlerinde hangi kredi türü
        //ya a hangi loglayıcı olduğuna dair bir bilgi tutmakla vakit ve enerji katbetmiyorum.
        //interface bunu benim için yapıyor

        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService>kayıtlar)
                                                           //Bu şekilde artık bascuruyap metotu benden 
                                                          //IKrediManager türünde bir KrediManager istiyor.
                                                         //Yani hesaplama yapmak istediğin kredi türünü
                                                        //Tanımla diyor.
        {
            krediManager.Hesapla();//Şimdi ben buraya hangi kredi tipini gönderirsem bellekte onunla ilgili
                                   //hesaplama işlemi çalışacaktır.
            foreach (var log in kayıtlar)
            {
                log.Log();
            }
            //KonutKredıManager konutKredıManager = new KonutKredıManager();
            //konutKredıManager.Hesapla();
            
            //Bu şekiilde giriş yaparsam çalışr ama sadece ilgili kredi türü için sonuç alırım.
            //Burada başvuru yap işleminin dinamik olması lazım. Yüzlerce kredi türünü arka planda bilmesi
            //lazım. O zaman Interface'im benim Ihreritage ettiğim yani miras verdiğim classların referans
            //numarasını tutabiliyotrdu. Burada o tuttuğu ref no ları kullanma zamanı geldi. İnterface ile
            //neden çalıştığım sorusuan cevap. Başvuru yap metoduna interface i tanımlıyorum.
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
