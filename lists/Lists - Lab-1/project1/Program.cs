using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> doubles = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            for(int i = 0; i < doubles.Count; i++)
            {
                SumAdjacentEqualNumbers(doubles);
            }

            foreach(int i in doubles)
            {
                Console.Write($"{i} ");
            }
            
        }

        private static void SumAdjacentEqualNumbers(List<decimal> doubles)
        {
            for (int i = 0; i < doubles.Count-1; i++)
            {
                if (doubles[i] == doubles[i + 1])
                {
                    doubles[i] = doubles[i] + doubles[i + 1];
                    doubles.RemoveAt(i+1);
                    
                }
            }
        }
    }
}