using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public struct Player
    {
        public string Name;
        public char Symbol;
        public int[] Co;
    }

    class TTT
    {
        public char[,] Board;
        public Player[] Players;

        public TTT()
        {
            Board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            Players = new Player[2];
            Players[0].Co = new int[2];
            Players[1].Co = new int[2];
            Players[0].Name = "P1";
            Players[1].Name = "P2";
            Players[0].Symbol = 'o';
            Players[1].Symbol = 'x';
        }

        public bool Move(char[,] B, Player P)
        {
            if (B[P.Co[0], P.Co[1]] == ' ')
            {
                B[P.Co[0], P.Co[1]] = P.Symbol;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckEnd(char[,] B)
        {
            if ((B[0, 0] == B[0, 1] && B[0, 0] == B[0, 2] && B[0, 0] != ' ') ||
                (B[1, 0] == B[1, 1] && B[1, 0] == B[1, 2] && B[1, 0] != ' ') ||
                (B[2, 0] == B[2, 1] && B[2, 0] == B[2, 2] && B[2, 0] != ' ') ||
                (B[0, 0] == B[1, 0] && B[0, 0] == B[2, 0] && B[0, 0] != ' ') ||
                (B[0, 1] == B[1, 1] && B[0, 1] == B[2, 1] && B[0, 1] != ' ') ||
                (B[0, 2] == B[1, 2] && B[0, 2] == B[2, 2] && B[0, 2] != ' ') ||
                (B[0, 0] == B[1, 1] && B[0, 0] == B[2, 2] && B[0, 0] != ' ') ||
                (B[0, 2] == B[1, 1] && B[0, 2] == B[2, 0] && B[0, 2] != ' '))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckDraw(char[,] B)
        {
            if (B[0, 0] != ' ' && B[0, 1] != ' ' && B[0, 2] != ' ' &&
                B[1, 0] != ' ' && B[1, 1] != ' ' && B[1, 2] != ' ' &&
                B[2, 0] != ' ' && B[2, 1] != ' ' && B[2, 2] != ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
