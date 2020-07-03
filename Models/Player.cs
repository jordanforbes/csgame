using System;
using System.Collections.Generic;

namespace csgame.Models
{
    public abstract class Player
    {
        public string Name {get;set;}

        public int Strength {get;set;}
        public int Speed {get;set;}

        public int Health {get;set;}

        public string Type {get;set;}

        public List<Weapon> Inventory {get;set;}

        public string CurrentWeapon {get;set;}

        public Player(string name)
        {
            Name = name;
            CurrentWeapon = "1";
        }

        // public static void Initialize()
        // {
        //     Stick stick = new Stick("Time Stick", 5);
        //     Inventory<Weapon> Bag = new Inventory<Weapon>();

        //     Bag.Add(stick, 5);
        // }

        public virtual void ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%% PLAYER STATS %%%%%%%%%%%%%%");
            Console.WriteLine($"HP: {Health}\nStrength: {Strength}\nSpeed: {Speed}");
        }
    
        public virtual void Attack(Enemy target)
        {
            int dmg = Strength;
            target.Health -= dmg;
            // Console.ForegroundColor = ConsoleColor.Red;
            Color.Red($"{Type} {Name} attacked {target.Type} {target.Name} for {dmg} damage!");
            target.showHp();
            // if (target.Health <= 0)
            // {

            // }

        }

        public virtual void SpecialMove(Enemy target)
        {
            Color.Red("Placeholder");
        }
    }
}