using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})\1";
            Regex rg = new Regex(pattern);

            List<int> digits = new List<int>();

            foreach(char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    int digit = (int)ch-48;
                    digits.Add(digit);
                }
            }

            BigInteger coolThreshold = new BigInteger(1);

            for (int i = 0; i < digits.Count; i++)
            {
 
                coolThreshold *= digits[i];

            }

            MatchCollection matches = rg.Matches(input);

            List<string> realEmoji = new List<string>();

            if(matches.Any())
            {
                Console.WriteLine($"Cool threshold: {coolThreshold}");
                Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are: ");

                foreach (Match match in matches)
                {
                    string emoji = match.Groups["emoji"].ToString();
                    char[] emojiCh = emoji.ToCharArray();

                    BigInteger charSum = new BigInteger(0);
                    foreach (char c in emojiCh)
                    {
                        charSum += (int)c;
                    }
                    if (charSum > coolThreshold)
                    {
                        realEmoji.Add(match.ToString());
                    }

                }

                foreach(string emoji in realEmoji)
                {
                    Console.WriteLine($"{emoji} ");
                }
                

            }
            
        }
    }
}