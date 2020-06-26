namespace csgame.Models
{
    public abstract class Player
    {
        public string Name {get;set;}

        public int Strength {get;set;}

        public int Health {get;set;}

        public string Type {get;set;}

        public Player(string name)
        {
            Name = name;
        }
    }
}