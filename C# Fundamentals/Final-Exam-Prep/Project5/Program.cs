using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patter = @"(\@\#{1,})[A-Z][A-Za-z0-9]{4,}[A-Z]\1";
            Regex regex= new Regex(@"^@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+$");
            List<string> barcodes= new List<string>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if(regex.Match(input).Success )
                {
                    List<int> digits = new List<int>();

                    char[] chars = input.ToCharArray();

                    foreach (char c in chars)
                    {
                        if (char.IsDigit(c))
                        {
                            int digit = (int)c - 48;
                            digits.Add(digit);
                        }
                    }
                    if (digits.Any())
                    {
                        Console.WriteLine($"Product group: {String.Join("", digits)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }   
            
        }
    }
}