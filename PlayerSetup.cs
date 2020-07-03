
using System.Drawing;
using System;
using csgame.Models;

namespace csgame
{

    public class PlayerSetup
    {
        public static Player Setup()
        {
            Color.Green("Hey what's yer name anyway?");
            Color.Yellow("Type yer name below!");

            string name = Console.ReadLine();
            string choice = "";

            Color.Green($"{name}? Weird name but what do I know? My son's named Umami!");
            Color.Blue("A jolly burst of laughter echoes through the room. It wasn't that funny.");
            Color.Green("What kinda Timenaut are ye? There's only one answer right now.");
            while (choice != "1" && choice != "2")
            {
                Color.Yellow("1. Time-Knight \n2.You better not");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case ("1"):
                    Color.Green("Ah, yer a TIME KNIGHT!");
                    Knight knight = new Knight(name);
                    return knight;
                case ("2"):
                    Color.Green("Yer a jerk.");
                    Knight knight2 = new Knight(name);
                    return knight2;
            }
            // Knight knight = new Knight (name);
            // return knight;
            return null;
        }

        public static Player Test()
        {
            Color.Yellow("Type your name");
            string name = Console.ReadLine();

            Knight k1 = new Knight(name);
            Sword s1 = new Sword();
            k1.Inventory.Add(s1);
            return k1;
        }

    }
    
}
