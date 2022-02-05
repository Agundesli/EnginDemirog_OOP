using System;
using System.Collections.Generic;

namespace DERSS2_INTERFACE
{
    class Program
    {

        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKredıManager konutKredıManager = new KonutKredıManager();
            //konutKredıManager.Hesapla();

            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKredıManager = new KonutKredıManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLogger = new DatabaseLogger();
            ILoggerService fileLogger = new FileLogger();
            ILoggerService smsLogger = new SmsLogger();

            List<ILoggerService> kayitlar = new List<ILoggerService> { new SmsLogger(), new FileLogger() };
           // List<IKrediManager> kredilerr = new List<IKrediManager> { new EsnafKrediManager(),new TasitKrediManager()};
                //bunun içinde başvuru manager de bir list gerekirdi
            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.BasvuruYap(esnafKrediManager, kayitlar);

            //basvuruManager.BasvuruYap(esnafKrediManager, 
            //    new List<ILoggerService> { new DatabaseLogger(), new SmsLogger() });

            //2. şekildeki gibi yaptığımda da sonuç alabilirim(IKrediManager)
            //Yani interfacelerde kendisini implemente eden classların referans numarasını tutabilirler
            //kendisini implemente eden sınıflar için base yapıdadır



            //List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            List<IKrediManager> krediler = new List<IKrediManager>{new IhtiyacKrediManager(), 
                new  TasitKrediManager() };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
