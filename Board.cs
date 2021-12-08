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
        }
        public bool GameInProgress { get; set; }
        public int GameNo { get; set; }
        public char Winner { get; set; }    
    }
}
