namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "End")
            {
                int index = int.Parse(command[1]);
                int power = int.Parse(command[2]);

                if(command[0] == "Shoot")
                {
                    input[index] -= power;
                    if(input[index] < 0)
                    {
                        input.RemoveAt(index);
                    }
                }
                else if (command[0] == "Add")
                {
                    if(index < input.Count)
                    {
                        input.Add(power);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(command[0] == "Strike")
                {
                    if (index + power < input.Count && index - power >= 0)
                    {
                        input.RemoveRange(index - power, index + power);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join("|",input));
        }
    }
}