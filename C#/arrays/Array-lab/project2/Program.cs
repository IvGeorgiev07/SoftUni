using System;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int[] reverseNum = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int j = n-1; j >=0; j--)
            {
                int revNum = numbers[j];
                Console.Write($"{revNum} ");
            }
        }
    }
}