using System;
using System.Linq;
using System.Collections.Generic;

namespace Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            List<int> output = new List<int>();

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i+1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == n)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                        
                    }
                }
            }

            
        }
    }
}