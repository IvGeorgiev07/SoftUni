using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder code = new StringBuilder(inputText);

            string[] command = Console.ReadLine().Split('|');

            while (command[0] != "Decode")
            {
                if (command[0] == "Move")
                {
                    int n = int.Parse(command[1]);
                    if (n <= code.Length - 1)
                    {
                        char[] temp = code.ToString().Take(n).ToArray();
                        string tempStr = new string(temp);
                        code.Remove(0, n);
                        code.Append(tempStr);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    code.Insert(index, value);
                }
                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];

                    code.Replace(substring, replacement);

                }
                command = Console.ReadLine().Split('|');
            }
            Console.WriteLine($"The decrypted message is: {code}");
        }
    }
}