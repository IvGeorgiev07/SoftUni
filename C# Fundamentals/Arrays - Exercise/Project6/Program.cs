using System;
using System.Linq;
using System.Collections.Generic;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                CalcLeftSum(i,leftSum,counter);

            }
        }

        private static void CalcLeftSum(int i, int leftSum, int counter)
        {
            throw new NotImplementedException();
        }
    }
}