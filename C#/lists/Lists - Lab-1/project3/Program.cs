using System;
using System.Collections.Generic;
using System.Linq;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();

            if(input1.Count >= input2.Count)
            {
                for (int i = 0; i < input1.Count; i++)
                {
                    output.Add(input1[i]);
                    if (i < input2.Count)
                    {
                        output.Add(input2[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < input2.Count; i++)
                {
                    if(i < input1.Count)
                    {
                        output.Add(input1[i]);
                    }

                    if (i < input2.Count)
                    {
                        output.Add(input2[i]);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", output));

        }
    }
}