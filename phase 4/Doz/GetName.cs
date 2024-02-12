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
    public partial class GetName : Form
    {
        public static int players;
        public GetName(int player)
        {
            InitializeComponent();
            players = player;
            if(player == 1)
            {
                groupB2.Visible = false;
            }
        }

        private void GetName_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] Signs = { 'X', '0' };
            string[] names = { "Player 1", "Player 2" };

            if(players == 2)
            {
                
                if (p1sign.Text != "" && p1sign.Text !=Convert.ToString( Signs[1]))
                {
                    Signs[0] = Convert.ToChar(p1sign.Text);
                }
                if (p1name.Text != "" && p1name.Text != p2name.Text)
                {
                    names[0] = p1name.Text;
                }


                if (p2sign.Text != "" && p2sign.Text != Convert.ToString(Signs[0]))
                {
                    Signs[1] = Convert.ToChar(p2sign.Text);
                }
                if (p2name.Text != "" && p2name.Text != p1name.Text)
                {
                    names[1] = p2name.Text;
                }

                FriendGame RunFriendGame = new FriendGame(names[0], Signs[0], names[1], Signs[1]);
                this.Hide();
                RunFriendGame.Show();


            }
            else
            {


                if (p1sign.Text != "" && p1sign.Text != "0")
                {
                    Signs[0] = Convert.ToChar(p1sign.Text);
                }
                if (p1name.Text != "" && p1name.Text != "Coumputer")
                {
                    names[0] = p1name.Text;
                }

                CPUGame RunCpuGame = new CPUGame(names[0], Signs[0]);
                this.Hide();
                RunCpuGame.Show();

            }



        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }
    }
}
