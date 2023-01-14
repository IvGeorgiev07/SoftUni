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
            string input = Console.ReadLine();
            string newText = string.Empty;
            if (input.Length > 0)
            {
                newText= input;
            }
            StringBuilder code = new StringBuilder(newText);


            string[] cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string command = cmd[0];

            while (cmd[0] != "Finish")
            {
                command = cmd[0];
                if (command == "Replace")
                {
                    string oldValue = cmd[1];
                    string newValue = cmd[2];
                    code.Replace(oldValue, newValue);
                    Console.WriteLine(code);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    if (startIndex > 0 && endIndex < code.Length)
                    {
                        code.Remove(startIndex, endIndex);
                        Console.WriteLine(code);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (command == "Make")
                {
                    string cmdArgs = cmd[1];
                    string text = code.ToString();

                    if (cmdArgs == "Upper")
                    {
                        text = text.ToUpper();
                        code.Clear();
                        code.Append(text);
                    }
                    else if (cmdArgs == "Lower")
                    {
                        text = text.ToLower();
                        code.Clear();
                        code.Append(text);
                    }

                    Console.WriteLine(code);
                }
                else if (command == "Check")
                {
                    string cmdArgs = cmd[1];
                    if (code.ToString().Contains(cmdArgs))
                    {
                        Console.WriteLine($"Message contains {cmdArgs}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {cmdArgs}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int sum = 0;

                    if (startIndex > 0 && endIndex <= code.Length - 1)
                    {
                        string sb = code.ToString().Substring(startIndex, endIndex);
                        char[] chars = sb.ToCharArray();

                        for (int i = 0; i < chars.Length; i++)
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
                cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            
        }

    }
}
