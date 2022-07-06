using System;
using System.Linq;
using System.Collections.Generic;


namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxNum = 0;
            int counter = 1;
            int num = 0;

            for(int i = 0; i < input.Length-1; i++)
            {
                if(input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if(counter > maxNum)
                {
                    maxNum = counter;
                    num = input[i];
                }
            }
            
            for(int i = 0; i < maxNum; i++)
            {
                Console.Write($"{num} ");
            }

        }
    }
}