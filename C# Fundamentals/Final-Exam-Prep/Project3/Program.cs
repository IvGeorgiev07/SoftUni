using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Project3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroList = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);

                Hero hero = new Hero(hp, mp);
                heroList.Add(name, hero);
            }

            string input2;

            while ((input2 = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input2.Split(" - ");


                if (cmdArgs[0] == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string heroName = cmdArgs[1];
                    int currentMana = heroList[heroName].Mp;
                    if (currentMana - mpNeeded >= 0)
                    {
                        int newMana = currentMana - mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {cmdArgs[3]} and now has {newMana} MP!");
                        heroList[heroName].Mp = newMana;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {cmdArgs[3]}!");
                    }
                }
                else if (cmdArgs[0] == "TakeDamage")
                {
                    string heroName = cmdArgs[1];
                    int dmg = int.Parse(cmdArgs[2]);
                    int currentHp = heroList[heroName].Hp;

                    if (currentHp - dmg > 0)
                    {
                        int newHp = currentHp - dmg;
                        Console.WriteLine($"{heroName} was hit for {dmg} HP by {cmdArgs[3]} and now has {newHp} HP left!");
                        heroList[heroName].Hp = newHp;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {cmdArgs[3]}!");
                        heroList.Remove(heroName);
                    }
                }
                else if (cmdArgs[0] == "Recharge")
                {
                    string heroName = cmdArgs[1];
                    int recharge = int.Parse(cmdArgs[2]);
                    int currentMana = heroList[heroName].Mp;

                    int rechargedAmount = 0;
                    if (currentMana + recharge > 200)
                    {
                        rechargedAmount = 200 - currentMana;
                    }
                    else
                    {
                        rechargedAmount = recharge;
                    }
                    heroList[heroName].Mp += rechargedAmount;

                    Console.WriteLine($"{heroName} recharged for {rechargedAmount} MP!");

                }
                else if (cmdArgs[0] == "Heal")
                {
                    string heroName = cmdArgs[1];
                    int heal = int.Parse(cmdArgs[2]);
                    int currentHp = heroList[heroName].Hp;

                    int HealedAmount = 0;
                    if(currentHp+heal > 100)
                    {
                        HealedAmount = 100 - currentHp;
                    }
                    else
                    {
                        HealedAmount = heal;
                    }

                    heroList[heroName].Hp += HealedAmount;

                    Console.WriteLine($"{heroName} healed for {HealedAmount} HP!");

                }
            }

            foreach(var (name, hero) in heroList)
            {
                Console.WriteLine(name);
                Console.WriteLine($"  HP: {hero.Hp}");
                Console.WriteLine($"  MP: {hero.Mp}");
            }

        }
    }









    public class Hero
    {
        public Hero(int hp, int mp)
        {
            Hp = hp;
            Mp = mp;
        }

        public int Hp { get; set; }

        public int Mp { get; set; }
    }

}
