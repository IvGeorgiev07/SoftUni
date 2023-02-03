using System;
using System.Linq;
using System.Collections.Generic;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];
            if (size[0] < 2 || size[1] < 2) 
            {
                return;
            }

            for(int row = 0; row < size[0]; row++)
            {
                char[] colEle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for(int col = 0; col < size[1]; col++)
                {
                    matrix[row,col] = colEle[col];
                }
            }
            //int[] indexOf2x2 = new int[2];
            int counter = 0;
            for(int i = 0; i < size[0]-1; i++)
            {
                for (int j = 0; j < size[1]-1; j++)
                {
                    if (matrix[i,j] == matrix[i,j+1]
                        && matrix[i, j] == matrix[i+1, j]
                        && matrix[i, j] == matrix[i+1, j + 1])
                    {
                        //indexOf2x2[0] = i;
                        //indexOf2x2[1] = j;
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}