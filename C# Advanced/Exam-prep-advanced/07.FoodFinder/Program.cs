using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace _07.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputedWater = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] inputedFlour = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Queue<double> water = new Queue<double>(inputedWater);
            Stack<double> flour = new Stack<double>(inputedFlour);

            Dictionary<string, int> foods = new Dictionary<string, int>
            {
                { "Croissant", 0 },
                { "Muffin", 0 },
                { "Baguette", 0 },
                { "Bagel", 0 }
            };
            while (water.Any() && flour.Any() )
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();
                double waterPercentage = currentWater*100/(currentWater+currentFlour);
                
                if(waterPercentage == 50)
                {
                    foods["Croissant"]++;
                }
                else if(waterPercentage == 40)
                {
                    foods["Muffin"]++;
                }
                else if (waterPercentage == 30)
                {
                    foods["Baguette"]++;
                }
                else if (waterPercentage == 20)
                {
                    foods["Bagel"]++;
                }
                else if (currentFlour >= currentWater)
                {
                    double returningFlour = currentFlour - currentWater;
                    foods["Croissant"]++;
                    if(returningFlour > 0)
                    {
                        flour.Push(returningFlour);
                    }
                    
                    
                }
                //else
                //{
                //    flour.Push(currentFlour);
                //    water.Enqueue(currentWater);
                //}
            }

            var sb = new StringBuilder();
            var ordered = foods.OrderBy(x => x.Key).OrderByDescending(x=>x.Value);
            if(foods.Any())
            {
                foreach (var food in ordered)
                {
                    if (food.Value > 0)
                    {
                        sb.AppendLine($"{food.Key}: {food.Value}");
                    }

                }

            }
            
            if (water.Count> 0)
            {
                sb.AppendLine($"Water left: {string.Join(", ", water)}");
            }
            else
            {
                sb.AppendLine($"Water left: None");
            }
            
            if(flour.Count> 0)
            {
                sb.AppendLine($"Flour left: {string.Join(", ", flour)}");
            }
            else
            {
                sb.AppendLine($"Flour left: None");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}