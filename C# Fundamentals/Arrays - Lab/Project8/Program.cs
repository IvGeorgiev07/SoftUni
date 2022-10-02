using System;
using System.Linq;

namespace Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < ints.Length-1; j++)
            {
                for (int i = 0; i < ints.Length-1; i++)
                {
                    //int temp = ints[i + 1];
                    ints[i] = ints[i] + ints[i + 1];
                    // ints[i + 1] = temp;
                }

            }
            Console.WriteLine(ints[0]);

        }
    }
}