using System;
using System.Collections.Generic;
using System.Linq;

namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> charList = new List<char>(input);
            List<char> tempChars = new List<char>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            string output = string.Empty;

            findNums(charList, numbers, tempChars);
            
            separateEvenAndOddIndexes(numbers, takeList, skipList);

            removingNumsFromCharlist(charList, tempChars);

            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> tempStr = charList.Select(c => c.ToString()).ToList();
                List<string> temp = tempStr.Skip(indexForSkip).Take(takeList[i]).ToList();
                output += string.Concat(temp);
                indexForSkip += takeList[i] + skipList[i];
                
            }

            Console.WriteLine(output);
        }

        private static void removingNumsFromCharlist(List<char> charList, List<char> tempChars)
        {
            foreach(char c in tempChars)
            {
                if (charList.Contains(c))
                {
                    charList.Remove(c);
                }
            }
        }

        private static void separateEvenAndOddIndexes(List<int> numbers, List<int> takeList, List<int> skipList)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if(i%2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
        }

        private static void findNums(List<char> charList, List<int> numbers, List<char> tempChars)
        {
            for (int i = 0; i < charList.Count; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    double temp = Char.GetNumericValue(charList[i]);

                    if (temp == j)
                    {
                        numbers.Add(j);
                        tempChars.Add(charList[i]);
                    }
                }
            }
        }
    }
}