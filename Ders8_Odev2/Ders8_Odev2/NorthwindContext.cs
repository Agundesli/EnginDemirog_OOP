using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_Odev2
{
    //Bu sınıfı açma sebebimiz Classlar ile Database arasındaki köprüyü kurmak.
    //DbContext ile inheritence ederek bu yol açılmış olur
    //Nuget pazarından entityframework'u aktif et
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
            //bu şekilde override ile mevcut metodu ezerek çalışmak istediğim veritabanını seçtim. Peki tablolar ile nasıl
            //ilişkilendireceğim? onun içinde prop özelliği kullanacağım.
        }
        public DbSet<Product> Products { get; set; }//Product classı ile veri tabanındaki Products tablosu ilişkilendirildi
    }


    //Giriş: DbContext uygulamadaki nesneler ile veri tabanındaki tabloları ilişkilendirmeyi sağlayan aracıdır. Neden böyle bir
    //şeye ihtiyaç duyarız? Büyük sistemlerde sunucular databaseler uygulamalr ile aynı pc de olmayabilir. Bu durumda biz hangi veri
    //tabanı ile çalışacağımızı contexte anlatmalıyız. Nasıl? DbContext definationlarına baktığımızda OnConfiguring metodu Virtual
    //yapıdadır. Bunun sebebi bizim hangi veri tabanı ile çalışacağımız contexte anşlatmal için onu override etmeliyiz
    //override:Üzerine yazmak, mevcut metodu ezmek anlamındadır. EntityFramework kütüphansi bize bu imkanı vermemk için 
    //yani DbContexti override edebilmemiz için Onconfiguring metodunu virtual olarak da tanımlamıştır.
    //Virtual: Bir class içerisinde bir metodu yazıyoruz onu inheritence eden yani miras alanb class isterse o metodu değiştire-
    //biliyor
    //yani bir class içerisinde override yapabilmem için ona miras veren sınıfın virtual olarak tanımlanması gerekir.
    //****************************ÖRNEK***********************:
    public class A
    {
        public virtual void Do()//Virtual ile tanımladım
        {
            //
            //
            //

        }
    }
    public class B : A//Aclassı inheritence edildi ve override ile do metodu üzerinde değişikli yapılabilcek
    {
        public override void Do()
        {
            base.Do();
        }
    } 
}
