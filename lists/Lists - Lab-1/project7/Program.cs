using System;
using System.Collections.Generic;
using System.Linq;

namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input2 = Console.ReadLine().Split().ToArray();

            while (input2[0] != "end")
            {
                string current = input2[0]; // for debugging only
                if (input2[0] == "Contains")
                {
                    checkItemsAreEqual(input, input2);
                    
                }
                else if (input2[0] == "PrintEven")
                {
                    printEvenNums(input);
                    
                }
                else if (input2[0] == "PrintOdd")
                {
                    printOddNums(input);
                    
                }
                else if (input2[0] == "GetSum")
                {
                    getSum(input);
                    
                }
                else if (input2[0] == "Filter")
                {
                    filterItems(input, input2);
                    
                }

                input2 = Console.ReadLine().Split().ToArray();
            }
            
        }

        static void getSum(List<int> input)
        {
            int sum = 0;
            for(int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            Console.Write(sum);
            Console.WriteLine();
        }

        static void filterItems(List<int> input, string[] input2)
        {
            string condition = input2[1];
            int num = int.Parse(input2[2]);

            if(condition == "<")
            {
                for(int i = 0; i < input.Count; i++)
                {
                    if (input[i] < num)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > num)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] >= num)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= num)
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
                Console.WriteLine();
            }

        }

        static void printOddNums(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.WriteLine();
        }

        static void printEvenNums(List<int> input)
        {
            for(int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    Console.Write($"{input[i]} ");
                }
            }
            Console.WriteLine();
        }

        static void checkItemsAreEqual(List<int> input, string[] input2)
        {
            int num = int.Parse(input2[1]);
            bool isEqual = false;

            for (int i = 0; i < input.Count; i++)
            {                
                if(num == input[i])
                {
                    isEqual = true;
                }               
            }

            if (isEqual == true)
            {
                Console.Write("Yes");
                Console.WriteLine();
            }
            else if(isEqual == false)
            {
                Console.Write("No such number");
                Console.WriteLine();
            }
        }
    }
}