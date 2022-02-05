using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1_GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        
        //Constructer
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] temparray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < temparray.Length; i++)
            {
                items[i] = temparray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
