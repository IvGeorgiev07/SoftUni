using System;
using System.Collections.Generic;
using System.Linq;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> output = new List<int>();
            int maxValue = int.MinValue;

            findMaxValue(arr1, maxValue, output);
            output.Reverse();

            foreach (int i in output)
            {
                Console.Write($"{i} ");
            }
        }
        static void findMaxValue(int[] arr1, int maxValue, List<int> output)
        {
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                if (arr1[i] > maxValue)
                {
                    maxValue = arr1[i];
                    output.Add(maxValue);
                }

            }
        }
    }
}