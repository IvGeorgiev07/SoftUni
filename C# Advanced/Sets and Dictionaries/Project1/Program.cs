﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names= new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}