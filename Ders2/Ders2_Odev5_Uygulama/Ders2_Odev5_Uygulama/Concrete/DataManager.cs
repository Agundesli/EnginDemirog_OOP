using Ders2_Odev5_Uygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Odev5_Uygulama.Concrete
{
    public class DataManager
    {
        public void Add(IDataManager dataManager)
        {
            dataManager.Add();
        }
        public void Update(IDataManager dataManager)
        {
            dataManager.Update();
        }
        public void Delete(IDataManager dataManager)
        {
            dataManager.Delete();
        }
    }
}
