using System;
using System.Collections.Generic;
using System.Text;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double sum =0;

            if(day == "Friday")
            {
                if (type == "Students" && people >= 30)
                {
                    sum += (people * 8.45)*0.85;
                }
                else if (type == "Students" && people < 30)
                {
                    sum += people * 8.45;
                }
                else if (type == "Business" && people >= 100)
                {
                    sum += (people - 10) * 10.9;
                }
                else if (type == "Business" && people < 100)
                {
                    sum += people * 10.9;
                }
                else if (type == "Regular" && (people >=10 && people <=20))
                {
                    sum += (people * 15)*0.95;
                }
                else if (type == "Regular" && (people < 10 || people > 20))
                {
                    sum += people * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students" && people >= 30)
                {
                    sum += (people * 9.8) * 0.85;
                }
                else if (type == "Students" && people < 30)
                {
                    sum += people * 9.8;
                }
                else if (type == "Business" && people >= 100)
                {
                    sum += (people - 10) * 15.6;
                }
                else if (type == "Business" && people < 100)
                {
                    sum += people * 15.6;
                }
                else if (type == "Regular" && people >= 10 && people <= 20)
                {
                    sum += (people * 20) * 0.95;
                }
                else if (type == "Regular" && (people < 10 || people > 20))
                {
                    sum += people * 20;
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students" && people >= 30)
                {
                    sum += (people * 10.46) * 0.85;
                }
                else if (type == "Students" && people < 30)
                {
                    sum += people * 10.46;
                }
                else if (type == "Business" && people >= 100)
                {
                    sum += (people - 10) * 16;
                }
                else if (type == "Business" && people < 100)
                {
                    sum += people * 16;
                }
                else if (type == "Regular" && people >= 10 && people <= 20)
                {
                    sum += (people * 22.5) * 0.95;
                }
                else if (type == "Regular" && (people < 10 || people > 20))
                {
                    sum += people * 22.5;
                }
            }

            Console.WriteLine($"Total price: {sum:f2}");

        }
    }
}