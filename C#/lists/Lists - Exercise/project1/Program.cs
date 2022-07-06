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
            int maxPassengers = int.Parse(Console.ReadLine());
            int counter = 0;
            List<string> input2 = Console.ReadLine().Split().ToList();
            List<int> newPassengers = new List<int>();

            while (input2[0] != "end")
            {
                if (input2[0] == "Add")
                {
                    input.Add(int.Parse(input2[1]));
                }
                else
                {
                    newPassengers.Add(int.Parse(input2[0]));
                }

                input2 = Console.ReadLine().Split().ToList();
            }

            for (int i = 0; i < newPassengers.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (maxPassengers - input[j] >= newPassengers[i])
                    {
                        input[j] += newPassengers[i];
                        j = input.Count - 1;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", input));

        }
    }
}