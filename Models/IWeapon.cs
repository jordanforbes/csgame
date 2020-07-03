namespace csgame.Models
{
    public interface IWeapon
    {
        string Name {get;set;}

        void Use(Enemy target);
    }
}