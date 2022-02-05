using Ders2_Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev4.Abstract
{
    public interface ICustomerService
    {
        //IENTİTİY INTERFACE YAPISI CUSTOMER TARAFINDAN IMPLEMETE EDİLDİ VE IENTİTY INTERFACE SINIFI 
        //CUSTOMER SINIFININ REFERANSINI TUTABİLDİĞİ İÇİN, ICUTOMERSERVİCE INTERFACE'İ İÇERİSİNDE 
        //SAVE METODU OLUŞTURULURKEN PARAMETRE VE DĞİŞKEN OLARAK CUSTOMER ATANABİLDİ.
        //CUSTOMER SINIFINI DEĞİŞKEN TİPİ OLARAK KULLANABİLDİM
        public void Save(Customer customer);
    }
}
