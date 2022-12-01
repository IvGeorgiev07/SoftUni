using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var LicensePlates = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "register")
                {
                    if (!LicensePlates.ContainsKey(cmdArgs[1]))
                    {
                        LicensePlates.Add(cmdArgs[1], cmdArgs[2]);
                        Console.WriteLine($"{cmdArgs[1]} registered {cmdArgs[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {LicensePlates[cmdArgs[1]]}");
                    }
                }
                else if (cmdArgs[0] == "unregister")
                {
                    if (!LicensePlates.ContainsKey(cmdArgs[1]))
                    {
                        Console.WriteLine($"ERROR: user {cmdArgs[1]} not found");
                    }
                    else
                    {
                        LicensePlates.Remove(cmdArgs[1]);
                        Console.WriteLine($"{cmdArgs[1]} unregistered successfully");
                    }
                }

            }

            foreach(var kvp in LicensePlates)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}