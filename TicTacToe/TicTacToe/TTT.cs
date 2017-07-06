using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public struct Zawodnik
    {
        public char Symbol;
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
