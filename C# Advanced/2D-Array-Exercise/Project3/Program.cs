using System;
using System.Linq;
using System.Collections.Generic;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];
            if (size[0] < 3 || size[1] < 3)
            {
                return;
            }

            for (int rowz = 0; rowz < size[0]; rowz++)
            {
                int[] colEle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int colz = 0; colz < size[1]; colz++)
                {
                    matrix[rowz, colz] = colEle[colz];
                }
            }
            int[] indexOf3x3 = new int[2];
            int sum = int.MinValue;
            for (int i = 0; i < size[0]-2; i++)
            {
                for (int j = 0; j < size[1]-2; j++)
                {
                    if (matrix[i, j]
                       + matrix[i, j + 1]
                       + matrix[i, j + 2]
                       + matrix[i + 1, j]
                       + matrix[i + 1, j + 1]
                       + matrix[i + 1, j + 2]
                       + matrix[i + 2, j]
                       + matrix[i + 2, j + 1]
                       + matrix[i + 2, j + 2] > sum)
                    {
                        indexOf3x3[0] = i; 
                        indexOf3x3[1]=j;
                        int rows = indexOf3x3[0];
                        int cols = indexOf3x3[1];
                        int temSsum = 0;
                        for (int r = rows; r < rows + 3; r++)
                        {
                            for (int c = cols; c < cols + 3; c++)
                            {
                                temSsum += matrix[r, c];
                            }
                        }
                        sum = temSsum;
                    }
                }
            }
            int row = indexOf3x3[0];
            int col = indexOf3x3[1];
            Console.WriteLine($"Sum = {sum}");
            for (int i = row; i < row+3; i++)
            {
                for (int j = col; j < col+3; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}