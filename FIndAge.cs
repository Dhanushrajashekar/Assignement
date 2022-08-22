/*Write a program that reads your age from the console and prints your age after 10 years.

using System;*/

namespace solution1
{
    class dhanush
    {
        static void Main()
        {
            int age;
            int result;
            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            result = age + 10;
            Console.WriteLine($"You age after 10 years is going to be {result}");
         }
    }
}
