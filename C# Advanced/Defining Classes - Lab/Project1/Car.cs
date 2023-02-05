using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
     public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;


        public Car()
        {
            this.Make = String.Empty;
            this.Model = String.Empty;
            this.Year = 0;
            this.FuelQuantity = 0;
            this.FuelConsumption = 0;
            this.AverageTirePressure= 0;
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption): this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
        public Tire[] Tires { get; set; }
        public Engine Engine { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double AverageTirePressure { get; set; }

        public void Drive (double distance)
        {
            double neededFuel = FuelConsumption * distance;
            if(neededFuel < FuelQuantity)
            {
                FuelQuantity -= neededFuel;
            }
            else
            {
                
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.AppendLine($"Make: {this.Make}");
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Year: {this.Year}");
            stringBuilder.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            stringBuilder.AppendLine($"FuelQuantity: {this.FuelQuantity:f1}");

            return stringBuilder.ToString().Trim();
        }
    }
}
