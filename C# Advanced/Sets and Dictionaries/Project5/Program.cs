using System;
using System.Linq;
using System.Collections.Generic;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();

            char[] chars = Console.ReadLine().ToArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!charsCount.ContainsKey(chars[i]))
                {
                    charsCount.Add(chars[i], 0);
                }

                charsCount[chars[i]] ++;
            }
            
            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}