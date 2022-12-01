using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Courses= new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" : ");

            while (input[0] != "end")
            {
                
                if (!Courses.ContainsKey(input[0]))
                {
                    Courses[input[0]] = new List<string>
                    {
                        input[1],
                    };
                }
                else
                {
                    Courses[input[0]].Add(input[1]);
                }
                input = Console.ReadLine().Split(" : ");
            }

            foreach(var kvp in Courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}