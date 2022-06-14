using System;
using System.Collections.Generic;
using System.Linq;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();

 
                if (i + 1 % 2 == 0)
                {
                    arr2[i] = temp[1];
                }
                
            }

            foreach(int i in arr1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            foreach (int i in arr2)
            {
                Console.Write($"{i} ");
            }

        }
    }
}