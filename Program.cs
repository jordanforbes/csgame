using System.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using csgame.Models;

namespace csgame
{
    public class Program
    {

        

        // static Player PlayerSetup()
        // {
        //     Color.Green("Hey what's yer name anyway?");
        //     Color.Yellow("Type yer name below!");

        //     string name = Console.ReadLine();
        //     string choice = "";

        //     Color.Green($"{name}? Weird name but what do I know? My son's named Umami!");
        //     Color.Blue("A jolly burst of laughter echoes through the room. It wasn't that funny.");
        //     Color.Green("What kinda Timenaut are ye? There's only one answer right now.");
        //     while(choice !="1" && choice != "2"){
        //         Color.Yellow("1. Time-Knight \n2.You better not");
        //         choice = Console.ReadLine();
        //     }

        //     switch (choice) 
        //     {
        //         case ("1"):
        //             Color.Green("Ah, yer a TIME KNIGHT!");
        //             Knight knight = new Knight (name);
        //             return knight;
        //         case ("2"):
        //             Color.Green("Yer a jerk.");
        //             Knight knight2 = new Knight(name);
        //             return knight2;
        //     }
        //             // Knight knight = new Knight (name);
        //             // return knight;
        //     return null;
        // }

        // static void StartGame (Player player) {

        // }
    
        static void StartGame(){
            Color.Blue("You're a newly minted Time Thief, having just passed your initiation into the Time Mafia. \nIt's your job to go throughout history to get important artifacts for the Time Godfather.");
            // Color.Yellow("select 1");
            Pause.Enter();
            Color.Green("Ah there ye argh! Yer Late!");
            Question.FirstQ();
            // Pause.Enter();
            Player player = PlayerSetup.Setup();
            Color.Green("The first mission we got is fer ye is ta go get King Arthur's Sword, Excalibur from jolly ol' medieval England!");
            Pause.Enter();
            Color.Blue("You hop in your new time machine, that the time mafia provided with time mafia money\n and just like that you're off to old England.");
            Pause.Enter();
            Color.Green("BZZZZZZZZZZZZZZZZZZZZZZ");
            Color.Yellow("BZZZZZZZZZZZZZZZZZZZZZZ");
            Color.Red("BZZZZZZZZZZZZZZZZZZZZZZ");
            Color.Blue("And just like that you're in medieval times");
            Pause.Enter();
            Color.Blue("Looking around you realize that you've materialized in the middle of stonehenge. It turns out that this is what it was for all along.\nIn the distance you notice a gathering of knights around what appears to be a giraffe.");
            Pause.Enter("Press Enter to Approach");
            Color.Blue("You run down the hill to reach the gathering of knights.\nThey are surrouned in a circle. A round circle. Like a table.\nYou were right before, they were standing around a Giraffe. A voice cries out\nOi! Wot are YEE dewen 'ere!");
            Color.Green("Whoops lad ye fergot to turn on yer translator!");
            Pause.Enter("Press Enter to turn on your translator");
            Color.Blue("'Excuse me what are you doing here?' A short but handsome man riding a white horse bearing a nametag that says 'King Arthur' on it.");
            Pause.Enter("Press Enter to say 'Don't worry about it, man, just pretend I'm not here.'");
            Color.Blue("I'm sorry I don't understand your accent");
            Color.Green("NOW LAD! WHILE HE'S CONFUSED!");
            Pause.Enter("Press Enter to attack while he's confused");
            Battle.First(player);
            Sword excal = new Sword();
            player.Inventory.Add(excal);
            Console.WriteLine();
            //start battle against arthur
        }
        static void TestGame()
        {
            Player p1 = PlayerSetup.Test();
            Battle.First(p1);
        }
        public static void Main(string[] args)
        {
            // CreateWebHostBuilder(args).Build().Run();
            Color.Green("%%%%%%%%%%%% Time Thieves 2: There is no Time Theves 1 %%%%%%%%%%%%%%%");
            Pause.Enter();
            // TestGame();
            StartGame();
            // Player player = PlayerSetup ();
            // PlayerSetup();
        }

        // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>();

        
    }
}
