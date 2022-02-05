using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERSS2_INTERFACE
{
    class SmsLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Kaydı Yollandı.");
        }
    }
}
