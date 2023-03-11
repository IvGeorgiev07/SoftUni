using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PizzaCalories
{
    internal class Topping
    {
        private string type;
        private int weigh;
        public Topping(string type, int weigh)
        {
            Type = type;
            Weigh = weigh;
        }

        private string Type
        {
            get { return type; }
            set
            {
                if (value != "Meat" && value != "Veggies" && value != "Cheese"&& value != "Sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value;
                
            }
        }
        private int Weigh
        {
            get => weigh;
            set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range[1..50].");
                }
                weigh = value;
            }
        }
        static int CaloriesPerGram => 2;
        private double ToppingModifier { get; set; }

        public double CaloriesCalc()
        {
            if (Type == "Meat")
            {
                ToppingModifier = 1.2;
            }
            else if (Type == "Veggies")
            {
                ToppingModifier = 0.8;
            }
            else if (Type == "Cheese")
            {
                ToppingModifier = 1.1;
            }
            else if (Type == "Sauce")
            {
                ToppingModifier = 0.9;
            }
            double calories = Weigh * CaloriesPerGram * ToppingModifier;
            return calories;

        }


    }
}
