using System;
using System.Linq;
namespace Array_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 3, 4, 5 };
            //Another method to declare a array //
            int [] brr = new int[5] {45,74,94,09,899};
            //Accessing array elements//
            Console.WriteLine(arr[0]);
            int l = arr.Length;
            Console.WriteLine(l);
            //index method is used as Array.Index(arg1,arg2) where arg1 is name of array and arg2 is the element whose index is to be found//
            Console.WriteLine(Array.IndexOf(arr,5));
            //System.Linq is used for min , max and sum of array//
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
            //Use Arrays.sort(arg) where arg is the name of the array to sort the array//
            Array.Sort(arr);
            for(int i = 0; i < l; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
