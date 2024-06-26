using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Arrays
    {
        static void Main()
        {
            //int[] num = new int[10];
            //Console.WriteLine("enter elements");
            //for (int i = 0; i < 10; i++)
            //{
            //    num[i] = Byte.Parse(Console.ReadLine());
            //}

            // decalre and initialze array
            int[] num = new int[] { 1, 2, 3, 3, 4 };
            int[] num1 = new[] { 1, 2, 4, 5, 6 };
            int[] num3 = [1, 2, 3, 4, 5, 8];

            Console.WriteLine("elements are");
            for (int i = 0; i < num.Length; i++)
            {
                num[i]++;
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("elements are");
            // syntax for foreach loop
            // foreach(type range_variable in array/collection)
            //     range_variable 

            foreach (int i in num)
            {
                //i++;
                Console.WriteLine(i);
            }
        }

    }
}