using System;
using System.Collections.Generic;
using System.Linq;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}