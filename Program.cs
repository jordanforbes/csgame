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

        

        static Player PlayerSetup()
        {
            Color.Green("Hey what's yer name anyway?");
            Color.Yellow("Type yer name below!");

            string name = Console.ReadLine();
            string choice = "";

            Color.Green($"{name}? Weird name but what do I know? My son's named Umami!");
            Color.Blue("A jolly burst of laughter echoes through the room. It wasn't that funny.");
            Color.Green("What kinda Timenaut are ye? There's only one answer right now.");
            while(choice !="1" && choice != "2"){
                Color.Yellow("1. Time-Knight \n2.You better not");
                choice = Console.ReadLine();
            }

            switch (choice) 
            {
                case ("1"):
                    Color.Green("Ah, yer a TIME KNIGHT!");
                    Knight knight = new Knight (name);
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

        // static void StartGame (Player player) {

        // }
    
        static void StartGame(){
            Color.Blue("You're a newly minted Time Thief, having just passed your initiation into the Time Mafia. \nIt's your job to go throughout history to get important artifacts for the Time Godfather.");
            // Color.Yellow("select 1");
            Pause.Enter();
            Color.Green("Ah there ye argh! Yer Late!");
            Question.FirstQ();
            // Pause.Enter();
            Player player = PlayerSetup();
            Color.Green("The first mission we got is fer ye is ta go get King Arthur's Sword, Excalibur from jolly ol' medieval England!");
            Pause.Enter();
            Color.Blue("You hop in your new time machine, that the time mafia provided with time mafia money\n and just like that you're off to old England.");
            Battle.First(player);
            //start battle against arthur
        }
        public static void Main(string[] args)
        {
            // CreateWebHostBuilder(args).Build().Run();
            Color.Green("%%%%%%%%%%%% Time Thieves 2: There is no Time Theves 1 %%%%%%%%%%%%%%%");
            Pause.Enter();
            StartGame();
            // Player player = PlayerSetup ();
            // PlayerSetup();
        }

        // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>();

        
    }
}
