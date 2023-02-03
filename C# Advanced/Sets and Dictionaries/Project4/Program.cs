using System;
using System.Linq;
using System.Collections.Generic;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberCount= new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                
                if(!numberCount.ContainsKey(input))
                {
                    numberCount.Add(input, 0);
                }

                numberCount[input]++;
            }

            Console.WriteLine(numberCount.Single(x => x.Value % 2 == 0).Key);
        }
    }
}