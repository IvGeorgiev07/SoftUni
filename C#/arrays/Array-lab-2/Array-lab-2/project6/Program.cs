using System;
using System.Collections.Generic;
using System.Linq;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i <= input.Length - 1; i += 2)
            {
                if (input[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {input[i]}");
                }
            }
        }
    }
}