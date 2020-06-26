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

        static void ConsoleGreen (string text){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void ConsoleYellow (string text){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void ConsoleBlue (string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Player PlayerSetup()
        {
            ConsoleGreen("Hey what's yer name anyway?");
            ConsoleYellow("Type yer name below!");

            string name = Console.ReadLine();
            string choice = "";

            ConsoleGreen($"{name}? Weird name but what do I know? My son's named Umami!");
            ConsoleBlue("A jolly burst of laughter echoes through the room. It wasn't that funny.");
            ConsoleGreen("What kinda Timenaut are ye? There's only one answer right now.");
            while(choice !="1" && choice != "2"){
                ConsoleYellow("1. Time-Knight \n2.You better not");
                choice = Console.ReadLine();
            }

            switch (choice) 
            {
                case ("1"):
                    ConsoleGreen("Ah, yer a TIME KNIGHT!");
                    Knight knight = new Knight (name);
                    return knight;
                case ("2"):
                    ConsoleGreen("Yer a jerk.");
                    return null;
            }
            return null;
        }

        static void StartGame (Player player) {

        }
        public static void Continue ()
        {
            ConsoleYellow("Press Enter");
            ConsoleKey key = Console.ReadKey(true).Key;
            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey (true).Key;
            }
        }
        static string FirstQuestion()
        {
            ConsoleYellow("Select a number");

            string choice = "";

            while (choice != "1" && choice != "2")
            {
                ConsoleYellow("1. Sorry \n 2. Wait, who are you?");
                choice = Console.ReadLine();
            }
            switch(choice)
            {
                case("1"):
                    return null;
                case("2"):
                    ConsoleYellow("The name's Salty! I was a pirate in the old days of King George but now I'm here in the future thanks to timetravel!\n I handle dispach fer the Time Mafia.");
                    return null;

            }
            return null;

        }
        static void StartGame(){
            ConsoleBlue("You're a newly minted Time Thief, having just passed your initiation into the Time Mafia. \nIt's your job to go throughout history to get important artifacts for the Time Godfather.");
            // ConsoleYellow("select 1");
            Continue();
            ConsoleGreen("Ah there ye argh! Yer Late!");
            FirstQuestion();
            // Continue();
            Player player = PlayerSetup();
            ConsoleGreen("The first mission we got is fer ye is ta go get King Arthur's Sword, Excalibur from jolly ol' medieval England!");
            Continue();
            ConsoleBlue("You hop in your new time machine, that the time mafia provided with time mafia money\n and just like that you're off to old England.");
        }
        public static void Main(string[] args)
        {
            // CreateWebHostBuilder(args).Build().Run();
            ConsoleGreen("%%%%%%%%%%%% Time Thieves 2: There is no Time Theves 1 %%%%%%%%%%%%%%%");
            Continue();
            StartGame();
            // Player player = PlayerSetup ();
            // PlayerSetup();
        }

        // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>();

        
    }
}
