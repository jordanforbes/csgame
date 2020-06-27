using System;

namespace csgame.Models 
{
    public abstract class Enemy {
        public string Name;
        public string Type;
        public int Strength;
        public int Dexterity;
        public int Speed;
        public int Health;
        public Enemy()
        {

        }
        public virtual void showHp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"%%%%%%%%%%% Enemy HP: {Health} %%%%%%%%%%%");
            Console.ResetColor();

        }
    }
}