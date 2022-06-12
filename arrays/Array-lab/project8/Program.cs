using System;
using System.Collections.Generic;
using System.Linq;

namespace project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aar1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = aar1.Length;

            while(counter > 1)
            {
                for (int i = 0; i < aar1.Length-1; i++)
                {
                    aar1[i] = aar1[i] + aar1[i + 1];

                }
                counter--;

            }
            Console.WriteLine(aar1[0]);
        }
    }
}