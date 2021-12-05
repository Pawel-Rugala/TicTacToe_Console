using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public class Board
    {
        public Board(int num)
        {
            Title = $"Game {num}";
            LP = 4;
            TP = 6;
        }
        public string Title { get; set; }
        public int LP { get; set; }
        public int TP { get; set; }
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


        public void getValues()
        {
            foreach(var field in fields)
            {
                Console.WriteLine($"{field.Val}: {field.X} | {field.Y}");
            }
        }

        public void addMark(char mark)
        {
            int index = fields.FindIndex(e => e.X == LP && e.Y ==TP);
            fields[index].Val = mark;
        }

        public char getValue(int x, int y)
        {
            int index = fields.FindIndex(e => e.X == x && e.Y == y);
            return fields[index].Val;
        }
        public bool checkWin()
        {

                if (fields[0].Val != 'e' && fields[0].Val == fields[1].Val && fields[1].Val == fields[3].Val || fields[0].Val != 'e' && fields[0].Val == fields[3].Val && fields[3].Val == fields[6].Val || fields[0].Val != 'e' && fields[0].Val == fields[4].Val && fields[4].Val == fields[8].Val)
                {
                    Console.SetCursorPosition(3, 17);
                    Console.WriteLine($"{fields[0].Val} wins");
                    return false;
                }
                else if (fields[4].Val != 'e' && fields[4].Val == fields[3].Val && fields[3].Val == fields[5].Val || fields[4].Val != 'e' && fields[4].Val == fields[1].Val && fields[1].Val == fields[7].Val)
                {
                    Console.SetCursorPosition(3, 17);
                    Console.WriteLine($"{fields[4].Val} wins");
                    return false;
                }
                else if (fields[8].Val != 'e' && fields[8].Val == fields[4].Val && fields[4].Val == fields[0].Val || fields[8].Val != 'e' && fields[8].Val == fields[5].Val && fields[5].Val == fields[2].Val || fields[8].Val != 'e' && fields[8].Val == fields[7].Val && fields[7].Val == fields[6].Val)
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
    }
}
