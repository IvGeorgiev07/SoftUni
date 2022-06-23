using System;
using System.Linq;
using System.Collections.Generic;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            int mid = 0;
            int leftSum = 0;
            int rightSum = 0;
            int output = 0;

            for (int i = 0; i < input.Length; i++)
            {
                equalSum(ref counter, input, mid, leftSum, rightSum,ref output);
                if (mid < input.Length - 1)
                {
                    mid++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine($"{output}");
            }
            else
            {
                Console.WriteLine("no");
            }


        }

        static int equalSum(ref int counter, int[] input, int mid, int leftSum, int rightSum,ref int output)
        {
            for (int j = 0; j < mid; j++)
            {
                leftSum += input[j];
            }

            for (int j = input.Length - 1; j > mid; j--)
            {
                rightSum += input[j];
            }

            if (leftSum == rightSum)
            {
                counter++;
                output = mid;
                return output;
            }
            return counter;
        }
    }
}