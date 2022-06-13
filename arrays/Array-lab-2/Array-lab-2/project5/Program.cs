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
            string[] buffer = new string[input.Length];

            for(int i = input.Length-1; i >= 0; i--)
            {
                output[i] = input[i];

                for(int j = 0; j < buffer.Length; j++)
                {
                    buffer[j] = output[i];
                }
            }
            
            for(int i = 0; i < buffer.Length; i++)
            {
                Console.Write($"{buffer[i]} ");
            }


        }
    }
}