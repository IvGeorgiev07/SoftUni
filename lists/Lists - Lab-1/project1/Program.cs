using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> doubles = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < doubles.Count; i++)
            {
                SumAdjacentEqualNumbers(doubles);
            }
            Console.WriteLine(String.Join(" ", doubles));
        }

        private static void SumAdjacentEqualNumbers(List<double> doubles)
        {
            for (int i = 0; i < doubles.Count - 1; i++)
            {
                if (doubles[i] == doubles[i + 1])
                {
                    doubles[i] = doubles[i] + doubles[i + 1];
                    doubles.RemoveAt(i + 1);

                }
            }
        }
    }
}