using System;
using System.Collections.Generic;
using System.Linq;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for(int row = 0; row < n; row++)
            {
                int[] colElem = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[colElem.Length];
                for (int col = 0; col < colElem.Length; col++)
                {
                    jaggedArray[row][col] = colElem[col];
                }
            }

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "END")
            {
                if (cmd[0] == "Add")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);

                    if(row >= 0 && row < n && col >= 0 && col < jaggedArray[row].Length)
                    {
                        int number = jaggedArray[row][col];
                        number += value;
                        jaggedArray[row][col]=number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);

                    if (row >= 0 && row < n && col >= 0 && col < jaggedArray[row].Length)
                    {
                        int number = jaggedArray[row][col];
                        number -= value;
                        jaggedArray[row][col] = number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                cmd = Console.ReadLine().Split();
            }

            for(int i =0; i < n; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}