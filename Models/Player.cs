using System;
namespace csgame.Models
{
    public abstract class Player
    {
        public string Name {get;set;}

        public int Strength {get;set;}
        public int Speed {get;set;}

        public int Health {get;set;}

        public string Type {get;set;}

        public Player(string name) => Name = name;

        public virtual void ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%% PLAYER STATS %%%%%%%%%%%%%%");
            Console.WriteLine($"HP: {Health}\nStrength: {Strength}\nSpeed: {Speed}");
        }
        static void ConsoleRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public virtual void Attack(Enemy target)
        {
            int dmg = Strength;
            target.Health -= dmg;
            // Console.ForegroundColor = ConsoleColor.Red;
            ConsoleRed($"{Type} {Name} attacked {target.Type} {target.Name} for {dmg} damage!");
            target.showHp();
            if (target.Health <= 0)
            {

            }

        }
    }
}