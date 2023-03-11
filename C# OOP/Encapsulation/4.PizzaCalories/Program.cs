namespace _4.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Topping> toppings = new List<Topping>();
            string[] pizzaName = Console.ReadLine().Split(" ");
            
            double doughCalories = 0;
            Pizza newPizza = null;

            try
            {
                Pizza currentPizza = new(pizzaName[1]);
                newPizza = currentPizza;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string flour = input[1];
            flour = FirstLetterToUpper(flour);
            string baking = input[2];
            baking = FirstLetterToUpper(baking);
            int grams = int.Parse(input[3]);

            try
            {
                Dough dough = new(flour, baking, grams);
                doughCalories = dough.DoughCalories();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            while (input2[0] != "END")
            {
                string topping = input2[1];
                topping = FirstLetterToUpper(topping);
                int toppingGrams = int.Parse(input2[2]);

                try
                {
                    Topping newTopping = new(topping, toppingGrams);
                    newPizza.Add(newTopping);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }

                input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            double totalCalories = newPizza.ToppingCalories() + doughCalories;
            Console.WriteLine($"{newPizza.Name} - {totalCalories:f2} Calories.");

            string FirstLetterToUpper(string str)
            {
                if (str == null)
                    return null;

                char[] arr = str.ToLower().ToCharArray();
                arr[0] = char.ToUpper(arr[0]);
                str = String.Join("", arr);
                return str.ToString().TrimEnd();
            }

        }
    }
}

