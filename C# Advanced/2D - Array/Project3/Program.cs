using System;
using System.Collections.Generic;
using System.Linq;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = colElements[col];
                }
            }

            int sum = 0;

            for(int i =0; i < n; i++)
            {
                sum += matrix[i,i];
            }
            Console.WriteLine(sum);
        }
    }
}