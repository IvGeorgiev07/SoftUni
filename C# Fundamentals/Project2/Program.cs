using System;
using System.Linq;
using System.Collections.Generic;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffe  = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Include")
                {
                    coffe.Add(command[1]);
                }
                else if(command[0] == "Remove")
                {
                    int index = int.Parse(command[2]);
                    if (coffe.Count - index - 1 >= 0 && index <= coffe.Count-1)
                    {
                        if (command[1] == "first")
                        {
                            for (int j = 0; j < index; j++)
                            {
                                coffe.RemoveAt(0);
                            }
                        }
                        else if(command[1] == "last")
                        {
                            for(int j = 0; j < index; j++)
                            {
                                coffe.RemoveAt(coffe.Count-1);
                            }
                        }
                    }
                    
                }
                else if( command[0] == "Prefer")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    if (coffe.Count - index1 - 1 >= 0 && index1 <= coffe.Count - 1 && coffe.Count - index2 - 1 >= 0 && index2 <= coffe.Count - 1)
                    {
                        string tmp = coffe[index1];
                        coffe[index1] = coffe[index2];
                        coffe[index2] = tmp;
                    } 
                }
                else if (command[0] == "Reverse")
                {
                    coffe.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(" ", coffe));

            
        }
    }
}