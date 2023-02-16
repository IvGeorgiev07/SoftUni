using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace _02.Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string racingNum = Console.ReadLine();

            string[,] matrix = new string[n, n];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] colEle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < colEle.Length; j++)
                {
                    matrix[i, j] = colEle[j];
                }
            }
            int totalKm = 0;
            int[] carLocation = {0,0};
            string direction = Console.ReadLine();
            while (direction != "End")
            {
                if(direction == "left")
                {
                    carLocation[1] += -1;
                }
                if (direction == "right")
                {
                    carLocation[1] += +1;
                }
                if (direction == "down")
                {
                    carLocation[0] += +1;
                }
                if (direction == "up")
                {
                    carLocation[0] += -1;
                }


                if (matrix[carLocation[0], carLocation[1]] == "T")
                {
                    matrix[carLocation[0], carLocation[1]] = ".";
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i,j] == "T")
                            {
                                carLocation[0] = i;
                                carLocation[1] = j;
                                totalKm += 30;
                                matrix[carLocation[0], carLocation[1]] = ".";
                            }
                        }

                    }
                    direction = Console.ReadLine();
                    continue;
                }
                else if(matrix[carLocation[0], carLocation[1]] == "F")
                {
                    matrix[carLocation[0], carLocation[1]] = "C";
                    totalKm += 10;
                    sb.AppendLine($"Racing car {racingNum} finished the stage!");
                    break;
                }
                totalKm+= 10;
                direction = Console.ReadLine();
            }

            if(direction == "End")
            {
                sb.AppendLine($"Racing car {racingNum} DNF.");
            }

            matrix[carLocation[0], carLocation[1]] = "C";
            sb.AppendLine($"Distance covered {totalKm} km.");
            Console.WriteLine(sb.ToString().Trim());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            
        }

    }
}