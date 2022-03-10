using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTac
{
    public partial class TicTacToe : Form
    {
        bool turn = true; // turn = true oldugu vaxt X,false oldugu vaxt ise O yazsin
        int turnCount = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe Game by Ruslan","Game",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (turn)
            {
                btn.Text = "X";
                btn.BackColor = Color.Blue;
            }
            else
            {
                btn.Text = "O";
                btn.BackColor = Color.Red;
            }

            turnCount++;
            turn = !turn;
            btn.Enabled = false;

            CheckForWinner();
        }
        private void CheckForWinner()
        {
            bool thereIsWinner = false;
            string winner;

            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                thereIsWinner = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                thereIsWinner = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                thereIsWinner = true;
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                thereIsWinner = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                thereIsWinner = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                thereIsWinner = true;
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                thereIsWinner = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button7.Enabled))
                thereIsWinner = true;

            if (thereIsWinner)
            {
                DisabledButton();
                if (!turn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show(winner + " qazandı!","Təbriklər!");
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Oyun bərabərə bitdi","Draw",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
        private void DisabledButton()
        {
            try
            {
                foreach (Control button in this.Controls)
                {
                    Button btn = (Button)button;
                    btn.Enabled = false;
                }
            }
            catch { }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacToe game = new TicTacToe();
            game.Show();
        }
    }
}
