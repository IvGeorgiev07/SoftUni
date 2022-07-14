using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> ints = new List<int>();

            foreach (var str in input)
            {
                ints.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(String.Join(" ", ints));

        }
    }
}
