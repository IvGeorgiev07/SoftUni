using System;
using System.Linq;


namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int sum = 0;

            for(int i = 0; i < input1.Length; i++)
            {
                if(input1[i] != input2[i])
                {
                    index = i;
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    return;
                }
                sum += input1[i];
            }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
                 
            
        }
    }
}