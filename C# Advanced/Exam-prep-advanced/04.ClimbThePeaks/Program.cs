using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ClimbThePeaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] foodInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] staminaInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> food = new Stack<int>(foodInput);
            Queue<int> stamina = new Queue<int>(staminaInput);

            string[] PeakNames = { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" };
            int[] PeakDiff = { 80, 90, 100, 60, 70 };

            Stack<string> peakNames= new Stack<string>(PeakNames.Reverse());
            Stack<int> peakDiff = new Stack<int>(PeakDiff.Reverse());

            Queue<string> conquredPeaks= new Queue<string>();
            while(food.Count > 0)
            {
                if (conquredPeaks.Count == PeakNames.Length)
                {
                    break;
                }

                int dailyFood = food.Pop();
                int dailyStamina = stamina.Dequeue();
                int energy = dailyFood + dailyStamina;
                int neededEnergy = peakDiff.Pop();
                string currentPeak = peakNames.Pop();

                if(energy >= neededEnergy)
                {
                    conquredPeaks.Enqueue(currentPeak);                     
                }
                else
                {
                    peakNames.Push(currentPeak);
                    peakDiff.Push(neededEnergy);
                }
         
            }

            StringBuilder sd = new StringBuilder();
            if(conquredPeaks.Count == PeakNames.Length)
            {
                sd.AppendLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
                sd.AppendLine("Conquered peaks:");
                for (int i = 0; i < PeakNames.Length; i++)
                {
                    string peak = conquredPeaks.Dequeue();
                    sd.AppendLine(peak);
                }
            }
            else if(conquredPeaks.Count < PeakNames.Length && conquredPeaks.Count > 0)
            {
                sd.AppendLine($"Alex failed! He has to organize his journey better next time -> @PIRINWINS");
                sd.AppendLine("Conquered peaks:");
                while(conquredPeaks.Count > 0)
                {
                    string peak = conquredPeaks.Dequeue();
                    sd.AppendLine(peak);
                }
            }
            else
            {
                sd.AppendLine($"Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            Console.WriteLine(sd.ToString().Trim());
        }
    }
}