using System;
using System.Collections.Generic;
using System.Linq;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] temp = new int[input.Length];

            for (int i = 0; i < n; i++)
            {
                numRotation(input, temp);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
        private static void numRotation(int[] input, int[] temp)
        {
            temp[input.Length - 1] = input[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i+1];
            }
            input[input.Length - 1] = temp[input.Length - 1];
        }
    }
}