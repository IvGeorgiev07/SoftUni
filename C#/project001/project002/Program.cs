using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 5364;
            int end = 8848;
            string text = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            int daysCount = 1;

            while (text != "END")
            {
                if (text == "Yes")
                {
                    daysCount++;
                    if (daysCount > 5)
                    {
                        break;
                    }
                    start += m;
                }
                else if(text == "No")
                {
                    start += m;
                }

                if (start >= end)
                {
                    break;
                }

                text = Console.ReadLine();

                if(text == "END")
                {
                    break;
                }
                m = int.Parse(Console.ReadLine());

            }
            if (start >= 8848)
            {
                Console.WriteLine($"Goal reached for {daysCount} days!");

            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{start}");
            }

        }
    }
}
