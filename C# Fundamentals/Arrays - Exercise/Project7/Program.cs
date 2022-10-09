using System;
using System.Linq;
using System.Collections.Generic;

namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenght = 0;
            int num = 0;
            int currentLenght = 1;

            for (int i = input.Length - 1; i > 0; i--)
            { 
                if (input[i] == input[i - 1])
                {
                    currentLenght++;
                    if(currentLenght >= lenght)
                    {
                        lenght = currentLenght;
                        num = input[i];
                    }
                }
                else
                {
                    currentLenght = 1;
                }

            }

            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"{num} ");
            }

        }
    }
}