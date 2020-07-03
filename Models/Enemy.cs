using System;

namespace csgame.Models 
{
    public abstract class Enemy {
        public string Name;
        public string Type;
        public int Strength;
        public int Dexterity;
        public int Speed;
        public int Health;
        public Enemy()
        {

        }
        public virtual void showHp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"%%%%%%%%%%% Enemy HP: {Health} %%%%%%%%%%%");
            Console.ResetColor();

        }

        public virtual void Attack(Player target)
        {
            int dmg = Strength;
            target.Health -=dmg;
            Color.Red($"{Name} attacks {target.Name} for {dmg} Damage!");
        }

    }
}