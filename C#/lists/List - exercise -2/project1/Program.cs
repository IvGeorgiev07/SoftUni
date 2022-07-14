using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string[] input = Console.ReadLine().Split().ToArray();            
            char[] inputStr = Console.ReadLine().ToCharArray();
            
            List<int> sums = new List<int>();
            List<char> output = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                int sum = 0;
                char[] splitedNum = input[i].ToCharArray();
                foreach (char c in splitedNum)
                {
                    int digit = (int)Char.GetNumericValue(c);
                    sum += digit;
                }
                sums.Add(sum);
            }
            List<char> temp = new List<char>(inputStr);

            for (int i = 0; i < sums.Count; i++)
            {
                if(sums[i] < temp.Count)
                {
                    output.Add(temp[sums[i]]);
                    temp.RemoveAt(sums[i]);
                }
                else
                {
                    int index = sums[i]-temp.Count;
                    output.Add(temp[index]);
                    temp.RemoveAt(index);
                }                    
            }
            Console.WriteLine(String.Join("", output));

        }
    }
}