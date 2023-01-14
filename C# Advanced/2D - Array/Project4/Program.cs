using System;
using System.Collections.Generic;
using System.Linq;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for(int row =0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();

                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            int counter = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]== symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        counter ++;
                    }
                }
            }

            if(counter == 0 )
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}