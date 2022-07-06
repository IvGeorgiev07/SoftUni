using System;
using System.Collections.Generic;
using System.Linq;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int multiplyer = int.Parse(Console.ReadLine());

            double[] output = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i] * multiplyer;
            }

            for(int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}