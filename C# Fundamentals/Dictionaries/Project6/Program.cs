using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> Student = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!Student.ContainsKey(name))
                {
                    Student[name] = new List<decimal>
                    {

                    grade,

                    };
                }
                else
                {
                    Student[name].Add(grade);
                }
            }

            foreach (var kvp in Student)
            {
                decimal sum = 0;
                foreach (var kvp2 in kvp.Value)
                {
                    sum += kvp2;
                }
                decimal averageGrade = sum / kvp.Value.Count;

                if (averageGrade >= 4.5m)
                {
                    Console.WriteLine($"{kvp.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}