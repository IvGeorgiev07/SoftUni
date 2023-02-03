using System;
using System.Linq;
using System.Collections.Generic;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> chemicals = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    chemicals.Add(input[j]);
                }
            }
            

            Console.WriteLine(String.Join(" ", chemicals));
        }
    }
}