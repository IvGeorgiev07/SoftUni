using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> Plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input= Console.ReadLine().Split("<->");
                string plantName = input[0];
                int rarity = int.Parse(input[1]);
                List<double> rating = new List<double>();

                if(!Plants.ContainsKey(plantName))
                {
                    Plant plant = new Plant(rarity, rating);
                    Plants.Add(plantName, plant);
                }
                else
                {
                    Plants[plantName].Rarity = rarity;
                }

            }

            string[] command = Console.ReadLine().Split(new char[] { ':',' ','-' },StringSplitOptions.RemoveEmptyEntries);


            while (command[0] != "Exhibition")
            {
                if (command[0] == "Rate")
                {
                    double rating = double.Parse(command[2]);
                    string plantName = command[1];

                    if (Plants.ContainsKey(plantName))
                    {
                        Plants[plantName].Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }  
                }
                else if (command[0] == "Update")
                {
                    int rarity = int.Parse(command[2]);
                    string plantName = command[1];

                    if (Plants.ContainsKey(plantName))
                    {
                        Plants[plantName].Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "Reset")
                {
                    string plantName = command[1];

                    if (Plants.ContainsKey(plantName))
                    {
                        Plants[plantName].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                command = Console.ReadLine().Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var (plantName, plantKVP) in Plants)
            {

                if(plantKVP.Rating.Count > 0)
                {
                    double averageRating = plantKVP.Rating.Average();
                    
                    Console.WriteLine($"- {plantName}; Rarity: {plantKVP.Rarity}; Rating: {averageRating:F2}");
                }
                else
                {
                    
                    
                    Console.WriteLine($"- {plantName}; Rarity: {plantKVP.Rarity}; Rating: 0.00");
                }
                
            }
        }
    }









    public class Plant
    {
        public Plant(int rarity, List<double> rating )
        {
            Rarity = rarity;
            Rating = rating;
        }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
    }
}