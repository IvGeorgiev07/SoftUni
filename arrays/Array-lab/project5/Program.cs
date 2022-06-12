using System;
using System.Collections.Generic;
using System.Linq;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();
            int[] ints = tokens.Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    sum += ints[i];
                }
            }

            Console.WriteLine(sum);



        }
    }
}