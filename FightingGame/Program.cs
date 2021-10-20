using System;
using System.Collections.Generic;

Random rnd = new Random();

int Health = 100;
int EnemyHealth = 100;

Console.WriteLine("Welcome to this Fighting Game\nPlease choose a name for your fighter");

string name = Console.ReadLine();

var list = new List<string>{"Vlad","Jeff","Bob"};
int index = rnd.Next(list.Count);
string enemy = list[index];

Console.WriteLine($"\nFight:\n{name} vs {enemy}!\n");

while (Health > 0 && EnemyHealth > 0)
{
    int damage = rnd.Next(21);
    EnemyHealth -= damage;
    if (EnemyHealth <= 0)
    {
        EnemyHealth = 0;
        damage = 0;
        Console.WriteLine($"{enemy} is now dead!");
    }
    else
    {
        Console.WriteLine($"Enemy's health is now {EnemyHealth}");
        damage = rnd.Next(16);
        Health -= damage;
        if (Health <= 0)
    {
        Health = 0;
        Console.WriteLine("You died :(");
    }
    else
    {
        Console.WriteLine($"Your health is now {Health}");
    }
    }
}

if (Health > 0 && EnemyHealth == 0)
{
    Console.WriteLine($"\n{name} won with {Health} health left! :)");
}
else if (Health == 0 && EnemyHealth > 0)
{
    Console.WriteLine($"\n{enemy} won with {EnemyHealth} health left! :(");
}

Console.ReadLine();