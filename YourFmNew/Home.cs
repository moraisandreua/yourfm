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
    public partial class Home : UserControl
    {
        Main superMain = null;
        public Home(Main super)
        {
            InitializeComponent();
            this.superMain = super;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadStations();
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            loadStations();
        }

        private void loadStations()
        {
            flowLayoutPanel1.Controls.Clear();
            int width = panel1.Width; // -20px left // -20px right // -20px * 4
            int availableWidth = width - 20 - 20 - 80;
            double pictureWidth = availableWidth / 5;

            for (int x = 1; x <= 11; x++)
            {
                PictureBox pb = new PictureBox();
                pb.Width = (int)pictureWidth;
                pb.Height = (int)pictureWidth;

                double left = (x * 20) + ((x - 1) * pictureWidth);
                double top = (x * 20);

                pb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                pb.Location = new Point((int)left, (int)top);
                pb.BackColor = Color.AliceBlue;
                pb.Click += new EventHandler(openChat);
                pb.Cursor = System.Windows.Forms.Cursors.Hand;

                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        void openChat(Object sender, EventArgs e)
        {
            superMain.openChat();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            superMain.openAddShow();
        }
    }
}
