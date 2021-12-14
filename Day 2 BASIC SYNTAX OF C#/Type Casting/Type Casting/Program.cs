using System;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //char -> int -> long -> float -> double//
            //type casting hierarchy//
            int a = 9;
            double d = a;//implicit type castign done//
            Console.WriteLine(d);
            //Explicit type casting//
            double dd = 89.99;
            int a1 = (int)dd;
            Console.WriteLine(dd);
            Console.WriteLine(a1);

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    
            Console.WriteLine(Convert.ToDouble(myInt));    
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}
