using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {            
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public double DefaultFuelConsumption => FuelConsumption;/*{ get; set; }*/
        public virtual double FuelConsumption => 1.25;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            Fuel = Fuel - kilometers * FuelConsumption;
        }
    }
}
