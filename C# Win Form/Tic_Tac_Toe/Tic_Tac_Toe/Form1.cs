using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Model;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int size = 3;
        string p1, p2;
        Board board;
        Game game;
        bool TurnPlayer = false;
        Result result;

        void EnableAllButton() {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Board(size);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            p1 = textBox1.Text;
            p2 = textBox2.Text;
            if (!p1.Equals("") && !p2.Equals(""))
            {
                Player player1 = new Player(p1, Mark.X);
                Player player2 = new Player(p2, Mark.O);
                EnableAllButton();
                ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
                game = new Game(resultAnalyzer, player1, player2);
            }
            else {
                MessageBox.Show("Please enter player name","Alert");
            }
        }


        private void TurningThePlayer(Button button,int pos) {
            if (TurnPlayer == false)
            {
                button.Text = Mark.X.ToString();
                result = game.Play(pos);
                CheckResult(result, p1);
                TurnPlayer = true;
            }
            else
            {
                button.Text = Mark.O.ToString();
                result = game.Play(pos);
                CheckResult(result, p2);
                TurnPlayer = false;
            }
            button.Enabled = false;
        }

        private void CheckResult(Result result,string player)
        {
            if (result.Equals(Result.Win))
            {
                MessageBox.Show("Congratulations! "+ player +" you won this game","Congo :)");
                this.Close();
            }
            else if (result.Equals(Result.Draw))
            {
                MessageBox.Show("Sorry! the game is draw","Sorry :(");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button2, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button3, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button4, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button5, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button6, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button7, 6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button8, 7);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            TurningThePlayer(button9, 8);
        }

    }
}
