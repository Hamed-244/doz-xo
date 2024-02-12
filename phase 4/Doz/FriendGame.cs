using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doz
{
    public partial class FriendGame : Form
    {

        //public variables
        public static int[] score = { 0, 0 };
        public static char[] signs = { 'X' , '0' };
        public static string[] playersName = { "Player 1", "Player 2" };
        public static int playIndex = 0;
        public static char[] tableArr = {'1' , '2', '3', '4',  '5',  '6',  '7',  '8',  '9' };
        public static bool winnerFlag = false;
        public static bool tieFlag = false;
        public static int moveCount = 0;
        //........................................





        // functions 
        public void changeRound()
        {
            playIndex++;
            round1.Visible = !round1.Visible;
            round2.Visible = !round2.Visible;
            if (playIndex == 2)
            {
                playIndex = 0;
            }
        }


        public void rowCheck()
        {

            if (tableArr[0] == tableArr[1] && tableArr[1] == tableArr[2])
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[3] == tableArr[4] && tableArr[4] == tableArr[5])
            {
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[6] == tableArr[7] && tableArr[7] == tableArr[8])
            {
                button7.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[0] == tableArr[3] && tableArr[3] == tableArr[6])
            {
                button1.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[1] == tableArr[4] && tableArr[4] == tableArr[7])
            {
                button2.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button8.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[2] == tableArr[5] && tableArr[5] == tableArr[8])
            {
                button3.BackColor = Color.Green;
                button6.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[0] == tableArr[4] && tableArr[4] == tableArr[8])
            {
                button1.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button9.BackColor = Color.Green;
                winnerFlag = true;
            }
            else if (tableArr[2] == tableArr[4] && tableArr[4] == tableArr[6])
            {
                button3.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                button7.BackColor = Color.Green;
                winnerFlag = true;
            }else if(moveCount == 9)
            {
                tieFlag = true;
            }


        }



        public void isWin(string name)
        {
            int place = Convert.ToInt32(name.Substring(name.Length - 1)) - 1;
            tableArr[place] = signs[playIndex];

            rowCheck();
        }


        /// /////////////////////////////////////

        // Start project 
        public FriendGame(string playerName , char sign , string playerName2 ,char sign2)
        {
            InitializeComponent();
            playersName[0] = playerName;
            playersName[1] = playerName2;
            p1Name.Text = playerName + " :";
            p2Name.Text = playerName2 + " :";
            signs[0] = sign;
            signs[1] = sign2;
            GameTimer.Enabled = true;
        }



        private void CPUGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            changeRound();
        }

        private void showWinner()
        {
            GameTimer.Stop();
            score[playIndex]++;
            p1Score.Text = Convert.ToString(score[0]);
            p2Score.Text = Convert.ToString(score[1]);
            Restart.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            winner.Visible = true;
            winner.Text = "WOW !!!!!   Winner is " + playersName[playIndex] + " !!!!";
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (!winnerFlag && !tieFlag)
            {
                Button btn = (Button)sender;
                if(btn.Text == "")
                {
                    btn.Text = signs[playIndex] + "";
                    moveCount++;
                    isWin(btn.Name);
                }

                if (winnerFlag)
                {
                    showWinner();
                }
                else if (tieFlag)
                {
                    GameTimer.Stop();
                    Restart.Visible = true;
                    winner.Text = "!!!!!  The Game equalised !!!!";
                    winner.Visible = true;
                    cry.Visible = true;
                }
                else
                {
                    GameTimer.Stop();
                    changeRound();
                    GameTimer.Start();
                }
            }



        }

        private void Restart_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button) &&
                ctrl.Name != "Restart" && ctrl.Name != "Back")
                {
                    ctrl.Text = String.Empty;
                    ctrl.BackColor = Color.Gainsboro;
                }
            }


            for (int i = 0; i<9; i++)
            {
                tableArr[i] = Convert.ToChar(i);
            }
            winnerFlag = false;
            tieFlag = false;
            playIndex = 0;
            round1.Visible = true;
            round2.Visible = false;
            Restart.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            winner.Visible = false;
            cry.Visible = false;
            moveCount = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }
    }
}
