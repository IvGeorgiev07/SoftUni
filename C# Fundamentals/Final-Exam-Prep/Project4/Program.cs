using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder text= new StringBuilder(input);

            string[] command = Console.ReadLine().Split(":|:");

            while(command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);

                    text.Insert(index, " ");

                    Console.WriteLine(text);
                }
                else if(command[0] == "Reverse")
                {
                    string substring = command[1];
                    string newText = text.ToString();

                    if (newText.Contains(substring))
                    {
                        text.Remove(text.ToString().IndexOf(substring), substring.Length);

                        char[] chars= substring.Reverse().ToArray();
                        substring = new string(chars);

                        text.Append(substring);

                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];

                    text.Replace(substring, replacement);

                    Console.WriteLine(text.ToString());
                }
                command = Console.ReadLine().Split(":|:");
            }

            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}