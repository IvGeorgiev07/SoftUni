using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger f = 1;
            for(int i = 2; i <= n; i++)
            {
                f *=i;
            }

            Console.WriteLine(f);
        }
        
    }
}