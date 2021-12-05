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

    }
}
