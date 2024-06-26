namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            int age;
            Console.WriteLine("enter age");
           /* age = Convert.ToByte(Console.ReadLine())*/;
            age = Byte.Parse(Console.ReadLine());
            int salary;
            Console.WriteLine("enter salary");
            //salary= Convert.ToInt32(Console.ReadLine());
            salary = Int32.Parse(Console.ReadLine());

            // Conversion of one data type to other
            float da;
            Console.WriteLine("enter da");
            da = float.Parse(Console.ReadLine());

            da = salary;   // implicit converion
            salary = (int)da; // explicit conversion

            decimal hra = 90876.89M;

            da = (float)hra;

            string na = "97";
            salary = Convert.ToInt16(na);
                    


        }

        // Console, Convert are the classes that belongs to System namspace
        // Console class > Write(), WriteLine(), ReadLine()
        // Convert class > ToInt32(), ToSByte(), ToInt16() 
    }
}