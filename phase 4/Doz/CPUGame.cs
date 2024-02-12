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
    public partial class CPUGame : Form
    {

        // public variable 

        public static int[] score = { 0, 0 };
        public static char[] signs = { 'X', '0' };
        public static string[] playersName = { "Player 1", "Coumputer" };
        public static int playIndex = 0;
        public static char[] tableArr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static bool winnerFlag = false;
        public static bool tieFlag = false;
        public static int moveCount = 0;
        public static int[] btnIndex = { 0 ,0 ,0 };

        /// ///////////////////

        

        public CPUGame(string name , char sign)
        {
            InitializeComponent();
            p1Name.Text = name;
            signs[0] = sign;
        }

        public void signingCPU(int num)
        {
            string nameBtn = "button" + num;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button) &&
                ctrl.Name == nameBtn)
                {
                    ctrl.Text = "0";
                }
            }
        }


        public void ColorFull(int num)
        {
            string nameBtn = "button" + num;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button) &&
                ctrl.Name == nameBtn)
                {
                    //ctrl.Text = String.Empty;
                    ctrl.BackColor = Color.Green;
                }
            }
        
        }

        int minimax(int depth, bool isAI)
        {
            int score = 0;
            int bestScore = 0;
            char b;
            if (checkWin())
            {
                if (isAI)
                {
                    return -1;
                }
                if (!isAI)
                {
                    return +1;
                }
            }
            else
            {
                if (depth < 9)
                {
                    if (isAI == true)
                    {
                        bestScore = -999;
                        for (int i = 0; i < 9; i++)
                        {
                            if (tableArr[i] != signs[0] && tableArr[i] != '0')
                            {
                                tableArr[i] = signs[1];
                                b = Convert.ToChar(i);
                                score = minimax(depth + 1, false);
                                tableArr[i] = b;
                                if (score > bestScore)
                                {
                                    bestScore = score;
                                }
                            }
                        }
                        return bestScore;
                    }
                    else
                    {
                        bestScore = 999;
                        for (int i = 0; i < 9; i++)
                        {
                            if (tableArr[i] != signs[0] && tableArr[i] != '0')
                            {
                                tableArr[i] = signs[0];
                                b = Convert.ToChar(i);
                                score = minimax(depth + 1, true);
                                tableArr[i] = b;
                                if (score < bestScore)
                                {
                                    bestScore = score;
                                }
                            }
                        }
                        return bestScore;
                    }
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }

        int bestMove(int moveIndex)
        {
            int x = -1;
            int score = 0, bestScore = -999;
            char b;
            for (int i = 0; i < 9; i++)
            {
                if (tableArr[i] != signs[0] && tableArr[i] != '0')
                {
                    b = Convert.ToChar(i);
                    tableArr[i] = signs[1];
                    score = minimax(moveIndex + 1, false);
                    tableArr[i] = b;
                    if (score > bestScore)
                    {
                        bestScore = score;
                        x = i;
                    }
                }
            }
            return x;
        }

        public void showTie()
        {
            Restart.Visible = true;
            timer1.Enabled = false;
            winner.Visible = true;
            cry.Visible = true;
            winner.Text = "!!!!! The Game Equalised  !!!!";
        }

        public void showWinner()
        {
            ColorFull(btnIndex[0]);
            ColorFull(btnIndex[1]);
            ColorFull(btnIndex[2]);

            timer1.Enabled = false;
            score[playIndex]++;
            p1Score.Text = Convert.ToString(score[0]);
            p2Score.Text = Convert.ToString(score[1]);
            Restart.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            winner.Visible = true;
            winner.Text = "WOW !!!!!   Winner is " + playersName[playIndex] + " !!!!";
        }
        public bool checkWin()
        {
        
            if (tableArr[0] == tableArr[1] && tableArr[1] == tableArr[2])
            {
                btnIndex[0] = 1;
                btnIndex[1] = 2;
                btnIndex[2] = 3;
                return  true;
            }
            else if (tableArr[3] == tableArr[4] && tableArr[4] == tableArr[5])
            {
                btnIndex[0] = 4;
                btnIndex[1] = 5;
                btnIndex[2] = 6;
                return true;
            }
            else if (tableArr[6] == tableArr[7] && tableArr[7] == tableArr[8])
            {
                btnIndex[0] = 7;
                btnIndex[1] = 8;
                btnIndex[2] = 9;
                return true;
            }
            else if (tableArr[0] == tableArr[3] && tableArr[3] == tableArr[6])
            {
                btnIndex[0] = 1;
                btnIndex[1] = 4;
                btnIndex[2] = 7;
                return true;
            }
            else if (tableArr[1] == tableArr[4] && tableArr[4] == tableArr[7])
            {
                btnIndex[0] = 2;
                btnIndex[1] = 5;
                btnIndex[2] = 8;
                return true;
            }
            else if (tableArr[2] == tableArr[5] && tableArr[5] == tableArr[8])
            {
                btnIndex[0] = 3;
                btnIndex[1] = 6;
                btnIndex[2] = 9;
                return true;
            }
            else if (tableArr[0] == tableArr[4] && tableArr[4] == tableArr[8])
            {
                btnIndex[0] = 1;
                btnIndex[1] = 5;
                btnIndex[2] = 9;
                return true;
            }
            else if (tableArr[2] == tableArr[4] && tableArr[4] == tableArr[6])
            {
                btnIndex[0] = 3;
                btnIndex[1] = 5;
                btnIndex[2] = 7;
                return true;
            }


            return false;

        }
 

        public void changeRound()
        {
            timer1.Stop();

            playIndex++;

            round1.Visible = !round1.Visible;
            round2.Visible = !round2.Visible;

            
            int placeId = bestMove(moveCount);

            tableArr[placeId] = signs[1];
            signingCPU(placeId + 1);
            moveCount++;
            winnerFlag = checkWin();
            if (winnerFlag)
            {
                showWinner();
            }else if(moveCount == 9)
            {
                showTie();
            }
            else
            {
                playIndex--;
                round1.Visible = !round1.Visible;
                round2.Visible = !round2.Visible;
                timer1.Start();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!winnerFlag && moveCount != 9)
            {
                Button btn = (Button)sender;
                if(btn.Text == "")
                {
                    
                    btn.Text = signs[playIndex] + "";
                    int place = Convert.ToInt32(btn.Name.Substring(btn.Name.Length - 1)) - 1;
                    tableArr[place] = signs[playIndex];
                    moveCount++;
                    winnerFlag = checkWin();
                    if (winnerFlag)
                    {
                        showWinner();
                    }else if(moveCount == 9){
                        showTie();
                    }
                    else
                    {
                        changeRound();
                    }

                }
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            changeRound();
        }

        private void CPUGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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


            for (int i = 0; i < 9; i++)
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
