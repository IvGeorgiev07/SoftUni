using System;
using System.Linq;
using System.Collections.Generic;


namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i; j < input.Length-1; j++)
                {
                    sum = input[i] + input[j + 1];

                    if (sum == n)
                    {
                        Console.WriteLine($"{input[i]} {input[j + 1]}");
                        sum = 0;
                    }
                }
            }
        }
    }
}