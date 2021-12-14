using System;

namespace ConsoleApp2_Abstract_Class
{
    abstract class Car
    {
        public abstract void color();
        public void Name()
        {
            Console.WriteLine("BMW");
        }
    }
    class brand : Car
    {
        public override void color()
        {
            Console.WriteLine("Blue");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            brand b = new brand();
            b.Name();
            b.color();
        }
    }
}
