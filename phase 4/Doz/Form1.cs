using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Doz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CpuStart_Click(object sender, EventArgs e)
        {
            GetName GetNameCpu = new GetName(2);
            this.Hide();
            GetNameCpu.Show();
        }

        private void CPUStart_Click_1(object sender, EventArgs e)
        {
            GetName GetNameCpu = new GetName(1);
            this.Hide();
            GetNameCpu.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
