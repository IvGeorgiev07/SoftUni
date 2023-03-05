using System;
using System.Text;
using System.Collections.Generic;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int first = n % 10;
            int second = (n / 10) % 10;
            int third = n / 100;

            for (int i = 1; i <= first; i++)
            {
                for (int j = 1; j <= second; j++)
                {
                    for (int k = 1; k <= third; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i*j*k}");
                    }
                }
            }
        }
    }
}