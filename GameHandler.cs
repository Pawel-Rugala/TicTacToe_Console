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
                Console.SetCursorPosition(board.LeftPos, board.TopPos);
                while(board.Winner==' ')
                {
                    ErrorCheck(board);
                    KeyAction(board);
                    Console.SetCursorPosition(board.LeftPos, board.TopPos);
                    board.CheckWin();
                }
                WannaPlay(board);
            } while (board.GameInProgress); 
        }
        public static void PrintBoard()
        {
            Console.WriteLine("      |   |   ");
            Console.WriteLine("      |   |          Navigate using arrow keys");
            Console.WriteLine("      |   |   ");
            Console.WriteLine("   -----------       Press SPACE to add mark");
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
            if (board.Winner == '-')
            {
                Console.WriteLine("DRAW");
            }
            else
            {
                Console.WriteLine($"{board.Winner} wins");
            }
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
                        board.ResetVal();
                        ClearStatus();
                        Console.SetCursorPosition(0, 3);
                        break;
                    case ConsoleKey.RightArrow:
                        validKey = false;
                        Console.WriteLine("Results...");
                        board.PrintResults();
                        board.GameInProgress = false;
                        break;
                }
            }

        }
        public static void ClearStatus()
        {
            Console.SetCursorPosition(0, 19);
            Console.WriteLine(new String(' ', Console.BufferWidth));
            Console.WriteLine(new String(' ', Console.BufferWidth));
            Console.WriteLine(new String(' ', Console.BufferWidth));
            Console.WriteLine(new String(' ', Console.BufferWidth));
            Console.WriteLine(new String(' ', Console.BufferWidth));
            Console.SetCursorPosition(4, 7);

        }
        public static void ErrorCheck(Board board)
        {
            if(board.Error is not null)
            {
                Console.SetCursorPosition(board.LeftPos, board.TopPos);
                Console.Write(board.GetValue());
                Console.SetCursorPosition(0, 19);
                Console.WriteLine(board.Error);
                Console.WriteLine("Press SPACE to continue...");
                bool validKey = true;
                while (validKey)
                {
                    ConsoleKeyInfo keypress = Console.ReadKey();
                    switch (keypress.Key)
                    {
                        case ConsoleKey.Spacebar:
                            validKey = false;
                            board.LeftPos = 4;
                            board.TopPos = 7;
                            board.Error = null;
                            ClearStatus();
                            break;
                        default:
                            Console.WriteLine("invalid key");
                            break;
                    }
                }
            }
        }
        public static void KeyAction(Board board)
        {
            ConsoleKeyInfo keypress = Console.ReadKey();
            switch (keypress.Key)   
            {
                case ConsoleKey.LeftArrow:
                    if(board.LeftPos==4)
                    {
                        board.LeftPos = 12;
                    }
                    else
                    {
                        board.LeftPos -= 4;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (board.LeftPos == 12)
                    {
                        board.LeftPos = 4;
                    }
                    else
                    {
                        board.LeftPos += 4;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (board.TopPos == 7)
                    {
                        board.TopPos = 15;
                    }
                    else
                    {
                        board.TopPos -= 4;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (board.TopPos == 15)
                    {
                        board.TopPos = 7;
                    }
                    else
                    {
                        board.TopPos += 4;
                    }
                    break;
                case ConsoleKey.Spacebar:

                    if(board.GetValue() == ' ')
                    {
                        char mark = board.xTurn ? 'X' : 'O';
                        board.AddMark(mark);
                        Console.SetCursorPosition(board.LeftPos, board.TopPos);
                        Console.Write(mark);
                        Console.SetCursorPosition(4, 7);
                        board.xTurn = !board.xTurn;
                    }
                    else
                    {
                        board.Error = "Sorry this field is already taken";
                    }
                    break;
                default:
                    Console.SetCursorPosition(board.LeftPos, board.TopPos);
                    Console.Write(" ");
                    Console.SetCursorPosition(board.LeftPos, board.TopPos);
                    break;
            }
        }
        public static void Results(Board board)
        {
            board.GameInProgress = false;
             Console.WriteLine("Results...");
        }
    }
}
