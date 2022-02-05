using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev1_Devam
{
    interface SQLDMLManager
    {
        void Add();
        void Delete();
        void Update();
        void Server();

    }
    class OracleSQL : SQLDMLManager
    {
        public void Add()
        {
            Console.WriteLine("Oracle Ekleme Islemi Yapildi...");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Silme Islemi Yapildi...");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Guncelleme Islemi Yapildi");
        }
        public void Server()
        {
            Console.WriteLine("Oracle Server Secildi");
        }
    }
    class MsSQL : SQLDMLManager
    {
        public void Add()
        {
            Console.WriteLine("MsSQL Ekleme Islemi Yapildi...");
        }

        public void Delete()
        {
            Console.WriteLine("MsSQL Silme Islemi Yapildi...");
        }

        public void Update()
        {
            Console.WriteLine("MsSQL Guncelleme Islemi Yapildi...");
        }
        public void Server()
        {
            Console.WriteLine("MsSQL Server Secildi");
        }
    }
    class TSQL : SQLDMLManager
    {
        public void Add()
        {
            Console.WriteLine("TSQL Ekleme Islemi Yapildi...");
        }

        public void Delete()
        {
            Console.WriteLine("TSQL Silme Islemi Yapildi...");
        }

        public void Update()
        {
            Console.WriteLine("TSQL Guncelleme Islemi Yapildi...");
        }
        public void Server()
        {
            Console.WriteLine("TSQL Server Secildi");
        }
    }
    class DMLManager
    {
        public void Add(SQLDMLManager dml)
        {
            dml.Add();
            Console.ReadLine();
        }

        public void ServerSec(List<SQLDMLManager> servers)
        {
            foreach (var join in servers)
            {
                join.Server();
            }
        }
    }
}