using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public class Board
    {
        public Board()
        {
            LP = 4;
            TP = 6;
            NotEnd = true;
            GameNo = 1;
            xTurn = true;
            Error = false;
            Mark = 'X';
            Title = $"Game {GameNo}";
        }
        public bool GameInProgress { get; set; }
        public int GameNo { get; set; }
        public bool xTurn { get; set; }
        public string Title { get; set; }
        public int LP { get; set; }
        public int TP { get; set; }
        public char Mark { get; set; }
        public bool NotEnd { get; set; }
        public ConsoleKeyInfo Keypress { get; set; }    
        public bool Error { get; set; }
        private List<Field> fields = new List<Field>()
        {
            new Field(4, 6),
            new Field(8, 6),
            new Field(12, 6),
            new Field(4, 10),
            new Field(8, 10),
            new Field(12, 10),
            new Field(4, 14),
            new Field(8, 14),
            new Field(12, 14)
        };

        public void addMark(char mark)
        {
            int index = fields.FindIndex(e => e.X == LP && e.Y == TP);
            fields[index].Val = mark;
        }

        public char getValue(int x, int y)
        {
            int index = fields.FindIndex(e => e.X == x && e.Y == y);
            return fields[index].Val;
        }
        public bool checkWin()
        {
            if (fields[0].Val != 'e' && fields[0].Val == fields[1].Val && fields[1].Val == fields[2].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[0].Val} wins");
                return false;
            }
            else if (fields[0].Val != 'e' && fields[0].Val == fields[3].Val && fields[3].Val == fields[6].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[0].Val} wins");
                return false;
            }
            else if (fields[0].Val != 'e' && fields[0].Val == fields[4].Val && fields[4].Val == fields[8].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[0].Val} wins");
                return false;
            }
            else if (fields[4].Val != 'e' && fields[4].Val == fields[3].Val && fields[3].Val == fields[5].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[4].Val} wins");
                return false;
            }
            else if (fields[4].Val != 'e' && fields[4].Val == fields[1].Val && fields[1].Val == fields[7].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[4].Val} wins");
                return false;
            }
            else if (fields[8].Val != 'e' && fields[8].Val == fields[4].Val && fields[4].Val == fields[0].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[8].Val} wins");
                return false;
            }
            else if (fields[8].Val != 'e' && fields[8].Val == fields[5].Val && fields[5].Val == fields[2].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[8].Val} wins");
                return false;
            }
            else if (fields[8].Val != 'e' && fields[8].Val == fields[7].Val && fields[7].Val == fields[6].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[8].Val} wins");
                return false;
            }
            else if(fields[6].Val != 'e' && fields[6].Val == fields[4].Val && fields[4].Val == fields[2].Val)
            {
                Console.SetCursorPosition(3, 17);
                Console.WriteLine($"{fields[8].Val} wins");
                return false;
            }
            else
            {
                var areEs = fields.FindIndex(elem => elem.Val == 'e');
                if (areEs == -1)
                {
                    Console.SetCursorPosition(3, 17);
                    Console.WriteLine("Game over");
                    return false;
                }

                return true;
            }
        }

        public void MoveCursor()
        {

            switch (Keypress.Key)
            {
                case ConsoleKey.UpArrow:

                    if (TP == 6)
                    {
                        TP = 14;
                    }
                    else
                    {
                        TP -= 4;
                    }

                    break;
                case ConsoleKey.DownArrow:
                    if (TP == 14)
                    {
                        TP = 6;
                    }
                    else
                    {
                        TP += 4;
                    }

                    break;
                case ConsoleKey.LeftArrow:
                    if (LP == 4)
                    {
                        LP = 12;
                    }
                    else
                    {
                        LP -= 4;
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (LP == 12)
                    {
                        LP = 4;
                    }
                    else
                    {
                        LP += 4;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    break;


            }
        }
    }
}
