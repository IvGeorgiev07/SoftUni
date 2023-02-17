using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace FishingNet
{
    public class Net
    {
        private readonly ICollection<Fish> fish;
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            this.fish = new List<Fish>();
        }

        public string Material { get; set; }
        public int Capacity { get; set; }
        public IReadOnlyCollection<Fish> Fish => (IReadOnlyCollection<Fish>)this.fish;
        public int Count { get { return Fish.Count; } }

        public string AddFish(Fish fishToAdd)
        {
            if (string.IsNullOrWhiteSpace(fishToAdd.FishType) || fishToAdd.Weight <= 0
                || fishToAdd.Length <= 0)
            {
                return "Invalid fish.";
            }
            else if (Fish.Count+1>Capacity)
            {
                return "Fishing net is full.";
            }
            fish.Add(fishToAdd);
            return $"Successfully added {fishToAdd.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
           Fish releasedFish = fish.FirstOrDefault(x => x.Weight == weight);
            if(releasedFish != null)
            {
                fish.Remove(releasedFish);
                return true;
            }
            return false;
        }

        public Fish GetFish(string fishType) 
            => fish.FirstOrDefault(x=>x.FishType== fishType);

        public Fish GetBiggestFish()
        {
            Fish biggestFish = fish.OrderByDescending(x => x.Length).First();
            return biggestFish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            List<Fish> sorted = fish.OrderByDescending(x=>x.Length).ToList();
            sb.AppendLine($"Into the {Material}:");
            foreach(Fish f in sorted)
            {
                sb.AppendLine(f.ToString().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}
