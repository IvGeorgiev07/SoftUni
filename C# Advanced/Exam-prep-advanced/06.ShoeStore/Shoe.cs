﻿using System;
using System.Text;

namespace ShoeStore
{
    public class Shoe
    {
        private string name;
        private string type;
        private double size;
        private string material;
        public Shoe(string brand, string type, double size, string material)
        {
            Brand = brand;
            Type = type;
            Size = size;
            Material = material;
        }

        public string Brand { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }
        public string Material { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
              sb.AppendLine($"Size {Size}, {Material} {Brand} {Type} shoe.");
            return sb.ToString().Trim();
        }
    }
}
