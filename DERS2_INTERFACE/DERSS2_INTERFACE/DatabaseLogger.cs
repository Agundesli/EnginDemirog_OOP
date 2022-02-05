using System;

namespace DERSS2_INTERFACE
{

    class DatabaseLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
