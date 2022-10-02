using System;
using System.Linq;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] output = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = Math.Round(input[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($"{input[i]} => {output[i]}");
            }
            
                
            
        }
    }
}