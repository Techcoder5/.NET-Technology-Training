using System;

namespace ConsoleApp1
{
    class Program
    {
        public static bool checkPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                int val = Convert.ToInt32(Math.Sqrt(num));
                bool flag = false;
                for (int i = 2; i <= val; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        /*public static  void passbyvalue(int a1)
        {
            a1 = a1 + 10;
            Console.WriteLine("Value is : " + a1);
        }
        public static void passbyref(ref int b)
        {
            b = b + 10;
            Console.WriteLine(b);
        }
        public static void passbyout(out int d)
        {
            d = 10;
            Console.WriteLine(d);
        }*/
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (checkPrime(num) == false)
            {
                Console.WriteLine("Not a MegaPrimeNumber");
            }
            else
            {
                bool chk=false;
                while (num > 0)
                {
                    chk = false;
                    int digit = num % 10;
                    if (checkPrime(digit) == true)
                    {
                        chk = true;
                        num = num / 10;
                    }
                    else
                    {
                        Console.WriteLine("Not a MegaPrimeNumber");
                        break;
                    }
                }
                if (chk)
                {
                    Console.WriteLine("MegaPrimeNumber");
                }
            }
            
            Console.ReadLine();
        }
    }
}
