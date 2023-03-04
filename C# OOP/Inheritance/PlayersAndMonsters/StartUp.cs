using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Elf hero = new Elf(name, age);
            Console.WriteLine(hero);

        }
    }
}