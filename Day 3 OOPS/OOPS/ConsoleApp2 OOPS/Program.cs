using System;

namespace ConsoleApp2_OOPS
{
    class Program
    {
        /*String name = "Abc";
        int roll = 12345;
        int marks = 20;
        int sub1_marks;
        int sub2_marks;*/
        public int roll;
        public String name;
        public int marks;
        public int sub1_marks;
        public int sub2_marks;
        private string place = "New Delhi";
        //Constructor creation//
        public Program(String nm, int r ,int m, int m1,int m2)
        {
            name = nm;
            roll = r;
            marks = m;
            sub1_marks = m1;
            sub2_marks = m2;
        }

        static void Main(string[] args)
        {
            Program p = new Program("Ajay",1,20,30,50);
            Console.WriteLine(p.name);
            Console.WriteLine(p.roll);
            Console.WriteLine(p.marks);
            /*p.sub1_marks = 20;
            p.sub2_marks = 23;*/
            Console.WriteLine(p.sub1_marks);
            Console.WriteLine(p.sub2_marks);
            Console.WriteLine(p.place);

            Console.ReadLine();
        }
    }
}
