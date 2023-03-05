using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount { get { return Registry.Count; } }

        public bool AddChild(Child child)
        {
            if (Registry.Count == Capacity)
            {
                return false;
            }
            Registry.Add(child);
            return true;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] names = childFullName.Split(" ", System.StringSplitOptions.TrimEntries);

            Child childToRemove = Registry.FirstOrDefault(x => x.FirstName == names[0] && x.LastName == names[1]);

            if (childToRemove != null)
            {
                Registry.Remove(childToRemove);
                return true;
            }
            return false;
        }

        public Child GetChild(string childFullName)
        {
            string[] names = childFullName.Split(" ", System.StringSplitOptions.TrimEntries);

            Child childToRemove = Registry.FirstOrDefault(x => x.FirstName == names[0] && x.LastName == names[1]);

            if (childToRemove != null)
            {
                return childToRemove;
            }
            return null;
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            List<Child> sorted = Registry.OrderByDescending(x => x.Age).ThenBy(x=>x.LastName).ThenBy(x => x.FirstName).ToList();
            sb.AppendLine($"Registered children in {Name}:");

                for (int i = 0; i<sorted.Count;i++)
                {
                    sb.AppendLine(sorted[i].ToString());
                }
            return sb.ToString().TrimEnd();
        }
    }
}

