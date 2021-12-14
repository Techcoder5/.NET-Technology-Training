using System;
using System.Collections.Generic;

namespace ConsoleApp2_Generic_Implementation
{
    class Program
    {
        //Count function is used to get the the length of the stcak , queue, list etc//
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //List in generics//
            List<int> lstobj = new List<int>();
            lstobj.Add(12);
            lstobj.Add(245);
            lstobj.Add(24353);
            foreach (int i in lstobj){
                Console.WriteLine(i);
            }
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "A");
            d.Add(2, "B");
            int len = d.Count;
            foreach(KeyValuePair<int,string> i in d)
            {
                Console.WriteLine(i.Key+":"+i.Value);
            }

        }
    }
}
