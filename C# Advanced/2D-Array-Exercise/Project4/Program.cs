using System;
using System.Linq;
using System.Collections.Generic;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                string[] colEle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i,j] = colEle[j];
                }
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while(input[0] != "END")
            {
                if (input[0] == "swap" && input.Length == 5)
                {
                    int pos1 = int.Parse(input[1]);
                    int pos2 = int.Parse(input[2]);
                    int pos3 = int.Parse(input[3]);
                    int pos4 = int.Parse(input[4]);

                    if ( pos1 >= 0 && pos1< size[0]
                     && pos2 >= 0 && pos2 < size[1]
                     && pos3 >= 0 && pos3 < size[0]
                     && pos4 >= 0 && pos4 < size[1])
                    {
                        string temp = matrix[pos1,pos2];
                        matrix[pos1,pos2] = matrix[pos3,pos4];
                        matrix[pos3,pos4] = temp;
                        for (int i = 0; i < size[0]; i++)
                        {
                            for (int j = 0; j < size[1]; j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}