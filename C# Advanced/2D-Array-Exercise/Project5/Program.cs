using System;
using System.Linq;
using System.Collections.Generic;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[] snake = Console.ReadLine().ToCharArray();
            char[,] matrix = new char[size[0], size[1]];
            int counter = 0;
            for (int i = 0; i < size[0]; i++)
            {
                
                if (i % 2 == 0)
                {
                    for (int j = 0; j < size[1]; j++)
                    {
                        matrix[i, j] = snake[counter];
                        if (counter >= snake.Length-1)
                        {
                            counter = 0;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    for (int j = size[1] - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snake[counter];
                        if (counter >= snake.Length - 1)
                        {
                            counter = 0;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
            }

            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}