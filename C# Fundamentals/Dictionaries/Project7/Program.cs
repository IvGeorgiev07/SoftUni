using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> UserID = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End")
            {
                if (!UserID.ContainsKey(input[0]))
                {
                    UserID[input[0]] = new List<string>
                    {
                        input[1]
                    };
                }
                else
                {
                    if (!UserID[input[0]].Contains(input[1]))
                    {
                        UserID[input[0]].Add(input[1]);
                    }

                }
                input = Console.ReadLine().Split(" -> ");
            }

            foreach(var kvp in UserID)
            {
                Console.WriteLine(kvp.Key);

                foreach(var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"-- {kvp2}");
                }
            }
        }
    }
}