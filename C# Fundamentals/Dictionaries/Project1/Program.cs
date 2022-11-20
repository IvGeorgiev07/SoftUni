using System.Diagnostics.Tracing;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();
            char[] chars = input.Where(c => !char.IsWhiteSpace(c)).ToArray();

            Dictionary<char, int> words= new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (!words.ContainsKey(c))
                {
                    words.Add(c, 0);
                }

                words[c]++;
            }
            
            foreach(var kvp in words)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}