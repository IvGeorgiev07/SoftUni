using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Capacity = capacity;
            Model = model;
            Multiprocessor = new List<CPU>();
        }

        public List<CPU> Multiprocessor { get; set; }

        public int Capacity { get; set; }

        public string Model { get; set; }

        public int Count { get { return Multiprocessor.Count; } }

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            CPU cpuToRemove = Multiprocessor.FirstOrDefault(c => c.Brand == brand);
            if (cpuToRemove != null)
            {
                return Multiprocessor.Remove(cpuToRemove);
            }

            return false;
        }


        public CPU MostPowerful()
        {
            if (Multiprocessor.Count == 0)
            {
                return null;
            }
            CPU mostPowerCpu = Multiprocessor[0];
            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Frequency > mostPowerCpu.Frequency)
                {
                    mostPowerCpu = cpu;
                }
            }
            return mostPowerCpu;
        }


        public CPU GetCPU(string brand)
        {
            CPU cpuToGet = Multiprocessor.FirstOrDefault(c => c.Brand == brand);

            return cpuToGet;

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var item in Multiprocessor)
            {
                sb.AppendLine($"{item.Brand} CPU:");
                sb.AppendLine($"Cores: {item.Cores}");
                sb.AppendLine($"Frequency: {item.Frequency:f1} GHz");
            }
            return sb.ToString().Trim();

        }
    }
}
