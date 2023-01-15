using System;
using System.Collections.Generic;
using System.Linq;

namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];
            if(n < 1 || n > 60)
            {
                return;
            }
            for(int i = 0; i < n; i++)
            {
                jagged[i] = new int[i+1];
                jagged[i][0] = 1;
                for(int j = 1; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = 1;
                }
            }

            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j < jagged[i].Length-1; j++)
                {
                    int num1 = jagged[i-1][j-1];
                    int num2 = jagged[i - 1][j];
                    int sum = num1 + num2;
                    jagged[i][j] = sum;
                }
            }


            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}