using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class DebuggingDemo
    {
        static void Main()
        {
            // breakpoint is that statement, so when it is hit, after that we can see
            // program flow using F10, F11 , F12
            // Debugging > See flow of the program
            int num1, num2;
            int ch;
            Console.WriteLine("enter num1");
            num1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter ch");
            ch = byte.Parse(Console.ReadLine());
            //if (ch == 1)
            //    Console.WriteLine("Sum is " + num1 + num2);
            //else if (ch == 2)
            //    Console.WriteLine("DIff is " + (num1 - num2));
            //else if (ch == 3)
            //    Console.WriteLine("Product is " + (num1 * num2));
            //else if (ch == 4)
            //    Console.WriteLine("REm is " + num1 % num2);
            //else Console.WriteLine("invalid choice");
            switch (ch)
            {
                case 1: Console.WriteLine("Sum is " + num1 + num2); break;
                case 2: Console.WriteLine(num1 - num2); break;
                case 3: Console.WriteLine(num1 * num2); break;
                case 4: Console.WriteLine(num1 % num2); break;
                default: Console.WriteLine("invalid ch"); break;
            }
        }    }
}
