using System;
using System.Linq;
using System.Collections.Generic;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int topInt = int.MinValue;
            List<int> output = new List<int>();

            for(int i = input.Length-1; i >= 0; i--)
            {
                if(input[i] > topInt)
                {
                    topInt = input[i];
                    output.Add(topInt);
                }
            }

            output.Reverse();

            Console.WriteLine(String.Join(" ", output));
        }
    }
}