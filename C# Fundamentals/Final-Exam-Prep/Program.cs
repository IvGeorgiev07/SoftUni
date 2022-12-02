using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Final_Exam_Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            StringBuilder activationKey = new StringBuilder(key);

            string input;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] cmd = input.Split(">>>");
                
                if(cmd[0] == "Contains")
                {
                    if (activationKey.ToString().Contains(cmd[1]))
                    {
                        Console.WriteLine($"{activationKey} contains {cmd[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (cmd[0] == "Flip")
                {
                    int startIndex = int.Parse(cmd[2]);
                    int endIndex = int.Parse(cmd[3]);
                    string sb = activationKey.ToString().Substring(startIndex, endIndex - startIndex);
                    if (cmd[1] == "Upper")
                    {
                        sb = sb.ToUpper();
                        activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey.Insert(startIndex, sb);

                        Console.WriteLine(activationKey);
                    }
                    else if (cmd[1] == "Lower")
                    {
                        sb = sb.ToLower();
                        activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey.Insert(startIndex, sb);

                        Console.WriteLine(activationKey);
                    }
                }
                else if (cmd[0] == "Slice")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);

                    activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}