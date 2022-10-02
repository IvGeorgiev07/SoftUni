using System;
using System.Linq;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];   

            for (int i = 0; i < n; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }

            for (int i = ints.Length - 1; i >= 0; i--)
            {
                Console.Write($"{ints[i]} ");
            }
        }
    }
}