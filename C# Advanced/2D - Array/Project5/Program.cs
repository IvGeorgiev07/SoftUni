using System;
using System.Collections.Generic;
using System.Linq;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sum = 0;
            int[,] cube = new int[2, 2];
            int counter = 0;

            for (int i = 0; i < size[0] - 1; i++)
            {
                for (int j = 0; j < size[1] - 1; j++)
                {
                    int tempSum = 0;
                    tempSum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        cube[0, 0] = matrix[i, j];
                        cube[1, 0] = matrix[i+1, j];
                        cube[0, 1] = matrix[i, j+1];
                        cube[1, 1] = matrix[i+1, j+1];

                    }
                }
            }

            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    Console.Write($"{cube[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}