using System;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int l = s.Length;
            //Accesing string elements//
            foreach(char ch in s)
            {
                Console.Write(ch+" ");
            }
            Console.WriteLine();
            string s1 = "pqrs";
            Console.WriteLine(s+s1);
            //Another way of concat is to use concat function//
            Console.WriteLine(string.Concat(s,s1));
            //acessing index of string elements//
            Console.WriteLine(s.IndexOf('a'));
            //use of susbstring//
            Console.WriteLine(s.Substring(s.IndexOf('a')));
            Console.ReadLine();
        }
    }
}
