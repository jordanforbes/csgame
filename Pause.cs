using System.Drawing;
using System;

namespace csgame
{
    public class Pause 
    {
        public static void Enter()
        {
            Color.Yellow("Press Enter");
            ConsoleKey key = Console.ReadKey(true).Key;
            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true).Key;
            }
        }
        public static void Enter(string text)
        {
            Color.Yellow(text);
            ConsoleKey key = Console.ReadKey(true).Key;
            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true).Key;
            }
        }
    }
}