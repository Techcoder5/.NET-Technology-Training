using System;

namespace ConsoleApp2_OOPS
{
    class Program
    {
        String name = "Abc";
        int roll = 12345;
        int marks = 20;
        int sub1_marks;
        int sub2_marks;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.name);
            Console.WriteLine(p.roll);
            Console.WriteLine(p.marks);
            p.sub1_marks = 20;
            p.sub2_marks = 23;
            Console.WriteLine(p.sub1_marks);
            Console.WriteLine(p.sub2_marks);
            Console.ReadLine();
        }
    }
}
