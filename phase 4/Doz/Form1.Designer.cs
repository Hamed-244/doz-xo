namespace Doz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.FriendStart = new System.Windows.Forms.Button();
            this.CPUStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome";
            // 
            // FriendStart
            // 
            this.FriendStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FriendStart.BackColor = System.Drawing.Color.OrangeRed;
            this.FriendStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendStart.Location = new System.Drawing.Point(462, 315);
            this.FriendStart.Name = "FriendStart";
            this.FriendStart.Size = new System.Drawing.Size(309, 84);
            this.FriendStart.TabIndex = 1;
            this.FriendStart.Text = "Game with Friend";
            this.FriendStart.UseVisualStyleBackColor = false;
            this.FriendStart.Click += new System.EventHandler(this.CpuStart_Click);
            // 
            // CPUStart
            // 
            this.CPUStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPUStart.BackColor = System.Drawing.Color.Aqua;
            this.CPUStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUStart.Location = new System.Drawing.Point(62, 315);
            this.CPUStart.Name = "CPUStart";
            this.CPUStart.Size = new System.Drawing.Size(309, 84);
            this.CPUStart.TabIndex = 2;
            this.CPUStart.Text = "Game With Coumputer";
            this.CPUStart.UseVisualStyleBackColor = false;
            this.CPUStart.Click += new System.EventHandler(this.CPUStart_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.CPUStart);
            this.Controls.Add(this.FriendStart);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(850, 560);
            this.Name = "Form1";
            this.Text = "Doz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FriendStart;
        private System.Windows.Forms.Button CPUStart;
    }
}

