namespace FoodShortage
{
    public class StartUps
    {
        static void Main()
        {
            Dictionary<string, int> rebels = new();
            Dictionary<string, int> citizens = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if(input.Length == 3 )
                {
                    rebels.Add(input[0],0);
                }
                else if (input.Length == 4)
                {
                    citizens.Add(input[0], 0);
                }
            }

            string input2 = Console.ReadLine();

            while(input2 != "End")
            {
                if(rebels.ContainsKey(input2))
                {
                    rebels[input2]+=5;
                }
                else if (citizens.ContainsKey(input2))
                {
                    citizens[input2] += 10;
                }
                input2 = Console.ReadLine();
            }

            int totalFood = 0;

            foreach (var item in rebels)
            {
                totalFood += item.Value;
            }

            foreach (var item in citizens)
            {
                totalFood += item.Value;
            }
            Console.WriteLine(totalFood);
        }
    }
}