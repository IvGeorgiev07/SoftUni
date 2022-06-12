using System;
using System.Collections.Generic;
using System.Linq;


namespace project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] tokens = input.Split();
            string[] tokens2 = input2.Split();

            int[] arr1 = tokens.Select(int.Parse).ToArray();
            int[] arr2 = tokens2.Select(int.Parse).ToArray();
            int counter = 0;
            int arrSum = 0;

            for(int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    counter++;
                    arrSum += arr1[i];
                }
            }
            
            if(counter == arr1.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arrSum}");
            }
            else if (counter == 0)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {arr1.Length - 1} index");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {arr1.Length-counter} index");
            }                    
        }
    }
}