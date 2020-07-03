using System.Collections.Generic;

namespace csgame.Models
{
    public class Knight : Player
    {
        public Knight(string name) : base(name)
        {
            Stick stick = new Stick();
            Type = "Knight";
            Strength = 20;
            Health = 80;
            Speed = 1;
            Inventory = new List<Weapon>()
            {
                stick
            };

        }

        public override void Attack(Enemy target)
        {
            int dmg = Strength;
            target.Health -= dmg;
            Color.Red("You Attack!");
        }

        public override void SpecialMove(Enemy target)
        {
            this.Strength +=5;
            Color.Green("Your Strength increases!");
        }
    }
}