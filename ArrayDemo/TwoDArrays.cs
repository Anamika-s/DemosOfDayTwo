using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class TwoDArrays
    {
        static void Main()
        {
            //int[,] array1 = new int[3, 3];
            //Console.WriteLine("enter elements");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        array1[i, j] = byte.Parse(Console.ReadLine());
            //    }
            //}

            // declare & initialize 2 D Array
            //int[,] array1 = new int[3, 3]{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    {11, 12, 13 }
            //    };
            int[,] array1 = new int[,]
                { {1, 2, 3 },
                {4, 5, 6 },
                {11, 12, 13 }
                };


            Console.WriteLine("elements are");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
