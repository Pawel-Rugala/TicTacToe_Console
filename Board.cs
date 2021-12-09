using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Console
{
    public class Board
    {
        public Board(int top)
        {
            GameInProgress = true;
            GameNo = 1;
            Winner = ' ';
            LeftPos = 4;
            TopPos = top+7;
            xTurn = true;
            fields = new List<Field>()
        {
            new Field(4, top+7),
            new Field(8, top+7),
            new Field(12,top+7),
            new Field(4, top+11),
            new Field(8, top+11),
            new Field(12, top+11),
            new Field(4, top+15),
            new Field(8, top+15),
            new Field(12, top+15)
        };
        }
        public bool GameInProgress { get; set; }
        public int GameNo { get; set; }
        public char Winner { get; set; }
        public int LeftPos { get; set; }
        public int TopPos { get; set; }
        public bool xTurn { get; set; }
        public string Error { get; set; }

        public List<Field> fields;
        public List<char> status = new List<char>();


        public void AddMark(char mark)
        {
            int index = fields.FindIndex(field => field.X == LeftPos && field.Y == TopPos);
            if (index < 0)
            {
                Error = "Selection out of range";
            }
            else
            {
                fields[index].Val = mark;
            }
        }

        public char GetValue()
        {
            int index = fields.FindIndex(field => field.X == LeftPos && field.Y == TopPos);
            if (index < 0)
            {
                Error = "Getting values";
                return ' ';
            }
            else
            {
                return fields[index].Val;
            }
        }

        public void CheckWin()
        {
            if
            (
            fields[0].Val != ' ' && fields[0].Val == fields[1].Val && fields[2].Val == fields[0].Val
            ||
            fields[0].Val != ' ' && fields[0].Val == fields[4].Val && fields[8].Val == fields[0].Val
            ||
            fields[0].Val != ' ' && fields[0].Val == fields[3].Val && fields[6].Val == fields[0].Val
            )
            {
                Winner = fields[0].Val;
                status.Add(fields[0].Val);
            }
            else if
            (
            fields[4].Val != ' ' && fields[4].Val == fields[5].Val && fields[3].Val == fields[4].Val
            ||
            fields[4].Val != ' ' && fields[4].Val == fields[1].Val && fields[7].Val == fields[4].Val
            )
            {
                Winner = fields[4].Val;
                status.Add(fields[4].Val);
            }
            else if
            (
            fields[2].Val != ' ' && fields[2].Val == fields[4].Val && fields[6].Val == fields[2].Val
            ||
            fields[2].Val != ' ' && fields[2].Val == fields[5].Val && fields[8].Val == fields[2].Val
            )
            {
                Winner = fields[2].Val;
                status.Add(fields[2].Val);
            }
            else if
            (
            fields[8].Val != ' ' && fields[8].Val == fields[7].Val && fields[6].Val == fields[8].Val
            )
            {
                Winner = fields[8].Val;
                status.Add(fields[8].Val);
            }
            else if (!fields.Any(field => field.Val == ' '))
            {
                Winner = '-';
                status.Add(Winner);
            }


        }

        public void ResetVal()
        {
            foreach (var field in fields)
            {
                field.Val = ' ';
            }
            GameNo += 1;
            LeftPos = 4;
            TopPos = 7;
            Winner = ' ';
        }

        public void PrintResults()
        {
            int xWins = status.Count(stat => stat == 'X');
            int oWins = status.Count(stat => stat == 'O');
            int draw = status.Count(stat => stat == '-');
            Console.WriteLine($"X wins: {xWins}");
            Console.WriteLine($"O wins: {oWins}");
            Console.WriteLine($"Draw: {draw}");
        }
    }
}
