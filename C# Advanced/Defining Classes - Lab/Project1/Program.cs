using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            int counter = 0;
            string input = Console.ReadLine();
            List<string> tires = new List<string>();
            List<string> engines = new List<string>();
            List<string> cars = new List<string>();
            Dictionary<int, Car> newCars= new Dictionary<int, Car>();
            
            while (true)
            {
                if (counter == 0)
                {
                    tires.Add(input);
                }
                else if (counter == 1)
                {
                    engines.Add(input);
                }
                else if (counter == 2)
                {
                    cars.Add(input);
                }
                input = Console.ReadLine();

                if (input == "No more tires")
                {
                    counter++;
                    input = Console.ReadLine();
                }
                else if (input == "Engines done")
                {
                    counter++;
                    input = Console.ReadLine();
                }
                else if (input == "Show special")
                {
                    break;
                }

            }

            for (int i = 0; i < cars.Count; i++)
            {
                string[] carInfo = cars[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int engineIndex = int.Parse(carInfo[5]);
                int tireIndex = int.Parse(carInfo[6]);
                string[] newCar = cars[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] newEngine = engines[engineIndex].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                double[] newTire = tires[tireIndex].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                newCars.Add(i, new Car());
                newCars[i].Make = newCar[0];
                newCars[i].Model = newCar[1];
                newCars[i].Year = int.Parse(newCar[2]);
                newCars[i].FuelQuantity = double.Parse(newCar[3]);
                newCars[i].FuelConsumption = double.Parse(newCar[4]);
                newCars[i].Engine = new Engine(int.Parse(newEngine[0]), double.Parse(newEngine[1]));
                newCars[i].Tires = new Tire[4];
                newCars[i].Tires[0] = new Tire((int)newTire[0], newTire[1]);
                newCars[i].Tires[1] = new Tire((int)newTire[2], newTire[3]);
                newCars[i].Tires[2] = new Tire((int)newTire[4], newTire[5]);
                newCars[i].Tires[3] = new Tire((int)newTire[6], newTire[7]);
                
                newCars[i].AverageTirePressure = newTire[1]+ newTire[3]+ newTire[5] + newTire[7];

            }

            foreach (var car in newCars)
            {
                
                if(car.Value.Year >= 2017 && car.Value.Engine.HorsePower >= 330 && car.Value.AverageTirePressure >=9 && car.Value.AverageTirePressure <= 10)
                {
                    car.Value.Drive(0.2);
                    Console.WriteLine(car.Value.WhoAmI());
                }
            }

        }
    }
}
