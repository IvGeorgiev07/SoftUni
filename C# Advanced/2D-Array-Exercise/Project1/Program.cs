using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for(int row = 0; row < n; row++)
            {
                int[] colEle = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < n; col++)
                {
                    matrix[row,col] = colEle[col];
                }
            }
            int primeSum = 0;
            int secondSum = 0;
            for(int row = 0; row< n; row++)
            {
                primeSum += matrix[row, row];
            }
            int counter = 0;
            for (int col = n - 1; col >= 0; col--)
            {
                secondSum+= matrix[counter, col];
                counter++;
            }
            int sum = primeSum-secondSum;
            Console.WriteLine(Math.Abs(sum));
        }
    }
}