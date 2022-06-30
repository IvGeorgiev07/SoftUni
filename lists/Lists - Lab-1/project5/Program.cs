using System;
using System.Collections.Generic;
using System.Linq;


namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int counter = 0;
            int current = 0;
            for(int i = 0; i < input.Count; i++)
            {
                current = input[i];
                if (input[i] < 0)
                {
                    input.RemoveAt(i);
                    counter++;
                    i--;
                }

                if(counter > input.Count)
                {
                    input.Clear();
                }
            }

            input.Reverse();

            if(input.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", input));
            }
            
        }
    }
}