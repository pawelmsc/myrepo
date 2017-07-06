using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public struct Zawodnik
    {
        public string Name;
        public char Symbol;
        public int[] Co;
    }

    class TTT
    {
        public char[,] Plansza;

        public TTT()
        {
            Plansza = new char[3, 3];
        }
    }
}
