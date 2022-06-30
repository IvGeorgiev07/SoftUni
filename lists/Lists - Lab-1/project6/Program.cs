using System;
using System.Collections.Generic;
using System.Linq;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int modifier = 0;
            int modifier2 = 0;
            string[] input2 = Console.ReadLine().Split().ToArray();

            while (input2[0] != "end")
            {                
                string current = input2[0];
                if (input2[0] == "Add")
                {
                    modifier = int.Parse(input2[1]);
                    input.Add(modifier);
                }
                else if (input2[0] == "Remove")
                {
                    modifier = int.Parse(input2[1]);
                    input.Remove(modifier);
                }
                else if (input2[0] == "RemoveAt")
                {
                    modifier = int.Parse(input2[1]);
                    input.RemoveAt(modifier);
                }
                else if (input2[0] == "Insert")
                {
                    modifier = int.Parse(input2[1]);
                    modifier2 = int.Parse(input2[2]);
                    input.Insert(modifier2, modifier);
                }
                input2 = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}