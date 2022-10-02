using System;
using System.Linq;

namespace Project5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    sum += ints[i];
                }
            }
            Console.WriteLine(sum); 
        }
    }
}