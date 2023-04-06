namespace BorderControl
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string,int> IdList = new();
            string firstInput = Console.ReadLine().TrimEnd();
            string[] input = firstInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);            
            
            while (input[0]!="End")
            {
                IdList.Add(input[0], 0);
                firstInput = Console.ReadLine().TrimEnd();
                input = firstInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string input2 = Console.ReadLine();

            for (int i = 0; i < IdList.Count; i++)
            {
                char[] arr = IdList[i].ToCharArray();
                string index = string.Empty;

                for (int j = 1; j <= input2.Length; j++)
                {
                    index += arr[arr.Length - j];
                }
                
                char[] indexCh = index.Reverse().ToArray();
                index = String.Join("", indexCh);

                if(index == input2)
                {
                    Console.WriteLine(IdList[i]);
                }

            }
        }
    }
}