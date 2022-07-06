using System;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            
            int n = int.Parse(Console.ReadLine());

            if(n <=7 && n > 0)
            {
                Console.WriteLine(daysOfWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}