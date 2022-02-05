using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
    class ProductManager//İşleri yapan class, classlar içerisine metotlar ekliyorum.
    {
        public void Add(Product product)//bu aperasyon ile eklme işlemini yapacağım.
                                       // Tanımladığım parametre ve türü bana; ilgili türde bir değişken ver demek
                                       //Sen bana tanımladığın türde bir değişken göndereceksin ve ben onu tanımladığın
                                       //değişken adı ile tutuyor olacağım
        {
            Console.WriteLine(product.ProductName+" Eklendi");
        }
        public void Updata(Product product)
        {
            Console.WriteLine(product.ProductName+" Güncellendi");
        }
        //Manager ya da Service başlıklı claslarda ise CRUD operasyonlarının yapıldığı tabandır.
        //CRUD; Create,Read,Update,Delete gibi işelemler yapılır. Listeleme,Arama...
        //Database de kayıtlı olan veriler işleme girip yönetmek için bu class da tanımlanan, tanımlanacak operasyon ile
        //yönetilir.

        //public int Topla(int sayi1, int sayi2)
        //{
            //return sayi1+sayi2;//Burada ise sen return ile ilgili işlemi yaptırıyorsun ve geri sana işlem sonucunu
                              //veriyor. Yani ilgili sonucu başka yerlerde de çağırabilirsin. Çünkü sonucu return ile aldın
        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);//Bu işlem sonucunu ben kullanmak ister isem void buna izin vermez.
                                          //Void toplama sonucu vermez sadece gösterir ve bitirir.
                                          //ilgili sonucu sadece ekranda görürüm
        //}
        //Void anahtar kelimesi; Void ile belirttiğimiz metotlar git ekle git sil git güncelle vs işlemleri yapıyor
        //İşlemi yaptıktan sonra bitiriyor. O işlem sonunda işlemin ne olduğu geri dönmesi vs ihtiyacın yok ise 
        //void ile tanımlıyoruz.
    }
}
