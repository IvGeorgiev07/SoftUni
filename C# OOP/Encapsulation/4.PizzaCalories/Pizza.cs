using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PizzaCalories
{
    internal class Pizza
    {
        private string name;

        public Pizza(string name)
        {
            Name = name;
            Toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {                
                if(value.Length < 0 || value.Length > 15 || String.IsNullOrWhiteSpace(value)|| String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        private List<Topping> Toppings { get; set; }

        public void Add(Topping topping)
        {
            if(Toppings.Count > 10 || Toppings.Count < 0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                Toppings.Add(topping);
            }
            
        }

        public double ToppingCalories()
        {
            if (Toppings.Count<1)
            {
                return 0;
            }
            double toppingCalories = 0;
            foreach (var topping in Toppings)
            {
                toppingCalories += topping.CaloriesCalc();
            }
            return toppingCalories;
        }
    }
}
