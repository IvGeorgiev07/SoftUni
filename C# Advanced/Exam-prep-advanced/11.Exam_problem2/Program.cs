using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace BlindManBuff
{
    public class Program
    {
        private static int manRow;
        private static int manCol;
        private static char[,] matrix;
        private static string lastDirection;

        private static int touches = 0;
        private static int moves = 0;

        public static void Main()
        {
            int[] n = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            matrix = new char[n[0], n[1]];

            for (int i = 0; i < n[0]; i++)
            {
                char[] input = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];

                    if (matrix[i, j] == 'B')
                    {
                        manRow = i;
                        manCol = j;
                    }
                }
            }

            string direction = Console.ReadLine();

            while (direction != "Finish")
            {
                lastDirection = direction;

                if (direction == "up")
                {
                    Move(-1, 0);
               }
                else if (direction == "down")
                {
                    Move(1, 0);
                }
                else if (direction == "right")
                {
                    Move(0, 1);
                }
                else if (direction == "left")
                {
                    Move(0, -1);
                }

                if (touches == 3)
                {
                    break;
                }
                direction = Console.ReadLine();
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Game over!");
            stringBuilder.AppendLine($"Touched opponents: {touches} Moves made: {moves}");
            Console.WriteLine(stringBuilder.ToString().Trim());
        }

        public static void Move(int row, int col)
        {
            if (!IsInside(manRow + row, manCol + col))
            {
                return;
            }
            if (matrix[manRow + row, manCol + col] == 'O')
            {
                return;
            }
            matrix[manRow, manCol] = '-';
            if (matrix[manRow+row, manCol+col] == 'P')
            {
                if (lastDirection == "up")
                {
                    manRow += row;
                    moves++;
                }
                else if (lastDirection == "down")
                {
                    manRow += row;
                    moves++;
                }
                else if (lastDirection == "right")
                {
                    manCol += col;
                    moves++;
                }
                else if (lastDirection == "left")
                {
                    manCol += col;
                    moves++;
                }
                matrix[manRow, manCol] = '-';
                touches++;
            }
            else
            {

                if (lastDirection == "up")
                {
                    manRow += row;
                    moves++;
                }
                else if (lastDirection == "down")
                {
                    manRow += row;
                    moves++;
                }
                else if (lastDirection == "right")
                {
                    manCol += col;
                    moves++;
                }
                else if (lastDirection == "left")
                {
                    manCol += col;
                    moves++;
                }
                matrix[manRow, manCol] = 'B';

            }

        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }
    }
}
