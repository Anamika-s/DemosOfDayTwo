using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class NamedParameter
    {
        static void DisplayDetails(int id, string name, string deopt,
            float salary, int exp)
        {
            Console.WriteLine("id " + id + " name " + name + " salary " + salary + " dept " + deopt + " exp " + exp);
        }















        static void Main()
        {
            DisplayDetails(10, "accts", "ajay", 90989.8f, 180);
            DisplayDetails(id: 9, name: "deepak", deopt: "accts", salary: 90908.7f, exp: 8);
            DisplayDetails(name: "ajay", salary: 9090f, id: 9, deopt: "accts", exp: 9);
        }

    }
}
