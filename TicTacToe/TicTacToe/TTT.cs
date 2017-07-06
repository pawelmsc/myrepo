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
            Board = new char[3, 3];
            Players = new Player[2];
            Players[0].Co = new int[2];
            Players[1].Co = new int[2];
            Players[0].Name = "P1";
            Players[1].Name = "P2";
        }
    }
}
