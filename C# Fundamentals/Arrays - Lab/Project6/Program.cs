using System;
using System.Linq;

namespace Project5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    evenSum += ints[i];
                }
                else if (ints[i] % 2 != 0)
                {
                    oddSum += ints[i];
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}