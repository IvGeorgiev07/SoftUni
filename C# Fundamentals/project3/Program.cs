using System;
using System.Linq;
using System.Collections.Generic;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string> output = new List<string>();

            while (input[0] != "end")
            {
                if(input[0] == "Chat")
                {
                    output.Add(input[input.Length-1]);
                }
                else if(input[0] == "Delete")
                {
                    if (output.Contains(input[1]))
                    {
                        output.Remove(input[1]);
                    }
                }
                else if (input[0] == "Edit")
                {
                    int index = output.FindIndex(s => s == input[1]);

                    if (index != -1)
                        output[index] = input[2];
                }
                else if (input[0] == "Pin")
                {
                    if (output.Contains(input[1]))
                    {
                        output.Remove(input[1]);
                        output.Add(input[1]);
                    }
                }
                else if (input[0]== "Spam")
                {
                    for(int i = 1; i < input.Length; i++)
                    {
                        output.Add(input[i]);
                    }
                }
                input = Console.ReadLine().Split().ToArray();

            }
            for(int i = 0; i < output.Count; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}