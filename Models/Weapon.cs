namespace csgame.Models
{
    public class Weapon : IWeapon
    {
        public string Name {get;set;}
        public int Power {get;set;}

        public Weapon(string name, int power)
        {
            Name = name;
            Power = power;
        }
        public Weapon()
        {

        }
        public virtual void Use(Enemy target)
        {
            Color.Red("You punch the bad guy with your empty fist");
        }

        public virtual void Use(Player player, Enemy target)
        {
            
        }
    }
}