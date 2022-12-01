using System.Diagnostics.Tracing;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> ProductAndPrice= new Dictionary<string, decimal>();
            Dictionary<string, int> ProductAndQuantity = new Dictionary<string, int>();

            string[] input= Console.ReadLine().Split();

            while (input[0] != "buy")
            {
                decimal price = decimal.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!ProductAndPrice.ContainsKey(input[0]))
                {
                    ProductAndPrice.Add(input[0], price);
                }
                else
                {
                    ProductAndPrice[input[0]] = price;
                }

                if (!ProductAndQuantity.ContainsKey(input[0]))
                {
                    ProductAndQuantity.Add(input[0], quantity);
                }
                else
                {
                    ProductAndQuantity[input[0]] += quantity;
                }

                input = Console.ReadLine().Split();                

            }
            foreach (var kvp in ProductAndPrice)
            {
                decimal productPrice = kvp.Value;
                int productQuantity = ProductAndQuantity[kvp.Key];

                decimal sum = productPrice * productQuantity;

                Console.WriteLine($"{kvp.Key} -> {sum:f2}");
            }

        }
    }

}
    
