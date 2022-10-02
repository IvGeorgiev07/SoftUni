using System;
using System.Linq;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string[] output = new string[input.Length];
            

            
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[input.Length-1-i];
            }
            

            Console.WriteLine(String.Join(" ",output));
        }
    }
}