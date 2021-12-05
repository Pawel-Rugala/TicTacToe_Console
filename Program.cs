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

            //hqweljasld 
            //Console.SetCursorPosition(4, 6);
            //Console.ReadLine();

            do
            {
                Console.WriteLine("Tic Tac Toe!\n");
                Console.WriteLine("    X / O   \n\n");
                PrintBoard();
                var board = new Board(gameNo);
                bool isEnd = true;
                do
                {
                    bool error = false;
                    char mark;
                    if (xTurn)
                    {
                        mark = 'X'; 
                    }
                    else
                    {
                        mark = 'O';
                    }
                    
                    Console.SetCursorPosition(board.LP, board.TP);
                    ConsoleKeyInfo keypress = Console.ReadKey();
                    if (isEnd)
                    {
                        switch (keypress.Key)
                        {
                            case ConsoleKey.UpArrow:

                                if (board.TP == 6)
                                {
                                    board.TP = 14;
                                }
                                else
                                {
                                    board.TP -= 4;
                                }

                                break;
                            case ConsoleKey.DownArrow:
                                if (board.TP == 14)
                                {
                                    board.TP = 6;
                                }
                                else
                                {
                                    board.TP += 4;
                                }

                                break;
                            case ConsoleKey.LeftArrow:
                                if (board.LP == 4)
                                {
                                    board.LP = 12;
                                }
                                else
                                {
                                    board.LP -= 4;
                                }

                                break;
                            case ConsoleKey.RightArrow:
                                if (board.LP == 12)
                                {
                                    board.LP = 4;
                                }
                                else
                                {
                                    board.LP += 4;
                                }
                                break;
                            case ConsoleKey.Spacebar:
                                Console.SetCursorPosition(board.LP, board.TP);
                                if (board.getValue(board.LP, board.TP) == 'e')
                                {
                                    board.addMark(mark);
                                    Console.Write(mark);
                                    board.LP = 4;
                                    board.TP = 6;
                                    xTurn = !xTurn;
                                }
                                else
                                {
                                    Console.SetCursorPosition(board.LP, board.TP);
                                    Console.Write(board.getValue(board.LP, board.TP));
                                    error = true;
                                    do
                                    {
                                        Console.SetCursorPosition(3, 17);
                                        Console.WriteLine("Sorry this position is taken already choose different.  Press ESC to continue!");
                                        Console.WriteLine("");
                                        ConsoleKeyInfo removeError = Console.ReadKey();
                                        if (removeError.Key == ConsoleKey.Escape)
                                        {
                                            error = false;
                                        }
                                    } while (error);
                                    Console.SetCursorPosition(3, 17);
                                    Console.WriteLine("===  Move using arrow keys and place mark pressing SPACE ===================================================");
                                }
                                break;


                        }
                    }
                        isEnd = board.checkWin();
                } while (isEnd);

                Console.SetCursorPosition(3, 17);
                Console.WriteLine("Wanna play again? Yes or No?");
                string choice = Console.ReadLine();
                if (choice == "No")
                {
                    gameInProgress = false;
                }
                else
                {
                    Console.SetCursorPosition(0, 0);
                }

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
