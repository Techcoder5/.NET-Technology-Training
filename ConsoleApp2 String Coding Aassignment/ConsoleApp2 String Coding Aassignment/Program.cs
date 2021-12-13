using System;

namespace ConsoleApp2_String_Coding_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullname = Console.ReadLine();
            String[] arr = fullname.Split(' ');
            int len = arr.Length;
            //foreach(String name in arr)
            //{
            //    Console.WriteLine(name);
            //}
            if (len == 1)
            {
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[0]);
                Console.WriteLine(arr[0].ToUpper());
            }
            else if (len == 2)
            {
                String first_name = arr[0];
                var first_initial = first_name[0];
                Console.WriteLine(first_initial + ". " + arr[1]);
                Console.WriteLine(arr[1] + ", " + arr[0]);
                Console.WriteLine(first_initial + " " + arr[1].ToUpper());

            }
            else
            {
                String first_name = arr[0];
                var first_initial = first_name[0];
                String last_name = arr[len - 1];
                var last_initial = last_name[0];
                /*Console.WriteLine(first_initial+". "+arr[1][0]+". "+last_name);
                Console.WriteLine(last_name+", "+first_name+" "+arr[1]);
                Console.WriteLine(first_initial + " " + arr[1][0] + " " + last_name.ToUpper());*/
                //int len = arr.Length;
                int val = len - 2 + 1;
                string[] brr = new string[val];
                int j = 0;
                for (int i = 2; i < len; i++)
                {
                    brr[j] = arr[i];
                    j = j + 1;
                }
                //Console.WriteLine(brr);
                string s1 = "";
                for (int i = 0; i < brr.Length; i++)
                {
                    s1 = s1 + brr[i];
                    s1 = s1 + " ";
                }
                //Console.WriteLine(s1);
                Console.WriteLine(first_initial + ". " + arr[1][0] + ". " + s1);
                string[] crr = new string[len];
                int idx = 0;
                for (int i = 0; i < len; i++)
                {
                    crr[idx] = arr[i];
                    idx = idx + 1;
                }
                string s2 = "";
                for (int i = 0; i < crr.Length - 1; i++)
                {
                    s2 = s2 + crr[i];
                    s2 = s2 + " ";
                }
                Console.WriteLine(last_name + ", " + s2);
                String s3 = "";
                for (int i = 0; i < crr.Length - 1; i++)
                {
                    crr[i] = crr[i].ToUpper();
                    s3 = s3 + crr[i][0];
                    s3 = s3 + " ";
                }
                Console.WriteLine(s3 + arr[len - 1].ToUpper());
            }
            Console.ReadLine();
        }
    }
}

