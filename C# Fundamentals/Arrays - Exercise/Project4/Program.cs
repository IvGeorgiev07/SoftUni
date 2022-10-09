using System;
using System.Linq;
using System.Collections.Generic;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                int temp = input[0];
                for (int i = 0; i < input.Length-1; i++)
                {
                    input[i] = input[i+1];
                }
                input[input.Length-1] = temp;
            }

            Console.WriteLine(String.Join(" ",input));

        }
    }
}