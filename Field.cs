using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public class Field
    {
        public Field(int x, int y)
        {
            Val = 'e';
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public char Val { get; set; }
    }
}
