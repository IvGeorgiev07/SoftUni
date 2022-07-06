using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int Sum = 0;

            for(int i = 0; i < input; i++)
            {
                Sum+= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Sum);
        }
    }
}