
using System;
using System.Collections.Generic;
using System.Linq;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();

            double[] ints = tokens.Select(double.Parse).ToArray();

            for(int i = 0; i < ints.Length; i++)
            {
                var newNum = ints[i];
                Console.WriteLine($"{newNum} => {Math.Round(newNum, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}