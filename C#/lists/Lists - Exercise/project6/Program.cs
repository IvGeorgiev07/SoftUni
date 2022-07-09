using System;
using System.Collections.Generic;
using System.Linq;


namespace project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> hand1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hand2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int cards = Math.Min(hand1.Count, hand2.Count);
            int i = 0;

            while(cards > 1)
            {
                
                cards = Math.Min(hand1.Count, hand2.Count);
                compareCards(cards, ref hand1, ref hand2, i);
               // Console.WriteLine(String.Join(" ", hand1));
                //Console.WriteLine(String.Join(" ", hand2));
            }
            if(hand1.Count > hand2.Count)
            {
                Console.WriteLine($"First player wins! Sum: {hand1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {hand2.Sum()}");
            }
        }

        private static List<int> compareCards(int cards, ref List<int> hand1, ref List<int> hand2, int i)
        {
            if (hand1[i] > hand2[i])
            {
                hand1.Add(hand1[i]);
                hand1.Add(hand2[i]);
                hand1.RemoveAt(i);
                hand2.RemoveAt(i);
            }
            else if (hand1[i] < hand2[i])
            {
                hand2.Add(hand2[i]);
                hand2.Add(hand1[i]);
                hand2.RemoveAt(i);
                hand1.RemoveAt(i);
            }
            else if (hand1[i] == hand2[i])
            {
                hand2.RemoveAt(i);
                hand1.RemoveAt(i);
            }

            return hand1;
            return hand2;
        }
    }
}