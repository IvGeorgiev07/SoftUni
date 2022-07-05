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
            List<string> input = Console.ReadLine().Split().ToList();
            List<string> attendanceList = new List<string>();
            int counter = 1;
            

            while (true)
            {  

                if (input[2] == "going!")
                {
                    attendanceList.Add(input[0]);
                }
                else if(input[2] == "not")
                {
                    for(int i = 0; i < attendanceList.Count; i++)
                    {
                        if(input[0] != attendanceList[i])
                        {
                            Console.WriteLine($"{input[0]} is not in the list!");
                        }
                        else if (input[0] == attendanceList[i])
                        {
                            attendanceList.Remove(input[0]);
                        }
                    }
                }
                input = Console.ReadLine().Split().ToList();
                counter++;
                if (counter > n)
                {
                    break;
                }
            }
            for(int i = 0; i < attendanceList.Count; i++)
            {
                Console.WriteLine(attendanceList[i]);
            }
        }
    }
}