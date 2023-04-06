namespace Telephony
{
    public class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(Calling(input[i]));
            }

            for (int i = 0; i < input2.Length; i++)
            {
                Console.WriteLine(Browsing(input2[i])); 
            }



            string Calling(string number)
            {
                char[] arr = number.ToCharArray();
                string output = string.Empty;
                foreach (char ch in arr)
                {
                    if (char.IsLetter(ch))
                    {
                        return "Invalid number!";
                    }
                }

                if (arr.Length == 7)
                {
                    output = $"Dialing... {number}";
                }
                else if (arr.Length == 10)
                {
                    output = $"Calling... {number}";
                }
                return output;
            }

            string Browsing(string webSite)
            {
                char[] arr = webSite.ToCharArray();
                foreach (char ch in arr)
                {
                    if (char.IsDigit(ch))
                    {
                        return "Invalid URL!";
                    }
                }
                return $"Browsing: {webSite}!";
            }

        }
    }
}