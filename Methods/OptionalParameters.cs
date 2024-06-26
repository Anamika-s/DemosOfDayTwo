using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class OptionalParameters
    {
        static void SI(int principal=10000, int rate =7,int time=15)
        {
            Console.WriteLine(principal*rate*time/100);
        }

        static void Main()
        {
            SI(12000, 2, 10);
            SI(20000, 8);
            SI(20000);
            SI(20000, 3);




        }
    }
}
