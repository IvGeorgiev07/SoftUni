﻿using System;
using System.Linq;
using System.Collections.Generic;


namespace project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int maxNum = 0;
            int dna = 0;
            int index = 0;
            int min = int.MaxValue;
            int sum = 0;
            

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Clone them!")
                {
                    break;
                }
                else
                {
                    continue;
                }

                int[] ints = input.Split("!").Select(int.Parse).ToArray();

                sumOfDNA(maxNum, index, ints, ref sum, dna, n);

                sequenceOfOne(index, ints, dna, n);

                if (index < min)
                {
                    min = index;
                    
                }
            }

            Console.WriteLine($"Best DNA sample {} with sum: {sum}.");

        }

        private static void sequenceOfOne(int index, int[] ints, int dna, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (ints[i] == ints[i + 1])
                {
                    index = i;
                }
            }
        }

        private static void sumOfDNA(int maxNum, int index, int[] ints, ref int sum, int dna, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (ints[i] == 1)
                {
                    sum++;
                }

                if (sum > maxNum)
                {
                    maxNum = sum;
                }
            }
        }
    }
}