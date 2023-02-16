using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _05.NavyBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int[] startLocation = new int[2];

            for (int i = 0; i < n; i++)
            {
                char[] colElements = Console.ReadLine().ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colElements[j];
                    if (matrix[i,j] == 'S')
                    {
                        startLocation[0] = i;
                        startLocation[1] = j;
                        matrix[i, j] = '-';
                    }
                }
            }

            int mineHits = 0;
            int cruiseKills = 0;

            while(mineHits < 3 && cruiseKills < 3)
            {
                string direction = Console.ReadLine();

                if(direction == "up")
                {
                    startLocation[0]--;
                }
                if (direction == "down")
                {
                    startLocation[0]++;
                }
                if (direction == "left")
                {
                    startLocation[1]--;
                }
                if (direction == "right")
                {
                    startLocation[1]++;
                }                

                if (matrix[startLocation[0], startLocation[1]] == '*')
                {
                    matrix[startLocation[0], startLocation[1]] = '-';
                    mineHits++;
                }
                if (matrix[startLocation[0], startLocation[1]] == 'C')
                {
                    matrix[startLocation[0], startLocation[1]] = '-';
                    cruiseKills++;                    

                }
                
            }

            if(cruiseKills == 3)
            {
                matrix[startLocation[0], startLocation[1]] = 'S';
                Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
            }
            else
            {
                matrix[startLocation[0], startLocation[1]] = 'S';
                Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{startLocation[0]}, {startLocation[1]}]!");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}