using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j =0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                
            }
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }
    }
}