﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;

        }

        public string Name { get; private set; }
        public string Type { get; private set; }
        public double Rate { get; private set; }
        public int Days { get; private set; }
        public bool Hired { get; set; } = false;

        public bool Paid { get; set; } = false;


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Renovator: {this.Name}");
            sb.AppendLine($"--Specialty: {this.Type}");
            sb.AppendLine($"--Rate per day: {this.Rate} BGN");
            return sb.ToString().TrimEnd();
        }
    }
}
