using System;

Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
// int attack = random.Next(1, 10);
// int turn = 0;


// HERO'S TURN
do
{
    int heroAttack = random.Next(1, 10);
    if (monsterHealth > 0)
    {
        monsterHealth = monsterHealth - heroAttack;
        Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
    }
    else
    {
        Console.WriteLine("Hero wins!");
    }
    int monsterAttack = random.Next(1, 10);
    if (heroHealth > 0)
    {
        heroHealth = heroHealth - monsterAttack;
        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
    }
    else
    {
        Console.WriteLine("Monster wins!");
    }
} while (monsterHealth > 0 || heroHealth > 0);
