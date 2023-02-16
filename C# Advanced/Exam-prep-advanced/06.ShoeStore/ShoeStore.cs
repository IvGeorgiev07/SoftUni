using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {        
        public ShoeStore(string name, int storageCapacity)
        {
            Shoes = new List<Shoe>();
            Name = name;
            StorageCapacity = storageCapacity;
        }

        public List<Shoe> Shoes { get; init; }
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public int Count { get { return Shoes.Count; } }

        public string AddShoe(Shoe shoe)
        {
            string text = string.Empty;
            if(StorageCapacity == 0)
            {
                text = $"No more space in the storage room";
            }
            else if(StorageCapacity > 0)
            {
                Shoes.Add(shoe);
                text = $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
                StorageCapacity--;
            }
            return text.Trim() ;
        }

        public int RemoveShoes(string material)
        {
            int counter = 0;
            for (int i = 0; i < Shoes.Count; i++)
            {
                if (Shoes[i].Material == material)
                {
                    Shoes.Remove(Shoes[i]);
                    counter++;
                    i = 0;
                }
            }
            return counter;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> sortedShoes = new List<Shoe>();
            
            foreach (var shoe in Shoes)
            {
                if(shoe.Type == type.ToLower())
                {
                    sortedShoes.Add(shoe);
                }
            }
            return sortedShoes;
        }

        public Shoe GetShoeBySize(double size)
        {
            Shoe firstSHoe = Shoes.FirstOrDefault(x=> x.Size == size);
            return firstSHoe;
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            foreach (var shoe in Shoes)
            {
                
                if (shoe.Size == size && shoe.Type == type)
                {
                    sb.AppendLine($"Size {shoe.Size}, {shoe.Material} {shoe.Brand} {shoe.Type} shoe.");
                    counter++;
                }
            }
            if(counter == 0)
            {
                sb.Clear();
                sb.AppendLine("No matches found!");
            }
            return sb.ToString().Trim();
        }
    }
}
