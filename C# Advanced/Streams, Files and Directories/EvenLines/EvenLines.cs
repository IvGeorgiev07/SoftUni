namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                StringBuilder sb = new StringBuilder();
                int count = 0;

                string line = String.Empty;

                while (line != null)
                {
                    line = streamReader.ReadLine();

                    if (count % 2 == 0)
                    {
                        string replaceSymbol = ReplaceSymbol(line);
                        string reverseWords = ReverseWords(replaceSymbol);
                        sb.AppendLine(reverseWords);
                    }
                    count++;
                }
                return sb.ToString();

            }
        }

        private static string ReplaceSymbol(string line)
        {
            StringBuilder stringBuilder= new StringBuilder(line);
            string[] symbolToReplace = { "-", ",", ".", "!", "?"};
            foreach (var item in symbolToReplace)
            {
                stringBuilder.Replace(item, "@");
            }
            return stringBuilder.ToString();
        }

        private static string ReverseWords(string replacedSymbol)
        {
            string[] reversedWords = replacedSymbol.Split().Reverse().ToArray();
            return String.Join(" ", reversedWords);
        }
    }
}
