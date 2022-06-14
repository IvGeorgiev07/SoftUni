using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                sum += input[i];
            }

            foreach(int i in input)
            {
                Console.Write($"{i} ");
                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}