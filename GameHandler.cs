using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public static class GameHandler
    {
        public static void StartGame()
        {
            Console.WriteLine("   TIC TAC TOE GAME");
            Console.WriteLine("         X / O");

        }
        public static void PrintBoard()
        {
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("   -----------");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("   -----------");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |   ");
        }
    }
}
