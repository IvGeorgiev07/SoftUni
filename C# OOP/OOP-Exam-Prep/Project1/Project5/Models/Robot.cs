using RobotService.Models.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public class Robot : IRobot
    {
        public Robot(string model, int batteryCapacity, int conversionCapacityIndex)
        {
            Model= model;
            BatteryCapacity= batteryCapacity;
            ConvertionCapacityIndex= conversionCapacityIndex;
            BatteryLevel = batteryCapacity;
            interfaceStandards = new();
        }
        
        private string model;
        public string Model
        {
            get { return model; }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNullOrWhitespace);
                }
                model = value;
            }
        }


        private int batteryCapacity;
        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            private set 
            { 
                if(batteryCapacity < 0)
                {
                    throw new ArgumentException(ExceptionMessages.BatteryCapacityBelowZero);
                }
                batteryCapacity = value;
            }
        }

        private int batteryLevel;
        public int BatteryLevel
        {
            get { return batteryLevel; }
            private set { batteryLevel = value; }
        }

        private int convertionCapacityIndex;
        public int ConvertionCapacityIndex
        {
            get { return convertionCapacityIndex; }
            private set { convertionCapacityIndex = value; }
        }

        private List<int> interfaceStandards;
        public IReadOnlyCollection<int> InterfaceStandards => interfaceStandards.AsReadOnly();


        public void Eating(int minutes)
        {
            int energy = minutes * ConvertionCapacityIndex;
            if (BatteryLevel < BatteryCapacity)
            {
                BatteryLevel += energy;
            }
            if(BatteryLevel > BatteryCapacity)
            {
                BatteryLevel = BatteryCapacity;
            }
            
        }

        public bool ExecuteService(int consumedEnergy)
        {
            if(BatteryLevel >= consumedEnergy)
            {
                batteryLevel -= consumedEnergy;
                return true;
            }
            return false;
        }

        public void InstallSupplement(ISupplement supplement)
        {
            interfaceStandards.Add(supplement.InterfaceStandard);
            BatteryCapacity -= supplement.BatteryUsage;
            BatteryLevel -= supplement.BatteryUsage;
        }

        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"{typeof(Robot)} {Model}:");
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");
            if(InterfaceStandards.Count > 0)
            {
                sb.AppendLine($"--Supplements installed: {String.Join(" ", InterfaceStandards)}");
            }
            else
            {
                sb.AppendLine($"--Supplements installed: none");
            }

            return sb.ToString().Trim();
        }
    }
}
