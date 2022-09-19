using System;
using System.Collections.Generic;
using System.Text;

namespace project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string password = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char eachChar = input[i];
                password += eachChar;
            }
            

            string input2 = Console.ReadLine();
            int counter = 1;
            while (input2 != password)
            {
                if(counter < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if(counter == 4)
                {
                    Console.WriteLine($"User {input} blocked!");
                    return;
                }
               counter++;

               input2 = Console.ReadLine();
            }

            Console.WriteLine($"User {input} logged in.");
        }
    }
}