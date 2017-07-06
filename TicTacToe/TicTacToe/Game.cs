using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void pbx00_Click(object sender, EventArgs e)
        {
            pbx00.Image = Properties.Resources.circle;
        }

        private void pbx10_Click(object sender, EventArgs e)
        {
            pbx10.Image = Properties.Resources.cross;
        }
    }
}
