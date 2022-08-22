using System;

namespace solution1
{
    class dhanush
    {
        static void Main()
        {
            int a;
            int b;
            Console.WriteLine("Enter the 2 values");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("Value 'a' is smaller");
            }
            else if (b < a)
            {
                Console.WriteLine("Value 'b' is bigger");
            }
            else
            {
                Console.WriteLine("exit");
            }
        }
    }
}
