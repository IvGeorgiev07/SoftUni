using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace project001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double kmPerDay = m;
            double totalKm = kmPerDay;

            for(int i = 0; i<n;i++)
            {
                double input = int.Parse(Console.ReadLine());
                double percentage =(input / 100 + 1);
                kmPerDay = kmPerDay * percentage;
                totalKm += kmPerDay;    
            }

            if(totalKm> 1000)
            {
                double endResult = totalKm - 1000;
                Console.WriteLine($"You've done great job running {Math.Ceiling(endResult)} more kilometers!");
            }
            else
            {
                double endResult = 1000-totalKm;
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(endResult)} more kilometers!");
            }

            
        }
    }
}