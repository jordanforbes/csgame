namespace csgame.Models
{
    public class Knight : Player
    {
        public Knight(string name) : base(name)
        {
            Type = "Knight";
            Strength = 20;
            Health = 80;
            Speed = 1;

        }

        public override void Attack(Enemy target)
        {
            int dmg = Strength;
            target.Health -= dmg;
        }
    }
}