
namespace YourFmNew
{
    partial class Title
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.backBtn = new DarkUI.Controls.DarkButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.darkTextBox1);
            this.panel3.Controls.Add(this.darkButton1);
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 45);
            this.panel3.TabIndex = 2;
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(87, 8);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.PlaceholderText = "Search...";
            this.darkTextBox1.Size = new System.Drawing.Size(269, 31);
            this.darkTextBox1.TabIndex = 2;
            // 
            // darkButton1
            // 
            this.darkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.darkButton1.Location = new System.Drawing.Point(46, 5);
            this.darkButton1.MaximumSize = new System.Drawing.Size(35, 35);
            this.darkButton1.MinimumSize = new System.Drawing.Size(35, 35);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(35, 35);
            this.darkButton1.TabIndex = 1;
            this.darkButton1.Text = ">";
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.backBtn.Location = new System.Drawing.Point(6, 5);
            this.backBtn.MaximumSize = new System.Drawing.Size(35, 35);
            this.backBtn.MinimumSize = new System.Drawing.Size(35, 35);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(5);
            this.backBtn.Size = new System.Drawing.Size(35, 35);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "<";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 45);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(998, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 45);
            this.panel2.TabIndex = 4;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1300, 45);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Title";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Title_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkButton backBtn;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

