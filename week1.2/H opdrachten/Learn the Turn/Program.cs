using System;

class Program
{
    public static void Main()
    {
        int your_damage = 30;
        int enemy_health = 90;
        int turnsTaken = 0;
        //Correct the code below

        while (enemy_health > 0)
        {
            enemy_health -= your_damage;
            turnsTaken++;
        }
        //Correct the code above

        Console.WriteLine($"The enemy's HP was reduced to {enemy_health}");
        Console.WriteLine($"It took you {turnsTaken} to defeat the enemy");
    }
}