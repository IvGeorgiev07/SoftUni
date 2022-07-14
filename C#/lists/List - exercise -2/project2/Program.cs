using System;
using System.Collections.Generic;
using System.Linq;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double leftSum = 0;
            double rightSum = 0;
            int mid = (input.Length-1)/2;

            for(int i = 0; i < mid; i++)
            {
                leftSum+=input[i];
                if(input[i] == 0)
                {
                    leftSum *= 0.8;
                }
            }

            for (int i = input.Length-1; i > mid; i--)
            {
                rightSum += input[i];
                if (input[i] == 0)
                {
                    rightSum *= 0.8;
                }
            }

            if(leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(leftSum,2)}");
            }
            else if (rightSum < leftSum)
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(rightSum,2)}");
            }

        }
    }
}