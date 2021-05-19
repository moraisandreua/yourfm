using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;

namespace YourFmNew
{
    public partial class Main : Vip.CustomForm.FormBase
    {
        Title titleBarBtn = new Title();
        int titleBarBtn_left = 0;
        int titleBarBtn_top = 0;

        private void setSize()
        {
            titleBarBtn.Location = new Point(this.Location.X + titleBarBtn_left, this.Location.Y + titleBarBtn_top);
            titleBarBtn.Size = new Size(this.Size.Width - 100, 41);
        }

        public Main()
        {
            InitializeComponent();
            setSize();
            titleBarBtn.Show();
            titleBarBtn.Owner = this;
            panel1.Location = new Point(-6, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_Move(object sender, EventArgs e)
        {
            setSize();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panel1.Size = new Size(400, this.Size.Height);
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                this.Location = new Point(0, 0);
                setSize();
            }
            else if (this.WindowState==FormWindowState.Normal)
            {
                setSize();
            }
        }

        private void Main_ResizeBegin(object sender, EventArgs e)
        {

        }
    }
}
