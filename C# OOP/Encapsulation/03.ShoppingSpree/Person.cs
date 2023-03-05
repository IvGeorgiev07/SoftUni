using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    internal class Person
    {
        private string name;
        private decimal money;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        private List<Product> BagOfProducts { get; set; }

        public void AddProduct(Product product)
        {
            BagOfProducts.Add(product);
        }

        public string ReadBag()
        {
            StringBuilder sb = new StringBuilder();
            List<string> products = new List<string>();
            if(BagOfProducts.Count > 0)
            {
                foreach(Product product in BagOfProducts)
                {
                    products.Add(product.Name);
                }
                sb.Append(String.Join(", ",products));
            }
            else
            {
                sb.Append("Nothing bought");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
