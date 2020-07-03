using System;
using csgame.Models;

namespace csgame
{ 
    public class Battle
    {
        public static void First(Player player)
        {
            // player.CurrentWeapon =0;
            // player.CurrentWeapon = 1;/
            Arthur art = new Arthur();
            Color.Red("########## TIME FOR BATTLE! ###########");
            while(art.Health > 0 && player.Health > 0)
            {
                Weapon selectedWeapon = player.Inventory[Int32.Parse(player.CurrentWeapon)-1];
                void ChooseWeapon()
                {
                    selectedWeapon = player.Inventory[Int32.Parse(player.CurrentWeapon)-1];
                    Color.Blue($"Equipped Weapon: {selectedWeapon.Name}");
                }
                // ChooseWeapon();
                foreach( Weapon item in player.Inventory)
                {
                    Color.Blue($"Current Inventory: {item.Name}");

                }
                Color.Red($"Enemy: {art.Name}, HP: {art.Health}");
                Color.Green($"{player.Name} HP: {player.Health}");
                Color.Yellow("What will you do?");

                string choice = "";

                //BATTLE 
                bool endTurn = true; //decides if an action lets the enemy hit the player
                void Fight()
                {
                    endTurn = true;
                    while (choice =="")
                    {
                        Color.Yellow("1.Attack\n2.Boost Strength\n3.Use Weapon\n4.Switch Weapon");
                        choice = Console.ReadLine();
                    }

                    //BATTLE CONTROLS
                    string c1 = "";
                    switch (choice)
                    {
                        case ("1"):
                            player.Attack(art);
                            Color.Green("YA GOT HIM!");
                            Color.Blue($"WHAM! You punch King Arthur right in his smug face for {player.Strength} damage!");
                            break;
                        case ("2"):
                            Color.Blue($"{player.Name} boosted their strength from {player.Strength}to {player.Strength+5}");
                            player.SpecialMove(art);
                            break;
                        case ("3"):
                            // Color.Blue("you dont know what that is");
                            player.Inventory[Int32.Parse(player.CurrentWeapon)-1].Use(player,art);
                            break;
                        case ("4"):
                            int i = 1;
                            // string c2 = "";
                            //
                            endTurn = false;
                                Color.Yellow($"Current Weapon = {selectedWeapon.Name}");
                                    Color.Red("hitting 4");
                                foreach( Weapon item in player.Inventory)
                                {
                                    Color.Yellow($"{i}. {item.Name}");
                                    i++;
                                }
                            
                            c1 = Console.ReadLine();
                            player.CurrentWeapon = c1;
                            ChooseWeapon();
                            break;
                    }
                   
                }
                Fight();
                if(endTurn == true)
                {
                    art.Attack(player);
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