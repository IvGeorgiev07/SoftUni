using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _01.StackAndQue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeinAmount= new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> drinks = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            int totalCaffein = 0;
            while (drinks.Count > 0 && caffeinAmount.Count > 0)
            {

                int caffein = caffeinAmount.Pop();
                int drink = drinks.Dequeue();
                int multiplayed = caffein * drink;
                

                if (multiplayed + totalCaffein <= 300)
                {
                    totalCaffein += multiplayed;
                }
                else
                {
                    drinks.Enqueue(drink);
                    totalCaffein -= 30;
                    if(totalCaffein <= 0)
                    {
                        totalCaffein= 0;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            if(drinks.Count > 0)
            {
                sb.AppendLine($"Drinks left: {String.Join(", ", drinks)}");
            }
            else
            {
                sb.AppendLine($"At least Stamat wasn't exceeding the maximum caffeine.");
            }

            sb.AppendLine($"Stamat is going to sleep with {totalCaffein} mg caffeine.");
            Console.WriteLine(sb.ToString().Trim());
                       
        }
    }
}