using System;
using csgame.Models;

namespace csgame
{ 
    public class Battle
    {
        public static void First(Player player)
        {
            Arthur art = new Arthur();
            Color.Red("########## TIME FOR BATTLE! ###########");
            while(art.Health > 0 && player.Health > 0)
            {
                Color.Red($"Enemy: {art.Name}, HP: {art.Health}");
                Color.Green($"{player.Name} HP: {player.Health}");
                Color.Yellow("What will you do?");

                string choice = "";
                while (choice !="1")
                {
                    Color.Yellow("1.Attack");
                    choice = Console.ReadLine();
                }

                switch (choice)
                {
                    case ("1"):
                        art.Health -= player.Strength;
                        Color.Green("YA GOT HIM!");
                        Color.Blue($"WHAM! You punch King Arthur right in his smug face for {player.Strength} damage!");
                        break;
                }
            }
            Color.Blue("%%%%%%%%%% V I C T O R Y %%%%%%%%%%%%%%");
            Color.Red("'Ow, fine I give up!' Said King Arthur, still reeling from getting his world rocked by your fists.\n'Here, TAKE Excalibur, I didn't want to be king anyway'");
            Pause.Enter();
            Color.Blue("King Arthur hands you Excalibur");
            Color.Green("YA DID IT MATEY!");

        }
    }
}