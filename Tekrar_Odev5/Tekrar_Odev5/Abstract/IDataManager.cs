using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekrar_Odev5.Entities;

namespace Tekrar_Odev5.Abstract
{
    public interface IDataManager<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public T GetById(int id);
       
        
    }
}
