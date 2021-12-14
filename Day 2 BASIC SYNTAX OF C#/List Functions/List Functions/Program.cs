using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(12);
            l.Add(23);
            l.Add(345);
            l.Add(7833);
            //Count function is used to get the length of collections //
            Console.WriteLine(l.Count);
            foreach (int i in l)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine(l.IndexOf(788));
            l.Insert(2, 67);
            Console.WriteLine(l[2]);
            Console.WriteLine(l.Count);
            List<int> a = new List<int>();
            a.Add(4546);
            a.Add(75577);
            l.InsertRange(1,a);
            Console.WriteLine(l.Count);
            /*var dept = new List<department>()
            {
                new department(){id=1,Name="CSE"},
                new department(){id=2,Name="EN"},
                new department(){id=3,Name="EC"}
            };*/
            l.Sort();
            bool f = l.Remove(5);
            Console.WriteLine(f);
            l.RemoveAt(1);
            //Console.WriteLine(g);
            Console.WriteLine(l.BinarySearch(12));
            //Binary search searches for the element and return the zero based index of the element//
            Console.WriteLine(l.Max());
            Console.ReadLine();
        }
    }
}
