using System;
using System.Collections.Generic;

Random rnd = new Random();

int Health = 100;
int EnemyHealth = 100;
int damage;
int chance;
int enemyAttack;

Console.WriteLine("Welcome to this Fighting Game\nPlease choose a name for your fighter");

string name = Console.ReadLine();

var list = new List<string>{"Vlad","Jeff","Bob"};
int index = rnd.Next(list.Count);
string enemy = list[index];
string action;

Console.WriteLine($"\nFight:\n{name} vs {enemy}!\n");

while (Health > 0 && EnemyHealth > 0)
{
    Console.WriteLine("Choose an attack!");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("(1) Bow attack\n(2) Knife attack");
    Console.ResetColor();
    action = Console.ReadLine();
    if(action == "1") {
        chance = rnd.Next(2);
        if(chance == 0) {
            damage = rnd.Next(15,26);
        }
        else {
            damage = 0;
        }
    }
    else {
        chance = rnd.Next(5);
        if(chance == 0) {
            damage = 0;
        }
        else {
            damage = rnd.Next(5,11);
        }
    }
    EnemyHealth -= damage;
    if (EnemyHealth <= 0)
    {
        EnemyHealth = 0;
        damage = 0;
        Console.WriteLine($"{enemy} is now dead!");
    }
    else
    {
        Console.WriteLine($"{enemy}'s health is now {EnemyHealth}");
        enemyAttack = rnd.Next(2);
        if(enemyAttack == 0) {
            Console.WriteLine($"{enemy} used 'Knife Attack'");
            chance = rnd.Next(5);
            if(chance == 0) {
                damage = 0;
            }
            else {
                damage = rnd.Next(5,11);
            }  
        }
        else {
            Console.WriteLine($"{enemy} used 'Bow Attack'");
            chance = rnd.Next(2);
            if (chance == 0) {
                damage = rnd.Next(15,26);
            }
            else {
                damage = 0;
            }
        }
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