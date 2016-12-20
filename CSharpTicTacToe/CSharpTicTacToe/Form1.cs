using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTicTacToe
{
    public partial class MainWin : Form
    {
        enum Player
        {
            X,O
        };

        Player currentPlayer;
        int moveLeft;

        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {
            button1_1.Text = "";
            button1_2.Text = "";
            button1_3.Text = "";
            button2_1.Text = "";
            button2_2.Text = "";
            button2_3.Text = "";
            button3_1.Text = "";
            button3_2.Text = "";
            button3_3.Text = "";

            button1_1.Enabled = true;
            button1_2.Enabled = true;
            button1_3.Enabled = true;
            button2_1.Enabled = true;
            button2_2.Enabled = true;
            button2_3.Enabled = true;
            button3_1.Enabled = true;
            button3_2.Enabled = true;
            button3_3.Enabled = true;

            labelTurn.Visible = true;

            currentPlayer = Player.X;
            moveLeft = 9;
        }

        private void EndGame()
        {
            button1_1.Enabled = false;
            button1_2.Enabled = false;
            button1_3.Enabled = false;
            button2_1.Enabled = false;
            button2_2.Enabled = false;
            button2_3.Enabled = false;
            button3_1.Enabled = false;
            button3_2.Enabled = false;
            button3_3.Enabled = false;
        }

        private void CheckRow()
        {
            if (button1_1.Text == button1_2.Text && button1_2.Text == button1_3.Text)
            {
                if (button1_1.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button1_1.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
            else
            if (button2_1.Text == button2_2.Text && button2_2.Text == button2_3.Text)
            {
                if (button2_1.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button2_1.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
            else
            if (button3_1.Text == button3_2.Text && button3_2.Text == button3_3.Text)
            {
                if (button3_1.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button3_1.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
        }

        private void CheckColumn()
        {
            if (button1_1.Text == button2_1.Text && button2_1.Text == button3_1.Text)
            {
                if (button1_1.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button1_1.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
            else 
            if (button1_2.Text == button2_2.Text && button2_2.Text == button3_2.Text)
            {
                if (button1_2.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button1_2.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
            else
            if (button1_3.Text == button2_3.Text && button2_3.Text == button3_3.Text)
            {
                if (button1_3.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else 
                if (button1_3.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
        }

        private void CheckDiagonal()
        {
            if (button1_1.Text == button2_2.Text && button2_2.Text == button3_3.Text)
            {
                if (button1_1.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button1_1.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
            else
            if (button1_3.Text == button2_2.Text && button2_2.Text == button3_1.Text)
            {
                if (button1_3.Text == Player.X.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.X.ToString() + " has won the game!");
                }
                else
                if (button1_3.Text == Player.O.ToString())
                {
                    EndGame();
                    MessageBox.Show(Player.O.ToString() + " has won the game!");
                }
            }
        }

        private void Check()
        {
            CheckRow();
            CheckColumn();
            CheckDiagonal();
        }

        private void button_newgame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = currentPlayer.ToString();
            currentPlayer = currentPlayer == Player.X ? Player.O : Player.X;
            button.Enabled = false;
            labelTurn.Text = currentPlayer.ToString() + "'s Turn";
            Check();
        }
    }
}
