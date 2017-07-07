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
        private TTT GameTTT;

        public Game()
        {
            InitializeComponent();
            gbxGame.Visible = false;
            GameTTT = new TTT();
        }

        private void pbx00_Click(object sender, EventArgs e)
        {
            pbx00.Image = Properties.Resources.circle;
        }

        private void pbx10_Click(object sender, EventArgs e)
        {
            pbx10.Image = Properties.Resources.cross;
        }

        private void pbx20_Click(object sender, EventArgs e)
        {
            pbx20.Image = Properties.Resources.circle;
        }

        private void pbx01_Click(object sender, EventArgs e)
        {
            pbx01.Image = Properties.Resources.cross;
        }

        private void pbx11_Click(object sender, EventArgs e)
        {
            pbx11.Image = Properties.Resources.circle;
        }

        private void pbx21_Click(object sender, EventArgs e)
        {
            pbx21.Image = Properties.Resources.cross;
        }

        private void pbx02_Click(object sender, EventArgs e)
        {
            pbx02.Image = Properties.Resources.circle;
        }

        private void pbx12_Click(object sender, EventArgs e)
        {
            pbx12.Image = Properties.Resources.cross;
        }

        private void pbx22_Click(object sender, EventArgs e)
        {
            pbx22.Image = Properties.Resources.circle;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            btnStart.Visible = false;
            tbxP1.Visible = false;
            tbxP2.Visible = false;
            GameTTT.Players[0].Name = tbxP1.Text;
            GameTTT.Players[1].Name = tbxP2.Text;
            gbxGame.Visible = true;
        }
    }
}
