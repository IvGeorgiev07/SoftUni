using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();

            for(int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(input.Length);

                string a = input[randomIndex];
                string b = input[i];

                input[randomIndex] = b;
                input[i] = a;
            }
            Console.WriteLine(String.Join(Environment.NewLine, input));


        }
    }
        
}