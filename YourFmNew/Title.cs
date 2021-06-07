using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFmNew
{
    public partial class Title : Form
    {
        Main superWindow = null;
        int diffX = 0;
        int diffY = 0;

        public Title(Main super)
        {
            InitializeComponent();
            this.superWindow = super;
        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown=false;

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X-diffX;
                mouseY = MousePosition.Y-diffY;
                superWindow.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            diffX = MousePosition.X - superWindow.Location.X;
            diffY = MousePosition.Y - superWindow.Location.Y;
        }
    }
}
