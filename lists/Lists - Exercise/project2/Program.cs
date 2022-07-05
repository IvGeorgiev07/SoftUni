using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> input2 = Console.ReadLine().Split().ToList();

            while (input2[0] != "end")
            {
                if(input2[0] == "Delete")
                {
                    for(int i = 0; i < input.Count; i++)
                    {
                        if(input[i] == input[1])
                        {
                            input.Remove(int.Parse(input2[1]));
                        }
                    }
                }
                else if (input2[0] == "Insert")
                {
                    input.Insert(int.Parse(input2[2]), int.Parse(input2[1]));
                }
                input2 = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}