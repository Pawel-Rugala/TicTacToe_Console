using System;

namespace TicTacToe_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameInProgress = true;
            int gameNo = 1;
            bool xTurn = true;


            //Console.SetCursorPosition(4, 6);
            //Console.ReadLine();

            do
            {
                Console.WriteLine("Tic Tac Toe!\n");
                Console.WriteLine("    X / O   \n\n");
                PrintBoard();
                bool isEnd = false;
                var board = new Board(gameNo);

                do
                {
                    char mark;
                    if(xTurn)
                    {
                        mark = 'X'; 
                    }
                    else
                    {
                        mark = 'O';
                    }
                    
                    Console.SetCursorPosition(board.LP, board.TP);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                    ConsoleKeyInfo keypress = Console.ReadKey();
                    switch (keypress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if(board.getValue(board.LP, board.TP)=='e')
                            {
                                Console.SetCursorPosition(board.LP, board.TP);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(" ");
                            }
                            if(board.TP == 6)
                            {
                                    board.TP = 14;
                            } else
                            {
                                board.TP -= 4;
                            }
                            Console.SetCursorPosition(board.LP, board.TP);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                            break;
                        case ConsoleKey.DownArrow:
                            if (board.getValue(board.LP, board.TP) == 'e')
                            {
                                Console.SetCursorPosition(board.LP, board.TP);
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(" ");
                            }
                            if (board.TP == 14)
                            {
                                board.TP = 6;
                            }
                            else
                            {
                                board.TP += 4;
                            }
                            if (board.getValue(board.LP, board.TP) == 'e')
                            {
                                Console.SetCursorPosition(board.LP, board.TP);
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" ");
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.SetCursorPosition(board.LP, board.TP);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            if (board.LP == 4)
                            {
                                board.LP = 12;
                            }
                            else
                            {
                                board.LP -= 4;
                            }
                            Console.SetCursorPosition(board.LP, board.TP);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                            break;
                        case ConsoleKey.RightArrow:
                            Console.SetCursorPosition(board.LP, board.TP);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            if (board.LP == 12)
                            {
                                board.LP = 4;
                            }
                            else
                            {
                                board.LP += 4;
                            }
                            Console.SetCursorPosition(board.LP, board.TP);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                            break;
                        case ConsoleKey.Spacebar:
                            Console.SetCursorPosition(board.LP+1, board.TP);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            Console.SetCursorPosition(board.LP, board.TP);
                            Console.BackgroundColor = xTurn ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            board.addMark(mark);
                            Console.Write(mark);
                            board.LP = 4;
                            board.TP = 6;
                            xTurn = !xTurn;
                            Console.SetCursorPosition(board.LP, board.TP);
                            break;
                    }
                } while (!isEnd);

            } while (gameInProgress);
        }

        private static void PrintBoard()
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
