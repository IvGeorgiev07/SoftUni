using System;
using System.Collections.Generic;
using System.Linq;


namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            List<string> attendanceList = new List<string>();
            int counter = 0;


            while (counter < n)
            {
                input = Console.ReadLine().Split().ToList();
                counter++;

                if (input[2] == "going!")
                {
                    if (attendanceList.Contains(input[0]) == false)
                    {
                        attendanceList.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                }
                else if (input[2] == "not")
                {
                    if (attendanceList.Contains(input[0]) == false)
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");

                    }
                    else if (attendanceList.Contains(input[0]) == true)
                    {
                        attendanceList.Remove(input[0]);
                    }
                }
            }
            for (int i = 0; i < attendanceList.Count; i++)
            {
                Console.WriteLine(attendanceList[i]);
            }
        }
    }
}