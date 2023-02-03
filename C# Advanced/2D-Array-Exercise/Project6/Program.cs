using System;
using System.Linq;
using System.Collections.Generic;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] colEle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jagged[i] = new int[colEle.Length];
                for (int j = 0; j < colEle.Length; j++)
                {
                    jagged[i][j] = colEle[j];
                }
            }


            for (int i = 1; i < n; i++)
            {
                if (jagged[i].Length == jagged[i - 1].Length)
                {
                    for (int j = 0; j < jagged[i-1].Length; j++)
                    {
                        jagged[i-1][j] = jagged[i - 1][j] * 2;
                        jagged[i][j] = jagged[i][j] * 2;
                    }
                    
                }
                else
                {
                    for (int j = 0; j < jagged[i-1].Length; j++)
                    {
                        jagged[i-1][j] = jagged[i - 1][j] / 2;
                    }
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] = jagged[i][j] / 2;
                    }
                } 
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                if (input[0] == "Add")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);
                    if(row >=0 && row < n
                      && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (input[0] == "Subtract")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);
                    if (row >= 0 && row < n
                      && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }




            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}