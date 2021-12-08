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
            GameInProgress = true;
            GameNo = 1;
            Winner = ' ';
            LeftPos = 4;
            TopPos = 7;
            xTurn = true;
        }
        public bool GameInProgress { get; set; }
        public int GameNo { get; set; }
        public char Winner { get; set; }
        public int LeftPos { get; set; }
        public int TopPos { get; set; }
        public bool xTurn { get; set; }
    }
}
