using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace ApocalypsePreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputedTextiles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] inputedMeds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> textiles = new Queue<int>(inputedTextiles);
            Stack<int> meds = new Stack<int>(inputedMeds);

            Dictionary<string, int> healingItems = new Dictionary<string, int>
            {
                { "Patch", 0 },
                { "Bandage", 0 },
                { "MedKit", 0 },
            };
            while (textiles.Any() && meds.Any())
            {
                int currentTextile = textiles.Dequeue();
                int currentMed = meds.Pop();
                int resources = currentMed+currentTextile;

                if (resources == 30)
                {
                    healingItems["Patch"]++;
                }
                else if (resources == 40)
                {
                    healingItems["Bandage"]++;
                }
                else if (resources == 100)
                {
                    healingItems["MedKit"]++;
                }               
                else if (resources > 100)
                {
                    int returningResources = resources - 100;
                    healingItems["MedKit"]++;
                    int nextMed = meds.Pop();
                    meds.Push(returningResources+ nextMed);
                }
                else
                {
                    meds.Push(currentMed+10);
                }
                //else
                //{
                //    flour.Push(currentFlour);
                //    water.Enqueue(currentWater);
                //}
            }

            var sb = new StringBuilder();

            if (!textiles.Any() && meds.Any())
            {
                sb.AppendLine($"Textiles are empty.");
            }
            if (!meds.Any() && textiles.Any())
            {
                sb.AppendLine($"Medicaments are empty.");
            }
            if (!meds.Any() && !textiles.Any())
            {
                sb.AppendLine("Textiles and medicaments are both empty.");
            }

            var ordered = healingItems.OrderBy(x => x.Key).OrderByDescending(x => x.Value);
            if (healingItems.Any())
            {
                foreach (var item in ordered)
                {
                    if (item.Value > 0)
                    {
                        sb.AppendLine($"{item.Key} - {item.Value}");
                    }

                }

            }

            if (textiles.Any() && !meds.Any())
            {
                sb.AppendLine($"Textiles left: {string.Join(", ", textiles)}");
            }
            

            if (meds.Any() && !textiles.Any())
            {
                sb.AppendLine($"Medicaments left: {string.Join(", ", meds)}");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}