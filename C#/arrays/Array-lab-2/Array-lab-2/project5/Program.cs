using System;
using System.Collections.Generic;
using System.Linq;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] output = new string[input.Length];
            var temp = input[input.Length - 1];


            for (int i = input.Length - 2; i >= 0; i--)
            {
                output[i+1] = input[i];
            }

            output[0] = temp;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                Console.Write($"{output[i]} ");
            }


        }
    }
}