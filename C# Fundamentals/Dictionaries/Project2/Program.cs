using System.Diagnostics.Tracing;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            Dictionary<string, int> resouceQty = new Dictionary<string, int>();

            while(resource != "stop")
            {
                if (!resouceQty.ContainsKey(resource))
                {
                    resouceQty.Add(resource, qty);
                }
                else if (resouceQty.ContainsKey(resource))
                {
                    resouceQty[resource] += qty;
                }

                resource = Console.ReadLine();
                if (resource != "stop")
                {
                    qty = int.Parse(Console.ReadLine());
                }
                
            }

            foreach(var kvp in resouceQty)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}