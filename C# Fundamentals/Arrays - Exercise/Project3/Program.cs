using System;
using System.Linq;
using System.Collections.Generic;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                
                if(i % 2 == 0)
                {
                    list1.Add(temp[1]);
                    list2.Add(temp[0]);
                }
                else
                {
                    list1.Add(temp[0]);
                    list2.Add(temp[1]);
                }
            }

            Console.WriteLine(String.Join(" ",list1));
            Console.WriteLine(String.Join(" ", list2));
        }
    }
}