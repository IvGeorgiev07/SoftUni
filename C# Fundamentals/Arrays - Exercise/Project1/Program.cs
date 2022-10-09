using System;
using System.Linq;
using System.Collections.Generic;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            List<string> str = new List<string>();

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        str.Add(arr2[i]);
                    }
                }
            }

            Console.WriteLine(String.Join(" ",str));
        }
    }
}