using System.Globalization;

namespace RPG_challenge;

class Program
{
    static void Main(string[] args)
    {
        int monsterHP = 10;
        int heroHP = 10;

        Random random = new Random();

        do
        {
            int roll = random.Next(1, 11);
            monsterHP -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHP} health.");

            if (monsterHP <= 0) continue;

            roll = random.Next(1, 11);
            heroHP -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHP} health.");

        } while (heroHP > 0 && monsterHP > 0);

        Console.WriteLine(heroHP > monsterHP ? "Hero wins!": "Monster wins!");
    }
}