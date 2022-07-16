using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] range = new int[2];
            List<int> mixedList = new List<int>();
            List<int> output = new List<int>();

            findTheRange(input, input2, range);
            mixingLists(input, input2, mixedList);

            if (range[0] > range[1])
            {
                for (int i = 0; i < mixedList.Count; i++)
                {
                    if (mixedList[i] > range[1] && mixedList[i] < range[0])
                    {
                        output.Add(mixedList[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < mixedList.Count; i++)
                {
                    if (mixedList[i] > range[0] && mixedList[i] < range[1])
                    {
                        output.Add(mixedList[i]);
                    }
                }
            }
            output.Sort();
            Console.WriteLine(String.Join(" ", output));


        }

        private static void mixingLists(List<int> input, List<int> input2, List<int> mixedList)
        {
            for (int i = 0; i < input.Count; i++)
            {
                mixedList.Add(input[i]);
                mixedList.Add(input2[input.Count - i - 1]);
            }
        }

        private static void findTheRange(List<int> input, List<int> input2, int[] range)
        {
            if (input.Count > input2.Count)
            {
                range[0] = input[input.Count - 1];
                range[1] = input[input.Count - 2];
                input.RemoveRange(input.Count - 2, 2);
            }
            else
            {
                range[0] = input2[0];
                range[1] = input2[1];
                input2.RemoveAt(0);
                input2.RemoveAt(1);
            }
        }
    }
}