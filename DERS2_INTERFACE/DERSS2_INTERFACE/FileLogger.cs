using System;

namespace DERSS2_INTERFACE
{
    class FileLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
