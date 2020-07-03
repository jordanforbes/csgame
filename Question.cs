using System;

namespace csgame
{
    public class Question
    {
        public static string FirstQ()
        {
            Color.Yellow("Select a number");

            string choice = "";

            while (choice != "1" && choice != "2")
            {
                Color.Yellow("1. Sorry \n 2. Wait, who are you?");
                choice = Console.ReadLine();
            }
            switch (choice)
            {
                case ("1"):
                    return null;
                case ("2"):
                    Color.Yellow("The name's Salty! I was a pirate in the old days of King George but now I'm here in the future thanks to timetravel!\n I handle dispach fer the Time Mafia.");
                    return null;

            }
            return null;

        }

        public static string SecondQ()
        {
            Color.Yellow("How do you respond?");
            string choice = "";
            while (choice != "1" && choice != "2")
            {
                Color.Yellow("1. I'm a Time Thief from the future here to take Excalibur\n 2. Don't worry about it.");
                choice = Console.ReadLine();
            }
            switch (choice)
            {
                case ("1"):
                    Color.Yellow("I'm sorry I don't understand your accent, could you repeat that?");
                    return null;
                case ("2"):
                    Color.Yellow("I'm sorry I don't understand your accent, could you repeat that?");
                    return null;

            }
            return null;


        }

    }
}