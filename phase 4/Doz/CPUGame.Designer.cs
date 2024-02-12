namespace Doz
{
    partial class CPUGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPUGame));
            this.winner = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.round2 = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.round1 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.p1Score = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.p1Name = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.p2Name = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cry = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cry)).BeginInit();
            this.SuspendLayout();
            // 
            // winner
            // 
            this.winner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.Location = new System.Drawing.Point(308, 461);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(383, 33);
            this.winner.TabIndex = 36;
            this.winner.Text = "WOW !!!! Winner is hamed !!";
            this.winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winner.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(156, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 128);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 128);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // round2
            // 
            this.round2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.round2.AutoSize = true;
            this.round2.BackColor = System.Drawing.SystemColors.Control;
            this.round2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round2.ForeColor = System.Drawing.Color.Red;
            this.round2.Location = new System.Drawing.Point(613, 125);
            this.round2.Name = "round2";
            this.round2.Size = new System.Drawing.Size(23, 29);
            this.round2.TabIndex = 33;
            this.round2.Text = "*";
            this.round2.Visible = false;
            // 
            // p2Score
            // 
            this.p2Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2Score.AutoSize = true;
            this.p2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.Location = new System.Drawing.Point(571, 120);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(26, 29);
            this.p2Score.TabIndex = 21;
            this.p2Score.Text = "0";
            // 
            // round1
            // 
            this.round1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.round1.AutoSize = true;
            this.round1.BackColor = System.Drawing.SystemColors.Control;
            this.round1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round1.ForeColor = System.Drawing.Color.Red;
            this.round1.Location = new System.Drawing.Point(613, 66);
            this.round1.Name = "round1";
            this.round1.Size = new System.Drawing.Size(23, 29);
            this.round1.TabIndex = 32;
            this.round1.Text = "*";
            // 
            // Restart
            // 
            this.Restart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Restart.BackColor = System.Drawing.Color.Red;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(401, 521);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(196, 44);
            this.Restart.TabIndex = 31;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(564, 391);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 43);
            this.button9.TabIndex = 30;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button3_Click);
            // 
            // p1Score
            // 
            this.p1Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1Score.AutoSize = true;
            this.p1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.Location = new System.Drawing.Point(571, 62);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(26, 29);
            this.p1Score.TabIndex = 20;
            this.p1Score.Text = "0";
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(457, 391);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 43);
            this.button8.TabIndex = 29;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button3_Click);
            // 
            // p1Name
            // 
            this.p1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p1Name.AutoSize = true;
            this.p1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Name.Location = new System.Drawing.Point(348, 62);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(110, 29);
            this.p1Name.TabIndex = 19;
            this.p1Name.Text = "player 1 :";
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(353, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 43);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button3_Click);
            // 
            // p2Name
            // 
            this.p2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2Name.AutoSize = true;
            this.p2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Name.Location = new System.Drawing.Point(348, 113);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(150, 29);
            this.p2Name.TabIndex = 18;
            this.p2Name.Text = "Coumputer : ";
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(564, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 43);
            this.button6.TabIndex = 27;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(457, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 43);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(353, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 43);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(564, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 43);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(457, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 43);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 43);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cry
            // 
            this.cry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cry.Image = ((System.Drawing.Image)(resources.GetObject("cry.Image")));
            this.cry.Location = new System.Drawing.Point(353, 176);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(318, 282);
            this.cry.TabIndex = 37;
            this.cry.TabStop = false;
            this.cry.Visible = false;
            // 
            // Back
            // 
            this.Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(897, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 32);
            this.Back.TabIndex = 38;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button10_Click);
            // 
            // CPUGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.cry);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.round2);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.round1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "CPUGame";
            this.Text = "Doz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPUGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label round2;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label round1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label p1Name;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label p2Name;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox cry;
        private System.Windows.Forms.Button Back;
    }
}