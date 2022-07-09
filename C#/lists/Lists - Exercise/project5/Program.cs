using System;
using System.Collections.Generic;
using System.Linq;


namespace project5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (input.Contains(input2[0]))
            {
                int index = input.IndexOf(input2[0]);
                input.RemoveRange(Math.Max(index - input2[1], 0), Math.Min(input2[1] * 2 + 1, input.Count - Math.Max(index - input2[1], 0)));
            }

            Console.WriteLine(input.Sum());
        }
    }
}