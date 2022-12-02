using System;
using System.Linq;
using System.Collections.Generic;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal exp = decimal.Parse(Console.ReadLine());
            decimal battles = decimal.Parse(Console.ReadLine());
            int counter = 0;
            
            for (int i = 1; i <= battles; i++)
            {
                decimal expPerBattle = decimal.Parse(Console.ReadLine());
                counter++;
                if (i % 3 == 0)
                {
                    exp -= expPerBattle * 1.15m;
                }
                else if (i % 5 == 0)
                {
                    exp -= expPerBattle * 0.9m;
                }
                else if (i % 15 == 0)
                {
                    exp -= expPerBattle * 1.05m;
                }
                else
                {
                    exp -= expPerBattle;
                }

                if (exp <= 0)
                {
                    break;
                }
            }

            if (exp <= 0)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {exp:f2} more needed.");
            }
        }
    }
}