using System;

namespace ConsoleApp2_Inheritance
{
    class Department
    {
        string dept_name;
        public void name()
        {
            Console.WriteLine("Computer Science Department");
        }
    }
    class Student: Department
    {
        public string std_name = "Ajay";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.name();
            Console.WriteLine(p.std_name);
        }
    }
}
