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

            for(int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }
                for (int j = input.Length-1; j > i ; j--)
                {
                    rightSum += input[j];
                }

                if(leftSum == rightSum)
                {
                    counter = i;
                    Console.WriteLine(counter);
                    return;
                    
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if(counter == 0)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}