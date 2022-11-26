using System.Diagnostics.Tracing;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<decimal, int> counts = new Dictionary<decimal, int>();
            Dictionary<string, Dictionary counts> ProductSum = new Dictionary<string, counts>();
            
            while (true)
            {
                string[] product = Console.ReadLine().Split();
                if (product[0] == "buy")
                {
                    break;
                }

                if (!ProductSum.ContainsKey(product[0]))
                {
                    decimal price = decimal.Parse(product[1]);
                    int count = int.Parse(product[2]);
                    ProductSum.Add(product[0], new Dictionary<decimal, int> { { price, count } });
                }
                else
                {
                    
                }
                
                
            }

            foreach (var kvp in ProductSum)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

        }
    }
}