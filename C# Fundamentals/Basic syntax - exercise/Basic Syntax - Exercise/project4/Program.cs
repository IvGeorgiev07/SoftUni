using System;
using System.Collections.Generic;
using System.Text;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = input; i <= input2; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}