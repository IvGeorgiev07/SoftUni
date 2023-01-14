using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            StringBuilder activationKey = new StringBuilder(key);

            string input;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] cmd = input.Split();

                if (cmd[0] == "Check")
                {
                    if (activationKey.ToString().Contains(cmd[1]))
                    {
                        Console.WriteLine($"Message contains {cmd[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {cmd[1]}");
                    }
                }
                else if (cmd[0] == "Make")
                {                  
                    if (cmd[1] == "Upper")
                    {
                        string text = activationKey.ToString().ToUpper();
                        activationKey.Clear();
                        activationKey.Append(text);
                        Console.WriteLine(activationKey);
                    }
                    else if (cmd[1] == "Lower")
                    {

                        string text = activationKey.ToString().ToLower();
                        activationKey.Clear();
                        activationKey.Append(text);
                        Console.WriteLine(activationKey);
                    }
                }
                else if (cmd[0] == "Cut")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    if (startIndex >= 0 && endIndex >= 0 && startIndex <= activationKey.Length - 1 && endIndex <= activationKey.Length - 1)
                    {
                        activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }
                else if (cmd[0] == "Replace")
                {
                    string substring = cmd[1];
                    string replacement = cmd[2];

                    activationKey.Replace(substring, replacement);
                    Console.WriteLine(activationKey);

                }
                else if (cmd[0] == "Sum")
                {

                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int sum = 0;
                    if(startIndex >= 0 && endIndex >= 0 && startIndex <= activationKey.Length-1 && endIndex <= activationKey.Length - 1)
                    {
                        string sb = activationKey.ToString().Substring(startIndex, endIndex - startIndex);
                        char [] chars = sb.ToCharArray();

                        for(int i =0; i < chars.Length; i++)
                        {
                            int value = (int)chars[i];
                            sum += value;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }

                }

            }
        }
    }
}