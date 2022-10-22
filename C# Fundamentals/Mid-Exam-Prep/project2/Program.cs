namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                int temp = 4;
                if (wagons[i] < 4)
                {
                    temp -= wagons[i];
                    if (people >= 4)
                    {
                        wagons[i] += temp;
                        people -= temp;
                    }
                    else
                    {
                        wagons[i] += people;
                        people -= temp;
                    }

                }
            }


            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(String.Join(" ", wagons));
            }


        }
    }
}