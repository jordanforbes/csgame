namespace csgame.Models
{
    public class Stick : Weapon
    {
        public Stick(string name, int power) : base(name, power)
        {
        }
        public Stick()
        {
            Name = "Time Stick";
            Power = 5;
        }
        

        public override void Use(Player player, Enemy target)
        {
            int dmg = this.Power;
            target.Health -= dmg;
            Color.Red($"You spin the stick around, making you feel stronger.\nYour intimidation hurts {target.Name}'s pride for {dmg} damage");
        }
    }
}