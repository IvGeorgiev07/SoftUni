using System;
using System.Collections.Generic;
using System.Linq;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();
            int sum = 0;
            int mid = input.Count / 2;
            
            if(input.Count % 2 != 0)
            {
                for (int i = 0; i < input.Count / 2; i++)
                {
                    sum = input[i] + input[input.Count - i - 1];
                    input[i] = sum;
                }

                output = input.GetRange(0, mid+1);
                Console.WriteLine(String.Join(" ", output));

            }
            else
            {
                for (int i = 0; i < input.Count / 2; i++)
                {
                    sum = input[i] + input[input.Count - i - 1];
                    input[i] = sum;
                }

                output = input.GetRange(0, mid);
                Console.WriteLine(String.Join(" ", output));
            }


        }
    }
}