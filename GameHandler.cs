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
            Board board = new Board();
            Console.WriteLine("   TIC TAC TOE GAME");
            Console.WriteLine("        X / O\n");

            do
            {
                Console.WriteLine($"   Game no: {board.GameNo} \n\n");
                PrintBoard();
                KeyAction();
                if (board.Winner != ' ')
                {
                    WannaPlay(board);
                }
            } while (board.GameInProgress); 

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
        public static void WannaPlay(Board board)
        {
            Console.SetCursorPosition(0, 19);
            Console.WriteLine($"{board.Winner} wins");
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine(" YES <- left arrow    ---   right arrow -> NO");
            bool validKey = true;
            while(validKey)
            {
                ConsoleKeyInfo keypress = Console.ReadKey();
                switch(keypress.Key)
                {
                    case ConsoleKey.LeftArrow:
                        validKey = false;
                        board.GameNo++;
                        Console.SetCursorPosition(0, 3);
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Results...");
                        validKey = false;
                        board.GameInProgress = false;
                        break;
                }
            }

        }
        
        public static void KeyAction()
        {
            ConsoleKeyInfo keypress = Console.ReadKey();
            switch (keypress.Key)   
            {
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                default:
                    break;
            }
        }
    }
}
