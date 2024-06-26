using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class OutputParameters
    {
        // Func can return more than 1 value using output para without using return statement
        static void Operations(int a, int b,
            out int sum,
            out int difference,
            out int product,
            out float remainder)
        {
            sum = a + b;
            difference = b - a;
            product = a * b;
            remainder = a % b;
        }
        static void Main()
        {

            // calling part
            int sum, difference, product;
            float remainder;
            Operations(20, 10, out sum, out difference, out product, out remainder);
            Console.WriteLine($"Sum is {sum}\nDifference is {difference}\nProduct is {product}\nRemainder is {remainder}");
        }
    }
}
