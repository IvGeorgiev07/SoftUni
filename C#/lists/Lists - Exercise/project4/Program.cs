using System;
using System.Collections.Generic;
using System.Linq;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> input2 = Console.ReadLine().Split().ToList();

            while (input2[0] != "End")
            {
                if (input2[0] == "Add")
                {
                    input.Add(int.Parse(input2[1]));
                    //Console.WriteLine(String.Join(" ", input));   
                }
                else if (input2[0] == "Insert")
                {
                    if (int.Parse(input2[2]) < input.Count && int.Parse(input2[2]) >=0)
                    {
                        insertNum(input, input2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                    //Console.WriteLine(String.Join(" ", input));
                }
                else if (input2[0] == "Remove")
                {
                    if(int.Parse(input2[1]) < input.Count && int.Parse(input2[1]) >= 0)
                    {
                        input.RemoveAt(int.Parse(input2[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    //Console.WriteLine(String.Join(" ", input));
                }
                else if (input2[1] == "left" && int.Parse(input2[2])>0)
                {
                    
                    for(int i = 0; i < int.Parse(input2[2]); i++)
                    {
                        shiftLeftNums(input);
                    }
                    //Console.WriteLine(String.Join(" ", input));
                }
                else if (input2[1] == "right" && int.Parse(input2[2]) > 0)
                {
                    for (int i = 0; i < int.Parse(input2[2]); i++)
                    {
                        shiftRightNums(input);
                    }
                   // Console.WriteLine(String.Join(" ", input));
                }
                input2 = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(String.Join(" ", input));
        }

        private static void shiftRightNums(List<int> input)
        {
            int lastNum = input[input.Count-1];
            for(int i = input.Count - 1; i >= 1; i--)
            {
                input[i] = input[i-1];
            }
            input[0] = lastNum;
        }

        private static void shiftLeftNums(List<int> input)
        {
            int firstNum = input[0];
            for(int i = 0; i < input.Count-1; i++)
            {
                input[i] = input[i + 1];
            }
            input[input.Count-1] = firstNum;
        }

        private static void insertNum(List<int> input, List<string> input2)
        {
            int num = int.Parse(input2[1]);
            int index = int.Parse(input2[2]);

            input.Insert(index, num);
        }
    }
}

    