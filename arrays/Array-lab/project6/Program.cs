using System;
using System.Collections.Generic;
using System.Linq;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();
            int[] ints = tokens.Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if(ints[i] % 2 == 0)
                {
                    evenSum+=ints[i];
                }
                else
                {
                    oddSum+=ints[i];
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}