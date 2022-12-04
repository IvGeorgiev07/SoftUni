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
            Regex regex = new Regex(@"((\|)|(\#))(?<food>[a-zA-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<kcal>\d{4})\1");

            string input = Console.ReadLine();
            double kcal = 0;

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                double calories = double.Parse(match.Groups["kcal"].Value);
                kcal += calories;
            }

            if(matches.Count > 0)
            {
                double days = kcal / 2000;
                Console.WriteLine($"You have food to last you for: {Math.Floor(days)} days!");

                foreach (Match match in matches)
                {
                    Console.WriteLine($"Item: {match.Groups["food"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["kcal"].Value}");
                }

            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
        }
    }
}