using System;

namespace solution1
{
    class multiplication
    {
        static void Main()
        {
            int a;
            int b;
            int c;
            int result;
            Console.WriteLine("Enter the 3 values");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            result = a * b * c;
            Console.WriteLine($"The Result is {result}");
        }
    }
}

