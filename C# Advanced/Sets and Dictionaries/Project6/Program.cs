using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            string[] separator = { " -> ", "," };
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (!clothes.ContainsKey(input[0]))
                {
                    clothes.Add(input[0], new Dictionary<string, int>());
                }
                for (int j = 1; j < input.Length; j++)
                {
                    if (!clothes[input[0]].ContainsKey(input[j]))
                    {
                        clothes[input[0]].Add(input[j],0);
                    }
                    clothes[input[0]][input[j]]++;
                }
            }

            string[] secondInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    string print = $"* {cloth.Key} - {cloth.Value}";                    
                    if (secondInput[0] == color.Key && secondInput[1] == cloth.Key)
                    {
                        print += " (found!)";
                    }
                    Console.WriteLine(print);
                }
            }

        }
    }
}