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
            int modifier = 0;
            int modifier2 = 0;
            List<int> copy = input;
            string[] input2 = Console.ReadLine().Split().ToArray();
            bool change = false;

            while (input2[0] != "end")
            {
                if (input2[0] == "Remove")
                {
                    inputModifier(input, input2, modifier, modifier2);
                    change = true;
                }
                else if (input2[0] == "Add")
                {
                    inputModifier(input, input2, modifier, modifier2);
                    change = true;
                }
                else if (input2[0] == "Insert")
                {
                    inputModifier(input, input2, modifier, modifier2);
                    change = true;
                }
                else if (input2[0] == "RemoveAt")
                {
                    inputModifier(input, input2, modifier, modifier2);
                    change = true;
                }
                else if (input2[0] == "Contains")
                {
                    bool equalNums = false;
                    checkItemsAreEqual(input, input2, ref equalNums);

                    if (equalNums == true)
                    {
                        Console.Write("Yes");
                        Console.WriteLine();
                    }
                    else if (equalNums == false)
                    {
                        Console.Write("No such number");
                        Console.WriteLine();
                    }
                }
                else if (input2[0] == "PrintEven")
                {
                    int[] evenNums = new int[input.Count];
                    printEvenNums(input, ref evenNums);

                    for (int i = 0; i < evenNums.Length; i++)
                    {
                        if (evenNums[i] != 0)
                        {
                            Console.Write($"{evenNums[i]} ");
                        }
                    }
                    Console.WriteLine();

                }
                else if (input2[0] == "PrintOdd")
                {
                    int[] oddNums = new int[input.Count];
                    printOddNums(input, ref oddNums);

                    for (int i = 0; i < oddNums.Length; i++)
                    {
                        if (oddNums[i] != 0)
                        {
                            Console.Write($"{oddNums[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input2[0] == "GetSum")
                {
                    int sum = 0;
                    getSum(input, ref sum);

                    Console.WriteLine(sum);
                }
                else if (input2[0] == "Filter")
                {
                    List<int> filteredNums = new List<int>();
                    filterItems(input, input2, ref filteredNums);

                    Console.WriteLine(String.Join(" ", filteredNums));
                }

                input2 = Console.ReadLine().Split().ToArray();
            }
            if (change == true)
            {
                Console.WriteLine(string.Join(" ", input));
            }

        }

        private static void inputModifier(List<int> input, string[] input2, int modifier, int modifier2)
        {
            if (input2[0] == "Add")
            {
                modifier = int.Parse(input2[1]);
                input.Add(modifier);
            }
            else if (input2[0] == "Remove")
            {
                modifier = int.Parse(input2[1]);
                input.Remove(modifier);
            }
            else if (input2[0] == "RemoveAt")
            {
                modifier = int.Parse(input2[1]);
                input.RemoveAt(modifier);
            }
            else if (input2[0] == "Insert")
            {
                modifier = int.Parse(input2[1]);
                modifier2 = int.Parse(input2[2]);
                input.Insert(modifier2, modifier);
            }
        }

        static int getSum(List<int> input, ref int sum)
        {
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            return sum;
        }

        static List<int> filterItems(List<int> input, string[] input2, ref List<int> filteredNums)
        {
            string condition = input2[1];
            int num = int.Parse(input2[2]);

            if (condition == "<")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] < num)
                    {
                        filteredNums.Add(input[i]);
                    }
                }
            }
            else if (condition == ">")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > num)
                    {
                        filteredNums.Add(input[i]);
                    }
                }
            }
            else if (condition == ">=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] >= num)
                    {
                        filteredNums.Add(input[i]);
                    }
                }
            }
            else if (condition == "<=")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= num)
                    {
                        filteredNums.Add(input[i]);
                    }
                }
            }
            return filteredNums;

        }

        static int[] printOddNums(List<int> input, ref int[] oddNums)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {
                    oddNums[i] = input[i];
                }
            }
            return oddNums;
        }

        static int[] printEvenNums(List<int> input, ref int[] evenNums)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenNums[i] = input[i];
                }
            }
            return evenNums;
        }

        static bool checkItemsAreEqual(List<int> input, string[] input2, ref bool equalNums)
        {
            int num = int.Parse(input2[1]);


            for (int i = 0; i < input.Count; i++)
            {
                if (num == input[i])
                {
                    equalNums = true;
                }
            }
            return equalNums;

        }
    }
}