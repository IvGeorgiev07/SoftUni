using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputMin = int.MaxValue;

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] < inputMin)
                {
                    inputMin = input[i];
                }
            }
            Console.WriteLine(inputMin);
        }
    }
}