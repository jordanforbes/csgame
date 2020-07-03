namespace csgame.Models
{
    public class Sword : Weapon
    {
        public Sword()
        {
            Name = "Excalibur";
            Power = 10;
            
        }

        public override void Use(Player player, Enemy target)
        {
            // Random rand = new Random(0,1);
            int dmg = player.Strength + this.Power;
            target.Health -= dmg;
            Color.Red($"You brandish Excalibur! You do a sword hit! The enemy takes {dmg} damage!");
        }
    }
}