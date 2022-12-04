using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<code>[a-zA-z\s]{8,})\]");

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);
                

                if (matches.Count > 0)
                {
                    List<int> digits = new List<int>();
                    string command = string.Empty;

                    foreach (Match match in matches)
                    {
                        string code = match.Groups["code"].Value;
                        char[] chars = code.ToCharArray();
                        command = match.Groups["command"].Value;
                        


                        for (int j = 0; j < chars.Length; j++)
                        {
                            int value = (int)chars[j];
                            digits.Add(value);
                        }
                    }

                    Console.WriteLine($"{command}: {String.Join(" ", digits)}");
                    

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }


            }


            
            
        }
    }
}