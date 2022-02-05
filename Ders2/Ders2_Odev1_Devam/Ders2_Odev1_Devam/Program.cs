using System;
using System.Collections.Generic;

namespace Ders2_Odev1_Devam
{
    class Program
    {
        //Polimorfizim: Çok biçimlilik, Bir nesneyi farklı amaçlar ile implemente edip, o implementasyonun
        //tamamına ya da belli bir kısmana ulaşmayı sağlamaktır.
        static void Main(string[] args)
        {
            DMLManager dMLManager = new DMLManager();
            dMLManager.Add(new TSQL());

            //SQLDMLManager[] sQLDMLManagers = new SQLDMLManager[3];
            //{
            //    new MsSQL();
            //    new OracleSQL();
            //    new TSQL();
            //}

            //foreach (var sql in sQLDMLManagers)
            //{
            //    sql.Server();
            //}

            List<SQLDMLManager> server = new List<SQLDMLManager> { new OracleSQL(), new TSQL() };
            dMLManager.ServerSec(server);
            Console.ReadLine();
        }
    }
}
