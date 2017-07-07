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
        private int PlayerTurn;

        public Game()
        {
            InitializeComponent();
            gbxGame.Visible = false;
            lblTip.Visible = false;
            GameTTT = new TTT();
            PlayerTurn = 0;
            tbxP1.Text = "";
            tbxP2.Text = "";
        }

        private void PlayGame(int T, int Co1, int Co2)
        {
            int[] Coo = new int[2];

            Coo[0] = Co1;
            Coo[1] = Co2;

            if (T == 1)
            {
                GameTTT.Players[0].Co[0] = Coo[0];
                GameTTT.Players[0].Co[1] = Coo[1];
                if (GameTTT.Move(GameTTT.Board, GameTTT.Players[0]))
                {
                    ShowSymbolOnBoard(Coo, GameTTT.Players[0].Symbol);

                    if (GameTTT.CheckEnd(GameTTT.Board))
                    {
                        if (MessageBox.Show("WIN!" + Environment.NewLine + "Player: " + tbxP1.Text + " is a winner." + Environment.NewLine + "New game?", "Game end", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ClearBoard();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        if (GameTTT.CheckDraw(GameTTT.Board))
                        {
                            if (MessageBox.Show("DRAW!" + Environment.NewLine + "New game?", "Game end", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                ClearBoard();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            PlayerTurn = 2;
                            lblTip.Text = "Player move: " + tbxP2.Text + " (" + GameTTT.Players[1].Symbol + ")";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong move!");
                }
            }

            if (T == 2)
            {
                GameTTT.Players[1].Co[0] = Coo[0];
                GameTTT.Players[1].Co[1] = Coo[1];
                if (GameTTT.Move(GameTTT.Board, GameTTT.Players[1]))
                {
                    ShowSymbolOnBoard(Coo, GameTTT.Players[1].Symbol);

                    if (GameTTT.CheckEnd(GameTTT.Board))
                    {
                        if (MessageBox.Show("WIN!" + Environment.NewLine + "Player: " + tbxP2.Text + " is a winner." + Environment.NewLine + "New game?", "Game end", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ClearBoard();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        if (GameTTT.CheckDraw(GameTTT.Board))
                        {
                            if (MessageBox.Show("DRAW!" + Environment.NewLine + "New game?", "Game end", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                ClearBoard();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            PlayerTurn = 1;
                            lblTip.Text = "Player move: " + tbxP1.Text + " (" + GameTTT.Players[0].Symbol + ")";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong move!");
                }
            }
                       
            /*
            bool GameEnd = false;
            bool W1 = false;
            bool W2 = false;
            bool M1 = false;
            bool M2 = false;
            string Winner = "";

            while (!GameEnd)
            {
                while (!M1)
                {
                    lblTip.Text = "Player move: " + tbxP1.Text;
                    GameTTT.Players[0].Co[0] = Coo[0];
                    GameTTT.Players[0].Co[1] = Coo[1];
                    M1 = GameTTT.Move(GameTTT.Board, GameTTT.Players[0]);
                    if (M1)
                    {
                        ShowSymbolOnBoard(Coo, GameTTT.Players[0].Symbol);
                    }
                }
                W1 = GameTTT.CheckEnd(GameTTT.Board);
                M1 = false;
                if (W1)
                {
                    Winner = tbxP1.Text;
                    GameEnd = true;
                }
                else
                {
                    while (!M2)
                    {
                        lblTip.Text = "Player move: " + tbxP2.Text;
                        GameTTT.Players[1].Co[0] = Coo[0];
                        GameTTT.Players[1].Co[1] = Coo[1];
                        M2 = GameTTT.Move(GameTTT.Board, GameTTT.Players[1]);
                        if (M2)
                        {
                            ShowSymbolOnBoard(Coo, GameTTT.Players[1].Symbol);
                        }
                    }
                    W2 = GameTTT.CheckEnd(GameTTT.Board);
                    M2 = false;
                }
                if (W2)
                {
                    Winner = tbxP2.Text;
                    GameEnd = true;
                }
            }

            MessageBox.Show("The winner is: " + Winner);
            */
        }

        private void ClearBoard()
        {
            gbxGame.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            btnStart.Visible = true;
            tbxP1.Visible = true;
            tbxP2.Visible = true;
            lblTip.Visible = false;
            pbx00.Image = null;
            pbx01.Image = null;
            pbx02.Image = null;
            pbx10.Image = null;
            pbx11.Image = null;
            pbx12.Image = null;
            pbx20.Image = null;
            pbx21.Image = null;
            pbx22.Image = null;

            GameTTT.Board = new char[3,3] {{' ',' ',' '}, {' ',' ',' '}, {' ',' ',' '}};
        }

        private void pbx00_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 0, 0);
            //pbx00.Image = Properties.Resources.circle;
        }

        private void pbx10_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 1, 0);
            //pbx10.Image = Properties.Resources.cross;
        }

        private void pbx20_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 2, 0);
            //pbx20.Image = Properties.Resources.circle;
        }

        private void pbx01_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 0, 1);
            //pbx01.Image = Properties.Resources.cross;
        }

        private void pbx11_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 1, 1);
            //pbx11.Image = Properties.Resources.circle;
        }

        private void pbx21_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 2, 1);
            //pbx21.Image = Properties.Resources.cross;
        }

        private void pbx02_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 0, 2);
            //pbx02.Image = Properties.Resources.circle;
        }

        private void pbx12_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 1, 2);
            //pbx12.Image = Properties.Resources.cross;
        }

        private void pbx22_Click(object sender, EventArgs e)
        {
            PlayGame(PlayerTurn, 2, 2);
            //pbx22.Image = Properties.Resources.circle;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxP1.Text != "" && tbxP2.Text != "")
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    btnStart.Visible = false;
                    tbxP1.Visible = false;
                    tbxP2.Visible = false;
                    GameTTT.Players[0].Name = tbxP1.Text;
                    GameTTT.Players[1].Name = tbxP2.Text;
                    gbxGame.Visible = true;
                    lblTip.Visible = true;
                    PlayerTurn = 1;
                    lblTip.Text = "Player move: " + tbxP1.Text + " (" + GameTTT.Players[0].Symbol + ")";
                }
                else
                {
                    MessageBox.Show("Enter player names.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ShowSymbolOnBoard(int[] C, char S)
        {
            if(S == 'o')
            {
                if (C[0] == 0 && C[1] == 0)
                {
                    pbx00.Image = Properties.Resources.circle;
                }
                if (C[0] == 0 && C[1] == 1)
                {
                    pbx01.Image = Properties.Resources.circle;
                }
                if (C[0] == 0 && C[1] == 2)
                {
                    pbx02.Image = Properties.Resources.circle;
                }
                if (C[0] == 1 && C[1] == 0)
                {
                    pbx10.Image = Properties.Resources.circle;
                }
                if (C[0] == 1 && C[1] == 1)
                {
                    pbx11.Image = Properties.Resources.circle;
                }
                if (C[0] == 1 && C[1] == 2)
                {
                    pbx12.Image = Properties.Resources.circle;
                }
                if (C[0] == 2 && C[1] == 0)
                {
                    pbx20.Image = Properties.Resources.circle;
                }
                if (C[0] == 2 && C[1] == 1)
                {
                    pbx21.Image = Properties.Resources.circle;
                }
                if (C[0] == 2 && C[1] == 2)
                {
                    pbx22.Image = Properties.Resources.circle;
                }
            }

            if (S == 'x')
            {
                if (C[0] == 0 && C[1] == 0)
                {
                    pbx00.Image = Properties.Resources.cross;
                }
                if (C[0] == 0 && C[1] == 1)
                {
                    pbx01.Image = Properties.Resources.cross;
                }
                if (C[0] == 0 && C[1] == 2)
                {
                    pbx02.Image = Properties.Resources.cross;
                }
                if (C[0] == 1 && C[1] == 0)
                {
                    pbx10.Image = Properties.Resources.cross;
                }
                if (C[0] == 1 && C[1] == 1)
                {
                    pbx11.Image = Properties.Resources.cross;
                }
                if (C[0] == 1 && C[1] == 2)
                {
                    pbx12.Image = Properties.Resources.cross;
                }
                if (C[0] == 2 && C[1] == 0)
                {
                    pbx20.Image = Properties.Resources.cross;
                }
                if (C[0] == 2 && C[1] == 1)
                {
                    pbx21.Image = Properties.Resources.cross;
                }
                if (C[0] == 2 && C[1] == 2)
                {
                    pbx22.Image = Properties.Resources.cross;
                }
            }
        }
    }
}