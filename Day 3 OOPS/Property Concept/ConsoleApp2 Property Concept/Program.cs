using System;

namespace ConsoleApp2_Property_Concept
{
    class person
    {
        private string name;
        private int roll;
        public string Name
        {
            /*get { return name; }
            set { name = value; }*/
            //Shorthand notation for get and set property concept//
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.Name = "Ram";
            Console.WriteLine(p.Name);
            Console.ReadLine();
        }
    }
}
