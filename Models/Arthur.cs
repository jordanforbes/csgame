namespace csgame.Models 
{
    public class Arthur : Enemy 
    {
        public Arthur() : base()
        {
            Name = "King Arthur";
            Type = "King";
            Strength = 20;
            Health = 50;
        }

        public override void Attack(Player target)
        {
            int dmg = Strength;
            target.Health -=dmg;
            Color.Red("Arthur takes a big ol swing at you with his sword but it's thankfully only a flesh wound");
        }
    }
}