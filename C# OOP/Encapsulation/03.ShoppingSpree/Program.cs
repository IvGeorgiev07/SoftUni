namespace _03.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> person = new Dictionary<string, Person>();
            Dictionary<string, Product> product = new Dictionary<string, Product>();

            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in input)
            {
                try
                {
                    string[] items = item.Split("=");
                    Person newPerson = new(items[0], decimal.Parse(items[1]));
                    person.Add(items[0], newPerson);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }

            }

            string[] input2 = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in input2)
            {
                try
                {
                    string[] items = item.Split("=");
                    Product newProduct = new(items[0], decimal.Parse(items[1]));
                    product.Add(items[0], newProduct);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }

            }


            string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input3[0] != "END")
            {
                string name = input3[0];
                string currentProduct = input3[1];
                if (person[name].Money - product[currentProduct].Cost >= 0)
                {
                    person[name].Money -= product[currentProduct].Cost;
                    person[name].AddProduct(product[currentProduct]);
                    Console.WriteLine($"{name} bought {currentProduct}");
                }
                else
                {
                    Console.WriteLine($"{person[name].Name} can't afford {product[currentProduct].Name}");
                }
                input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (person != null)
            {
                foreach (var item in person)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.ReadBag()}");
                }

            }
        }
    }
}