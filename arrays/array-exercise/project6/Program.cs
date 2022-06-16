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

            for (int i = 0; i < input.Length; i++)
            {
                equalSum(counter, input, mid, leftSum, rightSum);
                if (mid < input.Length - 1)
                {
                    mid++;
                }
            }

            Console.WriteLine(counter);

        }

        static void equalSum(int counter, int[] input, int mid, int leftSum, int rightSum)
        {


            for (int j = 0; j < input[mid]; j++)
            {
                leftSum += input[j];
            }

            for (int j = input.Length - 1; j > input[mid]; j--)
            {
                rightSum += input[j];
            }

            if (leftSum == rightSum)
            {
                counter++;
            }
            //Console.WriteLine(leftSum);
            //Console.WriteLine(rightSum);




        }
    }
}