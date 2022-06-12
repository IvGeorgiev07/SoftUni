using System;
using System.Collections.Generic;
using System.Linq;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split();

            for(int i = tokens.Length-1; i >= 0; i--)
            {
                string newStr = tokens[i];
                Console.Write($"{newStr} ");
            }
        }
    }
}