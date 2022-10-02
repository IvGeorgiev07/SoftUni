using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            string input2 = string.Empty;


            for (int i = 0; i <= input.Length-1; i++)
            {
                Console.WriteLine(input[i]);
                input2 +=input[i];
                
            }

            int inputnum = int.Parse(input2);

            for (int i = 0; i <= input.Length - 1; i++)
            {
                int tempsum = 1;

                for (int j = input[i]; j > 1; j--)
                {
                    tempsum *= j;
                    sum += tempsum;
                    Console.WriteLine(tempsum);
                }
            }

            if (sum == inputnum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}