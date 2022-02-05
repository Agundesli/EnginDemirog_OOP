using System;
using System.Collections.Generic;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            Console.WriteLine(plakalar.Count);
            plakalar.Add(34, "İstanbul");
            plakalar.Add(33, "İstanbul");
            plakalar.Add(32, "İstanbul");
            plakalar.Add(31, "İstanbul");
            Console.WriteLine(plakalar.Count);
            MyDictionary<int, string> plakalar2 = new MyDictionary<int, string>();
            Console.WriteLine(plakalar2.Count);
            plakalar2.Add(34, "İstanbul");
            plakalar2.Add(33, "İstanbul");
            plakalar2.Add(32, "İstanbul");
            plakalar2.Add(31, "İstanbul");
            Console.WriteLine(plakalar2.Count);
        }
    }
    class MyDictionary<K,V>
    {
        K[] k_array;
        V[] v_array;

        K[] k_temp_array;
        V[] v_temp_array;
        public MyDictionary()
        {
            k_array = new K[0];
            v_array = new V[0];
        }

        public void Add (K item1,V item2)
        {
            k_temp_array = k_array;
            v_temp_array = v_array;

            k_array = new K[k_array.Length+1];
            v_array = new V[v_array.Length+1];

            for (int i = 0; i < k_temp_array.Length; i++)
            {
                k_array[i] = k_temp_array[i];
            }

            for (int i = 0; i < v_temp_array.Length; i++)
            {
                v_array[i] = v_temp_array[i];
            }

            k_array[k_array.Length - 1] = item1;
            v_array[v_array.Length - 1] = item2;

        }
        public int Count
        {
            get { return k_array.Length; }
   
        }
    }
}
