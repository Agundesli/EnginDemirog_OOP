using Ders2_Odev5_Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev5_Uygulama.Abstract
{
    public interface IDataManager
    {
        public void Add();
        public void Update();
        public void Delete();
    }
}
